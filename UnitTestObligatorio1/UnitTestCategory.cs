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
        private Services _cleanUp;
        private string _personalCategoryName;
        private Category _categoryPersonalInitialize;
        private User _user;
        private SessionController _sessionController;
        private CategoryController _categoryController;

        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                _cleanUp = new Services();
                _cleanUp.DataBaseCleanup();
                _sessionController = SessionController.GetInstance();
                _categoryController = new CategoryController();
                _user = new User()
                {
                    MasterName = "Gonzalo",
                    MasterPass = "HolaSoyGonzalo123"
                };
                _sessionController.CreateUser(_user);
                _personalCategoryName = "Personal";
                _categoryController.CreateCategoryOnCurrentUser(_personalCategoryName);
                _categoryPersonalInitialize = _categoryController.GetCategoriesFromCurrentUser().ToArray()[0];
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
            Assert.AreEqual<string>(_categoryPersonalInitialize.Name, "Personal");
        }

        [TestMethod]
        public void GetCategoryUser()
        {
            Assert.AreEqual<User>(_categoryPersonalInitialize.User, _user);
        }

        [TestMethod]
        public void GetCategoryUserMasterName()
        {
            Assert.AreEqual<String>(_categoryPersonalInitialize.GetUserMasterName(), _user.MasterName);
        }

        [TestMethod]
        public void CreateListOfCategoriesInUser()
        {
            List<Category> categories = _categoryController.GetCategoriesFromCurrentUser();
            Assert.IsNotNull(categories);
        }

        [TestMethod]
        [ExpectedException(typeof(CategoryTooShortException))]
        public void CreateCateogryTooShort()
        {
            string shortCategoryName = "Li";
            _categoryController.CreateCategoryOnCurrentUser(shortCategoryName);
        }

        [TestMethod]
        public void CreateCateogryMinLength()
        {
            _personalCategoryName = "Mis";
        }

        [TestMethod]
        [ExpectedException(typeof(CategoryTooLongException))]
        public void CreateCateogryTooLong()
        {
            string longCategoryName = "Peliculas/Series";
            _categoryController.CreateCategoryOnCurrentUser(longCategoryName);
        }

        [TestMethod]
        public void CreateCateogryMaxLength()
        {
            _personalCategoryName = "Paginas de cine";
        }


        [TestMethod]
        public void AddsCategoriesToNewUser()
        {
            User user = new User("Juancito", "Pepe123");
            _sessionController.CreateUser(user);
            _categoryController.CreateCategoryOnCurrentUser(_personalCategoryName);
            Assert.AreEqual(_categoryController.GetCategoriesFromCurrentUser().ToArray()[0], _categoryPersonalInitialize);
        }

        [TestMethod]
        public void ConfiguresCategoryToString()
        {
            string categotyName = _categoryPersonalInitialize.ToString();
            Assert.AreEqual(categotyName, "Personal");
        }

        [TestMethod]
        public void ModifyCategory()
        {
            List<Category> categoriesBeforeModify = _categoryController.GetCategoriesFromCurrentUser();
            Category firstCategory = categoriesBeforeModify.ToArray()[0];
            firstCategory.Name = "Modificado";
            _categoryController.ModifyCategoryOnCurrentUser(firstCategory);
            List<Category> categoriesAfterModify = _categoryController.GetCategoriesFromCurrentUser();
            Assert.AreEqual(categoriesAfterModify.ToArray()[0], firstCategory);
        }

        [TestMethod]
        [ExpectedException(typeof(CategoryAlreadyAddedException))]
        public void AddsAlreadyAddedCategoryToUser()
        {
            _categoryController.CreateCategoryOnCurrentUser(_personalCategoryName);
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

            Assert.IsFalse(category1.Equals(_categoryPersonalInitialize));
        }

        [TestMethod]
        public void CategoryNotEqualInvalidObject()
        {
            Assert.IsFalse(_categoryPersonalInitialize.Equals(new object()));
        }

        [TestMethod]
        public void AddCategoryToUserObject()
        {
            Category category1 = new Category()
            {
                Name = "Facultad"
            };
            _categoryController.CreateCategoryOnCurrentUser(category1.Name);
            CollectionAssert.Contains(_user.Categories, category1);
        }

        [TestMethod]
        public void CategoryId()
        {
            _categoryPersonalInitialize.Id = 1;
            Assert.AreEqual<int>(_categoryPersonalInitialize.Id, 1);
        }

        [TestMethod]
        public void CategoryDifferentId()
        {
            _categoryPersonalInitialize.Id = 1254;
            Assert.AreNotEqual<int>(_categoryPersonalInitialize.Id, 1);
        }
    }
}
