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
    class PasswordStrengthReport
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

            _personal = new Category()
            {
                Name = "Personal"
            };
            _currentUser.Categories.Add(_personal);

            _work = new Category()
            {
                Name = "Work"
            };
            _currentUser.Categories.Add(_work);

            _university = new Category()
            {
                Name = "University"
            };
            _currentUser.Categories.Add(_university);

            _family = new Category()
            {
                Name = "Family"
            };
            _currentUser.Categories.Add(_family);

        }

        [TestMethod]
        public void GetNumberOfPasswordByStrenghtColorAndCategory()
        {
            ValueTuple<string, Category>[] passwords = new (string pass, Category category)[]
              {
                  (redPassword[0] ,_family),
                  (redPassword[1],_family),
                  (redPassword[2],_family)
              };
            AddPasswordsToPasswordManager(passwords);
            List<passwordReportByCategoryAndColor> report = this._passwordManager.GetPasswordReportByCategoryAndColor();
            report.First
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
