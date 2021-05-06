using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1
{
    public class TestData
    {
        private PasswordManager _passwordManager;
        private Random _random;

        private User Juana;
        private User Pablo;
        private User mario;
        private User laura;
        public TestData(PasswordManager passwordManager)
        {
            this._passwordManager = passwordManager;
            this._random = new Random();
            this.CreateUsers();

            this.CreateCategories("Juana", new string[] { "Personal", "Trabajo", "Facultad" });
            this.CreateCategories("Pablo", new string[] { "Trabajo", "Facultad" });
            this.CreateCategories("Mario", new string[] { "Personal" });
            this.CreateCategories("Laura", new string[] { "Personal", "Facultad" });

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


        }

        private void CreatePasswordOnlyPassNameAndCategory(string userName, string password, string category)
        {
            this._passwordManager.Login(userName, userName);
            Password newPassword = new Password
            {
                User = this._passwordManager.CurrentUser,
                Category = this._passwordManager.GetCategoriesFromCurrentUser().Find(cat => cat.Name == category),
                Site = "ort.edu.uy/" + this._random.Next(1, 100),
                Username = "23985" + this._random.Next(1, 10),
                Pass = password,
                Notes = "Numero aleatorio: " + this._random.Next(1, 10)
            };
            this._passwordManager.CreatePassword(newPassword);
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
            this._passwordManager.CreateUser(new User("Juana", "Juana"));
            this._passwordManager.CreateUser(new User("Pablo", "Pablo"));
            this._passwordManager.CreateUser(new User("Mario", "Mario"));
            this._passwordManager.CreateUser(new User("Laura", "Laura"));
        }

    }
}
