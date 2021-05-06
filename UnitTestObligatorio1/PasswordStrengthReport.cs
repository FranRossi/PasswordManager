using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class PasswordStrengthReport
    {
        private PasswordManager _passwordManager;
        private User _currentUser;
        private String[] redPasswordsName = { "23985023", "abcde876", "-d45023" };
        private List<Password> redPassword = new List<Password>();
        private String[] orangePasswordsName = { "239850232", "abcst333de8762", "-d4502-s--ss-3" };
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
            _passwordManager = new PasswordManager();
            _currentUser = new User()
            {
                Name = "Gonzalo",
                Pass = "HolaSoyGonzalo123"
            };

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


        [DataRow(PasswordStrengthColor.Red, "Family", 3)]
        [DataRow(PasswordStrengthColor.Red, "Work", 0)]
        [DataRow(PasswordStrengthColor.LightGreen, "Family", 1)]
        [DataRow(PasswordStrengthColor.Yellow, "Family", 2)]
        [DataRow(PasswordStrengthColor.Yellow, "University", 1)]
        [DataRow(PasswordStrengthColor.DarkGreen, "Family", 0)]
        [DataTestMethod]
        public void GetNumberOfPasswordByStrenghtColorAndCategory(PasswordStrengthColor color, string category, int quantity)
        {
            List<passwordReportByCategoryAndColor> report = this._passwordManager.GetPasswordReportByCategoryAndColor(_currentUser);
            var reportEntry = report.Find(entry => entry.Color == color && entry.Category.Name == category);
            Assert.IsTrue(reportEntry.Quantity == quantity, "Error: " + color + " " + category + " " + quantity);
        }

        [DataRow(PasswordStrengthColor.DarkGreen, 2)]
        [DataRow(PasswordStrengthColor.LightGreen, 3)]
        [DataRow(PasswordStrengthColor.Orange, 0)]
        [DataRow(PasswordStrengthColor.Red, 3)]
        [DataRow(PasswordStrengthColor.Yellow, 3)]
        [DataTestMethod]
        public void GetNumberOfPasswordByStrenghtColor(PasswordStrengthColor color, int quantity)
        {
            List<passwordReportByColor> report = this._passwordManager.GetPasswordReportByColor(_currentUser);
            var redEntry = report.Find(entry => entry.Color == color);
            Assert.IsTrue(redEntry.Quantity == quantity, "Error: Color:" + color + " Quantity: " + quantity);
        }

        [TestMethod]
        [TestCategory("GetPasswordOfSpecificColor")]
        public void GetPasswordOfColorDarkGreen()
        {
            List<Password> actualPasswords = this._passwordManager.GetPasswordsByColor(PasswordStrengthColor.DarkGreen);
            CollectionAssert.AreEquivalent(darkGreenPassword, actualPasswords);
        }
        [TestMethod]
        [TestCategory("GetPasswordOfSpecificColor")]
        public void GetPasswordOfColorLightGreen()
        {
            List<Password> actualPasswords = this._passwordManager.GetPasswordsByColor(PasswordStrengthColor.LightGreen, _currentUser);
            CollectionAssert.AreEquivalent(lightGreenPassword, actualPasswords);
        }
        [TestMethod]
        [TestCategory("GetPasswordOfSpecificColor")]
        public void GetPasswordOfColorYellow()
        {
            List<Password> actualPasswords = this._passwordManager.GetPasswordsByColor(PasswordStrengthColor.Yellow, _currentUser);
            CollectionAssert.AreEquivalent(yellowPassword, actualPasswords);
        }
        [TestMethod]
        [TestCategory("GetPasswordOfSpecificColor")]
        public void GetPasswordOfColorOrange()
        {
            List<Password> actualPasswords = this._passwordManager.GetPasswordsByColor(PasswordStrengthColor.Orange, _currentUser);
            CollectionAssert.AreEquivalent(orangePassword, actualPasswords);
        }
        [TestMethod]
        [TestCategory("GetPasswordOfSpecificColor")]
        public void GetPasswordOfColorRed()
        {
            List<Password> actualPasswords = this._passwordManager.GetPasswordsByColor(PasswordStrengthColor.Red, _currentUser);
            CollectionAssert.AreEquivalent(redPassword, actualPasswords);
        }

        private void AddCategoryToPasswordManager(ref Category category, string name)
        {
            category = new Category()
            {
                Name = name
            };
            _currentUser.Categories.Add(category);
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
