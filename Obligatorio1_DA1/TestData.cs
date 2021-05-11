using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;

namespace Obligatorio1_DA1
{
    public class TestData
    {
        private PasswordManager _passwordManager;
        private Random _random;
        private int _uniqueNumber;
        private User juana;
        private User pablo;
        private User mario;
        private User laura;
        public TestData(PasswordManager passwordManager)
        {
            this._passwordManager = passwordManager;
            this._random = new Random();
            _uniqueNumber = 10;
            this.CreateUsers();

            this.CreateCategories("Juana", new string[] { "Personal", "Trabajo", "Facultad" });
            this.CreateCategories("Pablo", new string[] { "Trabajo", "Facultad" });
            this.CreateCategories("Mario", new string[] { "Personal" });
            this.CreateCategories("Laura", new string[] { "Personal", "Facultad" });

            this.CreatePasswordWithColorJuana();

            this.ShareJuanaPasswors();



        }

        private void ShareJuanaPasswors()
        {
            this._passwordManager.Login("Juana", "Juana");
            List<Password> passwords = this._passwordManager.GetPasswords();
            passwords[0].ShareWithUser(this.pablo);
            passwords[0].ShareWithUser(this.mario);
            passwords[0].ShareWithUser(this.laura);

            passwords[1].ShareWithUser(this.mario);
            passwords[1].ShareWithUser(this.laura);

            passwords[3].ShareWithUser(this.mario);

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
            this._passwordManager.Login(userName, userName);

            for (int i = 0; i < _random.Next(1, 4); i++)
            {
                CreateCreditCardsForCurrentUser(category, userName);
            }
        }

        private void CreatePasswordOnlyPassNameAndCategory(string userName, string password, string category)
        {
            this._passwordManager.Login(userName, userName);
            Password newPassword = new Password
            {
                User = this._passwordManager.CurrentUser,
                Category = this._passwordManager.GetCategoriesFromCurrentUser().Find(cat => cat.Name == category),
                Site = "ort.edu.uy/" + this._uniqueNumber,
                Username = "23985" + this._uniqueNumber,
                Pass = password,
                Notes = "Numero aleatorio: " + this._random.Next(1, 10)
            };
            this._passwordManager.CreatePassword(newPassword);
            this._uniqueNumber++;
        }

        private void CreateCategories(string userName, string[] categoriesName)
        {
            this._passwordManager.Login(userName, userName);
            foreach (string name in categoriesName)
            {
                Category category = new Category() { Name = name };
                this._passwordManager.CreateCategoryOnCurrentUser(category);
            }
        }

        private void CreateUsers()
        {
            this.juana = new User("Juana", "Juana");
            this.pablo = new User("Pablo", "Pablo");
            this.mario = new User("Mario", "Mario");
            this.laura = new User("Laura", "Laura");
            this._passwordManager.CreateUser(juana);
            this._passwordManager.CreateUser(pablo);
            this._passwordManager.CreateUser(mario);
            this._passwordManager.CreateUser(laura);
        }

        private void CreateCreditCardsForCurrentUser(string category, string userName)
        {
            this._passwordManager.Login(userName, userName);
            CreditCard newCreditCard = new CreditCard
            {
                User = _passwordManager.CurrentUser,
                Category = this._passwordManager.GetCategoriesFromCurrentUser().Find(cat => cat.Name == category),
                Name = "MasterCard Black",
                Type = "Master",
                Number = this._uniqueNumber + RandomCreditCardNumber().ToString(),
                SecureCode = this._uniqueNumber + this._random.Next(0, 9).ToString(),
                ExpirationDate = "02/30",
                Notes = "Límite 400 shenn UYU"
            };
            this._passwordManager.CreateCreditCard(newCreditCard);
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
