using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using BusinessLogic;
using Obligatorio1_DA1.Exceptions;
using System;
using System.Collections.Generic;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestPasswordShare
    {
        private PasswordManager _passwordManager;
        private User _userShareFrom;
        private Category _category;

        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                _passwordManager = new PasswordManager();
                _userShareFrom = new User()
                {
                    MasterName = "Santiago",
                    MasterPass = "HolaSoySantiago1"
                };
                string categoryName = "Personal";
                _passwordManager.CreateUser(_userShareFrom);
                _passwordManager.CreateCategoryOnCurrentUser(categoryName);
                _category = _passwordManager.CurrentUser.Categories[0];
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }

        }

        [TestMethod]
        public void ShareOnePasswordWithAnotherUser()
        {

            User userShareTo = new User()
            {
                MasterName = "Lucía",
                MasterPass = "lu2000@1"
            };
            _passwordManager.CreateUser(userShareTo);
            _passwordManager.Login(_userShareFrom.MasterName, _userShareFrom.MasterPass);
            Password passwordToShare = new Password
            {
                User = _userShareFrom,
                Category = _category,
                Site = "www.google.com",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };
            _passwordManager.CreatePassword(passwordToShare);
            _passwordManager.SharePassword(passwordToShare, userShareTo);
            _passwordManager.Login(userShareTo.MasterName, userShareTo.MasterPass);
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
            _passwordManager.CreatePassword(passwordToShare);
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
            _passwordManager.CreateUser(userShareTo);
            _passwordManager.Login(_userShareFrom.MasterName, _userShareFrom.MasterPass);
            Password ort = new Password
            {
                User = _userShareFrom,
                Category = _category,
                Site = "www.google.com",
                Username = "123456",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };
            _passwordManager.CreatePassword(ort);
            expectedPasswords.Add(ort);
            _passwordManager.SharePassword(ort, userShareTo);

            Password trello = new Password
            {
                User = _userShareFrom,
                Category = _category,
                Site = "miami.com",
                Username = "josesito",
                Pass = "239850Jose2019"
            };
            _passwordManager.CreatePassword(trello);
            expectedPasswords.Add(trello);
            _passwordManager.SharePassword(trello, userShareTo);

            Password amazon = new Password
            {
                User = _userShareFrom,
                Category = _category,
                Site = "trello.com",
                Username = "josesito",
                Pass = "239850Jose2019"
            };
            _passwordManager.CreatePassword(amazon);
            expectedPasswords.Add(amazon);
            _passwordManager.SharePassword(amazon, userShareTo);
            _passwordManager.Login(userShareTo.MasterName, userShareTo.MasterPass);
            List<Password> sharedWithUser = _passwordManager.GetSharedPasswordsWithCurrentUser();
            CollectionAssert.AreEquivalent(sharedWithUser, expectedPasswords);

        }

        [TestMethod]
        public void DeleteSharedPassword()
        {
            User userShareTo = new User()
            {
                MasterName = "Lucía",
                MasterPass = "lu2000@1"
            };
            _passwordManager.CreateUser(userShareTo);

            _passwordManager.Login(_userShareFrom.MasterName, _userShareFrom.MasterPass);
            Password passwordToShare = new Password
            {
                User = _userShareFrom,
                Category = _category,
                Site = "www.google.com",
                Username = "123456",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };
            _passwordManager.CreatePassword(passwordToShare);
            _passwordManager.SharePassword(passwordToShare, userShareTo);
            _passwordManager.DeletePassword(passwordToShare);
            _passwordManager.Login(userShareTo.MasterName, userShareTo.MasterPass);
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

            _passwordManager.CreateUser(userShareTo);
            _passwordManager.Login(_userShareFrom.MasterName, _userShareFrom.MasterPass);
            _passwordManager.CreatePassword(pass);
            _passwordManager.SharePassword(pass, userShareTo);
            expectedUser.Add(userShareTo);

            List<User> usersSharedWith = _passwordManager.GetUsersSharedWith(pass);
            CollectionAssert.AreEquivalent(expectedUser, usersSharedWith);
        }

        [TestMethod]
        public void SharePasswordWithAlreadySharedUser()
        {
            User userShareTo = new User()
            {
                MasterName = "Lucía",
                MasterPass = "lu2000@1"
            };
            _passwordManager.CreateUser(userShareTo);
            _passwordManager.Login(_userShareFrom.MasterName, _userShareFrom.MasterPass);
            Password passwordToShare = new Password
            {
                User = _userShareFrom,
                Category = _category,
                Site = "www.google.com",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };
            _passwordManager.CreatePassword(passwordToShare);
            _passwordManager.SharePassword(passwordToShare, userShareTo);
            _passwordManager.SharePassword(passwordToShare, userShareTo);
            List<User> actualSharedUsers = _passwordManager.GetUsersSharedWith(passwordToShare);
            List<User> expectedSharedUsers = new List<User>() { userShareTo };
            CollectionAssert.AreEquivalent(expectedSharedUsers, actualSharedUsers);
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

            _passwordManager.CreateUser(lucia);
            _passwordManager.CreateUser(pablo);
            _passwordManager.CreateUser(juana);
            _passwordManager.Login(_userShareFrom.MasterName, _userShareFrom.MasterPass);
            _passwordManager.CreatePassword(pass);
            _passwordManager.SharePassword(pass, lucia);
            _passwordManager.SharePassword(pass, pablo);
            _passwordManager.SharePassword(pass, juana);
            expectedUser.Add(lucia);
            expectedUser.Add(pablo);
            expectedUser.Add(juana);


            List<User> usersSharedWith = _passwordManager.GetUsersSharedWith(pass);
            CollectionAssert.AreEquivalent(expectedUser, usersSharedWith);
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

            _passwordManager.CreatePassword(pass);

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

            _passwordManager.CreateUser(userShareWith);
            _passwordManager.CreateUser(pablo);
            _passwordManager.CreateUser(juana);
            _passwordManager.Login(_userShareFrom.MasterName, _userShareFrom.MasterPass);
            _passwordManager.CreatePassword(pass);
            _passwordManager.SharePassword(pass, userShareWith);
            expectedUser.Add(pablo);
            expectedUser.Add(juana);

            List<User> usersNotSharedWith = _passwordManager.GetUsersPassNotSharedWith(pass);
            CollectionAssert.AreEquivalent(expectedUser, usersNotSharedWith);
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

            _passwordManager.CreateUser(lucia);
            _passwordManager.CreateUser(pablo);
            _passwordManager.CreateUser(juana);
            _passwordManager.Login(_userShareFrom.MasterName, _userShareFrom.MasterPass);
            _passwordManager.CreatePassword(pass);
            expectedUser.Add(lucia);
            expectedUser.Add(pablo);
            expectedUser.Add(juana);


            List<User> usersNotSharedWith = _passwordManager.GetUsersPassNotSharedWith(pass);
            CollectionAssert.AreEquivalent(expectedUser, usersNotSharedWith);
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

            _passwordManager.CreateUser(lucia);
            _passwordManager.CreateUser(pablo);
            _passwordManager.CreateUser(juana);
            _passwordManager.Login(_userShareFrom.MasterName, _userShareFrom.MasterPass);
            _passwordManager.CreatePassword(pass);
            _passwordManager.SharePassword(pass, lucia);
            _passwordManager.SharePassword(pass, pablo);
            _passwordManager.SharePassword(pass, juana);


            List<User> usersSharedWith = _passwordManager.GetUsersPassNotSharedWith(pass);
            List<User> expectedUser = new List<User>();
            CollectionAssert.AreEquivalent(expectedUser, usersSharedWith);
        }

        [TestMethod]
        public void UnSharePassword()
        {
            User userShareTo = new User()
            {
                MasterName = "Lucía",
                MasterPass = "lu2000@1"
            };
            _passwordManager.CreateUser(userShareTo);
            Password passwordToShare = new Password
            {
                User = _userShareFrom,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };
            _passwordManager.Login("Santiago", "HolaSoySantiago1");
            _passwordManager.CreatePassword(passwordToShare);
            _passwordManager.SharePassword(passwordToShare, userShareTo);
            _passwordManager.UnSharePassword(passwordToShare, userShareTo);
            _passwordManager.Login("Lucía", "lu2000@1");
            List<Password> sharedWithUser = _passwordManager.GetSharedPasswordsWithCurrentUser();
            CollectionAssert.DoesNotContain(sharedWithUser, passwordToShare);
        }


    }
}
