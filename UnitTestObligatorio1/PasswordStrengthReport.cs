using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
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
            _passwordManager.CreateUser(_currentUser);

            AddCategoryToPasswordManager(ref _personal, "Personal");
            AddCategoryToPasswordManager(ref _work, "Work");
            AddCategoryToPasswordManager(ref _university, "University");
            AddCategoryToPasswordManager(ref _family, "Family");

            ValueTuple<List<Password>, string, PasswordStrengthColor, Category>[] passwords =
                new (List<Password> passwords, string pass, PasswordStrengthColor color, Category category)[]
                 {
                  (redPassword,redPasswordsName[0], PasswordStrengthColor.Red,_family),
                  (redPassword,redPasswordsName[1], PasswordStrengthColor.Red,_family),
                  (redPassword,redPasswordsName[2], PasswordStrengthColor.Red,_family),

                  (yellowPassword,yellowPasswordsName[0], PasswordStrengthColor.Yellow,_family),
                  (yellowPassword,yellowPasswordsName[1], PasswordStrengthColor.Yellow,_family),
                  (yellowPassword,yellowPasswordsName[2], PasswordStrengthColor.Yellow,_university),

                  (lightGreenPassword,lightGreenPasswordsName[0], PasswordStrengthColor.LightGreen,_family),
                  (lightGreenPassword,lightGreenPasswordsName[1], PasswordStrengthColor.LightGreen,_university),
                  (lightGreenPassword,lightGreenPasswordsName[2], PasswordStrengthColor.LightGreen,_work),

                  (darkGreenPassword,darkGreenPasswordsName[0], PasswordStrengthColor.DarkGreen,_work),
                  (darkGreenPassword,darkGreenPasswordsName[1], PasswordStrengthColor.DarkGreen,_university),
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
        public void GetNumberOfPasswordByStrengthColorAndCategory(PasswordStrengthColor color, string category, int quantity)
        {
            List<passwordReportByCategoryAndColor> report = this._passwordManager.GetPasswordReportByCategoryAndColor();
            var reportEntry = report.Find(entry => entry.Color == color && entry.Category.Name == category);
            Assert.IsTrue(reportEntry.Quantity == quantity, "Error: " + color + " " + category + " " + quantity);
        }

        [DataRow(PasswordStrengthColor.DarkGreen, 2)]
        [DataRow(PasswordStrengthColor.LightGreen, 3)]
        [DataRow(PasswordStrengthColor.Orange, 0)]
        [DataRow(PasswordStrengthColor.Red, 3)]
        [DataRow(PasswordStrengthColor.Yellow, 3)]
        [DataTestMethod]
        public void GetNumberOfPasswordByStrengthColor(PasswordStrengthColor color, int quantity)
        {
            List<passwordReportByColor> report = this._passwordManager.GetPasswordReportByColor();
            var redEntry = report.Find(entry => entry.Color == color);
            Assert.IsTrue(redEntry.Quantity == quantity, "Error: Color:" + color + " Quantity: " + quantity);
        }

        /*        [TestMethod]
                public void GetNumberOfPasswordByStrengthColor2()
                {
                    List<passwordReportByColor> expectedReport = new List<passwordReportByColor>()
                    {
                        passwordReportByColor
                    };
                    List<passwordReportByColor> report = this._passwordManager.GetPasswordReportByColor();
                    var redEntry = report.Find(entry => entry.Color == color);
                    Assert.IsTrue(redEntry.Quantity == quantity, "Error: Color:" + color + " Quantity: " + quantity);
                }*/


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

        private void AddPasswordsToPasswordManager(ValueTuple<List<Password>, string, PasswordStrengthColor, Category>[] passwords)
        {
            for (int i = 0; i < passwords.Length; i++)
            {
                Mock<Password> newPassword = new Mock<Password>(MockBehavior.Loose);
                newPassword.Setup(pass => pass.User).Returns(_currentUser);
                newPassword.Setup(pass => pass.Category).Returns(passwords[i].Item4);
                newPassword.Setup(pass => pass.Site).Returns(i + "ort.edu.uy");
                newPassword.Setup(pass => pass.Username).Returns("23985" + i);

                newPassword.Setup(pass => pass.PasswordStrength).Returns(passwords[i].Item3);

                _passwordManager.CreatePassword(newPassword.Object);
                passwords[i].Item1.Add(newPassword.Object);
            }
        }

    }
}
