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
        private PasswordManager _passwordManager;
        private SessionController _sessionController;
        private CategoryController _categoryController;
        private PasswordController _myPasswordController;
        private User _userShareFrom;
        private string _userShareFromMasterPass;
        private Category _category;

        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                _categoryController = new CategoryController();
                _sessionController = SessionController.GetInstance();
                _passwordManager = new PasswordManager();
                _myPasswordController = new PasswordController();
                _userShareFromMasterPass = "HolaSoySantiago1";
                _userShareFrom = new User()
                {
                    MasterName = "Santiago",
                    MasterPass = _userShareFromMasterPass
                };
                string categoryName = "Personal";
                _sessionController.CreateUser(_userShareFrom);
                _categoryController.CreateCategoryOnCurrentUser(categoryName);
                _category = _sessionController.CurrentUser.Categories[0];
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

            User userShareTo = new User()
            {
                MasterName = "Lucía",
                MasterPass = "lu2000_1"
            };
            _sessionController.CreateUser(userShareTo);
            _sessionController.Login(_userShareFrom.MasterName, _userShareFromMasterPass);
            Password passwordToShare = new Password
            {
                User = _userShareFrom,
                Category = _category,
                Site = "www.google.com",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };
            _myPasswordController.CreatePassword(passwordToShare);
            _passwordManager.SharePassword(passwordToShare, userShareTo);
            _sessionController.Login(userShareTo.MasterName, "lu2000_1");
            List<Password> sharedWithUser = _passwordManager.GetSharedPasswordsWithCurrentUser();
            CollectionAssert.Contains(sharedWithUser, passwordToShare);
        }


        [TestMethod]
        [ExpectedException(typeof(PasswordSharedWithSameUserException))]
        public void SharePasswordWithSameUser()
        {
            Password passwordToShare = new Password
            {
                User = _userShareFrom,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };
            _myPasswordController.CreatePassword(passwordToShare);
            _passwordManager.SharePassword(passwordToShare, _userShareFrom);
            List<Password> sharedWithUser = _passwordManager.GetSharedPasswordsWithCurrentUser();
        }
        [TestMethod]
        public void ShareManyPasswordsWithAnotherUser()
        {
            List<Password> expectedPasswords = new List<Password>();

            User userShareTo = new User()
            {
                MasterName = "Lucía",
                MasterPass = "lu2000@1"
            };
            _sessionController.CreateUser(userShareTo);
            _sessionController.Login(_userShareFrom.MasterName, _userShareFromMasterPass);
            Password ort = new Password
            {
                User = _userShareFrom,
                Category = _category,
                Site = "www.google.com",
                Username = "123456",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };
            _myPasswordController.CreatePassword(ort);
            expectedPasswords.Add(ort);
            _passwordManager.SharePassword(ort, userShareTo);

            Password trello = new Password
            {
                User = _userShareFrom,
                Category = _category,
                Site = "miami.com",
                Username = "josesito",
                Pass = "239850Jose2019",
                Notes = ""
            };
            _myPasswordController.CreatePassword(trello);
            expectedPasswords.Add(trello);
            _passwordManager.SharePassword(trello, userShareTo);

            Password amazon = new Password
            {
                User = _userShareFrom,
                Category = _category,
                Site = "trello.com",
                Username = "josesito",
                Pass = "239850Jose2019",
                Notes = ""
            };
            _myPasswordController.CreatePassword(amazon);
            expectedPasswords.Add(amazon);
            _passwordManager.SharePassword(amazon, userShareTo);
            _sessionController.Login(userShareTo.MasterName, "lu2000@1");
            List<Password> sharedWithUser = _passwordManager.GetSharedPasswordsWithCurrentUser();
            CollectionAssert.AreEqual(sharedWithUser, expectedPasswords);

        }

        [TestMethod]
        public void DeleteSharedPassword()
        {
            User userShareTo = new User()
            {
                MasterName = "Lucía",
                MasterPass = "lu2000@1"
            };
            _sessionController.CreateUser(userShareTo);

            _sessionController.Login(_userShareFrom.MasterName, _userShareFromMasterPass);
            Password passwordToShare = new Password
            {
                User = _userShareFrom,
                Category = _category,
                Site = "www.google.com",
                Username = "123456",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };
            _myPasswordController.CreatePassword(passwordToShare);
            _passwordManager.SharePassword(passwordToShare, userShareTo);
            _myPasswordController.DeletePassword(passwordToShare);
            _sessionController.Login(userShareTo.MasterName, "lu2000@1");
            List<Password> sharedWithUser = _passwordManager.GetSharedPasswordsWithCurrentUser();
            CollectionAssert.DoesNotContain(sharedWithUser, passwordToShare);
        }

        [TestMethod]
        public void GetSharedPasswordUser()
        {
            List<User> expectedUser = new List<User>();

            User userShareTo = new User()
            {
                MasterName = "Lucía",
                MasterPass = "lu2000@1"
            };

            Password pass = new Password
            {
                User = _userShareFrom,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };

            _sessionController.CreateUser(userShareTo);
            _sessionController.Login(_userShareFrom.MasterName, _userShareFromMasterPass);
            _myPasswordController.CreatePassword(pass);
            _passwordManager.SharePassword(pass, userShareTo);
            expectedUser.Add(userShareTo);

            List<User> usersSharedWith = _passwordManager.GetUsersSharedWith(pass);
            CollectionAssert.AreEqual(expectedUser, usersSharedWith);
        }

        [TestMethod]
        public void SharePasswordWithAlreadySharedUser()
        {
            User userShareTo = new User()
            {
                MasterName = "Lucia",
                MasterPass = "lu2000@1"
            };
            _sessionController.CreateUser(userShareTo);
            _sessionController.Login(_userShareFrom.MasterName, _userShareFromMasterPass);
            Password passwordToShare = new Password
            {
                User = _userShareFrom,
                Category = _category,
                Site = "www.google.com",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };
            _myPasswordController.CreatePassword(passwordToShare);
            _passwordManager.SharePassword(passwordToShare, userShareTo);
            _passwordManager.SharePassword(passwordToShare, userShareTo);
            List<User> actualSharedUsers = _passwordManager.GetUsersSharedWith(passwordToShare);
            List<User> expectedSharedUsers = new List<User>() { userShareTo };
            CollectionAssert.AreEqual(expectedSharedUsers, actualSharedUsers);
        }

        [TestMethod]
        public void GetSharedPasswordUsersMultipleUsers()
        {
            List<User> expectedUser = new List<User>();
            User lucia = new User()
            {
                MasterName = "Lucía",
                MasterPass = "lu2000@1"
            };
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

            Password pass = new Password
            {
                User = _userShareFrom,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };

            _sessionController.CreateUser(lucia);
            _sessionController.CreateUser(pablo);
            _sessionController.CreateUser(juana);
            _sessionController.Login(_userShareFrom.MasterName, _userShareFromMasterPass);
            _myPasswordController.CreatePassword(pass);
            _passwordManager.SharePassword(pass, lucia);
            _passwordManager.SharePassword(pass, pablo);
            _passwordManager.SharePassword(pass, juana);
            expectedUser.Add(juana);
            expectedUser.Add(lucia);
            expectedUser.Add(pablo);



            List<User> usersSharedWith = _passwordManager.GetUsersSharedWith(pass);
            CollectionAssert.AreEqual(expectedUser, usersSharedWith);
        }

        [TestMethod]
        public void GetUsersPasswordNotShared()
        {
            List<User> expectedUser = new List<User>();

            Password pass = new Password
            {
                User = _userShareFrom,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };

            _myPasswordController.CreatePassword(pass);

            List<User> usersSharedWith = _passwordManager.GetUsersSharedWith(pass);
            CollectionAssert.AreEquivalent(expectedUser, usersSharedWith);
        }

        [TestMethod]
        public void GetNotSharedWithUser()
        {
            List<User> expectedUser = new List<User>();
            User userShareWith = new User()
            {
                MasterName = "Lucía",
                MasterPass = "lu2000@1"
            };
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

            Password pass = new Password
            {
                User = _userShareFrom,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };

            _sessionController.CreateUser(userShareWith);
            _sessionController.CreateUser(pablo);
            _sessionController.CreateUser(juana);
            _sessionController.Login(_userShareFrom.MasterName, _userShareFromMasterPass);
            _myPasswordController.CreatePassword(pass);
            _passwordManager.SharePassword(pass, userShareWith);
            expectedUser.Add(juana);
            expectedUser.Add(pablo);


            List<User> usersNotSharedWith = _passwordManager.GetUsersPassNotSharedWith(pass);
            CollectionAssert.AreEqual(expectedUser, usersNotSharedWith);
        }

        [TestMethod]
        public void GetNotSharedWithAnyUser()
        {
            List<User> expectedUser = new List<User>();

            User lucia = new User()
            {
                MasterName = "Lucía",
                MasterPass = "lu2000@1"
            };
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

            Password pass = new Password
            {
                User = _userShareFrom,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };

            _sessionController.CreateUser(lucia);
            _sessionController.CreateUser(pablo);
            _sessionController.CreateUser(juana);
            _sessionController.Login(_userShareFrom.MasterName, _userShareFromMasterPass);
            _myPasswordController.CreatePassword(pass);
            expectedUser.Add(juana);
            expectedUser.Add(lucia);
            expectedUser.Add(pablo);


            List<User> usersNotSharedWith = _passwordManager.GetUsersPassNotSharedWith(pass);
            CollectionAssert.AreEqual(expectedUser, usersNotSharedWith);
        }

        [TestMethod]
        public void GetNotSharedWithAllUsers()
        {
            User lucia = new User()
            {
                MasterName = "Lucía",
                MasterPass = "lu2000@1"
            };
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

            Password pass = new Password
            {
                User = _userShareFrom,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };

            _sessionController.CreateUser(lucia);
            _sessionController.CreateUser(pablo);
            _sessionController.CreateUser(juana);
            _sessionController.Login(_userShareFrom.MasterName, _userShareFromMasterPass);
            _myPasswordController.CreatePassword(pass);
            _passwordManager.SharePassword(pass, lucia);
            _passwordManager.SharePassword(pass, pablo);
            _passwordManager.SharePassword(pass, juana);


            List<User> usersSharedWith = _passwordManager.GetUsersPassNotSharedWith(pass);
            List<User> expectedUser = new List<User>();
            CollectionAssert.AreEqual(expectedUser, usersSharedWith);
        }

        [TestMethod]
        public void UnSharePassword()
        {
            User userShareTo = new User()
            {
                MasterName = "Lucía",
                MasterPass = "lu2000@1"
            };
            _sessionController.CreateUser(userShareTo);
            Password passwordToShare = new Password
            {
                User = _userShareFrom,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };
            _sessionController.Login("Santiago", "HolaSoySantiago1");
            _myPasswordController.CreatePassword(passwordToShare);
            _passwordManager.SharePassword(passwordToShare, userShareTo);
            _passwordManager.UnSharePassword(passwordToShare, userShareTo);
            _sessionController.Login("Lucía", "lu2000@1");
            List<Password> sharedWithUser = _passwordManager.GetSharedPasswordsWithCurrentUser();
            CollectionAssert.DoesNotContain(sharedWithUser, passwordToShare);
        }


    }
}
