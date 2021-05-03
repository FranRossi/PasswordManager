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

        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                this._categoryPersonal = new Category()
                {
                    Name = "Personal"
                };
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
            Assert.IsNotNull(user.Categories);
        }

        [TestMethod]
        public void AddsCategoriesToUser()
        {
            User user = new User("Juancito", "Pepe123");
            user.Categories.Add(this._categoryPersonal);
            Assert.AreEqual(user.Categories[0], this._categoryPersonal);
        }

        [TestMethod]
        public void ShowCategoryName()
        {
            string categotyName = this._categoryPersonal.ToString();
            Assert.AreEqual(categotyName, "Personal");
        }

    }
}
