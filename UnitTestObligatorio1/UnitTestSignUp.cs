using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1;
using Obligatorio1_DA1.Exceptions;
using System;


namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestSignUp
    {

        [TestMethod]
        public void createPasswordManager()
        {
            PasswordManager passwordManager = new PasswordManager();
            Assert.IsNotNull(passwordManager);
        }


        PasswordManager passwordManager;
        [TestInitialize]
        public void createPasswordManagerBeforeTests()
        {
            passwordManager = new PasswordManager();
        }

        [TestMethod]
        public void createValidUser()
        {
            try
            {
                passwordManager.createUser("Juancito", "hola123");
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(PasswordTooShortException))]
        public void createInvalidUserPasswordTooShort()
        {
            passwordManager.createUser("Juan12", "hola");
        }

        [TestMethod]
        [ExpectedException(typeof(PasswordTooLongException))]
        public void createInvalidUserPasswordTooLong()
        {
            passwordManager.createUser("Pepe12", "hola12345678910111213141516171819202122");
        }

        [TestMethod]
        [ExpectedException(typeof(PasswordInvalidCharactersException))]
        public void createInvalidUserPasswordInvalidCharacter()
        {
            passwordManager.createUser("Pepe12", "½½½½hola½½½½");
        }

        [TestMethod]
        [ExpectedException(typeof(UsernameAlreadyTakenException))]
        public void createInvalidUserNameAlreadyTaken()
        {
            passwordManager.createUser("Pepe12", "pepe1232");
            passwordManager.createUser("Pepe12", "121hola");
        }


        [TestMethod]
        [ExpectedException(typeof(NameTooShortException))]
        public void createUserNameEmpty()
        {
            passwordManager.createUser("", "password");
        }

        [TestMethod]
        [ExpectedException(typeof(NameTooShortException))]
        public void createUserNameTooShort()
        {
            passwordManager.createUser("Khea", " ");
        }

        [TestMethod]
        [ExpectedException(typeof(NameTooLongException))]
        public void createUserNameTooLong()
        {
            passwordManager.createUser("MaritoBaracus1234VisualStudioEnterprise", "password");
        }
    }
}
