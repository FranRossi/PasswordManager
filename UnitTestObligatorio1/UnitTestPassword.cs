using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Utilities;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestPassword
    {
        private Password _password;
        private PasswordManager _passwordManager;
        private User _user;
        private Category _category;


        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                _passwordManager = new PasswordManager();
                _user = new User()
                {
                    Name = "Gonzalo",
                    Pass = "HolaSoyGonzalo123"
                };
                _category = new Category()
                {
                    Name = "Personal"
                };
                _user.Categories.Add(_category);
                this._password = new Password
                {
                    User = _user,
                    Category = _category,
                    Site = "ort.edu.uy",
                    Username = "239850",
                    Pass = "239850Ort2019",
                    Notes = "No me roben la cuenta"
                };
                _passwordManager.CreateUser(_user);
                _passwordManager.CreatePassword(_password);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }

        }

        [TestMethod]
        public void GetUserPasswords()
        {
            List<Password> userPasswords = this._passwordManager.GetPasswords();
            CollectionAssert.Contains(userPasswords, this._password);
        }

        [TestMethod]
        public void DeletePassword()
        {
            this._passwordManager.DeletePassword(this._password);
            List<Password> userPasswords = this._passwordManager.GetPasswords();
            CollectionAssert.DoesNotContain(userPasswords, this._password);
        }

        [TestMethod]
        public void GetUserPasswordsWithMultipleUsers()
        {
            User differentUser = new User()
            {
                Name = "Juan Perez",
                Pass = "juan123"
            };
            Category categoryPersonal = new Category()
            {
                Name = "Personal"
            };
            differentUser.Categories.Add(categoryPersonal);
            Password differentPassword = new Password
            {
                User = differentUser,
                Category = categoryPersonal,
                Site = "www.google.com",
                Username = "123456",
                Pass = "239850Ort2019"
            };

            this._passwordManager.CreatePassword(differentPassword);
            List<Password> userPasswords = this._passwordManager.GetPasswords();
            CollectionAssert.DoesNotContain(userPasswords, differentPassword);
        }

        [TestMethod]
        public void CreateNewPasswordWithoutNotes()
        {
            try
            {
                Password pass = new Password
                {
                    User = _user,
                    Category = _category,
                    Site = "work.com",
                    Username = "Joseph",
                    Pass = "wwwjosph"
                };
                _passwordManager.CreatePassword(pass);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }

        }

        [TestMethod]
        [ExpectedException(typeof(PasswordUsernameTooShortException))]
        public void CreateNewPasswordWithUsernameTooShort()
        {
            this._password.Username = "Tom";
        }

        [TestMethod]
        [ExpectedException(typeof(PasswordUsernameTooLongException))]
        public void CreateNewPasswordWithUsernameTooLong()
        {
            this._password.Username = "Hubert Blaine Wolfeschlegelsteinhausenbergerdorff ";
        }


        [TestMethod]
        [ExpectedException(typeof(PasswordTooShortException))]
        public void CreateNewPasswordTooShort()
        {
            this._password.Pass = "tom";
        }


        [TestMethod]
        [ExpectedException(typeof(PasswordTooLongException))]
        public void CreateNewPasswordTooLong()
        {
            this._password.Pass = "harryharryharryharryharryharry";
        }


        [TestMethod]
        [ExpectedException(typeof(PasswordSiteTooShortException))]
        public void CreateNewPasswordSiteTooShort()
        {
            this._password.Site = "hi";
        }


        [TestMethod]
        [ExpectedException(typeof(PasswordSiteTooLongException))]
        public void CreateNewSiteSiteTooLong()
        {
            this._password.Site = "htpps://wwww.harrywork.com/homepage/signup";
        }



        [TestMethod]
        [ExpectedException(typeof(ItemNotesTooLongException))]
        public void CreateNewPasswordNotesTooLong()
        {
            this._password.Notes = "Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when " +
                "an unknown printer took a galley of type and scrambled it to make a type specimen book. " +
                "It has survived not only five centuries, but also the leap into electronic typesetting, remaining" +
                " essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets " +
                "containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus " +
                "PageMaker including versions of Lorem ";
        }



        [DataRow(5, true, false, false, false, "^[A-Z]{5}$")]
        [DataRow(6, false, true, false, false, "^[a-z]{6}$")]
        [DataRow(8, true, true, false, false, "^([a-z]|[A-Z]){8}$")]
        [DataRow(15, false, false, true, false, "^[0-9]{15}$")]
        [DataRow(25, false, false, false, true, "^([ -/]|[:-@]|[[-`]|[{-~]){25}$")]
        [DataRow(6, true, true, true, true, "^[ -~]{6}$")]
        [DataRow(20, true, true, true, true, "^[ -~]{20}$")]
        [DataTestMethod]
        public void GenerateValidPassword
               (int length, Boolean upercase, Boolean lowercase, Boolean digits, Boolean specialDigits, string regex)
        {
            string pass = Password.GenerateRandomPassword(length, upercase, lowercase, digits, specialDigits);
            Regex regexToCheck = new Regex(regex);
            Assert.IsTrue(regexToCheck.IsMatch(pass), "Password: " + pass + " Regex: " + regex);
        }

        [DataRow(6, false, false, false, false)]
        [DataRow(9, false, false, false, false)]
        [DataTestMethod]
        [ExpectedException(typeof(PasswordGenerationNotSelectedCharacterTypesException))]
        public void GenerateInvalidNotTypesSelectedPassword
               (int length, Boolean upercase, Boolean lowercase, Boolean digits, Boolean specialDigits)
        {
            string pass = Password.GenerateRandomPassword(length, upercase, lowercase, digits, specialDigits);
        }


        [DataRow(4, true, false, false, false)]
        [DataRow(2, true, true, false, true)]
        [DataTestMethod]
        [ExpectedException(typeof(PasswordGenerationTooShortException))]
        public void GenerateInvalidTooShortPassword
       (int length, Boolean upercase, Boolean lowercase, Boolean digits, Boolean specialDigits)
        {
            string pass = Password.GenerateRandomPassword(length, upercase, lowercase, digits, specialDigits);
        }

        [DataRow(3434, true, false, false, false)]
        [DataRow(26, true, true, false, true)]
        [DataTestMethod]
        [ExpectedException(typeof(PasswordGenerationTooLongException))]
        public void GenerateInvalidTooLongPassword
        (int length, Boolean upercase, Boolean lowercase, Boolean digits, Boolean specialDigits)
        {
            string pass = Password.GenerateRandomPassword(length, upercase, lowercase, digits, specialDigits);
        }

        [TestMethod]
        public void CreateValidPassword()
        {
            try
            {
                this._password = new Password
                {
                    User = _user,
                    Category = _category,
                    Site = "example.com",
                    Username = "123456",
                    Pass = "239850Ort2019",
                    Notes = "No me roben la cuenta"
                };
                _passwordManager.CreatePassword(this._password);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ItemInvalidCategoryException))]
        public void CreateInvalidPasswordWrongCategory()
        {
            Category unusedCategory = new Category()
            {
                Name = "Work"
            };
            Password pass = new Password
            {
                User = _user,
                Category = unusedCategory,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };
        }

        [TestMethod]
        public void ShareOnePasswordWithAnotherUser()
        {
            User userShareFrom = new User()
            {
                Name = "Santiago",
                Pass = "HolaSoySantiago1"
            };
            Category category = new Category()
            {
                Name = "Personal"
            };
            this._passwordManager.CreateUser(userShareFrom);
            this._passwordManager.CreateCategoryOnCurrentUser(category);
            User userShareTo = new User()
            {
                Name = "Lucía",
                Pass = "lu2000@1"
            };
            this._passwordManager.CreateUser(userShareTo);
            this._passwordManager.Login(userShareFrom.Name, userShareFrom.Pass);
            Password passwordToShare = new Password
            {
                User = userShareFrom,
                Category = category,
                Site = "www.google.com",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };
            this._passwordManager.CreatePassword(passwordToShare);
            passwordToShare.ShareWithUser(userShareTo);
            this._passwordManager.Login(userShareTo.Name, userShareTo.Pass);
            List<Password> sharedWithUser = this._passwordManager.GetSharedPasswordsWithCurrentUser();
            CollectionAssert.Contains(sharedWithUser, passwordToShare);
        }


        [TestMethod]
        [ExpectedException(typeof(PasswordSharedWithSameUserException))]
        public void SharePasswordWithSameUser()
        {
            User userShareFrom = new User()
            {
                Name = "Santiago",
                Pass = "HolaSoySantiago1"
            };
            Category category = new Category()
            {
                Name = "Personal"
            };
            this._passwordManager.CreateUser(userShareFrom);
            this._passwordManager.CreateCategoryOnCurrentUser(category);
            this._passwordManager.Login(userShareFrom.Name, userShareFrom.Pass);
            Password passwordToShare = new Password
            {
                User = userShareFrom,
                Category = category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };
            this._passwordManager.CreatePassword(passwordToShare);
            passwordToShare.ShareWithUser(userShareFrom);
            List<Password> sharedWithUser = this._passwordManager.GetSharedPasswordsWithCurrentUser();
        }
        [TestMethod]
        public void ShareManyPasswordsWithAnotherUser()
        {
            List<Password> expectedPasswords = new List<Password>();

            User userShareFrom = new User()
            {
                Name = "Santiago",
                Pass = "HolaSoySantiago1"
            };
            Category category = new Category()
            {
                Name = "Personal"
            };
            this._passwordManager.CreateUser(userShareFrom);
            this._passwordManager.CreateCategoryOnCurrentUser(category);
            User userShareTo = new User()
            {
                Name = "Lucía",
                Pass = "lu2000@1"
            };
            this._passwordManager.CreateUser(userShareTo);
            this._passwordManager.Login(userShareFrom.Name, userShareFrom.Pass);
            Password ort = new Password
            {
                User = userShareFrom,
                Category = category,
                Site = "www.google.com",
                Username = "123456",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };
            this._passwordManager.CreatePassword(ort);
            expectedPasswords.Add(ort);
            ort.ShareWithUser(userShareTo);

            Password trello = new Password
            {
                User = userShareFrom,
                Category = category,
                Site = "miami.com",
                Username = "josesito",
                Pass = "239850Jose2019"
            };
            this._passwordManager.CreatePassword(trello);
            expectedPasswords.Add(trello);
            trello.ShareWithUser(userShareTo);

            Password amazon = new Password
            {
                User = userShareFrom,
                Category = category,
                Site = "trello.com",
                Username = "josesito",
                Pass = "239850Jose2019"
            };
            this._passwordManager.CreatePassword(amazon);
            expectedPasswords.Add(amazon);
            amazon.ShareWithUser(userShareTo);
            this._passwordManager.Login(userShareTo.Name, userShareTo.Pass);
            List<Password> sharedWithUser = this._passwordManager.GetSharedPasswordsWithCurrentUser();
            CollectionAssert.AreEquivalent(sharedWithUser, expectedPasswords);

        }

        [TestMethod]
        public void DeleteSharedPassword()
        {
            User userShareFrom = new User()
            {
                Name = "Santiago",
                Pass = "HolaSoySantiago1"
            };
            Category category = new Category()
            {
                Name = "Personal"
            };
            this._passwordManager.CreateUser(userShareFrom);
            this._passwordManager.CreateCategoryOnCurrentUser(category);
            User userShareTo = new User()
            {
                Name = "Lucía",
                Pass = "lu2000@1"
            };
            this._passwordManager.CreateUser(userShareTo);

            this._passwordManager.Login(userShareFrom.Name, userShareFrom.Pass);
            Password passwordToShare = new Password
            {
                User = userShareFrom,
                Category = category,
                Site = "www.google.com",
                Username = "123456",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };
            this._passwordManager.CreatePassword(passwordToShare);
            passwordToShare.ShareWithUser(userShareTo);
            this._passwordManager.DeletePassword(passwordToShare);
            this._passwordManager.Login(userShareTo.Name, userShareTo.Pass);
            List<Password> sharedWithUser = this._passwordManager.GetSharedPasswordsWithCurrentUser();
            CollectionAssert.DoesNotContain(sharedWithUser, passwordToShare);
        }

        [TestMethod]
        public void GetSharedPasswordUser()
        {
            List<User> expectedUser = new List<User>();

            User userShareFrom = new User()
            {
                Name = "Santiago",
                Pass = "HolaSoySantiago1"
            };
            Category category = new Category()
            {
                Name = "Personal"
            };
            User userShareTo = new User()
            {
                Name = "Lucía",
                Pass = "lu2000@1"
            };
            userShareFrom.Categories.Add(category);

            Password pass = new Password
            {
                User = userShareFrom,
                Category = category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };

            this._passwordManager.CreateUser(userShareTo);
            this._passwordManager.CreateUser(userShareFrom);
            this._passwordManager.CreatePassword(pass);
            pass.ShareWithUser(userShareTo);
            expectedUser.Add(userShareTo);


            List<User> usersSharedWith = pass.GetUsersSharedWith();
            CollectionAssert.AreEquivalent(expectedUser, usersSharedWith);
        }

        [TestMethod]
        public void GetSharedPasswordUsersMultipleUsers()
        {
            List<User> expectedUser = new List<User>();

            User userShareFrom = new User()
            {
                Name = "Santiago",
                Pass = "HolaSoySantiago1"
            };
            Category category = new Category()
            {
                Name = "Personal"
            };
            User lucia = new User()
            {
                Name = "Lucía",
                Pass = "lu2000@1"
            };
            User pablo = new User()
            {
                Name = "Pablo",
                Pass = "pa1230@1"
            };
            User juana = new User()
            {
                Name = "Juana",
                Pass = "juana0@1"
            };

            userShareFrom.Categories.Add(category);

            Password pass = new Password
            {
                User = userShareFrom,
                Category = category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };

            this._passwordManager.CreateUser(lucia);
            this._passwordManager.CreateUser(pablo);
            this._passwordManager.CreateUser(juana);
            this._passwordManager.CreateUser(userShareFrom);
            this._passwordManager.CreatePassword(pass);
            pass.ShareWithUser(lucia);
            pass.ShareWithUser(pablo);
            pass.ShareWithUser(juana);
            expectedUser.Add(lucia);
            expectedUser.Add(pablo);
            expectedUser.Add(juana);


            List<User> usersSharedWith = pass.GetUsersSharedWith();
            CollectionAssert.AreEquivalent(expectedUser, usersSharedWith);
        }

        [TestMethod]
        public void GetSharedPasswordNotShared()
        {
            List<User> expectedUser = new List<User>();
            User user = new User()
            {
                Name = "Santiago",
                Pass = "HolaSoySantiago1"
            };
            Category category = new Category()
            {
                Name = "Personal"
            };
            user.Categories.Add(category);

            Password pass = new Password
            {
                User = user,
                Category = category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };

            this._passwordManager.CreateUser(user);
            this._passwordManager.CreatePassword(pass);

            List<User> usersSharedWith = pass.GetUsersSharedWith();
            CollectionAssert.AreEquivalent(expectedUser, usersSharedWith);
        }


        [TestMethod]
        public void ModifyPassword()
        {
            Password newPassword = new Password
            {
                User = this._user,
                Category = this._category,
                Site = "ort.edu.uy",
                Username = "123456",
                Pass = "1234560Ort2020",
                Notes = "Esta es la nueva password"
            };
            this._passwordManager.ModifyPasswordOnCurrentUser(this._password, newPassword);
            List<Password> passwords = this._passwordManager.GetPasswords();
            CollectionAssert.Contains(passwords, newPassword);
        }

        [TestMethod]
        [ExpectedException(typeof(PasswordAlreadyExistsException))]
        public void ModifyPasswordThatAlreadyExists()
        {
            Password passwordAlreadyOnPasswordManager = new Password
            {
                User = this._user,
                Category = this._category,
                Site = "ort.edu.uy",
                Username = "123456",
                Pass = "1234560Ort2020",
                Notes = "Esta es una nota"
            };
            _passwordManager.CreatePassword(passwordAlreadyOnPasswordManager);

            Password newPassword = new Password
            {
                User = this._user,
                Category = this._category,
                Site = "ort.edu.uy",
                Username = "123456",
                Pass = "EstoEsUnGIF",
                Notes = "Esta es la nueva password"
            };
            this._passwordManager.ModifyPasswordOnCurrentUser(this._password, newPassword);
        }

        [TestMethod]
        [ExpectedException(typeof(PasswordAlreadyExistsException))]
        public void CreatePasswordThatAlreadyExists()
        {
            Password passwordAlreadyOnPasswordManager = new Password
            {
                User = this._user,
                Category = this._category,
                Site = "ort.edu.uy",
                Username = "123456",
                Pass = "1234560Ort2020",
                Notes = "Esta es una nota"
            };
            _passwordManager.CreatePassword(passwordAlreadyOnPasswordManager);

            Password newPassword = new Password
            {
                User = this._user,
                Category = this._category,
                Site = "ort.edu.uy",
                Username = "123456",
                Pass = "EstoEsUnGIF",
                Notes = "Esta es la nueva password"
            };
            this._passwordManager.CreatePassword(newPassword);
        }




        [TestMethod]
        public void GetNotSharedWithUser()
        {
            List<User> expectedUser = new List<User>();

            User userShareFrom = new User()
            {
                Name = "Santiago",
                Pass = "HolaSoySantiago1"
            };
            Category category = new Category()
            {
                Name = "Personal"
            };
            User userShareWith = new User()
            {
                Name = "Lucía",
                Pass = "lu2000@1"
            };
            User pablo = new User()
            {
                Name = "Pablo",
                Pass = "pa1230@1"
            };
            User juana = new User()
            {
                Name = "Juana",
                Pass = "juana0@1"
            };

            userShareFrom.Categories.Add(category);

            Password pass = new Password
            {
                User = userShareFrom,
                Category = category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };

            this._passwordManager.CreateUser(userShareWith);
            this._passwordManager.CreateUser(pablo);
            this._passwordManager.CreateUser(juana);
            this._passwordManager.CreateUser(userShareFrom);
            this._passwordManager.CreatePassword(pass);
            pass.ShareWithUser(userShareWith);
            expectedUser.Add(pablo);
            expectedUser.Add(juana);
            expectedUser.Add(this._user);


            List<User> usersSharedWith = this._passwordManager.GetUsersPassNotSharedWith(pass);
            CollectionAssert.AreEquivalent(expectedUser, usersSharedWith);
        }


        [TestMethod]
        public void GetNotSharedWithAnyUser()
        {
            List<User> expectedUser = new List<User>();

            User userShareFrom = new User()
            {
                Name = "Santiago",
                Pass = "HolaSoySantiago1"
            };
            Category category = new Category()
            {
                Name = "Personal"
            };
            User lucia = new User()
            {
                Name = "Lucía",
                Pass = "lu2000@1"
            };
            User pablo = new User()
            {
                Name = "Pablo",
                Pass = "pa1230@1"
            };
            User juana = new User()
            {
                Name = "Juana",
                Pass = "juana0@1"
            };

            userShareFrom.Categories.Add(category);

            Password pass = new Password
            {
                User = userShareFrom,
                Category = category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };

            this._passwordManager.CreateUser(lucia);
            this._passwordManager.CreateUser(pablo);
            this._passwordManager.CreateUser(juana);
            this._passwordManager.CreateUser(userShareFrom);
            this._passwordManager.CreatePassword(pass);
            expectedUser.Add(lucia);
            expectedUser.Add(pablo);
            expectedUser.Add(juana);
            expectedUser.Add(this._user);


            List<User> usersSharedWith = this._passwordManager.GetUsersPassNotSharedWith(pass);
            CollectionAssert.AreEquivalent(expectedUser, usersSharedWith);
        }

        [TestMethod]
        public void GetNotSharedWithAllUsers()
        {

            User userShareFrom = new User()
            {
                Name = "Santiago",
                Pass = "HolaSoySantiago1"
            };
            Category category = new Category()
            {
                Name = "Personal"
            };
            User lucia = new User()
            {
                Name = "Lucía",
                Pass = "lu2000@1"
            };
            User pablo = new User()
            {
                Name = "Pablo",
                Pass = "pa1230@1"
            };
            User juana = new User()
            {
                Name = "Juana",
                Pass = "juana0@1"
            };

            userShareFrom.Categories.Add(category);

            Password pass = new Password
            {
                User = userShareFrom,
                Category = category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };

            this._passwordManager.CreateUser(lucia);
            this._passwordManager.CreateUser(pablo);
            this._passwordManager.CreateUser(juana);
            this._passwordManager.CreateUser(userShareFrom);
            this._passwordManager.CreatePassword(pass);
            pass.ShareWithUser(lucia);
            pass.ShareWithUser(pablo);
            pass.ShareWithUser(juana);
            pass.ShareWithUser(this._user);


            List<User> usersSharedWith = this._passwordManager.GetUsersPassNotSharedWith(pass);
            List<User> expectedUser = new List<User>();
            CollectionAssert.AreEquivalent(expectedUser, usersSharedWith);
        }

        [TestMethod]
        public void UnSharePassword()
        {
            User userShareFrom = new User()
            {
                Name = "Santiago",
                Pass = "HolaSoySantiago1"
            };
            Category category = new Category()
            {
                Name = "Personal"
            };
            User userShareTo = new User()
            {
                Name = "Lucía",
                Pass = "lu2000@1"
            };
            userShareFrom.Categories.Add(category);
            Password passwordToShare = new Password
            {
                User = userShareFrom,
                Category = category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = "239850Ort2019",
                Notes = "No me roben la cuenta"
            };
            this._passwordManager.CreatePassword(passwordToShare);
            passwordToShare.ShareWithUser(userShareTo);
            passwordToShare.UnShareWithUser(userShareTo);
            List<Password> sharedWithUser = this._passwordManager.GetSharedPasswordsWithCurrentUser();
            CollectionAssert.DoesNotContain(sharedWithUser, passwordToShare);
        }

        [TestMethod]
        public void PasswordEqual()
        {
            Password passA = new Password
            {
                User = _user,
                Category = _category,
                Site = "work.com",
                Username = "Joseph",
                Pass = "wwwjosph",
                Notes = "First password"
            };

            Password passB = new Password
            {
                User = _user,
                Category = _category,
                Site = "work.com",
                Username = "Joseph",
                Pass = "joshpeh2",
                Notes = "Second password"
            };

            Assert.IsTrue(passA.Equals(passB));
        }

        [TestMethod]
        public void PasswordEqualityDifferentSite()
        {
            Password passA = new Password
            {
                User = _user,
                Category = _category,
                Site = "work.com.uy",
                Username = "Joseph",
                Pass = "wwwjosph",
                Notes = "First password"
            };

            Password passB = new Password
            {
                User = _user,
                Category = _category,
                Site = "work.com",
                Username = "Joseph",
                Pass = "joshpeh2",
                Notes = "Second password"
            };

            Assert.IsFalse(passA.Equals(passB));
        }

        [TestMethod]
        public void PasswordEqualityDifferentUsername()
        {
            Password passA = new Password
            {
                User = _user,
                Category = _category,
                Site = "work.com",
                Username = "Joseph1",
                Pass = "wwwjosph",
                Notes = "First password"
            };

            Password passB = new Password
            {
                User = _user,
                Category = _category,
                Site = "work.com",
                Username = "Joseph2",
                Pass = "joshpeh2",
                Notes = "Second password"
            };

            Assert.IsFalse(passA.Equals(passB));
        }

        [TestMethod]
        public void PasswordEqualityDifferentUsernameAndSite()
        {
            Password passA = new Password
            {
                User = _user,
                Category = _category,
                Site = "work.com.uy",
                Username = "Joseph1",
                Pass = "wwwjosph",
                Notes = "First password"
            };

            Password passB = new Password
            {
                User = _user,
                Category = _category,
                Site = "work.com",
                Username = "Joseph2",
                Pass = "joshpeh2",
                Notes = "Second password"
            };

            Assert.IsFalse(passA.Equals(passB));
        }


        [TestMethod]
        [ExpectedException(typeof(PasswordNotBelongToCurrentUserException))]
        public void ModifyPasswordFromAnotherUser()
        {
            User newUser = new User()
            {
                Name = "Santiago",
                Pass = "HolaSoySantiago1"
            };
            Category newCategory = new Category()
            {
                Name = "NewCategory"
            };
            newUser.Categories.Add(newCategory);
            Password newPassword = new Password
            {
                User = newUser,
                Category = newCategory,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = "1234560Ort2020",
                Notes = "Esta es la nueva password"
            };
            this._passwordManager.ModifyPasswordOnCurrentUser(this._password, newPassword);
        }


        [TestMethod]
        public void VerifyLasrModificationPassword()
        {
            Password newPassword = new Password
            {
                User = this._user,
                Category = this._category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = "1234560Ort2020",
                Notes = "Esta es la nueva password"
            };

            Assert.AreEqual(newPassword.LastModification, System.DateTime.Today);
        }

    }


}
