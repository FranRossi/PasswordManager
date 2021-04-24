using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1;
using System;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestCategory
    {
        private Category _category;

        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                this._category = new Category()
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
            Assert.AreEqual<string>(this._category.Name, "Personal");
        }

    }
}
