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

        [DataRow("mySuper")]
        [DataRow("12321pfg")]
        [DataRow("hellworld")]
        [DataTestMethod]
        public void UserPasswordIsHashed(string pass)
        {

            User newUser = new User("Juancito", pass);
            passwordManager.CreateUser(newUser);

        }

        [DataRow("hola123")]
        [DataRow("12321kl")]
        [DataRow("hellworld")]
        [DataTestMethod]
        public void HashDifferentThanOrignal(string originalMasterPass)
        {
            User newUser = new User("Juancito", originalMasterPass);
            passwordManager.CreateUser(newUser);
            User newUserFromPasswordManager = passwordManager.CurrentUser;
            string userMasterPass = newUserFromPasswordManager.MasterPass;
            Assert.AreNotEqual(userMasterPass, originalMasterPass);
        }


        [DataRow("asdfasdf")]
        [DataRow("1232qwerty1231kl")]
        [DataRow("mypass")]
        [DataTestMethod]
        public void HashingInUserLogin(string originalMasterPass)
        {
            User newUser = new User("Juancito", originalMasterPass);
            passwordManager.CreateUser(newUser);

            User anotherUser = new User("Pedrito", "Pedrito12345");
            passwordManager.CreateUser(anotherUser);

            passwordManager.Login("Juancito", originalMasterPass);

            User newUserFromPasswordManager = passwordManager.CurrentUser;
            string userMasterPass = newUserFromPasswordManager.MasterPass;
            Assert.AreNotEqual(userMasterPass, originalMasterPass);
        }

        [DataRow("hola123")]
        [DataRow("12321kl")]
        [DataRow("hellworld")]
        [DataTestMethod]
        public void GetUserOriginalPassword(string originalMasterPass)
        {
            User newUser = new User("Juancito", originalMasterPass);
            passwordManager.CreateUser(newUser);
            User newUserFromPasswordManager = passwordManager.CurrentUser;
            string userPasswordsKey = newUserFromPasswordManager.DecryptionKey;
            Assert.AreEqual(originalMasterPass, userPasswordsKey);
        }


    }
}
