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

        private SessionController _sessionController;


        [TestMethod]
        [ExpectedException(typeof(LogInException))]
        public void LoginUserWithoutAnyUserCreated()
        {
            _sessionController.Login("Pepe12", "alsdfjadf");
        }


        [TestInitialize]
        public void createSessionControllerBeforeTests()
        {
            _sessionController = SessionController.GetInstance();
            User newUser = new User("Lucia", "Lucia123");
            _sessionController.CreateUser(newUser);
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
                _sessionController.Login("Lucia", "Lucia123");
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }


        [DataRow("hoal3823")]
        [DataRow("")]
        [DataRow("lucia$123")]
        [DataRow("Lucia$1234")]
        [DataTestMethod]
        [ExpectedException(typeof(LogInException))]
        public void LoginUserWrongPassword(string wrongPassword)
        {
            _sessionController.Login("Lucia", wrongPassword);
        }

        [TestMethod]
        public void LoginUserWrongPasswordExceptionMessage()
        {
            try
            {
                _sessionController.Login("Lucia", "lucia$123");
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
            _sessionController.CreateUser(newUser);
            try
            {
                _sessionController.Login("Pepe12", "Lucia123");

            }
            catch (LogInException ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void CheckGetMasterNameOnCurrentUser()
        {
            User newUser = new User("Pepe12", "Lucia123");
            _sessionController.CreateUser(newUser);
            _sessionController.Login("Pepe12", "Lucia123");
            Assert.AreEqual(_sessionController.GetCurrentUserMasterName(), newUser.MasterName);
        }


        [DataRow("MaritoBaracus")]
        [DataRow("Maria")]
        [DataRow("Pepe Gonzales Segundo")]
        [DataTestMethod]
        public void UserToString(string name)
        {
            User newUser = new User(name, "password");
            string actualName = newUser.ToString();
            _sessionController.CreateUser(newUser);
            _sessionController.Login(actualName, "password");
            string expectedName = name;
            Equals(expectedName, actualName);
        }


    }
}
