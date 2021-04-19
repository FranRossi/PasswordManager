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
        [ExpectedException(typeof(ValidationException),
            "The password is too short (min. 5 characters).")]
        public void createInvalidUserPasswordTooShort()
        {
            passwordManager.createUser("Juan12", "hola");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "The password is too long (max. 25 characters).")]
        public void createInvalidUserPasswordTooLong()
        {
            passwordManager.createUser("Pepe12", "hola12345678910111213141516171819202122");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "The password contains invalid characters(32 - 126 in ascii).")]
        public void createInvalidUserPasswordInvalidCharacter()
        {
            passwordManager.createUser("Pepe12", "½½½½hola½½½½");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "The username is already taken")]
        public void createInvalidUserNameAlreadyTaken()
        {
            passwordManager.createUser("Pepe12", "pepe1232");
            passwordManager.createUser("Pepe12", "121hola");
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
          "The name is too short (min. 5 characters).")]
        public void createUserNameEmpty()
        {
            passwordManager.createUser("", "password");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "The name is too short (min. 5 characters).")]
        public void createUserNameTooShort()
        {
            passwordManager.createUser("Khea", " ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
           "The name is too long (max. 25 characters).")]
        public void createUserNameTooLong()
        {
            passwordManager.createUser("MaritoBaracus1234VisualStudioEnterprise", "password");
        }

    }
}
