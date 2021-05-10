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
                User newUser = new User("Juancito", "hola123");
                passwordManager.CreateUser(newUser);
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
            passwordManager.CreateUser(newUser);
        }

        [TestMethod]
        [ExpectedException(typeof(PasswordTooLongException))]
        public void CreateInvalidUserPasswordTooLong()
        {
            User newUser = new User("Pepe12", "hola12345678910111213141516171819202122");
            passwordManager.CreateUser(newUser);
        }

        [TestMethod]
        [ExpectedException(typeof(PasswordInvalidCharactersException))]
        public void CreateInvalidUserPasswordInvalidCharacter()
        {
            User newUser = new User("Pepe12", "½½½½hola½½½½");
            passwordManager.CreateUser(newUser);
        }

        [TestMethod]
        [ExpectedException(typeof(UsernameAlreadyTakenException))]
        public void CreateInvalidUserNameAlreadyTaken()
        {
            User newUser = new User("Pepe12", "pepe1232");
            passwordManager.CreateUser(newUser);
            User newUser2 = new User("Pepe12", "121hola");
            passwordManager.CreateUser(newUser2);
        }


        [TestMethod]
        [ExpectedException(typeof(UserNameTooShortException))]
        public void CreateUserEmptyName()
        {
            User newUser = new User("", "password");
            passwordManager.CreateUser(newUser);
        }

        [TestMethod]
        [ExpectedException(typeof(UserNameTooShortException))]
        public void CreateUserNameTooShort()
        {
            User newUser = new User("Khea", " ");
            passwordManager.CreateUser(newUser);
        }

        [TestMethod]
        [ExpectedException(typeof(UserNameTooLongException))]
        public void CreateUserNameTooLong()
        {
            User newUser = new User("MaritoBaracus1234VisualStudioEnterprise", "password");
            passwordManager.CreateUser(newUser);
        }

        // TODO move test to another unitTest file
        [DataRow("MaritoBaracus")]
        [DataRow("Lucia")]
        [DataRow("Pepe Gonzales Segundo")]
        [DataTestMethod]
        public void UserToString(string name)
        {
            User newUser = new User(name, "password");
            string actualName = newUser.ToString();
            string expectedName = name;
            StringAssert.Equals(expectedName, actualName);
        }

        [TestMethod]
        public void UserNotEqual()
        {
            User newUser1 = new User("Juancito", "hola123");

            User newUser2 = new User("juancito", "hola123");

            Assert.IsFalse(newUser1.Equals(newUser2));
        }

        [TestMethod]
        public void UserEqual()
        {
            User newUser1 = new User("Juancito", "hola123");

            User newUser2 = new User("Juancito", "hola123");

            Assert.IsTrue(newUser1.Equals(newUser2));
        }

    }
}
