using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Utilities;
using Repository;
using System;
using System.Collections.Generic;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestDataBreach
    {
        private SessionController _sessionController;
        private PasswordManager _passwordManager;
        private DataBreachController _databreachController;
        private CategoryController _categoryController;
        private CreditCardController _creditCardController;
        private PasswordController _passwordController;
        private User _currentUser;
        private IDataBreachReader<string> _dataBreachReaderFromString;


        private string _passwordDataBreach;
        private string _creditCardDataBreach;
        private string _itemDataBreach;
        private string _repeatedItemDataBreach;
        private string _itemDataBreachFromTextFile;
        private string _creditCardDataBreachFromTextFile;
        private string _passwordDataBreachFromTextFile;
        private string _currentUserMasterPass;
        private string[] _breachedPasswords = { "Passoword223", "239850232", "abcde876", "neant3232323hnea" };
        private string[] _breachedCreditCards = { "2354231413003498", "2354678713003498", "1256478713003498", "7685678713567898" };
        private string[] _breachedItems = { "2354231413003498", "Passoword223", "neant3232323hnea", "2354678713003498", "abcde876", "7685678713567898", "1256478713003498", "239850232", };
        private string[] _repeatedBreachedItems = { "2354231413003498", "2354231413003498", "neant3232323hnea", "2354678713003498", "abcde876", "7685678713567898", "1256478713003498", "239850232", };

        [TestInitialize]
        public void TestInitialize()
        {
            _sessionController = SessionController.GetInstance();
            _databreachController = new DataBreachController();
            _categoryController = new CategoryController();
            _passwordController = new PasswordController();
            _creditCardController = new CreditCardController();
            _passwordDataBreach = CreateDataBreachString(_breachedPasswords);
            _creditCardDataBreach = CreateDataBreachString(_breachedCreditCards);
            _itemDataBreach = CreateDataBreachString(_breachedItems);
            _repeatedItemDataBreach = CreateDataBreachString(_repeatedBreachedItems);
            _itemDataBreachFromTextFile = CreateDataBreachTextFile(_breachedItems);
            _passwordDataBreachFromTextFile = CreateDataBreachTextFile(_breachedPasswords);
            _creditCardDataBreachFromTextFile = CreateDataBreachTextFile(_breachedCreditCards);
            _passwordManager = new PasswordManager();
            _currentUserMasterPass = "HolaSoyGonzalo123";
            _currentUser = new User()
            {
                MasterName = "Gonzalo",
                MasterPass = _currentUserMasterPass
            };
            _sessionController.CreateUser(_currentUser);
            string categoryName = "Personal";
            _categoryController.CreateCategoryOnCurrentUser(categoryName);
            _currentUser = _sessionController.CurrentUser;

            _dataBreachReaderFromString = new DataBreachReaderFromString();
        }

        [TestCleanup]
        public void Cleanup()
        {
            UnitTestSignUp.DataBaseCleanup(null);
        }

        [TestMethod]
        public void GetDataBreachItems()
        {
            HashSet<DataBreachReportEntry> entries = _dataBreachReaderFromString.GetDataBreachEntries(_passwordDataBreach);
            HashSet<DataBreachReportEntry> expectedEntries = new HashSet<DataBreachReportEntry>();
            expectedEntries = LoadDataBreachReportEntry(_breachedPasswords, expectedEntries);
            Assert.IsTrue(CompareEntries(entries, expectedEntries));
        }

        [TestMethod]
        public void GetDataBreachItemsWithRepeatedInput()
        {
            HashSet<DataBreachReportEntry> entries = _dataBreachReaderFromString.GetDataBreachEntries(_repeatedItemDataBreach);
            HashSet<DataBreachReportEntry> expectedItems = new HashSet<DataBreachReportEntry>();
            expectedItems = LoadDataBreachReportEntry(_repeatedBreachedItems, expectedItems);
            Assert.IsTrue(CompareEntries(entries, expectedItems));
        }


        [TestMethod]
        public void GetDataBreachEntriesInBothImplementations()
        {
            IDataBreachReader<string> dataBreachReaderTextFile = new DataBreachReaderFromTextFile();
            HashSet<DataBreachReportEntry> breachedItemsString = _dataBreachReaderFromString.GetDataBreachEntries(_passwordDataBreach);
            HashSet<DataBreachReportEntry> breachedItemsTextFile = dataBreachReaderTextFile.GetDataBreachEntries(_passwordDataBreachFromTextFile);
            Assert.IsTrue(CompareEntries(breachedItemsString, breachedItemsTextFile));
        }


        [TestMethod]
        public void GetDataBreachEntryValue()
        {
            DataBreachReportEntry entry = new DataBreachReportEntry()
            {
                Value = "value"
            };
            Assert.IsTrue(entry.Value.Equals("value"));
        }

        [TestMethod]
        public void GetDataBreachEntryId()
        {
            DataBreachReportEntry entry = new DataBreachReportEntry()
            {
                Value = "value"
            };
            Assert.IsTrue(entry.Id == 0);
        }

        [TestMethod]
        public void GetDataBreachReportDate()
        {
            HashSet<DataBreachReportEntry> entries = _dataBreachReaderFromString.GetDataBreachEntries(_itemDataBreach);
            DataBreachReport dataBreachReport = new DataBreachReport(entries, _sessionController.CurrentUser);
            Assert.IsTrue(dataBreachReport.Date.Equals(DateTime.Today));
        }

        [TestMethod]
        public void GetDataBreachId()
        {
            HashSet<DataBreachReportEntry> entries = _dataBreachReaderFromString.GetDataBreachEntries(_itemDataBreach);
            DataBreachReport dataBreachReport = new DataBreachReport(entries, _sessionController.CurrentUser);
            Assert.IsTrue(dataBreachReport.Id == 0);
        }

        [TestMethod]
        public void GetDataBreachUser()
        {
            HashSet<DataBreachReportEntry> entries = _dataBreachReaderFromString.GetDataBreachEntries(_itemDataBreach);
            DataBreachReport dataBreachReport = new DataBreachReport(entries, _sessionController.CurrentUser);
            Assert.IsTrue(dataBreachReport.User.Equals(_currentUser));
        }

        [TestMethod]
        public void GetDataBreachItemQuantity()
        {
            HashSet<DataBreachReportEntry> entries = _dataBreachReaderFromString.GetDataBreachEntries(_creditCardDataBreach);
            DataBreachReport dataBreachReport = new DataBreachReport(entries, _sessionController.CurrentUser);
            List<Item> breachedCardList = AddBreachedCreditCardsToPasswordController();
            List<Item> breachResult = _databreachController.SaveBreachedItems(dataBreachReport);
            dataBreachReport.BreachedItems = breachResult;
            Assert.IsTrue(dataBreachReport.ItemQuantity == breachResult.Count);
        }

        [TestMethod]
        public void GetDataBreachEntryQuantity()
        {
            HashSet<DataBreachReportEntry> entries = _dataBreachReaderFromString.GetDataBreachEntries(_itemDataBreach);
            DataBreachReport dataBreachReport = new DataBreachReport(entries, _sessionController.CurrentUser);
            Assert.IsTrue(dataBreachReport.User.Equals(_currentUser));
            Assert.IsTrue(dataBreachReport.EntryQuantity == entries.Count);
        }

        [TestMethod]
        public void GetDataBreachBreachedItems()
        {
            HashSet<DataBreachReportEntry> entries = _dataBreachReaderFromString.GetDataBreachEntries(_itemDataBreach);
            string categoryName = "Facultad";
            _categoryController.CreateCategoryOnCurrentUser(categoryName);
            Category firstCategoryOnUser = _currentUser.Categories[0];
            DataBreachReport dataBreachReport = new DataBreachReport(entries, _sessionController.CurrentUser);
            List<Item> items = new List<Item>();
            Password newPassword = new Password
            {
                User = _currentUser,
                Category = firstCategoryOnUser,
                Site = "aulas.ort.edu.uy",
                Username = "23985",
                Pass = "Passoword223",
                Notes = "No me roben la cuenta"
            };
            CreditCard newCard = new CreditCard
            {
                User = _currentUser,
                Category = firstCategoryOnUser,
                Name = "Visa Gold",
                Type = "Visa",
                Number = "2354231413001234",
                SecureCode = "189",
                ExpirationDate = "10/21",
                Notes = "Tra­mite 400k UYU"
            };

            items.Add(newCard);
            items.Add(newPassword);

            dataBreachReport.BreachedItems = items;
            CollectionAssert.AreEqual(dataBreachReport.BreachedItems, items);
        }

        [TestMethod]
        public void PasswordOnlyDataBreachFromString()
        {
            HashSet<DataBreachReportEntry> entries = _dataBreachReaderFromString.GetDataBreachEntries(_passwordDataBreach);
            DataBreachReport dataBreachReport = new DataBreachReport(entries, _sessionController.CurrentUser);
            AddPasswordsFromDifferentUserToPasswordController();
            List<Item> breachedPasswordList = AddBreachedPasswordsToPasswordController();
            _databreachController.SaveBreachedItems(dataBreachReport);
            List<Item> breachResult = _databreachController.SaveBreachedItems(dataBreachReport);
            CollectionAssert.AreEqual(breachResult, breachedPasswordList);
        }

        [TestMethod]
        public void CreditCardOnlyDataBreachFromString()
        {
            HashSet<DataBreachReportEntry> entries = _dataBreachReaderFromString.GetDataBreachEntries(_creditCardDataBreach);
            DataBreachReport dataBreachReport = new DataBreachReport(entries, _sessionController.CurrentUser);
            AddCreditCardsFromDifferentToUserPasswordController();
            List<Item> breachedCardList = AddBreachedCreditCardsToPasswordController();
            List<Item> breachResult = _databreachController.SaveBreachedItems(dataBreachReport);
            CollectionAssert.AreEqual(breachResult, breachedCardList);
        }

        [TestMethod]
        public void CreditCardAndPasswordDataBreachFromString()
        {
            HashSet<DataBreachReportEntry> entries = _dataBreachReaderFromString.GetDataBreachEntries(_itemDataBreach);
            DataBreachReport dataBreachReport = new DataBreachReport(entries, _sessionController.CurrentUser);
            AddCreditCardsFromDifferentToUserPasswordController();
            AddPasswordsFromDifferentUserToPasswordController();
            List<Item> breachedItemsInDB = AddBreachedCreditCardsToPasswordController();
            breachedItemsInDB.AddRange(AddBreachedPasswordsToPasswordController());
            List<Item> breachResult = _databreachController.SaveBreachedItems(dataBreachReport);
            breachResult.Sort((a, b) => a.Id.CompareTo(b.Id));
            CollectionAssert.AreEqual(breachResult, breachedItemsInDB);
        }

        [TestMethod]
        public void GetDataBreachReportsFromCurrentUser()
        {
            HashSet<DataBreachReportEntry> entries = _dataBreachReaderFromString.GetDataBreachEntries(_creditCardDataBreach);
            DataBreachReport dataBreachReport1 = new DataBreachReport(entries, _sessionController.CurrentUser);
            AddCreditCardsFromDifferentToUserPasswordController();
            List<Item> breachResult = _databreachController.SaveBreachedItems(dataBreachReport1);
            dataBreachReport1.BreachedItems = breachResult;

            IDataBreachReader<string> dataBreachReader2 = new DataBreachReaderFromString();
            HashSet<DataBreachReportEntry> entries2 = dataBreachReader2.GetDataBreachEntries(_passwordDataBreach);
            DataBreachReport dataBreachReport2 = new DataBreachReport(entries2, _sessionController.CurrentUser);
            AddPasswordsFromDifferentUserToPasswordController();
            List<Item> breachResult2 = _databreachController.SaveBreachedItems(dataBreachReport2);
            dataBreachReport2.BreachedItems = breachResult2;

            List<DataBreachReport> expectedReports = new List<DataBreachReport>();
            expectedReports.Add(dataBreachReport1);
            expectedReports.Add(dataBreachReport2);

            List<DataBreachReport> reports = _databreachController.GetDataBreachReportsFromCurrentUser();
            bool areEqual = true;
            foreach (DataBreachReport report in reports)
            {
                bool isEqualToOne = false;
                foreach (DataBreachReport expectedReport in expectedReports)
                {
                    isEqualToOne = isEqualToOne || (report.Id == expectedReport.Id);
                }
                areEqual = areEqual && isEqualToOne;
            }
            Assert.IsTrue(areEqual);
        }

        [TestMethod]
        public void CheckPassBeenBreached()
        {
            IDataBreachReader<string> dataBreachReader = new DataBreachReaderFromString();
            HashSet<DataBreachReportEntry> entries = dataBreachReader.GetDataBreachEntries(_passwordDataBreach);
            Category firstCategoryOnUser = _currentUser.Categories[0];
            DataBreachReport dataBreachReport = new DataBreachReport(entries, _sessionController.CurrentUser);
            Password newPassword = new Password
            {
                User = _currentUser,
                Category = firstCategoryOnUser,
                Site = "0ort.edu.uy",
                Username = "239850",
                Pass = "Passoword223",
                Notes = "Esta pass esta modificada y aparece en breach"
            };
            AddBreachedPasswordsToPasswordController();

            _databreachController.SaveBreachedItems(dataBreachReport);

            bool passwordHasBeenBreached = _databreachController.VerifyPasswordHasBeenBreached(newPassword);
            Assert.IsTrue(passwordHasBeenBreached);
        }

        [TestMethod]
        public void CheckPassNotBeenBreached()
        {
            IDataBreachReader<string> dataBreachReader = new DataBreachReaderFromString();
            HashSet<DataBreachReportEntry> entries = dataBreachReader.GetDataBreachEntries(_passwordDataBreach);
            Category firstCategoryOnUser = _currentUser.Categories[0];
            DataBreachReport dataBreachReport = new DataBreachReport(entries, _sessionController.CurrentUser);
            Password newPassword = new Password
            {
                User = _currentUser,
                Category = firstCategoryOnUser,
                Site = "NuevoSitio",
                Username = "239850",
                Pass = "Passoword223",
                Notes = "Esta pass esta modificada y no aparece en breach"
            };
            AddBreachedPasswordsToPasswordController();

            _databreachController.SaveBreachedItems(dataBreachReport);

            bool passwordHasBeenBreached = _databreachController.VerifyPasswordHasBeenBreached(newPassword);
            Assert.IsFalse(passwordHasBeenBreached);
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

        private string CreateDataBreachTextFile(string[] breachedString)
        {
            string dataBreach = "";
            for (int i = 0; i < breachedString.Length; i++)
            {
                dataBreach += breachedString[i] + "\t";
            }
            return dataBreach;
        }

        private List<Item> AddBreachedPasswordsToPasswordController()
        {
            List<Item> brechedPasswordsList = new List<Item>();
            _sessionController.Login(_currentUser.MasterName, _currentUserMasterPass);
            Category firstCategoryOnUser = _currentUser.Categories[0];
            for (int i = 0; i < _breachedPasswords.Length; i++)
            {
                Password newPassword = new Password
                {
                    User = _currentUser,
                    Category = firstCategoryOnUser,
                    Site = i + "ort.edu.uy",
                    Username = "23985" + i,
                    Pass = _breachedPasswords[i],
                    Notes = "No me roben la cuenta"
                };
                brechedPasswordsList.Add(newPassword);
                _passwordController.CreatePassword(newPassword);
            }
            return brechedPasswordsList;
        }

        private void AddPasswordsFromDifferentUserToPasswordController()
        {

            User otherUser = new User()
            {
                MasterName = "Pedro",
                MasterPass = "HolaSoyPedro123"
            };
            _sessionController.CreateUser(otherUser);
            string categoryName = "Facultad";
            _categoryController.CreateCategoryOnCurrentUser(categoryName);
            Category firstCategoryOnUser = otherUser.Categories[0];
            Password newPassword = new Password
            {
                User = otherUser,
                Category = firstCategoryOnUser,
                Site = "aulas.ort.edu.uy",
                Username = "23985",
                Pass = "Passoword223",
                Notes = "No me roben la cuenta"
            };
            _passwordController.CreatePassword(newPassword);
            _sessionController.Login("Gonzalo", "HolaSoyGonzalo123");
        }

        private List<Item> AddBreachedCreditCardsToPasswordController()
        {
            List<Item> breachedCreditCardList = new List<Item>();
            _sessionController.Login(_currentUser.MasterName, _currentUserMasterPass);
            Category firstCategoryOnUser = _currentUser.Categories[0];
            for (int i = 0; i < _breachedCreditCards.Length; i++)
            {
                CreditCard newCard = new CreditCard
                {
                    User = _currentUser,
                    Category = firstCategoryOnUser,
                    Name = "Visa Gold",
                    Type = "Visa",
                    Number = _breachedCreditCards[i],
                    SecureCode = "189",
                    ExpirationDate = "10/21",
                    Notes = "Tra­mite 400k UYU"
                };
                breachedCreditCardList.Add(newCard);
                _creditCardController.CreateCreditCard(newCard);
            }
            return breachedCreditCardList;
        }

        private void AddCreditCardsFromDifferentToUserPasswordController()
        {
            string categoryName = "Facultad";
            User otherUser = new User()
            {
                MasterName = "Javier",
                MasterPass = "HolaSoyJavier123"
            };
            _sessionController.CreateUser(otherUser);
            _categoryController.CreateCategoryOnCurrentUser(categoryName);
            Category firstCategoryOnUser = otherUser.Categories[0];
            CreditCard newCard = new CreditCard
            {
                User = otherUser,
                Category = firstCategoryOnUser,
                Name = "Visa Gold",
                Type = "Visa",
                Number = "2354231413001234",
                SecureCode = "189",
                ExpirationDate = "10/21",
                Notes = "Tra­mite 400k UYU"
            };
            _creditCardController.CreateCreditCard(newCard);
            _sessionController.Login("Gonzalo", "HolaSoyGonzalo123");
        }


        private bool CompareEntries(HashSet<DataBreachReportEntry> breachedItems, HashSet<DataBreachReportEntry> expectedItems)
        {
            bool areEqual = true;
            foreach (DataBreachReportEntry entryA in breachedItems)
            {
                bool contained = false;
                foreach (DataBreachReportEntry entryB in expectedItems)
                {
                    if (entryA.Value == entryB.Value)
                        contained = true;
                }
                areEqual = areEqual && contained;
            }
            return areEqual;
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

    }
}
