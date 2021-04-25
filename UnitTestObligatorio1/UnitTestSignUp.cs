using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
using System;


namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestSignUp
    {

        [TestMethod]
        public void CreatePasswordManager()
        {
            PasswordManager passwordManager = new PasswordManager();
            Assert.IsNotNull(passwordManager);
        }


        PasswordManager passwordManager;
        [TestInitialize]
        public void CreatePasswordManagerBeforeTests()
        {
            passwordManager = new PasswordManager();
        }

        [TestMethod]
        public void CreateValidUser()
        {
            try
            {
                passwordManager.CreateUser("Juancito", "hola123");
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
            passwordManager.CreateUser("Juan12", "hola");
        }

        [TestMethod]
        [ExpectedException(typeof(PasswordTooLongException))]
        public void CreateInvalidUserPasswordTooLong()
        {
            passwordManager.CreateUser("Pepe12", "hola12345678910111213141516171819202122");
        }

        [TestMethod]
        [ExpectedException(typeof(PasswordInvalidCharactersException))]
        public void CreateInvalidUserPasswordInvalidCharacter()
        {
            passwordManager.CreateUser("Pepe12", "½½½½hola½½½½");
        }

        [TestMethod]
        [ExpectedException(typeof(UsernameAlreadyTakenException))]
        public void CreateInvalidUserNameAlreadyTaken()
        {
            passwordManager.CreateUser("Pepe12", "pepe1232");
            passwordManager.CreateUser("Pepe12", "121hola");
        }


        [TestMethod]
        [ExpectedException(typeof(NameTooShortException))]
        public void createUserEmptyName()
        {
            passwordManager.CreateUser("", "password");
        }

        [TestMethod]
        [ExpectedException(typeof(NameTooShortException))]
        public void createUserNameTooShort()
        {
            passwordManager.CreateUser("Khea", " ");
        }

        [TestMethod]
        [ExpectedException(typeof(NameTooLongException))]
        public void createUserNameTooLong()
        {
            passwordManager.CreateUser("MaritoBaracus1234VisualStudioEnterprise", "password");
        }
    }
}
