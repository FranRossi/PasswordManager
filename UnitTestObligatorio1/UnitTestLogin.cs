﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
using System;

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

        PasswordManager passwordManager;
        [TestInitialize]
        public void createPasswordManagerBeforeTests()
        {
            passwordManager = new PasswordManager();
            passwordManager.CreateUser("Lucia", "Lucia123");
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
        public void LoginUserWithPasswordAlreadyTaken()
        {
            passwordManager.CreateUser("Pepe12", "Lucia123");
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
