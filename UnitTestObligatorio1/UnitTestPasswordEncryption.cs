using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using BusinessLogic;
using Obligatorio1_DA1.Exceptions;
using System;
using System.Collections.Generic;
using Repository;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestPasswordEncryption
    {
        private Password _password;
        private PasswordManager _passwordManager;
        private User _user;
        private Category _category;

        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                _passwordManager = new PasswordManager();
                _user = new User()
                {
                    MasterName = "Gonzalo",
                    MasterPass = "HolaSoyGonzalo123"
                };
                _category = new Category()
                {
                    Name = "Personal"
                };
                _passwordManager.CreateUser(_user);
                _passwordManager.CreateCategoryOnCurrentUser(_category.Name);
                _category = _passwordManager.GetCategoriesFromCurrentUser().ToArray()[0];

            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }

        }

        [TestCleanup]
        public void Cleanup()
        {
            UnitTestSignUp.DataBaseCleanup(null);
        }

        [DataRow("mySuperSecurePassword")]
        [DataRow("12321pass werod")]
        [DataRow("hello world")]
        [DataTestMethod]
        public void EncryptedPasswordDifferentFromOriginal(string passName)
        {
            _password = new Password
            {
                User = _user,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = passName,
                Notes = "No me roben la cuenta"
            };
            string encryptedPassword = _password.Pass;
            string unEncryptedPassword = passName;
            Assert.AreNotEqual(unEncryptedPassword, encryptedPassword);
        }


        [DataRow("mySuperSecurePassword")]
        [DataRow("12321pass werod")]
        [DataRow("hello world")]
        [DataTestMethod]
        public void DencryptedPasswordDifferentFromOriginal(string passName)
        {
            _password = new Password
            {
                User = _user,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = passName,
                Notes = "No me roben la cuenta"
            };
            string unEncryptedPassword = passName;
            string decyptedPassword = _password.DecryptedPass;
            Assert.AreEqual(unEncryptedPassword, decyptedPassword);
        }
    }
}
