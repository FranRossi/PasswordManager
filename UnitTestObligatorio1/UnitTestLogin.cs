using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
using BusinessLogic;
using System;
using Repository;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestLogIn
    {
        [TestMethod]
        [ExpectedException(typeof(LogInException))]
        public void LoginUserWithoutAnyUserCreated()
        {
            passwordManager = new PasswordManager();
            passwordManager.Login("Pepe12", "alsdfjadf");
        }

        private PasswordManager passwordManager;
        [TestInitialize]
        public void createPasswordManagerBeforeTests()
        {
            passwordManager = new PasswordManager();
            User newUser = new User("Lucia", "Lucia123");
            passwordManager.CreateUser(newUser);
        }
        [TestCleanup]
        public void Cleanup()
        {
            UnitTestSignUp.DataBaseCleanup(null);
        }

        [TestMethod]
        public void LoginValidUser()
        {
            try
            {
                passwordManager.Login("Lucia", "Lucia123");
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(LogInException))]
        public void LoginUserWrongPassword()
        {
            passwordManager.Login("Lucia", "hoal3823");
        }

        [DataRow("hoal3823")]
        [DataRow("")]
        [DataRow("lucia$123")]
        [DataRow("Lucia$1234")]
        [DataTestMethod]
        [ExpectedException(typeof(LogInException))]
        public void LoginUserWrongPassword(string wrongPassword)
        {
            passwordManager.Login("Lucia", wrongPassword);
        }

        [TestMethod]
        public void LoginUserWrongPasswordExceptionMessage()
        {
            try
            {
                passwordManager.Login("Lucia", "lucia$123");
            }
            catch (ValidationException e)
            {
                Assert.AreEqual("El nombre usuario o contraseña son incorrectos.", e.Message);
            }
        }

        [TestMethod]
        public void LoginUserWithPasswordAlreadyTaken()
        {
            User newUser = new User("Pepe12", "Lucia123");
            passwordManager.CreateUser(newUser);
            try
            {
                passwordManager.Login("Pepe12", "Lucia123");

            }
            catch (LogInException ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

    }
}
