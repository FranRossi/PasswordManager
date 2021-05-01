﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            string[] passwordsToAdd = { "Passoword223", "239850232", "abcde876", "nethiseant3232323hnea" };
            string dataBreach = "";
            for (int i = 0; i < passwordsToAdd.Length; i++)
            {
                dataBreach += passwordsToAdd[i] + Environment.NewLine;
            }

            return dataBreach;
        }

        private void AddPasswordsToPasswordManager()
        {
            string[] passwordsToAdd = { "Passoword223", "239850232", "abcde876", "nethiseant3232323hnea" };
            Category category = new Category()
            {
                Name = "Personal"
            };
            _currentUser.Categories.Add(category);
            for (int i = 0; i < passwordsToAdd.Length; i++)
            {
                Password newPassword = new Password
                {
                    User = _currentUser,
                    Category = category,
                    Site = i + "ort.edu.uy",
                    Username = "23985" + i,
                    Pass = passwordsToAdd[i],
                    Notes = "No me roben la cuenta"
                };
                _passwordManager.CreatePassword(newPassword);
            }
        }

        private string CreateCreditCardDataBreachString()
        {
            string[] cardsToAdd = { "2354231413003498", "2354678713003498", "1256478713003498", "7685678713567898" };
            string dataBreach = "";
            for (int i = 0; i < cardsToAdd.Length; i++)
            {
                dataBreach += cardsToAdd[i] + Environment.NewLine;
            }

            return dataBreach;
        }

        private void AddCardsToPasswordManager()
        {
            string[] cardsToAdd = { "2354231413003498", "2354678713003498", "1256478713003498", "7685678713567898" };
            Category category = new Category()
            {
                Name = "Trabajo"
            };
            _currentUser.Categories.Add(category);
            for (int i = 0; i < cardsToAdd.Length; i++)
            {
                CreditCard newCard = new CreditCard
                {
                    User = _currentUser,
                    Category = category,
                    Name = "Visa Gold",
                    Type = "Visa",
                    Number = cardsToAdd[i],
                    SecureCode = "189",
                    ExpirationDate = "10/21",
                    Notes = "LÃ­mite 400k UYU"
                };
                _passwordManager.CreateCreditCard(newCard);
            }
        }
    }
}
