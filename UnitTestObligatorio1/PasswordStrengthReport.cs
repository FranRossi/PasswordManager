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

        [TestMethod]
        public void GetNumberOfPasswordByStrengthColor()
        {
            List<PasswordReportByColor> expectedReport = new List<PasswordReportByColor>() {
                 new PasswordReportByColor{Color = PasswordStrengthColor.DarkGreen, Quantity = 2 },
                 new PasswordReportByColor{Color = PasswordStrengthColor.LightGreen, Quantity = 3 },
                 new PasswordReportByColor{Color = PasswordStrengthColor.Orange, Quantity = 0 },
                 new PasswordReportByColor{Color = PasswordStrengthColor.Red, Quantity = 3 },
                 new PasswordReportByColor{Color = PasswordStrengthColor.Yellow, Quantity = 3 },
            };
            List<PasswordReportByColor> actualReport = this._passwordManager.GetPasswordReportByColor();
            CollectionAssert.AreEquivalent(expectedReport, actualReport);
        }

        [TestMethod]
        public void CheckCorrectNumberOfPasswordByStrengthColorAndCategory()
        {
            List<PasswordReportByCategoryAndColor> expectedReport = new List<PasswordReportByCategoryAndColor>() {
                 new PasswordReportByCategoryAndColor{Color = PasswordStrengthColor.Red, Quantity = 3, Category =  _family},
                 new PasswordReportByCategoryAndColor{Color = PasswordStrengthColor.Red, Quantity = 0, Category =  _work},
                 new PasswordReportByCategoryAndColor{Color = PasswordStrengthColor.LightGreen, Quantity = 1, Category =  _family},
                 new PasswordReportByCategoryAndColor{Color = PasswordStrengthColor.Yellow, Quantity = 2, Category =  _family},
                 new PasswordReportByCategoryAndColor{Color = PasswordStrengthColor.Yellow, Quantity = 1, Category =  _university},
                 new PasswordReportByCategoryAndColor{Color = PasswordStrengthColor.DarkGreen, Quantity = 0, Category =  _family}
            };
            List<PasswordReportByCategoryAndColor> actualReport = this._passwordManager.GetPasswordReportByCategoryAndColor();
            CollectionAssert.IsSubsetOf(expectedReport, actualReport);
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
            List<Password> actualPasswords = this._passwordManager.GetPasswordsByColor(PasswordStrengthColor.LightGreen);
            CollectionAssert.AreEquivalent(lightGreenPassword, actualPasswords);
        }
        [TestMethod]
        [TestCategory("GetPasswordOfSpecificColor")]
        public void GetPasswordOfColorYellow()
        {
            List<Password> actualPasswords = this._passwordManager.GetPasswordsByColor(PasswordStrengthColor.Yellow);
            CollectionAssert.AreEquivalent(yellowPassword, actualPasswords);
        }
        [TestMethod]
        [TestCategory("GetPasswordOfSpecificColor")]
        public void GetPasswordOfColorOrange()
        {
            List<Password> actualPasswords = this._passwordManager.GetPasswordsByColor(PasswordStrengthColor.Orange);
            CollectionAssert.AreEquivalent(orangePassword, actualPasswords);
        }
        [TestMethod]
        [TestCategory("GetPasswordOfSpecificColor")]
        public void GetPasswordOfColorRed()
        {
            List<Password> actualPasswords = this._passwordManager.GetPasswordsByColor(PasswordStrengthColor.Red);
            CollectionAssert.AreEquivalent(redPassword, actualPasswords);
        }

        private void AddCategoryToPasswordManager(ref Category category, string name)
        {
            category = new Category()
            {
                Name = name
            };
            _passwordManager.CreateCategoryOnCurrentUser(category);
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
