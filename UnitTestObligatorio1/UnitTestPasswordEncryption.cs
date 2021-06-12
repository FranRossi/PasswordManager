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
        private CategoryController _categoryController;
        private PasswordController _passwordController;
        private User _user;
        private Category _category;
        private Password _newPass;

        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                _sessionController = SessionController.GetInstance();
                _passwordManager = new PasswordManager();
                _categoryController = new CategoryController();
                _passwordController = new PasswordController();
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
                _categoryController.CreateCategoryOnCurrentUser(_category.Name);
                _category = _categoryController.GetCategoriesFromCurrentUser().ToArray()[0];

               _newPass = new Password
                {
                    User = _user,
                    Category = _category,
                    Site = "ort.edu.uy",
                    Username = "239850",
                    Pass = "123453",
                    Notes = "No me roben la cuenta"
                };

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
            _newPass.Pass = passName;
          
            _passwordController.CreatePassword(_newPass);
            Password newPassFromPasswordManger = _passwordController.GetPasswords()[0];
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
            _newPass.Pass = passName;

            _passwordController.CreatePassword(_newPass);
            string unEncryptedPassword = passName;
            Password newPassFromPasswordManger = _passwordController.GetPasswords()[0];
            string decyptedPassword = newPassFromPasswordManger.Pass;
            Assert.AreEqual(unEncryptedPassword, decyptedPassword);
        }


        [DataRow("mySuperSecurePassword")]
        [DataRow("12321pass werod")]
        [DataRow("hello world")]
        [DataTestMethod]
        public void SameUserAndPassResultsInSameEncryption(string passName)
        {
            _newPass.Pass = passName;
            _passwordController.CreatePassword(_newPass);

            Password secondPass = new Password
            {
                User = _user,
                Category = _category,
                Site = "amazon",
                Username = "amazingssss",
                Pass = passName
            };
            _passwordController.CreatePassword(secondPass);

            List<Password> passwords = _passwordController.GetPasswords();
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
            _newPass.Pass = passName;
            _passwordController.CreatePassword(_newPass);

            _user.DecryptionKey = "newPasswordKey";
            Password secondPass = new Password
            {
                User = _user,
                Category = _category,
                Site = "amazon",
                Username = "amazingssss",
                Pass = passName
            };
            _passwordController.CreatePassword(secondPass);

            List<Password> passwords = _passwordController.GetPasswords();
            Password newPassFromPasswordManger = passwords[0];
            Password secondPassFromPasswordManger = passwords[1];
            Assert.AreNotEqual(newPassFromPasswordManger.EncryptedPass, secondPassFromPasswordManger.EncryptedPass);
        }

    }
}

