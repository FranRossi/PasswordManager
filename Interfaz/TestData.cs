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
        private User _santiago;
        private DataBreachReaderFromString _dataBreachReaderFromString;

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

            this.CreateCategories("Juana", new string[] { "Personal", "Trabajo", "Facultad", "Amigos", "Familia" });
            this.CreateCategories("Pablo", new string[] { "Personal", "Trabajo", "Facultad", "Juegos", "Familia" });
            this.CreateCategories("Mario", new string[] { "Personal", "Trabajo", "Estudio", "Importantes", "Familia" });
            this.CreateCategories("Laura", new string[] { "Bancos", "Tiendas", "Facultad", "Amigos", "Negocios" });
            this.CreateCategories("Santiago", new string[] { "Redes Sociales", "Celular", "Compras", "Otras", "Juegos" });


            this.CreatePasswordWithColorJuana();
            this.CreatePasswordWithColorMario();
            this.CreatePasswordWithColorPablo();
            this.CreatePasswordWithColorLaura();
            this.CreatePasswordWithColorSantiago();

            this.ShareJuanaPasswords();

            Create3DataBreachJuana();
        }

        private void ShareJuanaPasswords()
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
        private void CreateNCreditCardsForUser(string userName, string category)
        {
            this._sessionController.Login(userName, userName);

            for (int i = 0; i < _random.Next(1, 2); i++)
            {
                CreateCreditCardsForCurrentUser(category, userName);
            }
        }

        private void CreatePasswordOnlyPassNameAndCategory(string userName, string password, string category)
        {
            string[] domains = { "ort", "amazon", "bank", "facebook", "twitter" };
            string[] subDomains = { ".com", ".net", ".co", ".gob", ".edu" };
            string[] subSubDomains = { ".br", ".uy", ".eu", ".uk", "" };

            string site = domains[_random.Next(0, 5)] + subDomains[_random.Next(0, 5)] + subSubDomains[_random.Next(0, 5)];
            this._sessionController.Login(userName, userName);
            Password newPassword = new Password
            {
                User = this._sessionController.CurrentUser,
                Category = this._myCategoryController.GetCategoriesFromCurrentUser().Find(cat => cat.Name == category),
                Site = site + "/" + this._uniqueNumber,
                Username = "23985" + this._uniqueNumber,
                Pass = password,
                Notes = "Numero aleatorio: " + this._random.Next(1, 10)
            };
            newPassword.LastModification = new DateTime(2021, 4, 5);
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
            this._santiago = new User("Santiago", "Santiago");
            this._sessionController.CreateUser(_juana);
            this._sessionController.CreateUser(_pablo);
            this._sessionController.CreateUser(_mario);
            this._sessionController.CreateUser(_laura);
            this._sessionController.CreateUser(_santiago);
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
                Number = (this._uniqueNumber + RandomCreditCardNumber().ToString()).Substring(0, 16),
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

        private void CreatePasswordWithColorJuana()
        {
            //Personal
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

            //Trabajo
            //red
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "2398345023", "Trabajo");
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "234850232", "Trabajo");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "abcst333de8762", "Trabajo");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "-d4502-s--ss-3", "Trabajo");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sT4-@234a", "Trabajo");
            //lightGreen
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "#AAHTNrtsrHRIISH", "Trabajo");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "148srtarst#$#@$5754543", "Trabajo");

            //Facultad
            //red
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "239850238", "Facultad");
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "239850232", "Facultad");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "123st333de8762", "Facultad");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "#stsrtARSRT1232", "Facultad");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "Chsau344(!&*($$^&#^@#&", "Facultad");

            //Amigos

            //red
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "123456", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "pass12", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sAT4-@", "Amigos");
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "123456789", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "asdst333de8762", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "-d4532-s--ss-3", "Amigos");
            //yellow
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "934857847293845702", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "asdlfjasdfsfxcvxcvdsf", "Amigos");
            //lightGreen
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sadfasDSFASDFdfSDFsSH", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "148sdfsdarst#$#@$5754543", "Amigos");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "#stsrtARSRT1234", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "3#@rstaAaartsaa", "Amigos");


            //Familia

            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "239850232", "Familia");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "abcst333de8762", "Familia");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "-d4502-s--ss-4", "Familia");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sT4-@234a", "Familia");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "148934sdf708", "Familia");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "nethisean4", "Familia");


            this.CreateNCreditCardsForUser("Juana", "Personal");
            this.CreateNCreditCardsForUser("Juana", "Facultad");
            this.CreateNCreditCardsForUser("Juana", "Amigos");
            this.CreateNCreditCardsForUser("Juana", "Familia");
        }

        private void CreatePasswordWithColorPablo()
        {

            //Personal
            //red
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "54654", "Personal");
            //yellow
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "21321361616516514", "Personal");
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "asdfasdfdfsa", "Personal");
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "DFASDFASSDFGSDAFDADF", "Personal");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "#stssdfSRT2$332", "Personal");
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "3#@rstaAaar@@tsda", "Personal");

            //Trabajo
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "239850232", "Trabajo");
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "absdfst333de8762", "Trabajo");
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "-d4502-s--ss-3", "Trabajo");
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "sT4-@234a", "Trabajo");
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "sT4-@123a", "Trabajo");

            //Facultad
            //red
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "23985023", "Facultad");
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "239850232", "Facultad");
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "absdft333de8762", "Facultad");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "#stsrtARSRT2332", "Facultad");
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "asdfD34(!&*($$^&#^@#&", "Facultad");

            //Juegos

            //red
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "123456", "Juegos");
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "lol123", "Juegos");
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "sAT4-@", "Juegos");
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "123456789", "Juegos");
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "asdst333de8762", "Juegos");
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "-d4532-s--ss-3", "Juegos");
            //yellow
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "934857847293845702", "Juegos");
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "asdlfjasdfsfxcvxcvdsf", "Juegos");
            //lightGreen
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "sadfasDSFASDFdfSDFsSH", "Juegos");
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "148sdfsdarst#$#@$5754543", "Juegos");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "#stsrtARSRT2332", "Juegos");
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "3#@rstaAaartsaa", "Juegos");


            //Familia

            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "239850232", "Familia");
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "abcst333de8762", "Familia");
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "-d4502-s--ss-3", "Familia");
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "sT4-@234a", "Familia");
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "148934sdf708", "Familia");
            this.CreatePasswordOnlyPassNameAndCategory("Pablo", "nethisean3", "Familia");


            this.CreateNCreditCardsForUser("Pablo", "Personal");
            this.CreateNCreditCardsForUser("Pablo", "Facultad");
            this.CreateNCreditCardsForUser("Pablo", "Juegos");
            this.CreateNCreditCardsForUser("Pablo", "Juegos");
        }

        private void CreatePasswordWithColorMario()
        {


            // Personal
            //red
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "23985023", "Personal");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "abcde876", "Personal");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "-d45023", "Personal");
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "239850232", "Personal");
            //yellow
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "14893470823575754543", "Personal");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "nethiseant3232323hnea", "Personal");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "n$#@$ntdtshneaa", "Personal");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "14893470823@#@#@754543", "Personal");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "ARDSDSRUDEIR@@#", "Personal");
            //lightGreen
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "#AAHTNrtsrHRIISH", "Personal");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "AAHTNrtsr#3IIHH", "Personal");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "Chau123(!&*($$^&#^@#&", "Personal");

            // Trabajo
            //red
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "23985023", "Trabajo");
            //yellow
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "ARDSDSRUDEIR@@#", "Trabajo");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "#stsrtARSRT2332", "Trabajo");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "3#@rstaAaartsaa", "Trabajo");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "AAHTNrtsr#3IIHH", "Trabajo");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "Chau123(!&*($$^&#^@#&", "Trabajo");


            // Estudio
            //red
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "23985023", "Estudio");
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "239850232", "Estudio");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "-d4502-s--ss-3", "Estudio");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "sAT4-@sesesior", "Estudio");
            //yellow
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "14893470823575754543", "Estudio");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "nethiseant3232323hnea", "Estudio");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "n$#@$ntdtshneaa", "Estudio");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "14893470823@#@#@754543", "Estudio");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "ARDSDSRUDEIR@@#", "Estudio");
            //lightGreen
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "#AAHTNrtsrHRIISH", "Estudio");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "netMUN2hiseanthnea", "Estudio");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "#stsrtARSRT2332", "Estudio");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "Chau123(!&*($$^&#^@#&", "Estudio");

            // Importantes
            //red
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "23985023", "Importantes");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "sAT4-@", "Importantes");
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "239850232", "Importantes");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "abcst333de8762", "Importantes");
            //yellow
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "14893470823575754543", "Importantes");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "nethiseanthneaa", "Importantes");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "14893470823@#@#@754543", "Importantes");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "ARDSDSRUDEIR@@#", "Importantes");
            //lightGreen
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "#AAHTNrtsrHRIISH", "Importantes");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "#stsrtARSRT2332", "Importantes");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "3#@rstaAaartsaa", "Importantes");

            // Familia
            //red
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "23985023", "Familia");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "sAT4-@", "Familia");
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "239850232", "Familia");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "sT4-@234a", "Familia");
            //yellow
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "ARDSDSRUDEIR@@#", "Familia");
            //lightGreen
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "#AAHTNrtsrHRIISH", "Familia");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "#stsrtARSRT2332", "Familia");
            this.CreatePasswordOnlyPassNameAndCategory("Mario", "3#@rstaAaartsaa", "Familia");


            this.CreateNCreditCardsForUser("Mario", "Personal");
            this.CreateNCreditCardsForUser("Mario", "Estudio");
            this.CreateNCreditCardsForUser("Mario", "Trabajo");
            this.CreateNCreditCardsForUser("Mario", "Importantes");
            this.CreateNCreditCardsForUser("Mario", "Familia");
        }

        private void CreatePasswordWithColorLaura()
        {

            // Bancos
            //yellow
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "ARDSDSRUDEIR@@#", "Bancos");
            //lightGreen
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "HOLA123(!&*($$^&#^@($@#&", "Bancos");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "#stsrtARSRT2332", "Bancos");
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "3#@rstaAaartsaa", "Bancos");
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "AAHTNrtsr#3IIHH", "Bancos");
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "Chau123(!&*($$^&#^@#&", "Bancos");

            // cat2
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "abcst333de8762", "Tiendas");
            //yellow
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "ARDSDSRUDEIR@@#", "Tiendas");
            //lightGreen
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "#AAHTNrtsrHRIISH", "Tiendas");
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "netMUN2hiseanthnea", "Tiendas");
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "HOLA123(!&*($$^&#^@($@#&", "Tiendas");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "#stsrtARSRT2332", "Tiendas");
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "3#@rstaAaartsaa", "Tiendas");
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "AAHTNrtsr#3IIHH", "Tiendas");
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "Chau123(!&*($$^&#^@#&", "Tiendas");


            // cat3
            //lightGreen
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "HOLA123(!&*($$^&#^@($@#&", "Facultad");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "#stsrtARSRT2332", "Facultad");
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "3#@rstaAaartsaa", "Facultad");
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "AAHTNrtsr#3IIHH", "Facultad");
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "Chau123(!&*($$^&#^@#&", "Facultad");

            // cat4
            //lightGreen
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "#AAHTNrtsrHRIISH", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "netMUN2hiseanthnea", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "148srtarst#$#@$5754543", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "chau123(!&*($$^&#^@($*@#&", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "HOLA123(!&*($$^&#^@($@#&", "Amigos");

            // cat5
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "ARDSDSRUDEIR@@#", "Negocios");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "#stsrtARSRT2332", "Negocios");
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "3#@rstaAaartsaa", "Negocios");
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "AAHTNrtsr#3IIHH", "Negocios");
            this.CreatePasswordOnlyPassNameAndCategory("Laura", "Chau123(!&*($$^&#^@#&", "Negocios");



            this.CreateNCreditCardsForUser("Laura", "Tiendas");
            this.CreateNCreditCardsForUser("Laura", "Bancos");
            this.CreateNCreditCardsForUser("Laura", "Facultad");
            this.CreateNCreditCardsForUser("Laura", "Negocios");
        }

        private void CreatePasswordWithColorSantiago()
        {

            // cat1
            //red
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "23985023", "Redes Sociales");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "abcde876", "Redes Sociales");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "-d45023", "Redes Sociales");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "sAT4-@", "Redes Sociales");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "sAT4-@", "Redes Sociales");
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "239850232", "Redes Sociales");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "abcst333de8762", "Redes Sociales");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "-d4502-s--ss-3", "Redes Sociales");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "sAT4-@sesesior", "Redes Sociales");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "sT4-@234a", "Redes Sociales");
            //yellow
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "14893470823575754543", "Celular");

            // cat2
            //red
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "23985023", "Celular");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "abcde876", "Celular");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "-d45023", "Celular");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "sAT4-@", "Celular");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "sAT4-@", "Celular");


            // cat3
            //red
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "sAT4-@", "Compras");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "sAT4-@", "Compras");
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "239850232", "Compras");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "sT4-@234a", "Compras");
            //yellow
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "14893470823575754543", "Compras");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "nethiseanthneaa", "Compras");

            // cat4
            //red
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "23985023", "Otras");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "abcde876", "Otras");
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "239850232", "Otras");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "abcst333de8762", "Otras");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "-d4502-s--ss-3", "Otras");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "sAT4-@sesesior", "Otras");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "sT4-@234a", "Otras");
            //yellow
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "14893470823575754543", "Otras");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "nethiseanthneaa", "Otras");

            // cat5
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "HOLA123(!&*($$^&#^@($@#&", "Juegos");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "#stsrtARSRT2332", "Juegos");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "3#@rstaAaartsaa", "Juegos");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "AAHTNrtsr#3IIHH", "Juegos");
            this.CreatePasswordOnlyPassNameAndCategory("Santiago", "Chau123(!&*($$^&#^@#&", "Juegos");



            this.CreateNCreditCardsForUser("Santiago", "Juegos");
            this.CreateNCreditCardsForUser("Santiago", "Juegos");
            this.CreateNCreditCardsForUser("Santiago", "Juegos");
            this.CreateNCreditCardsForUser("Santiago", "Juegos");
        }

        private void Create3DataBreachJuana()
        {
            this._sessionController.Login("Juana", "Juana");

            string[] _breachedPasswords = { "23985023", "14893470823575754543", "#stsrtARSRT2332", "2398345023", "mySecretPassword", "qwerty" };
            CreateDataBreach(_breachedPasswords, new DateTime(2021, 5, 5));

            ModifyBreachedPassoword("14893470823575754543", "1489347082357234234");
            ModifyBreachedPassoword("#stsrtARSRT2332", "#asdrtARSRT2332");
            ModifyBreachedPassoword("2398345023", "2398341234");

            string[] _breachedPasswords2 = { "-d4502-s--ss-3", "babushcka", "148sdfsdarst#$#@$5754543", "aaaaaa", "abcst333de8762", "qwerty123" };
            CreateDataBreach(_breachedPasswords2, new DateTime(2021, 5, 15));

            ModifyBreachedPassoword("-d4502-s--ss-3", "myDuperSecret");
            ModifyBreachedPassoword("148sdfsdarst#$#@$5754543", "yeaha");
            ModifyBreachedPassoword("abcst333de8762", "dfkljsjfj");


            CreditCard newCreditCard = new CreditCard
            {
                User = _sessionController.CurrentUser,
                Category = this._myCategoryController.GetCategoriesFromCurrentUser().Find(cat => cat.Name == "Personal"),
                Name = "Visa Premium",
                Type = "Visa",
                Number = "2354232313003498",
                SecureCode = "1234",
                ExpirationDate = "02/30",
                Notes = "Límite 400 23 UYU"
            };
            this._myCreditCardController.CreateCreditCard(newCreditCard);


            string[] _breachedItems = { "Chsau344(!&*($$^&#^@#&", "nethisean4", "2354232313003498", "2352331413003498", "1254231413003498", "sdsdsd123" };
            CreateDataBreach(_breachedItems, new DateTime(2021, 5, 25));



        }
        private void CreateDataBreach(string[] breachItems, DateTime date)
        {
            string _passwordDataBreach = CreateDataBreachString(breachItems);
            DataBreachReaderFromString _dataBreachReaderFromString = new DataBreachReaderFromString();
            HashSet<DataBreachReportEntry> entries = _dataBreachReaderFromString.GetDataBreachEntries(_passwordDataBreach);
            DataBreachReport dataBreachReport = new DataBreachReport(entries, _sessionController.CurrentUser);
            dataBreachReport.Date = date;
            DataBreachController _databreachController = new DataBreachController();
            _databreachController.SaveBreachedItems(dataBreachReport);
        }

        private void ModifyBreachedPassoword(string oldPass, string newPass)
        {
            Password breachedPassword;
            breachedPassword = GetPasswordFromCurrentUser(oldPass);
            breachedPassword.Pass = newPass;
            _myPasswordController.ModifyPasswordOnCurrentUser(breachedPassword);
        }
        private Password GetPasswordFromCurrentUser(string pass)
        {
            return _myPasswordController.GetPasswords().Find(p => p.Pass == pass);
        }
        private string CreateDataBreachString(string[] breachedString)
        {
            string dataBreach = "";
            for (int i = 0; i < breachedString.Length; i++)
            {
                dataBreach += breachedString[i] + Environment.NewLine;
            }
            return dataBreach;
        }

        private HashSet<DataBreachReportEntry> LoadDataBreachReportEntry(string[] breachedItem, HashSet<DataBreachReportEntry> expectedEntries)
        {
            for (int i = 0; i < breachedItem.Length; i++)
            {
                DataBreachReportEntry newEntry = new DataBreachReportEntry()
                {
                    Value = breachedItem[i]
                };
                expectedEntries.Add(newEntry);
            }
            return expectedEntries;
        }



        /*
            // cat1
            //red
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "23985023", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "abcde876", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "-d45023", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sAT4-@", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sAT4-@", "Amigos");
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "239850232", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "abcst333de8762", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "-d4502-s--ss-3", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sAT4-@sesesior", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sT4-@234a", "Amigos");
            //yellow
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "14893470823575754543", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "nethiseanthneaa", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "14893470823575754543", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "(!&*($$^&#^@($&)&@$)#", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "AAHTNINESHRIIH5453453", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "nethiseant3232323hnea", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "n$#@$ntdtshneaa", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "14893470823@#@#@754543", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "ARDSDSRUDEIR@@#", "Amigos");
            //lightGreen
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "#AAHTNrtsrHRIISH", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "netMUN2hiseanthnea", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "148srtarst#$#@$5754543", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "chau123(!&*($$^&#^@($*@#&", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "HOLA123(!&*($$^&#^@($@#&", "Amigos");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "#stsrtARSRT2332", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "3#@rstaAaartsaa", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "AAHTNrtsr#3IIHH", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "Chau123(!&*($$^&#^@#&", "Amigos");

            // cat2
            //red
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "23985023", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "abcde876", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "-d45023", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sAT4-@", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sAT4-@", "Amigos");
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "239850232", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "abcst333de8762", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "-d4502-s--ss-3", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sAT4-@sesesior", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sT4-@234a", "Amigos");
            //yellow
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "14893470823575754543", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "nethiseanthneaa", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "14893470823575754543", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "(!&*($$^&#^@($&)&@$)#", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "AAHTNINESHRIIH5453453", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "nethiseant3232323hnea", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "n$#@$ntdtshneaa", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "14893470823@#@#@754543", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "ARDSDSRUDEIR@@#", "Amigos");
            //lightGreen
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "#AAHTNrtsrHRIISH", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "netMUN2hiseanthnea", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "148srtarst#$#@$5754543", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "chau123(!&*($$^&#^@($*@#&", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "HOLA123(!&*($$^&#^@($@#&", "Amigos");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "#stsrtARSRT2332", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "3#@rstaAaartsaa", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "AAHTNrtsr#3IIHH", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "Chau123(!&*($$^&#^@#&", "Amigos");


            // cat3
            //red
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "23985023", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "abcde876", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "-d45023", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sAT4-@", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sAT4-@", "Amigos");
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "239850232", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "abcst333de8762", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "-d4502-s--ss-3", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sAT4-@sesesior", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sT4-@234a", "Amigos");
            //yellow
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "14893470823575754543", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "nethiseanthneaa", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "14893470823575754543", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "(!&*($$^&#^@($&)&@$)#", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "AAHTNINESHRIIH5453453", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "nethiseant3232323hnea", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "n$#@$ntdtshneaa", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "14893470823@#@#@754543", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "ARDSDSRUDEIR@@#", "Amigos");
            //lightGreen
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "#AAHTNrtsrHRIISH", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "netMUN2hiseanthnea", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "148srtarst#$#@$5754543", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "chau123(!&*($$^&#^@($*@#&", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "HOLA123(!&*($$^&#^@($@#&", "Amigos");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "#stsrtARSRT2332", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "3#@rstaAaartsaa", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "AAHTNrtsr#3IIHH", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "Chau123(!&*($$^&#^@#&", "Amigos");

            // cat4
            //red
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "23985023", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "abcde876", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "-d45023", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sAT4-@", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sAT4-@", "Amigos");
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "239850232", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "abcst333de8762", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "-d4502-s--ss-3", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sAT4-@sesesior", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sT4-@234a", "Amigos");
            //yellow
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "14893470823575754543", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "nethiseanthneaa", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "14893470823575754543", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "(!&*($$^&#^@($&)&@$)#", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "AAHTNINESHRIIH5453453", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "nethiseant3232323hnea", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "n$#@$ntdtshneaa", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "14893470823@#@#@754543", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "ARDSDSRUDEIR@@#", "Amigos");
            //lightGreen
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "#AAHTNrtsrHRIISH", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "netMUN2hiseanthnea", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "148srtarst#$#@$5754543", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "chau123(!&*($$^&#^@($*@#&", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "HOLA123(!&*($$^&#^@($@#&", "Amigos");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "#stsrtARSRT2332", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "3#@rstaAaartsaa", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "AAHTNrtsr#3IIHH", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "Chau123(!&*($$^&#^@#&", "Amigos");

            // cat5
            //red
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "23985023", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "abcde876", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "-d45023", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sAT4-@", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sAT4-@", "Amigos");
            //orange
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "239850232", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "abcst333de8762", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "-d4502-s--ss-3", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sAT4-@sesesior", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "sT4-@234a", "Amigos");
            //yellow
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "14893470823575754543", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "nethiseanthneaa", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "14893470823575754543", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "(!&*($$^&#^@($&)&@$)#", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "AAHTNINESHRIIH5453453", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "nethiseant3232323hnea", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "n$#@$ntdtshneaa", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "14893470823@#@#@754543", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "ARDSDSRUDEIR@@#", "Amigos");
            //lightGreen
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "#AAHTNrtsrHRIISH", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "netMUN2hiseanthnea", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "148srtarst#$#@$5754543", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "chau123(!&*($$^&#^@($*@#&", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "HOLA123(!&*($$^&#^@($@#&", "Amigos");
            //darkGreen
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "#stsrtARSRT2332", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "3#@rstaAaartsaa", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "AAHTNrtsr#3IIHH", "Amigos");
            this.CreatePasswordOnlyPassNameAndCategory("Juana", "Chau123(!&*($$^&#^@#&", "Amigos");



            this.CreateNCreditCardsForUser("Pablo", "Personal");
            this.CreateNCreditCardsForUser("Pablo", "Facultad");
            this.CreateNCreditCardsForUser("Pablo", "Juegos");
            this.CreateNCreditCardsForUser("Pablo", "Juegos");

        */

    }
}
