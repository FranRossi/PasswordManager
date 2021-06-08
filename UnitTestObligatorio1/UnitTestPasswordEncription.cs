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
    public class UnitTestPasswordEncription
    {
        private Password _password;
        private PasswordManager _passwordManager;
        private User _user;
        private Category _category;

        [TestInitialize]
        public void TestInitialize()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM PASSWORDS");
                context.Database.ExecuteSqlCommand("DELETE FROM CREDITCARDS");
                context.Database.ExecuteSqlCommand("DELETE FROM USERS");
            }
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
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM PASSWORDS");
                context.Database.ExecuteSqlCommand("DELETE FROM CREDITCARDS");
                context.Database.ExecuteSqlCommand("DELETE FROM USERS");
            }
        }

        [DataRow("mySuperSecurePassword")]
        [DataRow("12321pass werod")]
        [DataRow("hello world")]
        [DataTestMethod]
        public void EncriptedPasswordDifferentFromOriginal(string passName)
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
            string encriptedPassword = _password.Pass;
            string unEncriptedPassword = passName;
            Assert.AreNotEqual(unEncriptedPassword, encriptedPassword);
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
            string unEncriptedPassword = passName;
            string decyptedPassword = _password.DecyptedPass;
            Assert.AreEqual(unEncriptedPassword, decyptedPassword);
        }
    }
}
