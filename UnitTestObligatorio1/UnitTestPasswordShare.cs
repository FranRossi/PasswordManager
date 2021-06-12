using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using BusinessLogic;
using Obligatorio1_DA1.Exceptions;
using System;
using System.Collections.Generic;
using Repository;

namespace UnitTestObligatorio1
{


    [TestClass]
    public class UnitTestPasswordShare
    {
        private SessionController _sessionController;
        private CategoryController _categoryController;
        private PasswordController _passwordController;
        private SharePasswordController _sharePasswordController;
        private User _userShareFrom;
        private User _userShareTo;
        private string _userShareFromMasterPass;
        private Category _category;
        private Password _passwordToShare;

        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                _categoryController = new CategoryController();
                _sessionController = SessionController.GetInstance();
                _passwordController = new PasswordController();
                _sharePasswordController = new SharePasswordController();
                _userShareFromMasterPass = "HolaSoySantiago1";
                _userShareTo = new User()
                {
                    MasterName = "Lucía",
                    MasterPass = "lu2000_1"
                };
                _userShareFrom = new User()
                {
                    MasterName = "Santiago",
                    MasterPass = _userShareFromMasterPass
                };
                string categoryName = "Personal";
                _sessionController.CreateUser(_userShareTo);
                _sessionController.CreateUser(_userShareFrom);
                _categoryController.CreateCategoryOnCurrentUser(categoryName);
                _category = _sessionController.CurrentUser.Categories[0];

