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

        private User juan;
        private User pepe;
        private User mario;
        private User laura;
        TestData(PasswordManager passwordManager)
        {
            this._passwordManager = passwordManager;
            this._random = new Random();
            this.CreateUsers();

            this.CreateCategories("Juan", new string[] { "Personal", "Trabajo", "Facultad" });
            this.CreateCategories("Pepe", new string[] { "Trabajo", "Facultad" });
            this.CreateCategories("Mario", new string[] { "Personal" });
            this.CreateCategories("Laura", new string[] { "Personal", "Facultad" });

            //red
            this.CreatePasswordOnlyPassNameAndCategory("Juan", "23985023", "Personal");
            this.CreatePasswordOnlyPassNameAndCategory("Juan", "abcde876", "Personal");
            this.CreatePasswordOnlyPassNameAndCategory("Juan", "sAT4-@", "Personal");
            //yellow
            this.CreatePasswordOnlyPassNameAndCategory("Juan", "14893470823575754543", "Personal");
            this.CreatePasswordOnlyPassNameAndCategory("Juan", "nethiseanthneaa", "Personal");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Juan", "#stsrtARSRT2332", "Personal");
            this.CreatePasswordOnlyPassNameAndCategory("Juan", "3#@rstaAaartsaa", "Personal");

            //red
            this.CreatePasswordOnlyPassNameAndCategory("Juan", "23985023", "Trabajo");
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Juan", "239850232", "Trabajo");
            this.CreatePasswordOnlyPassNameAndCategory("Juan", "abcst333de8762", "Trabajo");
            this.CreatePasswordOnlyPassNameAndCategory("Juan", "-d4502-s--ss-3", "Trabajo");
            this.CreatePasswordOnlyPassNameAndCategory("Juan", "sT4-@234a", "Trabajo");
            //lightGreen
            this.CreatePasswordOnlyPassNameAndCategory("Juan", "#AAHTNrtsrHRIISH", "Trabajo");
            this.CreatePasswordOnlyPassNameAndCategory("Juan", "148srtarst#$#@$5754543", "Trabajo");

            //red
            this.CreatePasswordOnlyPassNameAndCategory("Juan", "23985023", "Facultad");
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Juan", "239850232", "Facultad");
            this.CreatePasswordOnlyPassNameAndCategory("Juan", "abcst333de8762", "Facultad");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Juan", "#stsrtARSRT2332", "Facultad");


        }

        private void CreatePasswordOnlyPassNameAndCategory(string userName, string password, string category)
        {
            this._passwordManager.Login(userName, userName);
            Password newPassword = new Password
            {
                User = this._passwordManager._currentUser,
                Category = this._passwordManager.GetCategoriesFromCurrentUser().Find(cat => cat.Name == category),
                Site = "ort.edu.uy/" + this._random.Next(1, 100),
                Username = "23985" + this._random.Next(1, 10),
                Pass = password,
                Notes = "Numero aleatorio: " + this._random.Next(1, 10)
            };
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
            this._passwordManager.CreateUser("Juan", "Juan");
            this._passwordManager.CreateUser("Pepe", "Pepe");
            this._passwordManager.CreateUser("Mario", "Mario");
            this._passwordManager.CreateUser("Laura", "Laura");
        }

    }
}
