using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestDataBreach
    {
        private string _passwordDataBreach;
        private string _credtiCardDataBreach;
        private string _itemDataBreach;
        private PasswordManager _passwordManager;
        private User _currentUser;
        private string[] _breachedPasswords = { "Passoword223", "239850232", "abcde876", "nethiseant3232323hnea" };
        private string[] _breachedCreditCards = { "2354231413003498", "2354678713003498", "1256478713003498", "7685678713567898" };
        private string[] _breachedItems = { "2354231413003498", "Passoword223", "nethiseant3232323hnea", "2354678713003498", "abcde876", "7685678713567898", "1256478713003498", "239850232", };

        [TestInitialize]
        public void TestInitialize()
        {
            _passwordDataBreach = CreateDataBreachString(_breachedPasswords);
            _credtiCardDataBreach = CreateDataBreachString(_breachedCreditCards);
            _itemDataBreach = CreateDataBreachString(_breachedItems);
            _passwordManager = new PasswordManager();
            _currentUser = new User()
            {
                Name = "Gonzalo",
                Pass = "HolaSoyGonzalo123"
            };
        }

        [TestMethod]
        public void PasswordOnlyDataBreach()
        {
            AddPasswordsFromDifferentUserToPasswordManager();
            List<Item> breachedPasswordList = AddBreachedPasswordsToPasswordManager();
            List<Item> breachResult = _passwordManager.GetBreachedItems(_passwordDataBreach, _currentUser);
            CollectionAssert.AreEquivalent(breachResult, breachedPasswordList);
        }

        [TestMethod]
        public void CreditCardOnlyDataBreach()
        {
            AddCreditCardsFromDifferentToUserPasswordManager();
            List<Item> breachedCardList = AddBreachedCreditCardsToPasswordManager();
            List<Item> breachResult = _passwordManager.GetBreachedItems(_credtiCardDataBreach, _currentUser);
            CollectionAssert.AreEquivalent(breachResult, breachedCardList);
        }

        [TestMethod]
        public void CreditCardAndPasswordDataBreach()
        {
            AddCreditCardsFromDifferentToUserPasswordManager();
            AddPasswordsFromDifferentUserToPasswordManager();
            List<Item> breachedItems = AddBreachedCreditCardsToPasswordManager();
            breachedItems.AddRange(AddBreachedPasswordsToPasswordManager());
            List<Item> breachResult = _passwordManager.GetBreachedItems(_itemDataBreach, _currentUser);
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
            Category category = new Category()
            {
                Name = "Facultad"
            };
            User otherUser = new User()
            {
                Name = "Pedro",
                Pass = "HolaSoyPedro123"
            };
            otherUser.Categories.Add(category);
            Password newPassword = new Password
            {
                User = otherUser,
                Category = category,
                Site = "aulas.ort.edu.uy",
                Username = "23985",
                Pass = "Passoword223",
                Notes = "No me roben la cuenta"
            };
            _passwordManager.CreatePassword(newPassword);
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
            Category category = new Category()
            {
                Name = "Facultad"
            };
            User otherUser = new User()
            {
                Name = "Pedro",
                Pass = "HolaSoyPedro123"
            };
            otherUser.Categories.Add(category);
            CreditCard newCard = new CreditCard
            {
                User = otherUser,
                Category = category,
                Name = "Visa Gold",
                Type = "Visa",
                Number = "2354231413003498",
                SecureCode = "189",
                ExpirationDate = "10/21",
                Notes = "Tra­mite 400k UYU"
            };
            _passwordManager.CreateCreditCard(newCard);
        }


    }
}
