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
        private PasswordManager _passwordManager;
        private User _currentUser;
        private String[] redPasswordsName = { "23985023", "abcde876", "-d45023" };
        private List<Password> redPassword = new List<Password>();
        private List<Password> orangePassword = new List<Password>();
        private String[] yellowPasswordsName = { "AAHTNINESHRIIHH", "nethiseant3232323hnea", "n$#@$ntdtshneaa" };
        private List<Password> yellowPassword = new List<Password>();
        private String[] lightGreenPasswordsName = { "AAHTNrtsrHRIISH", "148srtarst#$#@$5754543", "chau123(!&*($$^&#^@($*@#&", };
        private List<Password> lightGreenPassword = new List<Password>();
        private String[] darkGreenPasswordsName = { "3#@rstaAaartsaa", "Chau123(!&*($$^&#^@#&", "AAHTNrtsr#3IIHH" };
        private List<Password> darkGreenPassword = new List<Password>();
        private Category _personal;
        private Category _work;
        private Category _university;
        private Category _family;



        [TestInitialize]
        public void TestInitialize()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM PASSWORDS");
                context.Database.ExecuteSqlCommand("DELETE FROM CREDITCARDS");
                context.Database.ExecuteSqlCommand("DELETE FROM USERS");
            }
            _passwordManager = new PasswordManager();
            _currentUser = new User()
            {
                MasterName = "Gonzalo",
                MasterPass = "HolaSoyGonzalo123"

            };
            _passwordManager.CreateUser(_currentUser);

            AddCategoryToPasswordManager(ref _personal, "Personal");
            AddCategoryToPasswordManager(ref _work, "Work");
            AddCategoryToPasswordManager(ref _university, "University");
            AddCategoryToPasswordManager(ref _family, "Family");

            ValueTuple<List<Password>, string, Category>[] passwords = new (List<Password> passwords, string pass, Category category)[]
              {
                  (redPassword,redPasswordsName[0] ,_family),
                  (redPassword,redPasswordsName[1],_family),
                  (redPassword,redPasswordsName[2],_family),

                  (yellowPassword,yellowPasswordsName[0],_family),
                  (yellowPassword,yellowPasswordsName[1],_family),
                  (yellowPassword,yellowPasswordsName[2],_university),

                  (lightGreenPassword,lightGreenPasswordsName[0],_family),
                  (lightGreenPassword,lightGreenPasswordsName[1],_university),
                  (lightGreenPassword,lightGreenPasswordsName[2],_work),

                  (darkGreenPassword,darkGreenPasswordsName[0],_work),
                  (darkGreenPassword,darkGreenPasswordsName[1],_university),
              };
            AddPasswordsToPasswordManager(passwords);

        }

        [TestCleanup]
        public void Cleanup()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM PASSWORDS");
                context.Database.ExecuteSqlCommand("DELETE FROM CREDITCARDS");
                context.Database.ExecuteSqlCommand("DELETE FROM USERS");
            }
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
            CollectionAssert.AreEqual(darkGreenPassword, actualPasswords);
        }
        [TestMethod]
        [TestCategory("GetPasswordOfSpecificColor")]
        public void GetPasswordOfColorLightGreen()
        {
            List<Password> actualPasswords = this._passwordManager.GetPasswordsByColor(PasswordStrengthColor.LightGreen);
            CollectionAssert.AreEqual(lightGreenPassword, actualPasswords);
        }
        [TestMethod]
        [TestCategory("GetPasswordOfSpecificColor")]
        public void GetPasswordOfColorYellow()
        {
            List<Password> actualPasswords = this._passwordManager.GetPasswordsByColor(PasswordStrengthColor.Yellow);
            CollectionAssert.AreEqual(yellowPassword, actualPasswords);
        }
        [TestMethod]
        [TestCategory("GetPasswordOfSpecificColor")]
        public void GetPasswordOfColorOrange()
        {
            List<Password> actualPasswords = this._passwordManager.GetPasswordsByColor(PasswordStrengthColor.Orange);
            CollectionAssert.AreEqual(orangePassword, actualPasswords);
        }
        [TestMethod]
        [TestCategory("GetPasswordOfSpecificColor")]
        public void GetPasswordOfColorRed()
        {
            List<Password> actualPasswords = this._passwordManager.GetPasswordsByColor(PasswordStrengthColor.Red);
            CollectionAssert.AreEqual(redPassword, actualPasswords);
        }

        private void AddCategoryToPasswordManager(ref Category category, string name)
        {
            category = new Category()
            {
                Name = name
            };
            _passwordManager.CreateCategoryOnCurrentUser(name);
            List<Category> categories = _passwordManager.GetCategoriesFromCurrentUser();
            category = categories.Find(c => c.Name == name);
        }

        private void AddPasswordsToPasswordManager(ValueTuple<List<Password>, string, Category>[] passwords)
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
                _passwordManager.CreatePassword(newPassword);
                passwords[i].Item1.Add(newPassword);
            }
        }

    }
}
