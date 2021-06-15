using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
using BusinessLogic;
using System;
using Repository;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestSignUp
    {

        private Services _cleanUp;
        private SessionController _sessionController;
        [TestInitialize]
        public void CreateSessionControllerBeforeTests()
        {
            _cleanUp = new Services();
            _cleanUp.DataBaseCleanup();
            _sessionController = SessionController.GetInstance();
        }

        [TestCleanup]
        public void Cleanup()
        {
            _cleanUp.DataBaseCleanup();
        }

        [TestMethod]
        public void CreateValidUser()
        {
            try
            {
                User newUser = new User("Juancito", "hola123");
                _sessionController.CreateUser(newUser);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(PasswordTooShortException))]
        public void CreateInvalidUserPasswordTooShort()
        {
            User newUser = new User("Juan12", "hola");
            _sessionController.CreateUser(newUser);
        }

        [TestMethod]
        [ExpectedException(typeof(PasswordTooLongException))]
        public void CreateInvalidUserPasswordTooLong()
        {
            User newUser = new User("Pepe12", "hola12345678910111213141516171819202122");
            _sessionController.CreateUser(newUser);
        }

        [TestMethod]
        [ExpectedException(typeof(PasswordInvalidCharactersException))]
        public void CreateInvalidUserPasswordInvalidCharacter()
        {
            User newUser = new User("Pepe12", "½½½½hola½½½½");
            _sessionController.CreateUser(newUser);
        }

        [TestMethod]
        [ExpectedException(typeof(UsernameAlreadyTakenException))]
        public void CreateInvalidUserNameAlreadyTaken()
        {
            User newUser = new User("Pepe12", "pepe1232");
            _sessionController.CreateUser(newUser);
            User newUser2 = new User("Pepe12", "121hola");
            _sessionController.CreateUser(newUser2);
        }


        [TestMethod]
        [ExpectedException(typeof(UserNameTooShortException))]
        public void CreateUserEmptyName()
        {
            User newUser = new User("", "password");
            _sessionController.CreateUser(newUser);
        }

        [TestMethod]
        [ExpectedException(typeof(UserNameTooShortException))]
        public void CreateUserNameTooShort()
        {
            User newUser = new User("Khea", " ");
            _sessionController.CreateUser(newUser);
        }

        [TestMethod]
        [ExpectedException(typeof(UserNameTooLongException))]
        public void CreateUserNameTooLong()
        {
            User newUser = new User("MaritoBaracus1234VisualStudioEnterprise", "password");
            _sessionController.CreateUser(newUser);
        }


        [TestMethod]
        public void UserEqual()
        {
            User newUser1 = new User("Juancito", "hola123");
            User newUser2 = new User("Juancito", "hola123");

            Assert.IsTrue(newUser1.Equals(newUser2));
        }

        [TestMethod]
        public void UserNotEqual()
        {
            User newUser1 = new User("Juancito", "hola123");
            User newUser2 = new User("juancito", "hola123");

            Assert.IsFalse(newUser1.Equals(newUser2));
        }

        [TestMethod]
        public void UserNotEqualInvalidObject()
        {
            User newUser1 = new User("Juancito", "hola123");

            Assert.IsFalse(newUser1.Equals(new object()));
        }
    }
}
