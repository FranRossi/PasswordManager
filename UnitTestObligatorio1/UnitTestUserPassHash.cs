using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
using BusinessLogic;
using System;
using Repository;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestUserPassHash
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

        [TestCleanup]
        public void Cleanup()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM PASSWORDS");
                context.Database.ExecuteSqlCommand("DELETE FROM CREDITCARDS");
                context.Database.ExecuteSqlCommand("DELETE FROM USERS");
            }
        }

        [DataRow("mySuperSecurePassword")]
        [DataRow("12321pass werod")]
        [DataRow("hello world")]
        [DataTestMethod]
        public void UserPasswordIsHashed()
        {

            User newUser = new User("Juancito", "hola123");
            passwordManager.CreateUser(newUser);

        }

        [DataRow("mySuperSecurePassword")]
        [DataRow("12321pass werod")]
        [DataRow("hello world")]
        [DataTestMethod]
        public void HashDifferentThanOrignal(string textToHash)
        {
            //string hashedText = hashing.Hash(textToHash);
            //Assert.AreNotEqual(textToHash, hashedText, "Original: " + textToHash + " Result: " + hashedText);
        }

    }
}
