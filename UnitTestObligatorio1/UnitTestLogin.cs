using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1;
using System;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestLogin
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
                passwordManager.createUser("Juan", "hola123");
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "The password is too short (min. 5 characters).")]
        public void createInvalidUserPasswordTooShort()
        {
            passwordManager.createUser("Juan", "hola");
        }




    }
}
