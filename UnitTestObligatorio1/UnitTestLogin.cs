using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1;
using System;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestLogIn
    {

        public void LoginUserInvalidNoUsers()
        {
            passwordManager = new PasswordManager();
            Boolean result = passwordManager.login("Pepe", "alsdfjadf");
            Assert.IsFalse(result);
        }

        PasswordManager passwordManager;
        [TestInitialize]
        public void createPasswordManagerBeforeTests()
        {
            passwordManager = new PasswordManager();
            passwordManager.createUser("Lucia", "Lucia$123");
        }

        [TestMethod]
        public void LoginUserValid()
        {
            Boolean result = passwordManager.login("Lucia", "Lucia$123");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LoginUserWrongPassword()
        {
            Boolean result = passwordManager.login("Lucia", "hoal3823");
            Assert.IsFalse(result);
        }

        [DataRow("hoal3823")]
        [DataRow("")]
        [DataRow("lucia$123")]
        [DataRow("Lucia$1234")]
        [DataTestMethod]
        public void LoginUserWrongPassword(string wrongPassword)
        {
            Boolean result = passwordManager.login("Lucia", wrongPassword);
            Assert.IsFalse(result);
        }
    }
}
