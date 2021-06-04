using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using BusinessLogic;
using Obligatorio1_DA1.Exceptions;
using System;
using System.Collections.Generic;

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
                    MasterName = "Gonzalo",
                    MasterPass = "HolaSoyGonzalo123"
                };
                _category = new Category()
                {
                    Name = "Personal"
                };
                _passwordManager.CreateUser(_user);
                _passwordManager.CreateCategoryOnCurrentUser(_category.Name);
                _password = new Password
                {
                    User = _user,
                    Category = _category,
                    Site = "ort.edu.uy",
                    Username = "239850",
                    Pass = "239850Ort2019",
                    Notes = "No me roben la cuenta"
                };
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
            List<Password> userPasswords = _passwordManager.GetPasswords();
            CollectionAssert.Contains(userPasswords, _password);
        }

        [TestMethod]
        public void DeletePassword()
        {
            _passwordManager.DeletePassword(_password);
            List<Password> userPasswords = _passwordManager.GetPasswords();
            CollectionAssert.DoesNotContain(userPasswords, _password);
        }

        [TestMethod]
        public void GetUserPasswordsWithMultipleUsers()
        {
            User differentUser = new User()
            {
                MasterName = "Juan Perez",
                MasterPass = "juan123"
            };
            string personalCategoryName = "Personal";
            _passwordManager.CreateUser(differentUser);
            _passwordManager.CreateCategoryOnCurrentUser(personalCategoryName);
            Category firstCategoryOnUser = differentUser.Categories[0];
            Password differentPassword = new Password
            {
                User = differentUser,
                Category = firstCategoryOnUser,
                Site = "www.google.com",
                Username = "123456",
                Pass = "239850Ort2019"
            };
            _passwordManager.CreatePassword(differentPassword);
            _passwordManager.Login("Gonzalo", "HolaSoyGonzalo123");
            List<Password> userPasswords = _passwordManager.GetPasswords();
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
            _password.Username = "Tom";
        }

        [TestMethod]
        [ExpectedException(typeof(PasswordUsernameTooLongException))]
        public void CreateNewPasswordWithUsernameTooLong()
        {
            _password.Username = "Hubert Blaine Wolfeschlegelsteinhausenbergerdorff ";
        }


        [TestMethod]
        [ExpectedException(typeof(PasswordTooShortException))]
        public void CreateNewPasswordTooShort()
        {
            _password.Pass = "tom";
        }


        [TestMethod]
        [ExpectedException(typeof(PasswordTooLongException))]
        public void CreateNewPasswordTooLong()
        {
            _password.Pass = "harryharryharryharryharryharry";
        }

        [TestMethod]
        [ExpectedException(typeof(PasswordSiteTooShortException))]
        public void CreateNewPasswordSiteTooShort()
        {
            _password.Site = "hi";
        }

        [TestMethod]
        [ExpectedException(typeof(PasswordSiteTooLongException))]
        public void CreateNewSiteSiteTooLong()
        {
            _password.Site = "htpps://wwww.harrywork.com/homepage/signup";
        }

        [TestMethod]
        [ExpectedException(typeof(ItemNotesTooLongException))]
        public void CreateNewPasswordNotesTooLong()
        {
            _password.Notes = "Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when " +
                "an unknown printer took a galley of type and scrambled it to make a type specimen book. " +
                "It has survived not only five centuries, but also the leap into electronic typesetting, remaining" +
                " essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets " +
                "containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus " +
                "PageMaker including versions of Lorem ";
        }

        [TestMethod]
        public void CreateValidPassword()
        {
            try
            {
                _password = new Password
                {
                    User = _user,
                    Category = _category,
                    Site = "example.com",
                    Username = "123456",
                    Pass = "239850Ort2019",
                    Notes = "No me roben la cuenta"
                };
                _passwordManager.CreatePassword(_password);
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
        public void ModifyPassword()
        {
            List<Password> passwordsBeforeModify = _passwordManager.GetPasswords();
            Password newPassword = passwordsBeforeModify.ToArray()[0];
            newPassword.Username = "123456";
            newPassword.Pass = "1234560Ort2020";
            newPassword.Notes = "Esta es la nueva password";
            _passwordManager.ModifyPasswordOnCurrentUser(newPassword);
            List<Password> passwordsAfterModify = _passwordManager.GetPasswords();
            CollectionAssert.Contains(passwordsAfterModify, newPassword);
        }

        [TestMethod]
        [ExpectedException(typeof(PasswordAlreadyExistsException))]
        public void ModifyPasswordThatAlreadyExists()
        {
            Password passwordAlreadyOnPasswordManager = new Password
            {
                User = _user,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "123456",
                Pass = "1234560Ort2020",
                Notes = "Esta es una nota"
            };
            _passwordManager.CreatePassword(passwordAlreadyOnPasswordManager);

            Password newPassword = new Password
            {
                User = _user,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "123456",
                Pass = "EstoEsUnGIF",
                Notes = "Esta es la nueva password"
            };
            _passwordManager.ModifyPasswordOnCurrentUser(_password, newPassword);
        }

        [TestMethod]
        public void ModifyOneFieldOnPassword()
        {
            Password passwordAlreadyOnPasswordManager = new Password
            {
                User = _user,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "123456",
                Pass = "1234560Ort2020",
                Notes = "Esta es una nota"
            };
            _passwordManager.CreatePassword(passwordAlreadyOnPasswordManager);

            Password newPassword = new Password
            {
                User = _user,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "123456",
                Pass = "EstoEsUnGIF",
                Notes = "Esta es la nueva password"
            };
            _passwordManager.ModifyPasswordOnCurrentUser(passwordAlreadyOnPasswordManager, newPassword);
            List<Password> passwords = _passwordManager.GetPasswords();
            CollectionAssert.Contains(passwords, newPassword);
        }

        [TestMethod]
        [ExpectedException(typeof(PasswordAlreadyExistsException))]
        public void CreatePasswordThatAlreadyExists()
        {
            Password passwordAlreadyOnPasswordManager = new Password
            {
                User = _user,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "123456",
                Pass = "1234560Ort2020",
                Notes = "Esta es una nota"
            };
            _passwordManager.CreatePassword(passwordAlreadyOnPasswordManager);

            Password newPassword = new Password
            {
                User = _user,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "123456",
                Pass = "EstoEsUnGIF",
                Notes = "Esta es la nueva password"
            };
            _passwordManager.CreatePassword(newPassword);
        }

        [DataRow("work.com", "Joseph", "work.com", "Joseph")]
        [DataRow("WORK.COM", "Joseph", "work.com", "Joseph")]
        [DataRow("work.com", "JOSEPH", "work.com", "Joseph")]
        [DataRow("WORK.COM", "JOSEPH", "work.com", "Joseph")]
        [DataRow("wOrK.CoM", "JosEPH", "work.com", "Joseph")]
        [DataTestMethod]
        public void PasswordEqual(string site1, string username1, string site2, string username2)
        {
            Password passA = new Password
            {
                User = _user,
                Category = _category,
                Site = site1,
                Username = username1,
                Pass = "wwwjosph",
                Notes = "First password"
            };

            Password passB = new Password
            {
                User = _user,
                Category = _category,
                Site = site2,
                Username = username2,
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
        public void PasswordEqualityWithInvalidObject()
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

            Assert.IsFalse(passA.Equals(new object()));
        }

        [TestMethod]
        [ExpectedException(typeof(PasswordNotBelongToCurrentUserException))]
        public void ModifyPasswordFromAnotherUser()
        {
            User newUser = new User()
            {
                MasterName = "Santiago",
                MasterPass = "HolaSoySantiago1"
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
            _passwordManager.ModifyPasswordOnCurrentUser(_password, newPassword);
        }


        [TestMethod]
        public void VerifyLastModificationPassword()
        {
            Password newPassword = new Password
            {
                User = _user,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "239850",
                Pass = "1234560Ort2020",
                Notes = "Esta es la nueva password",
            };

            Assert.AreEqual(newPassword.LastModification, DateTime.Today);
        }

        [TestMethod]
        public void VerifyLastModificationPasswrodChanges()
        {
            Password newPassword = new Password
            {
                User = _user,
                Category = _category,
                Site = "ort.edu.uy",
                Username = "123456",
                Pass = "1234560Ort2020",
                Notes = "Esta es la nueva password",
                LastModification = new DateTime(2021, 5, 8)
            };
            _passwordManager.ModifyPasswordOnCurrentUser(_password, newPassword);
            Assert.AreEqual(_password.LastModification, newPassword.LastModification);
        }

        [TestMethod]
        [ExpectedException(typeof(PasswordNotBelongToCurrentUserException))]
        public void VerifyUserWhenCreatingPassword()
        {
            User newUser = new User()
            {
                MasterName = "Santiago",
                MasterPass = "HolaSoySantiago1"
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
            _passwordManager.CreatePassword(newPassword);
        }

        [TestMethod]
        public void PasswordId()
        {
            _password.Id = 1;
            Assert.AreEqual<int>(_password.Id, 1);
        }

        [TestMethod]
        public void PasswordDifferentId()
        {
            _password.Id = 1254;
            Assert.AreNotEqual<int>(_password.Id, 555);
        }
    }
}
