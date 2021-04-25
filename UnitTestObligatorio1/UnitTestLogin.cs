using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using System;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestLogIn
    {

        public void LoginUserWithoutAnyUserCreated()
        {
            passwordManager = new PasswordManager();
            Boolean result = passwordManager.Login("Pepe12", "alsdfjadf");
            Assert.IsFalse(result);
        }

        PasswordManager passwordManager;
        [TestInitialize]
        public void createPasswordManagerBeforeTests()
        {
            passwordManager = new PasswordManager();
            passwordManager.CreateUser("Lucia", "Lucia$123");
        }

        [TestMethod]
        public void LoginValidUser()
        {
            Boolean result = passwordManager.Login("Lucia", "Lucia$123");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LoginUserWrongPassword()
        {
            Boolean result = passwordManager.Login("Lucia", "hoal3823");
            Assert.IsFalse(result);
        }

        [DataRow("hoal3823")]
        [DataRow("")]
        [DataRow("lucia$123")]
        [DataRow("Lucia$1234")]
        [DataTestMethod]
        public void LoginUserWrongPassword(string wrongPassword)
        {
            Boolean result = passwordManager.Login("Lucia", wrongPassword);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LoginUserWithPasswordAlreadyTaken()
        {
            passwordManager.CreateUser("Pepe12", "Lucia$123");
            Boolean result = passwordManager.Login("Pepe12", "Lucia$123");
            Assert.IsTrue(result);
        }

    }
}
