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
        private string _itemDataBreach;
        private PasswordManager _passwordManager;
        private User _currentUser;
        private String[] redPassword = { "23985023", "abcde876", "-d45023" };
        private String[] orangePassword = { "239850232", "abcst333de8762", "-d4502-s--ss-3" };
        private String[] yellowPassword = { "AAHTNINESHRIIHH", "nethiseant3232323hnea", "n$#@$ntdtshneaa" };
        private String[] lightGreenPassword = { "AAHTNrtsrHRIISH", "148srtarst#$#@$5754543", "chau123(!&*($$^&#^@($*@#&", };
        private String[] darkGreenPassword = { "3#@rstaAaartsaa", "Chau123(!&*($$^&#^@#&", "AAHTNrtsr#3IIHH" };
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

            ValueTuple<string, Category>[] passwords = new (string pass, Category category)[]
              {
                  (redPassword[0] ,_family),
                  (redPassword[1],_family),
                  (redPassword[2],_family),

                  (yellowPassword[0],_family),
                  (yellowPassword[1],_family),
                  (yellowPassword[2],_university),

                  (lightGreenPassword[0],_family),
                  (lightGreenPassword[1],_university),
                  (lightGreenPassword[2],_work),

                  (darkGreenPassword[0],_work),
                  (darkGreenPassword[1],_university),
              };
            AddPasswordsToPasswordManager(passwords);

        }


        [DataRow(PasswordStrengthColor.Red, "Family", 3)]
        [DataRow(PasswordStrengthColor.Red, "Work", 3)]
        [DataRow(PasswordStrengthColor.LightGreen, "Family", 1)]
        [DataRow(PasswordStrengthColor.Yellow, "Family", 2)]
        [DataRow(PasswordStrengthColor.Yellow, "University", 1)]
        [DataRow(PasswordStrengthColor.DarkGreen, "Family", 0)]
        [DataTestMethod]
        public void GetNumberOfPasswordByStrenghtColorAndCategory(PasswordStrengthColor color, string category, int quantity)
        {
            List<passwordReportByCategoryAndColor> report = this._passwordManager.GetPasswordReportByCategoryAndColor();
            var redEntry = report.Find(entry => entry.Color == color && entry.Category.Name == category);
            Assert.IsTrue(redEntry.Quantity == quantity);
        }
        private void AddCategoryToPasswordManager(ref Category category, string name)
        {
            category = new Category()
            {
                Name = name
            };
            _currentUser.Categories.Add(category);
        }

        private void AddPasswordsToPasswordManager(ValueTuple<string, Category>[] passwords)
        {
            for (int i = 0; i < passwords.Length; i++)
            {
                Password newPassword = new Password
                {
                    User = _currentUser,
                    Category = passwords[i].Item2,
                    Site = i + "ort.edu.uy",
                    Username = "23985" + i,
                    Pass = passwords[i].Item1,
                    Notes = "No me roben la cuenta"
                };
                _passwordManager.CreatePassword(newPassword);
            }
        }

    }
}
