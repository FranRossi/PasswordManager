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
        private PasswordManager _passwordManager;
        private User _currentUser;
        [TestInitialize]
        public void TestInitialize()
        {
            _passwordDataBreach = CreatePasswordDataBreachString();
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


    }
}
