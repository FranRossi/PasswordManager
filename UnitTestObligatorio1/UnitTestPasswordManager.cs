using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Utilities;
using System;
using System.Text.RegularExpressions;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestPasswordManager
    {
        PasswordManager passwordManager;
        User user;
        Category category;
        [TestInitialize]
        public void CreatePasswordManagerBeforeTests()
        {
            passwordManager = new PasswordManager();
            user = new User()
            {
                Name = "Gonzalo",
                Pass = "HolaSoyGonzalo123"
            };
            category = new Category()
            {
                Name = "Personal"
            };
        }

        private Password _password;
        [TestMethod]
        public void CreateValidPassword()
        {
            try
            {
                user.Categories.Add(category);
                this._password = new Password
                {
                    User = user,
                    Category = category,
                    Site = "ort.edu.uy",
                    Username = "239850",
                    Pass = "239850Ort2019",
                    Notes = "No me roben la cuenta"
                };
                passwordManager.CreatePassword(this._password);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidPasswordCategoryException))]
        public void CreateInvalidPasswordWrongCategory()
        {
            Category unusedCategory = new Category()
            {
                Name = "Work"
            };
            Password pass = new Password
            {
                User = user,
                Category = unusedCategory,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };
        }

    }

}
