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
        private PasswordManager _passwordManager;
        private User _currentUser;
        private string[] _breachedPasswords = { "Passoword223", "239850232", "abcde876", "nethiseant3232323hnea" };
        private string[] _breachedCreditCards = { "2354231413003498", "2354678713003498", "1256478713003498", "7685678713567898" };
        [TestInitialize]
        public void TestInitialize()
        {
            _passwordDataBreach = CreatePasswordDataBreachString();
            _credtiCardDataBreach = CreateCreditCardDataBreachString();
            _passwordManager = new PasswordManager();
            _currentUser = new User()
            {
                Name = "Gonzalo",
                Pass = "HolaSoyGonzalo123"
            };
        }

        private string CreatePasswordDataBreachString()
        {
            string dataBreach = "";
            for (int i = 0; i < _breachedPasswords.Length; i++)
            {
                dataBreach += _breachedPasswords[i] + Environment.NewLine;
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

        private void AddPasswordsFromDifferentToPasswordManager()
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

        private string CreateCreditCardDataBreachString()
        {
            string[] breachedCreditCards = { "2354231413003498", "2354678713003498", "1256478713003498", "7685678713567898" };
            string dataBreach = "";
            for (int i = 0; i < breachedCreditCards.Length; i++)
            {
                dataBreach += breachedCreditCards[i] + Environment.NewLine;
            }

            return dataBreach;
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

        [TestMethod]
        public void PasswordOnlyDataBreach()
        {
            AddPasswordsFromDifferentToPasswordManager();
            List<Item> breachedPasswordList = AddBreachedPasswordsToPasswordManager();
            List<Item> breachResult = _passwordManager.getBreachedItems(_passwordDataBreach, _currentUser);
            CollectionAssert.AreEquivalent(breachResult, breachedPasswordList);
        }
    }
}
