using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
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
        [ExpectedException(typeof(CategoryTooShortException))]
        public void CreateCateogryTooShort()
        {
            this._categoryPersonal = new Category()
            {
                Name = "Li"
            };
        }

        [TestMethod]
        public void CreateCateogryMinLength()
        {
            try
            {
                this._categoryPersonal = new Category()
                {
                    Name = "Mis"
                };
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
            this._categoryPersonal = new Category()
            {
                Name = "Peliculas/Series"
            };
        }

        [TestMethod]
        public void CreateCateogryMaxLength()
        {
            try
            {
                this._categoryPersonal = new Category()
                {
                    Name = "Paginas de cine"
                };
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

        [TestMethod]
        [ExpectedException(typeof(CategoryAlreadyAddedException))]
        public void AddsAlreadyAddedCategoryToUser()
        {
            User user = new User("Juancito", "Pepe123");
            _passwordManager.CreateUser(user);
            _passwordManager.CreateCategoryOnCurrentUser(this._categoryPersonal);
            Category repeatedCategory = new Category()
            {
                Name = "Personal"
            };
            _passwordManager.CreateCategoryOnCurrentUser(repeatedCategory);
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
