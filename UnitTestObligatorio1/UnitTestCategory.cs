using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
using Repository;
using System;
using System.Collections.Generic;

namespace UnitTestObligatorio1
{

    [TestClass]
    public class UnitTestCategory
    {
        private string _personalCategoryName;
        private Category _personalCategory;
        private User _user;
        private SessionController _sessionController;
        private PasswordManager _passwordManager;

        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                _sessionController = SessionController.GetInstance();
                _passwordManager = new PasswordManager();
                _personalCategoryName = "Personal";
                _personalCategory = new Category()
                {
                    Name = _personalCategoryName
                };
                _user = new User()
                {
                    MasterName = "Gonzalo",
                    MasterPass = "HolaSoyGonzalo123"
                };
                _sessionController.CreateUser(_user);
                _passwordManager.CreateCategoryOnCurrentUser(_personalCategoryName);

            }
            catch (Exception exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }

        }
        [TestCleanup]
        public void Cleanup()
        {
            UnitTestSignUp.DataBaseCleanup(null);
        }

        [TestMethod]
        public void GetCategoryName()
        {
            Category category = new Category()
            {
                Name = "Personal"
            };
            Assert.AreEqual<string>(category.Name, "Personal");
        }

        [TestMethod]
        public void GetCategoryUser()
        {
            Category category = new Category()
            {
                Name = "Personal",
                User = _user
            };
            Assert.AreEqual<User>(category.User, _user);
        }

        [TestMethod]
        public void GetCategoryUserMasterName()
        {
            Category category = new Category()
            {
                Name = "Personal",
                User = _user
            };
            Assert.AreEqual<String>(category.GetUserMasterName(), _user.MasterName);
        }

        [TestMethod]
        public void CreateListOfCategoriesInUser()
        {
            User user = new User("Juancito", "Pepe123");
            _sessionController.CreateUser(user);
            List<Category> categories = _passwordManager.GetCategoriesFromCurrentUser();
            Assert.IsNotNull(categories);
        }

        [TestMethod]
        [ExpectedException(typeof(CategoryTooShortException))]
        public void CreateCateogryTooShort()
        {
            string shortCategoryName = "Li";
            _passwordManager.CreateCategoryOnCurrentUser(shortCategoryName);
        }

        [TestMethod]
        public void CreateCateogryMinLength()
        {
            try
            {
                _personalCategoryName = "Mis";
            }
            catch (Exception exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(CategoryTooLongException))]
        public void CreateCateogryTooLong()
        {
            string longCategoryName = "Peliculas/Series";
            _passwordManager.CreateCategoryOnCurrentUser(longCategoryName);
        }

        [TestMethod]
        public void CreateCateogryMaxLength()
        {
            try
            {
                _personalCategoryName = "Paginas de cine";
            }
            catch (CategoryTooLongException exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }
        }



        [TestMethod]
        public void AddsCategoriesToUser()
        {
            User user = new User("Juancito", "Pepe123");
            _sessionController.CreateUser(user);
            _passwordManager.CreateCategoryOnCurrentUser(_personalCategoryName);
            Category categoryToCompare = new Category { Name = _personalCategoryName };
            Assert.AreEqual(_passwordManager.GetCategoriesFromCurrentUser().ToArray()[0], categoryToCompare);
        }

        [TestMethod]
        public void ShowsCategoryAsAString()
        {
            string categotyName = _personalCategory.ToString();
            Assert.AreEqual(categotyName, "Personal");
        }

        [TestMethod]
        public void ModifyCategory()
        {
            User user = new User("Juancito", "Pepe123");
            _sessionController.CreateUser(user);
            _passwordManager.CreateCategoryOnCurrentUser(_personalCategoryName);
            List<Category> categoriesBeforeModify = _passwordManager.GetCategoriesFromCurrentUser();
            Category firstCategory = categoriesBeforeModify.ToArray()[0];
            firstCategory.Name = "Modificado";
            _passwordManager.ModifyCategoryOnCurrentUser(firstCategory);
            List<Category> categoriesAfterModify = _passwordManager.GetCategoriesFromCurrentUser();
            Assert.AreEqual(categoriesAfterModify.ToArray()[0], firstCategory);
        }

        [TestMethod]
        [ExpectedException(typeof(CategoryAlreadyAddedException))]
        public void AddsAlreadyAddedCategoryToUser()
        {
            User user = new User("Juancito", "Pepe123");
            _sessionController.CreateUser(user);
            _passwordManager.CreateCategoryOnCurrentUser(_personalCategoryName);
            string repeatedCategoryName = "Personal";
            _passwordManager.CreateCategoryOnCurrentUser(repeatedCategoryName);
        }

        [DataRow("Trabajo", "Trabajo")]
        [DataRow("trabajo", "trabajo")]
        [DataRow("TRABAJO", "TRABAJO")]
        [DataRow("TRABAJO", "trabajo")]
        [DataRow("TRABAJO", "Trabajo")]
        [DataRow("Trabajo", "trabajo")]
        [DataTestMethod]
        public void CategoryEqual(string name1, string name2)
        {
            Category category1 = new Category()
            {
                Name = name1
            };

            Category category2 = new Category()
            {
                Name = name2
            };

            Assert.IsTrue(category1.Equals(category2));
        }

        [TestMethod]
        public void CategoryNotEqual()
        {
            Category category1 = new Category()
            {
                Name = "Facultad"
            };

            Category category2 = new Category()
            {
                Name = "Trabajo"
            };

            Assert.IsFalse(category1.Equals(category2));
        }

        [TestMethod]
        public void CategoryNotEqualInvalidObject()
        {
            Category category1 = new Category()
            {
                Name = "Facultad"
            };

            Assert.IsFalse(category1.Equals(new object()));
        }

        [TestMethod]
        public void AddCategoryToUserObject()
        {
            User user = new User("Juancito", "Pepe123");
            string categoryName = "Facultad";
            Category category1 = new Category()
            {
                Name = "Facultad"
            };
            _sessionController.CreateUser(user);
            _passwordManager.CreateCategoryOnCurrentUser(category1.Name);
            CollectionAssert.Contains(user.Categories, category1);
        }

        [TestMethod]
        public void CategoryId()
        {
            _personalCategory.Id = 1;
            Assert.AreEqual<int>(_personalCategory.Id, 1);
        }

        [TestMethod]
        public void CategoryDifferentId()
        {
            _personalCategory.Id = 1254;
            Assert.AreNotEqual<int>(_personalCategory.Id, 1);
        }
    }
}
