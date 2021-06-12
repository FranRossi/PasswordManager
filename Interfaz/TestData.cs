using BusinessLogic;
using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;

namespace Presentation
{
    public class TestData
    {
        private SharePasswordController _sharePasswordController;
        private SessionController _sessionController;
        private CategoryController _myCategoryController;
        private CreditCardController _myCreditCardController;

        private PasswordController _myPasswordController;
        private Random _random;
        private int _uniqueNumber;
        private User _juana;
        private User _pablo;
        private User _mario;
        private User _laura;
        public TestData()
        {
            this._sessionController = SessionController.GetInstance();
            this._sharePasswordController = new SharePasswordController();
            _myCategoryController = new CategoryController();
            _myPasswordController = new PasswordController();
            _myCreditCardController = new CreditCardController();
            this._random = new Random();
            _uniqueNumber = 10;
            try
            {
                this.CreateUsers();
            }
            catch (Exception e)
            { // TODO catchear error 
            }

            this.CreateCategories("Juana", new string[] { "Personal", "Trabajo", "Facultad" });
            this.CreateCategories("Pablo", new string[] { "Trabajo", "Facultad" });
            this.CreateCategories("Mario", new string[] { "Personal" });
            this.CreateCategories("Laura", new string[] { "Personal", "Facultad" });

            this.CreatePasswordWithColorJuana();

            this.ShareJuanaPasswors();
        }

        private void ShareJuanaPasswors()
        {
            this._sessionController.Login("Juana", "Juana");
            List<Password> passwords = this._myPasswordController.GetPasswords();
            this._sharePasswordController.SharePassword(passwords[0], this._pablo);
            this._sharePasswordController.SharePassword(passwords[0], this._mario);
            this._sharePasswordController.SharePassword(passwords[0], this._laura);

            this._sharePasswordController.SharePassword(passwords[1], this._mario);
            this._sharePasswordController.SharePassword(passwords[1], this._laura);

            this._sharePasswordController.SharePassword(passwords[3], this._mario);
        }

        private void CreatePasswordWithColorJuana()
        {
            //red
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "23985023", "Personal");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "abcde876", "Personal");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sAT4-@", "Personal");
            //yellow
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "14893470823575754543", "Personal");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "nethiseanthneaa", "Personal");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "#stsrtARSRT2332", "Personal");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "3#@rstaAaartsaa", "Personal");
            //red
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "23985023", "Trabajo");
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "239850232", "Trabajo");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "abcst333de8762", "Trabajo");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "-d4502-s--ss-3", "Trabajo");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sT4-@234a", "Trabajo");
            //lightGreen
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "#AAHTNrtsrHRIISH", "Trabajo");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "148srtarst#$#@$5754543", "Trabajo");

            //red
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "23985023", "Facultad");
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "239850232", "Facultad");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "abcst333de8762", "Facultad");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "#stsrtARSRT2332", "Facultad");


            this.CreateNCreditCardsForUser("Juana", "Personal");
        }

        private void CreateNCreditCardsForUser(string userName, string category)
        {
            this._sessionController.Login(userName, userName);

            for (int i = 0; i < _random.Next(1, 4); i++)
            {
                CreateCreditCardsForCurrentUser(category, userName);
            }
        }

        private void CreatePasswordOnlyPassNameAndCategory(string userName, string password, string category)
        {
            this._sessionController.Login(userName, userName);
            Password newPassword = new Password
            {
                User = this._sessionController.CurrentUser,
                Category = this._myCategoryController.GetCategoriesFromCurrentUser().Find(cat => cat.Name == category),
                Site = "ort.edu.uy/" + this._uniqueNumber,
                Username = "23985" + this._uniqueNumber,
                Pass = password,
                Notes = "Numero aleatorio: " + this._random.Next(1, 10)
            };
            this._myPasswordController.CreatePassword(newPassword);
            this._uniqueNumber++;
        }

        private void CreateCategories(string userName, string[] categoriesNames)
        {
            this._sessionController.Login(userName, userName);
            foreach (string name in categoriesNames)
            {
                this._myCategoryController.CreateCategoryOnCurrentUser(name);
            }
        }

        private void CreateUsers()
        {
            this._juana = new User("Juana", "Juana");
            this._pablo = new User("Pablo", "Pablo");
            this._mario = new User("Mario", "Mario");
            this._laura = new User("Laura", "Laura");
            this._sessionController.CreateUser(_juana);
            this._sessionController.CreateUser(_pablo);
            this._sessionController.CreateUser(_mario);
            this._sessionController.CreateUser(_laura);
        }

        private void CreateCreditCardsForCurrentUser(string category, string userName)
        {
            this._sessionController.Login(userName, userName);
            CreditCard newCreditCard = new CreditCard
            {
                User = _sessionController.CurrentUser,
                Category = this._myCategoryController.GetCategoriesFromCurrentUser().Find(cat => cat.Name == category),
                Name = "MasterCard Black",
                Type = "Master",
                Number = this._uniqueNumber + RandomCreditCardNumber().ToString(),
                SecureCode = this._uniqueNumber + this._random.Next(0, 9).ToString(),
                ExpirationDate = "02/30",
                Notes = "Límite 400 shenn UYU"
            };
            this._myCreditCardController.CreateCreditCard(newCreditCard);
            this._uniqueNumber++;
        }

        private long RandomCreditCardNumber()
        {
            const long min = 10000000000000;
            const long max = 99999999999999;
            long randomLong = 10000000000000 + (long)(_random.NextDouble() * (max - min)); ;
            return randomLong;
        }

    }
}
