using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Utilities;
using Repository;
using System;
using System.Collections.Generic;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestDataBreach
    {
        private string _passwordDataBreach;
        private string _creditCardDataBreach;
        private string _itemDataBreach;
        private string _repeatedItemDataBreach;
        private PasswordManager _passwordManager;
        private User _currentUser;
        private string[] _breachedPasswords = { "Passoword223", "239850232", "abcde876", "neant3232323hnea" };
        private string[] _breachedCreditCards = { "2354231413003498", "2354678713003498", "1256478713003498", "7685678713567898" };
        private string[] _breachedItems = { "2354231413003498", "Passoword223", "neant3232323hnea", "2354678713003498", "abcde876", "7685678713567898", "1256478713003498", "239850232", };
        private string[] _repeatedBreachedItems = { "2354231413003498", "2354231413003498", "neant3232323hnea", "2354678713003498", "abcde876", "7685678713567898", "1256478713003498", "239850232", };

        [TestInitialize]
        public void TestInitialize()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM PASSWORDS");
                context.Database.ExecuteSqlCommand("DELETE FROM CREDITCARDS");
                context.Database.ExecuteSqlCommand("DELETE FROM USERS");
            }
            _passwordDataBreach = CreateDataBreachString(_breachedPasswords);
            _creditCardDataBreach = CreateDataBreachString(_breachedCreditCards);
            _itemDataBreach = CreateDataBreachString(_breachedItems);
            _repeatedItemDataBreach = CreateDataBreachString(_repeatedBreachedItems);
            _passwordManager = new PasswordManager();
            _currentUser = new User()
            {
                MasterName = "Gonzalo",
                MasterPass = "HolaSoyGonzalo123"
            };
            _passwordManager.CreateUser(_currentUser);
        }

        [TestCleanup]
        public void Cleanup()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM PASSWORDS");
                context.Database.ExecuteSqlCommand("DELETE FROM CREDITCARDS");
                context.Database.ExecuteSqlCommand("DELETE FROM USERS");
            }
        }

        [TestMethod]
        public void GetDataBreachItems()
        {
            DataBreach<string> dataBreach = new DataBreachFromString();
            HashSet<string> expectedItems = new HashSet<string>();
            for (int i = 0; i < _breachedPasswords.Length; i++)
                expectedItems.Add(_breachedPasswords[i]);
            Assert.IsTrue(expectedItems.SetEquals(dataBreach.GetDataBreachItems(_passwordDataBreach)));
        }

        [TestMethod]
        public void GetDataBreachItemsWithRepeatedInput()
        {
            DataBreach<string> dataBreach = new DataBreachFromString();
            HashSet<string> expectedItems = new HashSet<string>();
            for (int i = 0; i < _repeatedBreachedItems.Length; i++)
                expectedItems.Add(_repeatedBreachedItems[i]);
            Assert.IsTrue(expectedItems.SetEquals(dataBreach.GetDataBreachItems(_repeatedBreachedItems)));
        }

        [TestMethod]
        public void GetDataBreachDate()
        {
            DataBreach<string> dataBreach = new DataBreachFromString();
            Assert.IsTrue(dataBreach.Date.Equals(DateTime.Today));
        }

        [TestMethod]
        public void GetDataBreachId()
        {
            DataBreach<string> dataBreach = new DataBreachFromString();
            Assert.IsTrue(dataBreach.Id == 0);
        }

        [TestMethod]
        public void GetDataBreachUsuario()
        {
            DataBreach<string> dataBreach = new DataBreachFromString();
            dataBreach.User = _currentUser;
            Assert.IsTrue(dataBreach.User.Equals(_currentUser));
        }

        [TestMethod]
        public void GetDataBreachBreachedItems()
        {
            string categoryName = "Facultad";
            _passwordManager.CreateCategoryOnCurrentUser(categoryName);
            Category firstCategoryOnUser = _currentUser.Categories[0];
            DataBreach<string> dataBreach = new DataBreachFromString();
            List<Item> items = new List<Item>();
            Password newPassword = new Password
            {
                User = _currentUser,
                Category = firstCategoryOnUser,
                Site = "aulas.ort.edu.uy",
                Username = "23985",
                Pass = "Passoword223",
                Notes = "No me roben la cuenta"
            };
            CreditCard newCard = new CreditCard
            {
                User = _currentUser,
                Category = firstCategoryOnUser,
                Name = "Visa Gold",
                Type = "Visa",
                Number = "2354231413001234",
                SecureCode = "189",
                ExpirationDate = "10/21",
                Notes = "Tra­mite 400k UYU"
            };

            items.Add(newCard);
            items.Add(newPassword);

            dataBreach.BreachedItems = items;
            CollectionAssert.AreEqual(dataBreach.BreachedItems, items);
        }

        [TestMethod]
        public void PasswordOnlyDataBreachFromString()
        {
            AddPasswordsFromDifferentUserToPasswordManager();
            List<Item> breachedPasswordList = AddBreachedPasswordsToPasswordManager();
            DataBreach<string> dataBreach = new DataBreachFromString();
            _passwordManager.SaveBreachedItems(dataBreach);
            List<Item> breachResult = _passwordManager.SaveBreachedItems(dataBreach);
            CollectionAssert.AreEquivalent(breachResult, breachedPasswordList);
        }

        [TestMethod]
        public void CreditCardOnlyDataBreachFromString()
        {
            AddCreditCardsFromDifferentToUserPasswordManager();
            List<Item> breachedCardList = AddBreachedCreditCardsToPasswordManager();
            DataBreach<string> dataBreach = new DataBreachFromString();
            List<Item> breachResult = _passwordManager.SaveBreachedItems(dataBreach);
            CollectionAssert.AreEquivalent(breachResult, breachedCardList);
        }

        [TestMethod]
        public void CreditCardAndPasswordDataBreachFromString()
        {
            AddCreditCardsFromDifferentToUserPasswordManager();
            AddPasswordsFromDifferentUserToPasswordManager();
            List<Item> breachedItems = AddBreachedCreditCardsToPasswordManager();
            breachedItems.AddRange(AddBreachedPasswordsToPasswordManager());
            DataBreach<string> dataBreach = new DataBreachFromString();
            List<Item> breachResult = _passwordManager.SaveBreachedItems(dataBreach);
            CollectionAssert.AreEquivalent(breachResult, breachedItems);
        }

        private string CreateDataBreachString(string[] breachedString)
        {
            string dataBreach = "";
            for (int i = 0; i < breachedString.Length; i++)
            {
                dataBreach += breachedString[i] + Environment.NewLine;
            }
            return dataBreach;
        }

        private List<Item> AddBreachedPasswordsToPasswordManager()
        {
            List<Item> brechedPasswordsList = new List<Item>();
            Category category = new Category()
            {
                Name = "Personal"
            };
            _currentUser.Categories.Add(category);
            for (int i = 0; i < _breachedPasswords.Length; i++)
            {
                Password newPassword = new Password
                {
                    User = _currentUser,
                    Category = category,
                    Site = i + "ort.edu.uy",
                    Username = "23985" + i,
                    Pass = _breachedPasswords[i],
                    Notes = "No me roben la cuenta"
                };
                brechedPasswordsList.Add(newPassword);
                _passwordManager.CreatePassword(newPassword);
            }
            return brechedPasswordsList;
        }

        private void AddPasswordsFromDifferentUserToPasswordManager()
        {

            User otherUser = new User()
            {
                MasterName = "Pedro",
                MasterPass = "HolaSoyPedro123"
            };
            _passwordManager.CreateUser(otherUser);
            string categoryName = "Facultad";
            _passwordManager.CreateCategoryOnCurrentUser(categoryName);
            Category firstCategoryOnUser = otherUser.Categories[0];
            Password newPassword = new Password
            {
                User = otherUser,
                Category = firstCategoryOnUser,
                Site = "aulas.ort.edu.uy",
                Username = "23985",
                Pass = "Passoword223",
                Notes = "No me roben la cuenta"
            };
            _passwordManager.CreatePassword(newPassword);
            _passwordManager.Login("Gonzalo", "HolaSoyGonzalo123");
        }

        private List<Item> AddBreachedCreditCardsToPasswordManager()
        {
            List<Item> breachedCreditCardList = new List<Item>();
            Category category = new Category()
            {
                Name = "Trabajo"
            };
            _currentUser.Categories.Add(category);
            for (int i = 0; i < _breachedCreditCards.Length; i++)
            {
                CreditCard newCard = new CreditCard
                {
                    User = _currentUser,
                    Category = category,
                    Name = "Visa Gold",
                    Type = "Visa",
                    Number = _breachedCreditCards[i],
                    SecureCode = "189",
                    ExpirationDate = "10/21",
                    Notes = "Tra­mite 400k UYU"
                };
                breachedCreditCardList.Add(newCard);
                _passwordManager.CreateCreditCard(newCard);
            }
            return breachedCreditCardList;
        }

        private void AddCreditCardsFromDifferentToUserPasswordManager()
        {
            string categoryName = "Facultad";
            User otherUser = new User()
            {
                MasterName = "Javier",
                MasterPass = "HolaSoyJavier123"
            };
            _passwordManager.CreateUser(otherUser);
            _passwordManager.CreateCategoryOnCurrentUser(categoryName);
            Category firstCategoryOnUser = otherUser.Categories[0];
            CreditCard newCard = new CreditCard
            {
                User = otherUser,
                Category = firstCategoryOnUser,
                Name = "Visa Gold",
                Type = "Visa",
                Number = "2354231413001234",
                SecureCode = "189",
                ExpirationDate = "10/21",
                Notes = "Tra­mite 400k UYU"
            };
            _passwordManager.CreateCreditCard(newCard);
            _passwordManager.Login("Gonzalo", "HolaSoyGonzalo123");
        }


    }
}
