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

        [DataRow("mySuper")]
        [DataRow("12321pfg")]
        [DataRow("hellworld")]
        [DataTestMethod]
        public void UserPasswordIsHashed(string pass)
        {
            User newUser = new User("Juancito", pass);
            _sessionController.CreateUser(newUser);
        }

        [DataRow("hola123")]
        [DataRow("12321kl")]
        [DataRow("hellworld")]
        [DataTestMethod]
        public void HashDifferentThanOrignal(string originalMasterPass)
        {
            User newUser = new User("Juancito", originalMasterPass);
            _sessionController.CreateUser(newUser);
            User newUserFromPasswordManager = _sessionController.CurrentUser;
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
            _sessionController.CreateUser(newUser);

            User anotherUser = new User("Pedrito", "Pedrito12345");
            _sessionController.CreateUser(anotherUser);

            _sessionController.Login("Juancito", originalMasterPass);

            User newUserFromPasswordManager = _sessionController.CurrentUser;
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
            _sessionController.CreateUser(newUser);
            User newUserFromPasswordManager = _sessionController.CurrentUser;
            string userPasswordsKey = newUserFromPasswordManager.DecryptionKey;
            Assert.AreEqual(originalMasterPass, userPasswordsKey);
        }


    }
}
