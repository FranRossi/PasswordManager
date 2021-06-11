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

        private SessionController _sessionController;
        private PasswordManager _passwordManager;
        private User _user;
        private Category _category;

        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                _sessionController = SessionController.GetInstance();
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
                _sessionController.CreateUser(_user);
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
            Password newPass = new Password
            {
                User = _user,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = passName,
                Notes = "No me roben la cuenta"
            };
            _passwordManager.CreatePassword(newPass);
            Password newPassFromPasswordManger = _passwordManager.GetPasswords()[0];
            string encryptedPassword = newPassFromPasswordManger.EncryptedPass;
            string unEncryptedPassword = passName;
            Assert.AreNotEqual(unEncryptedPassword, encryptedPassword);
        }


        [DataRow("mySuperSecurePassword")]
        [DataRow("12321pass werod")]
        [DataRow("hello world")]
        [DataTestMethod]
        public void DencryptedPasswordSameThanOriginal(string passName)
        {
            Password newPass = new Password
            {
                User = _user,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = passName,
                Notes = "No me roben la cuenta"
            };
            _passwordManager.CreatePassword(newPass);
            string unEncryptedPassword = passName;
            Password newPassFromPasswordManger = _passwordManager.GetPasswords()[0];
            string decyptedPassword = newPassFromPasswordManger.Pass;
            Assert.AreEqual(unEncryptedPassword, decyptedPassword);
        }


        [DataRow("mySuperSecurePassword")]
        [DataRow("12321pass werod")]
        [DataRow("hello world")]
        [DataTestMethod]
        public void SameUserAndPassResultsInSameEncryption(string passName)
        {
            Password newPass = new Password
            {
                User = _user,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = passName,
                Notes = "No me roben la cuenta"
            };
            _passwordManager.CreatePassword(newPass);


            Password secondPass = new Password
            {
                User = _user,
                Category = _category,
                Site = "amazon",
                Username = "amazingssss",
                Pass = passName
            };
            _passwordManager.CreatePassword(secondPass);

            List<Password> passwords = _passwordManager.GetPasswords();
            Password newPassFromPasswordManger = passwords[0];
            Password secondPassFromPasswordManger = passwords[1];
            Assert.AreEqual(newPassFromPasswordManger.EncryptedPass, secondPassFromPasswordManger.EncryptedPass);
        }

        [DataRow("mySuperSecurePassword")]
        [DataRow("12321pass werod")]
        [DataRow("hello world")]
        [DataTestMethod]
        public void EncryptionDependeOnUsersKey(string passName)
        {
            Password newPass = new Password
            {
                User = _user,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = passName,
                Notes = "No me roben la cuenta"
            };
            _passwordManager.CreatePassword(newPass);

            _user.DecryptionKey = "newPasswordKey";
            Password secondPass = new Password
            {
                User = _user,
                Category = _category,
                Site = "amazon",
                Username = "amazingssss",
                Pass = passName
            };
            _passwordManager.CreatePassword(secondPass);

            List<Password> passwords = _passwordManager.GetPasswords();
            Password newPassFromPasswordManger = passwords[0];
            Password secondPassFromPasswordManger = passwords[1];
            Assert.AreNotEqual(newPassFromPasswordManger.EncryptedPass, secondPassFromPasswordManger.EncryptedPass);
        }

    }
}

