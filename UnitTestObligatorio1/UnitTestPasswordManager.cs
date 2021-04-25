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
        [TestInitialize]
        public void CreatePasswordManagerBeforeTests()
        {
            passwordManager = new PasswordManager();
        }

        private Password _password;
        [TestMethod]
        public void CreateValidPassword()
        {
            try
            {
                this._password = new Password
                {
                    Category = new Category()
                    {
                        Name = "Personal"
                    },
                    User = new User()
                    {
                        Name = "Gonzalo",
                        Pass = "HolaSoyGonzalo123"
                    },
                    Site = "ort.edu.uy",
                    Username = "239850",
                    Pass = "239850Ort2019",
                    Notes = "No me roben la cuenta"
                };
                this._password.User.Categories.Add(this._password.Category);
                passwordManager.CreatePassword(this._password);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

    }

}