                _passwordToShare = new Password
                {
                    User = _userShareFrom,
                    Category = _category,
                    Site = "www.google.com",
                    Username = "239850",
                    Pass = "239850Ort2019",
                    Notes = "No me roben la cuenta"
                };
                _passwordController.CreatePassword(_passwordToShare);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }

        }

        [TestCleanup]
        public void Cleanup()
        {
            UnitTestSignUp.DataBaseCleanup(null);
        }

        [TestMethod]
        public void ShareOnePasswordWithAnotherUser()
        {
            _sessionController.Login(_userShareFrom.MasterName, _userShareFromMasterPass);
            _sharePasswordController.SharePassword(_passwordToShare, _userShareTo);
            _sessionController.Login(_userShareTo.MasterName, "lu2000_1");
            List<Password> sharedWithUser = _sharePasswordController.GetSharedPasswordsWithCurrentUser();
            CollectionAssert.Contains(sharedWithUser, _passwordToShare);
        }


        [TestMethod]
        [ExpectedException(typeof(PasswordSharedWithSameUserException))]
        public void SharePasswordWithSameUser()
        {
            _sharePasswordController.SharePassword(_passwordToShare, _userShareFrom);
            List<Password> sharedWithUser = _sharePasswordController.GetSharedPasswordsWithCurrentUser();
        }
        [TestMethod]
        public void ShareManyPasswordsWithAnotherUser()
        {
            List<Password> expectedPasswords = new List<Password>();
            _sessionController.Login(_userShareFrom.MasterName, _userShareFromMasterPass);

            expectedPasswords.Add(_passwordToShare);
            _sharePasswordController.SharePassword(_passwordToShare, _userShareTo);

            Password trello = new Password
            {
                User = _userShareFrom,
                Category = _category,
                Site = "miami.com",
                Username = "josesito",
                Pass = "239850Jose2019",
                Notes = ""
            };
            _passwordController.CreatePassword(trello);
            expectedPasswords.Add(trello);
            _sharePasswordController.SharePassword(trello, _userShareTo);

            _sessionController.Login(_userShareTo.MasterName, "lu2000_1");
            List<Password> sharedWithUser = _sharePasswordController.GetSharedPasswordsWithCurrentUser();
            CollectionAssert.AreEqual(sharedWithUser, expectedPasswords);

        }

        [TestMethod]
        public void DeleteSharedPassword()
        {
            _sessionController.Login(_userShareFrom.MasterName, _userShareFromMasterPass);
            _sharePasswordController.SharePassword(_passwordToShare, _userShareTo);
            _passwordController.DeletePassword(_passwordToShare);
            _sessionController.Login(_userShareTo.MasterName, "lu2000_1");
            List<Password> sharedWithUser = _sharePasswordController.GetSharedPasswordsWithCurrentUser();
            CollectionAssert.DoesNotContain(sharedWithUser, _passwordToShare);
        }

        [TestMethod]
        public void GetSharedPasswordUser()
        {
            List<User> expectedUser = new List<User>();
            _sessionController.Login(_userShareFrom.MasterName, _userShareFromMasterPass);
            _sharePasswordController.SharePassword(_passwordToShare, _userShareTo);
            expectedUser.Add(_userShareTo);
            List<User> usersSharedWith = _sharePasswordController.GetUsersSharedWith(_passwordToShare);
            CollectionAssert.AreEqual(expectedUser, usersSharedWith);
        }

        [TestMethod]
        public void SharePasswordWithAlreadySharedUser()
        {
            _sessionController.Login(_userShareFrom.MasterName, _userShareFromMasterPass);
            _sharePasswordController.SharePassword(_passwordToShare, _userShareTo);
            _sharePasswordController.SharePassword(_passwordToShare, _userShareTo);
            List<User> actualSharedUsers = _sharePasswordController.GetUsersSharedWith(_passwordToShare);
            List<User> expectedSharedUsers = new List<User>() { _userShareTo };
            CollectionAssert.AreEqual(expectedSharedUsers, actualSharedUsers);
        }

        [TestMethod]
        public void GetSharedPasswordUsersMultipleUsers()
        {
            List<User> expectedUser = new List<User>();
            User pablo = new User()
            {
                MasterName = "Pablo",
                MasterPass = "pa1230@1"
            };
            User juana = new User()
            {
                MasterName = "Juana",
                MasterPass = "juana0@1"
            };

            _sessionController.CreateUser(pablo);
            _sessionController.CreateUser(juana);
            _sessionController.Login(_userShareFrom.MasterName, _userShareFromMasterPass);
            _sharePasswordController.SharePassword(_passwordToShare, _userShareTo);
            _sharePasswordController.SharePassword(_passwordToShare, pablo);
            _sharePasswordController.SharePassword(_passwordToShare, juana);
            expectedUser.Add(juana);
            expectedUser.Add(_userShareTo);
            expectedUser.Add(pablo);

            List<User> usersSharedWith = _sharePasswordController.GetUsersSharedWith(_passwordToShare);
            CollectionAssert.AreEqual(expectedUser, usersSharedWith);
        }

        [TestMethod]
        public void GetUsersPasswordNotShared()
        {
            List<User> expectedUser = new List<User>();

            List<User> usersSharedWith = _sharePasswordController.GetUsersSharedWith(_passwordToShare);
            CollectionAssert.AreEquivalent(expectedUser, usersSharedWith);
        }

        [TestMethod]
        public void GetNotSharedWithUser()
        {
            List<User> expectedUser = new List<User>();
            User pablo = new User()
            {
                MasterName = "Pablo",
                MasterPass = "pa1230@1"
            };
            User juana = new User()
            {
                MasterName = "Juana",
                MasterPass = "juana0@1"
            };

            _sessionController.CreateUser(pablo);
            _sessionController.CreateUser(juana);
            _sessionController.Login(_userShareFrom.MasterName, _userShareFromMasterPass);
            _sharePasswordController.SharePassword(_passwordToShare, _userShareTo);
            expectedUser.Add(juana);
            expectedUser.Add(pablo);

            List<User> usersNotSharedWith = _sharePasswordController.GetUsersPassNotSharedWith(_passwordToShare);
            CollectionAssert.AreEqual(expectedUser, usersNotSharedWith);
        }

        [TestMethod]
        public void GetNotSharedWithAnyUser()
        {
            List<User> expectedUser = new List<User>();
            User pablo = new User()
            {
                MasterName = "Pablo",
                MasterPass = "pa1230@1"
            };
            User juana = new User()
            {
                MasterName = "Juana",
                MasterPass = "juana0@1"
            };

            _sessionController.CreateUser(pablo);
            _sessionController.CreateUser(juana);
            _sessionController.Login(_userShareFrom.MasterName, _userShareFromMasterPass);
            expectedUser.Add(juana);
            expectedUser.Add(_userShareTo);
            expectedUser.Add(pablo);

            List<User> usersNotSharedWith = _sharePasswordController.GetUsersPassNotSharedWith(_passwordToShare);
            CollectionAssert.AreEqual(expectedUser, usersNotSharedWith);
        }

        [TestMethod]
        public void GetNotSharedWithAllUsers()
        {
            User pablo = new User()
            {
                MasterName = "Pablo",
                MasterPass = "pa1230@1"
            };
            User juana = new User()
            {
                MasterName = "Juana",
                MasterPass = "juana0@1"
            };

            _sessionController.CreateUser(pablo);
            _sessionController.CreateUser(juana);
            _sessionController.Login(_userShareFrom.MasterName, _userShareFromMasterPass);
            _sharePasswordController.SharePassword(_passwordToShare, _userShareTo);
            _sharePasswordController.SharePassword(_passwordToShare, pablo);
            _sharePasswordController.SharePassword(_passwordToShare, juana);

            List<User> usersSharedWith = _sharePasswordController.GetUsersPassNotSharedWith(_passwordToShare);
            List<User> expectedUser = new List<User>();
            CollectionAssert.AreEqual(expectedUser, usersSharedWith);
        }

        [TestMethod]
        public void UnSharePassword()
        {

            _sessionController.Login("Santiago", "HolaSoySantiago1");
            _sharePasswordController.SharePassword(_passwordToShare, _userShareTo);
            _sharePasswordController.UnSharePassword(_passwordToShare, _userShareTo);
            _sessionController.Login("Lucía", "lu2000_1");
            List<Password> sharedWithUser = _sharePasswordController.GetSharedPasswordsWithCurrentUser();
            CollectionAssert.DoesNotContain(sharedWithUser, _passwordToShare);
        }


    }
}
