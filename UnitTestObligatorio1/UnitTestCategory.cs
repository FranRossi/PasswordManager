using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestCategory
    {
        private Category _categoryPersonal;
        private PasswordManager _passwordManager;

        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                this._categoryPersonal = new Category()
                {
                    Name = "Personal"
                };
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
            Assert.AreEqual<string>(this._categoryPersonal.Name, "Personal");
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
        public void AddsCategoriesToUser()
        {
            User user = new User("Juancito", "Pepe123");
            _passwordManager.CreateUser(user);
            _passwordManager.CreateCategoryOnCurrentUser(this._categoryPersonal);
            Assert.AreEqual(_passwordManager.GetCategoriesFromCurrentUser().ToArray()[0], this._categoryPersonal);
        }

        [TestMethod]
        public void ShowsCategoryAsAString()
        {
            string categotyName = this._categoryPersonal.ToString();
            Assert.AreEqual(categotyName, "Personal");
        }

        [TestMethod]
        public void ModifyCategory()
        {
            User user = new User("Juancito", "Pepe123");
            _passwordManager.CreateUser(user);
            _passwordManager.CreateCategoryOnCurrentUser(this._categoryPersonal);
            Category newCategory = new Category()
            {
                Name = "Trabajo"
            };
            _passwordManager.ModifyCategoryOnCurrentUser(this._categoryPersonal, newCategory);
            Assert.AreEqual(_passwordManager.GetCategoriesFromCurrentUser().ToArray()[0], newCategory);
        }

    }
}
