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
        private Category _categoryPersonalInitialize;
        private User _user;
        private PasswordManager _passwordManager;

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
                _passwordManager.CreateUser(_user);
                _personalCategoryName = "Personal";
                _passwordManager.CreateCategoryOnCurrentUser(_personalCategoryName);
                _categoryPersonalInitialize = _passwordManager.GetCategoriesFromCurrentUser().ToArray()[0];
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
            _personalCategoryName = "Mis";
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
            _personalCategoryName = "Paginas de cine";
        }


        [TestMethod]
        public void AddsCategoriesToNewUser()
        {
            User user = new User("Juancito", "Pepe123");
            _passwordManager.CreateUser(user);
            _passwordManager.CreateCategoryOnCurrentUser(_personalCategoryName);
            Assert.AreEqual(_passwordManager.GetCategoriesFromCurrentUser().ToArray()[0], _categoryPersonalInitialize);
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
            _passwordManager.CreateCategoryOnCurrentUser(_personalCategoryName);
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
            CollectionAssert.Contains(_user.Categories, _categoryPersonalInitialize);
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
