using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Utilities;
using BusinessLogic;
using System;
using System.Collections.Generic;
using Repository;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestPasswordStrengthReport
    {

        private SessionController _sessionController;
        private PasswordManager _passwordManager;
        private CategoryController _categoryController;
        private PasswordController _passwordController;
        private User _currentUser;
        private String[] redPasswordsNames = { "23985023", "abcde876", "-d45023" };
        private List<Password> redPasswords = new List<Password>();
        private List<Password> orangePasswords = new List<Password>();
        private String[] yellowPasswordsNames = { "AAHTNINESHRIIHH", "nethiseant3232323hnea", "n$#@$ntdtshneaa" };
        private List<Password> yellowPasswords = new List<Password>();
        private String[] lightGreenPasswordsNames = { "AAHTNrtsrHRIISH", "148srtarst#$#@$5754543", "chau123(!&*($$^&#^@($*@#&", };
        private List<Password> lightGreenPasswords = new List<Password>();
        private String[] darkGreenPasswordsNames = { "3#@rstaAaartsaa", "Chau123(!&*($$^&#^@#&", "AAHTNrtsr#3IIHH" };
        private List<Password> darkGreenPasswords = new List<Password>();
        private Category _personal;
        private Category _work;
        private Category _university;
        private Category _family;



        [TestInitialize]
        public void TestInitialize()
        {
            _sessionController = SessionController.GetInstance();
            _passwordManager = new PasswordManager();
            _categoryController = new CategoryController();
            _passwordController = new PasswordController();
            _currentUser = new User()
            {
                MasterName = "Gonzalo",
                MasterPass = "HolaSoyGonzalo123"

            };
            _sessionController.CreateUser(_currentUser);

            AddCategoryToCategoryController(ref _personal, "Personal");
            AddCategoryToCategoryController(ref _work, "Work");
            AddCategoryToCategoryController(ref _university, "University");
            AddCategoryToCategoryController(ref _family, "Family");

            ValueTuple<List<Password>, string, Category>[] passwords = new (List<Password> passwords, string pass, Category category)[]
              {
                  (redPasswords,redPasswordsNames[0] ,_family),
                  (redPasswords,redPasswordsNames[1],_family),
                  (redPasswords,redPasswordsNames[2],_family),

                  (yellowPasswords,yellowPasswordsNames[0],_family),
                  (yellowPasswords,yellowPasswordsNames[1],_family),
                  (yellowPasswords,yellowPasswordsNames[2],_university),

                  (lightGreenPasswords,lightGreenPasswordsNames[0],_family),
                  (lightGreenPasswords,lightGreenPasswordsNames[1],_university),
                  (lightGreenPasswords,lightGreenPasswordsNames[2],_work),

                  (darkGreenPasswords,darkGreenPasswordsNames[0],_work),
                  (darkGreenPasswords,darkGreenPasswordsNames[1],_university),
              };
            AddPasswordsToPasswordController(passwords);

        }

        [TestCleanup]
        public void Cleanup()
        {
            UnitTestSignUp.DataBaseCleanup(null);
        }


        [DataRow(PasswordStrengthColor.Red, "Family", 3)]
        [DataRow(PasswordStrengthColor.Red, "Work", 0)]
        [DataRow(PasswordStrengthColor.LightGreen, "Family", 1)]
        [DataRow(PasswordStrengthColor.Yellow, "Family", 2)]
        [DataRow(PasswordStrengthColor.Yellow, "University", 1)]
        [DataRow(PasswordStrengthColor.DarkGreen, "Family", 0)]
        [DataTestMethod]
        public void GetNumberOfPasswordByStrengthColorAndCategory(PasswordStrengthColor color, string category, int quantity)
        {
            List<PasswordReportByCategoryAndColor> report = this._passwordManager.GetPasswordReportByCategoryAndColor();
            var reportEntry = report.Find(entry => entry.Color == color && entry.Category.Name == category);
            Assert.IsTrue(reportEntry.Quantity == quantity, "Error: " + color + " " + category + " " + quantity + " real " + reportEntry.Quantity);
        }

        [DataRow(PasswordStrengthColor.DarkGreen, 2)]
        [DataRow(PasswordStrengthColor.LightGreen, 3)]
        [DataRow(PasswordStrengthColor.Orange, 0)]
        [DataRow(PasswordStrengthColor.Red, 3)]
        [DataRow(PasswordStrengthColor.Yellow, 3)]
        [DataTestMethod]
        public void GetNumberOfPasswordByStrengthColor(PasswordStrengthColor color, int quantity)
        {
            List<PasswordReportByColor> report = this._passwordManager.GetPasswordReportByColor();
            var redEntry = report.Find(entry => entry.Color == color);
            Assert.IsTrue(redEntry.Quantity == quantity, "Error: Color:" + color + " Quantity: " + quantity);
        }

        [TestMethod]
        [TestCategory("GetPasswordOfSpecificColor")]
        public void GetPasswordOfColorDarkGreen()
        {
            List<Password> actualPasswords = this._passwordManager.GetPasswordsByColor(PasswordStrengthColor.DarkGreen);
            CollectionAssert.AreEqual(darkGreenPasswords, actualPasswords);
        }

        [TestMethod]
        [TestCategory("GetPasswordOfSpecificColor")]
        public void GetPasswordOfColorLightGreen()
        {
            List<Password> actualPasswords = this._passwordManager.GetPasswordsByColor(PasswordStrengthColor.LightGreen);
            CollectionAssert.AreEqual(lightGreenPasswords, actualPasswords);
        }

        [TestMethod]
        [TestCategory("GetPasswordOfSpecificColor")]
        public void GetPasswordOfColorYellow()
        {
            List<Password> actualPasswords = this._passwordManager.GetPasswordsByColor(PasswordStrengthColor.Yellow);
            CollectionAssert.AreEqual(yellowPasswords, actualPasswords);
        }

        [TestMethod]
        [TestCategory("GetPasswordOfSpecificColor")]
        public void GetPasswordOfColorOrange()
        {
            List<Password> actualPasswords = this._passwordManager.GetPasswordsByColor(PasswordStrengthColor.Orange);
            CollectionAssert.AreEqual(orangePasswords, actualPasswords);
        }

        [TestMethod]
        [TestCategory("GetPasswordOfSpecificColor")]
        public void GetPasswordOfColorRed()
        {
            List<Password> actualPasswords = this._passwordManager.GetPasswordsByColor(PasswordStrengthColor.Red);
            CollectionAssert.AreEqual(redPasswords, actualPasswords);
        }

        private void AddCategoryToCategoryController(ref Category category, string name)
        {
            category = new Category()
            {
                Name = name
            };
            _categoryController.CreateCategoryOnCurrentUser(name);
            List<Category> categories = _categoryController.GetCategoriesFromCurrentUser();
            category = categories.Find(c => c.Name == name);
        }

        private void AddPasswordsToPasswordController(ValueTuple<List<Password>, string, Category>[] passwords)
        {
            for (int i = 0; i < passwords.Length; i++)
            {
                Password newPassword = new Password
                {
                    User = _currentUser,
                    Category = passwords[i].Item3,
                    Site = i + "ort.edu.uy",
                    Username = "23985" + i,
                    Pass = passwords[i].Item2,
                    Notes = "No me roben la cuenta"
                };
                _passwordController.CreatePassword(newPassword);
                passwords[i].Item1.Add(newPassword);
            }
        }

    }
}
