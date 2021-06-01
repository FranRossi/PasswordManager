﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
using System;
using System.Collections.Generic;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestCategory
    {
        private string _personalCategoryName;
        private PasswordManager _passwordManager;

        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                _personalCategoryName = "Personal";
                _passwordManager = new PasswordManager();
            }
            catch (Exception exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }
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
        public void CreateListOfCategoriesInUser()
        {
            User user = new User("Juancito", "Pepe123");
            _passwordManager.CreateUser(user);
            List<Category> categories = _passwordManager.GetCategoriesFromCurrentUser();
            Assert.IsNotNull(categories);
        }

        [TestMethod]
        [ExpectedException(typeof(CategoryTooShortException))]
        public void CreateCateogryTooShort()
        {
            _personalCategoryName = "Li";
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
            _personalCategoryName = "Peliculas/Series";
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
            _passwordManager.CreateUser(user);
            _passwordManager.CreateCategoryOnCurrentUser(_personalCategoryName);
            Assert.AreEqual(_passwordManager.GetCategoriesFromCurrentUser().ToArray()[0], _personalCategoryName);
        }

        [TestMethod]
        public void ShowsCategoryAsAString()
        {
            string categotyName = _personalCategoryName.ToString();
            Assert.AreEqual(categotyName, "Personal");
        }

        [TestMethod]
        public void ModifyCategory()
        {
            User user = new User("Juancito", "Pepe123");
            _passwordManager.CreateUser(user);
            _passwordManager.CreateCategoryOnCurrentUser(_personalCategoryName);
            Category newCategory = new Category()
            {
                Name = "Trabajo"
            };
            _passwordManager.ModifyCategoryOnCurrentUser(_personalCategoryName, newCategory);
            Assert.AreEqual(_passwordManager.GetCategoriesFromCurrentUser().ToArray()[0], newCategory);
        }

        [TestMethod]
        [ExpectedException(typeof(CategoryAlreadyAddedException))]
        public void AddsAlreadyAddedCategoryToUser()
        {
            User user = new User("Juancito", "Pepe123");
            _passwordManager.CreateUser(user);
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
            Category category1 = new Category()
            {
                Name = "Facultad"
            };
            user.AddOneCategory(category1);
            CollectionAssert.Contains(user.Categories, category1);
        }
    }
}
