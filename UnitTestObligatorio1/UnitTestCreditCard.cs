using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using System;
using Obligatorio1_DA1.Exceptions;
using System.Collections.Generic;
using BusinessLogic;
using Repository;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestCreditCard
    {
        private CreditCard _cardInitialize;
        private CreditCard _secondCardInitialize;
        private PasswordManager _passwordManager;
        private User _user;
        private Category _categoryInitialize;
        private string _categoryName;


        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                _passwordManager = new PasswordManager();
                _user = new User()
                {
                    MasterName = "Gonzalo",
                    MasterPass = "HolaSoyGonzalo123"
                };

                _passwordManager.CreateUser(_user);
                _categoryName = "Personal";
                _passwordManager.CreateCategoryOnCurrentUser(_categoryName);
                _categoryInitialize = _passwordManager.GetCategoriesFromCurrentUser().ToArray()[0];
                _cardInitialize = new CreditCard
                {
                    User = _user,
                    Category = _categoryInitialize,
                    Name = "Visa Gold",
                    Type = "Visa",
                    Number = "2354678713003498",
                    SecureCode = "189",
                    ExpirationDate = "10/21",
                    Notes = "Límite 400k UYU"
                };
                _passwordManager.CreateCreditCard(_cardInitialize);

                _secondCardInitialize = new CreditCard
                {
                    User = _user,
                    Category = _categoryInitialize,
                    Name = "Master Black",
                    Type = "Master",
                    Number = "1234678713001234",
                    SecureCode = "1331",
                    ExpirationDate = "01/22",
                    Notes = "Límite 400k USD"
                };
                _passwordManager.CreateCreditCard(_secondCardInitialize);
            }
            catch (Exception exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            UnitTestSignUp.DataBaseCleanup(null);
        }

  /*      [TestMethod]
        public void CreateValidCreditCard()
        {
            CreditCard creditCard = new CreditCard
            {
                User = _user,
                Category = _categoryInitialize,
                Name = "Visa Gold",
                Type = "Visa",
                Number = "7754678713003477",
                SecureCode = "189",
                ExpirationDate = "10/21",
                Notes = "Límite 400k UYU"
            };

            _passwordManager.CreateCreditCard(creditCard);
        }


        [TestMethod]
        public void GetCategoryCard()
        {
            Assert.AreEqual<string>(_cardInitialize.Category.Name, "Personal");
        }

        [TestMethod]
        public void GetExpirationDateCard()
        {
            Assert.AreEqual<string>(_cardInitialize.ExpirationDate, "10/21");
        }*/

        [TestMethod]
        public void GetNameCard()
        {
            Assert.AreEqual<string>(_cardInitialize.Name, "Visa Gold");
        }

        [TestMethod]
        public void GetNotesCard()
        {
            Assert.AreEqual<string>(_cardInitialize.Notes, "Límite 400k UYU");
        }

        [TestMethod]
        public void GetSecureCodeCard()
        {
            Assert.AreEqual<string>(_cardInitialize.SecureCode, "189");
        }

        [TestMethod]
        public void GetTypeCard()
        {
            Assert.AreEqual<string>(_cardInitialize.Type, "Visa");
        }

        [TestMethod]
        [ExpectedException(typeof(CreditCardNumberLengthIncorrectException))]
        public void CreateInvalidCardNumberTooShort()
        {
            _cardInitialize.Number = "235467871";
        }

        [TestMethod]
        [ExpectedException(typeof(CreditCardNumberInvalidCharactersException))]
        public void CreateInvalidCardNumberWithWrongCharacters()
        {
            _cardInitialize.Number = "2s46f871/00r3498";
        }

        [TestMethod]
        [ExpectedException(typeof(CreditCardNumberLengthIncorrectException))]
        public void CreateInvalidCardNumberTooLong()
        {
            _cardInitialize.Number = "2354 6787 1300 3498 134/00r3498";
        }



        [TestMethod]
        public void CreateNewCardWithoutNotes()
        {
            try
            {
                Category firstCategoryOnUser = _user.Categories[0];
                CreditCard newCard = new CreditCard
                {
                    User = _user,
                    Category = firstCategoryOnUser,
                    Name = "Visa Black",
                    Type = "Visa",
                    Number = "2354678713003498",
                    SecureCode = "189",
                    ExpirationDate = "10/21"
                };
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }

        }

        [TestMethod]
        public void CreateCardShowingOnlyLast4Digits()
        {
            string cardNumberShowingOnlyLast4Digits = _cardInitialize.SecretNumber;
            Assert.AreEqual<string>("XXXX XXXX XXXX 3498", cardNumberShowingOnlyLast4Digits);
        }


        [TestMethod]
        public void GetCreditCards()
        {
            List<CreditCard> creditCards = _passwordManager.GetCreditCards();
            CollectionAssert.Contains(creditCards, _cardInitialize);
        }

        [TestMethod]
        public void DeleteACreditCard()
        {
            _passwordManager.DeleteCreditCard(_cardInitialize);
            List<CreditCard> creditCards = _passwordManager.GetCreditCards();
            CollectionAssert.DoesNotContain(creditCards, _cardInitialize);
        }

        [TestMethod]
        public void DeleteACreditCardAfterModify()
        {
            List<CreditCard> creditCardBeforeModify = _passwordManager.GetCreditCards();
            CreditCard firstCreditCard = creditCardBeforeModify.ToArray()[0];
            firstCreditCard.Name = "Visa Gold";
            firstCreditCard.Type = "Visa";
            firstCreditCard.Number = "2354678713003498";
            firstCreditCard.SecureCode = "189";
            firstCreditCard.ExpirationDate = "10/21";
            firstCreditCard.Notes = "Límite 400k UYU";
            _passwordManager.ModifyCreditCardOnCurrentUser(firstCreditCard);
            _passwordManager.DeleteCreditCard(firstCreditCard);
            List<CreditCard> creditCardsAfterModify = _passwordManager.GetCreditCards();
            CollectionAssert.DoesNotContain(creditCardsAfterModify, firstCreditCard);
        }

        [TestMethod]
        public void GetCreditCardsOnlyFromCurrentUser()
        {
            User user = new User()
            {
                MasterName = "Felipe",
                MasterPass = "12345",
            };
            _passwordManager.CreateUser(user);
            _passwordManager.CreateCategoryOnCurrentUser(_categoryName);
            Category firstCategoryOnUser = user.Categories[0];
            CreditCard _card2 = new CreditCard
            {
                User = user,
                Category = firstCategoryOnUser,
                Name = "MasterCard Black",
                Type = "Master",
                Number = "2354678713001111",
                SecureCode = "111",
                ExpirationDate = "02/30",
                Notes = "Límite 400 shenn UYU"
            };
            _passwordManager.CreateCreditCard(_card2);
            _passwordManager.Login("Gonzalo", "HolaSoyGonzalo123");
            List<CreditCard> creditCards = _passwordManager.GetCreditCards();
            CollectionAssert.DoesNotContain(creditCards, _card2);
        }

        [TestMethod]
        public void GetCreditCardsRefferingToSameUser()
        {
            User currentUser = _passwordManager.CurrentUser;
            Category firstCategoryOnUser = currentUser.Categories[0];
            CreditCard _card2 = new CreditCard
            {
                User = currentUser,
                Category = firstCategoryOnUser,
                Name = "MasterCard Black",
                Type = "Master",
                Number = "2354678713001111",
                SecureCode = "111",
                ExpirationDate = "02/30",
                Notes = "Límite 400 shenn UYU"
            };
            _passwordManager.CreateCreditCard(_card2);
            List<CreditCard> creditCards = _passwordManager.GetCreditCards();
            CollectionAssert.Contains(creditCards, _card2);
        }

        [TestMethod]
        public void ModifyCreditCard()
        {
            List<CreditCard> creditCardBeforeModify = _passwordManager.GetCreditCards();
            CreditCard firstCreditCard = creditCardBeforeModify.ToArray()[0];
            firstCreditCard.Name = "Visa Gold";
            firstCreditCard.Type = "Visa";
            firstCreditCard.Number = "2354678713003498";
            firstCreditCard.SecureCode = "189";
            firstCreditCard.ExpirationDate = "10/21";
            firstCreditCard.Notes = "Límite 400k UYU";
            _passwordManager.ModifyCreditCardOnCurrentUser(firstCreditCard);
            List<CreditCard> creditCardAfterModify = _passwordManager.GetCreditCards();
            CollectionAssert.Contains(creditCardAfterModify, firstCreditCard);
        }

        [TestMethod]
        [ExpectedException(typeof(CreditCardAlreadyExistsException))]
        public void ModifyCreditCardThatAlreadyExists()
        {

            Category firstCategoryOnUser = _passwordManager.CurrentUser.Categories[0];
            CreditCard creditCardAlreadyInPasswordManager = new CreditCard
            {
                User = _passwordManager.CurrentUser,
                Category = firstCategoryOnUser,
                Name = "MasterCard Black",
                Type = "Master",
                Number = "2354678713001111",
                SecureCode = "111",
                ExpirationDate = "02/30",
                Notes = "Límite 400 shenn UYU"
            };
            _passwordManager.CreateCreditCard(creditCardAlreadyInPasswordManager);

            List<CreditCard> creditCardBeforeModify = _passwordManager.GetCreditCards();
            CreditCard firstCreditCard = creditCardBeforeModify.ToArray()[0];
            firstCreditCard.Name = "Visa Gold";
            firstCreditCard.Type = "Visa";
            firstCreditCard.Number = "2354678713001111";
            firstCreditCard.SecureCode = "189";
            firstCreditCard.ExpirationDate = "10/21";
            firstCreditCard.Notes = "Límite 400k UYU";
            _passwordManager.ModifyCreditCardOnCurrentUser(firstCreditCard);
        }

        [TestMethod]
        public void ModifyOneFieldCreditCard()
        {
            Category firstCategoryOnUser = _passwordManager.CurrentUser.Categories[0];
            CreditCard creditCardAlreadyInPasswordManager = new CreditCard
            {
                User = _passwordManager.CurrentUser,
                Category = firstCategoryOnUser,
                Name = "MasterCard Black",
                Type = "Master",
                Number = "2354678713001111",
                SecureCode = "111",
                ExpirationDate = "02/30",
                Notes = "Límite 400 shenn UYU"
            };
            _passwordManager.CreateCreditCard(creditCardAlreadyInPasswordManager);

            List<CreditCard> creditCardBeforeModify = _passwordManager.GetCreditCards();
            CreditCard firstCreditCard = creditCardBeforeModify.ToArray()[0];
            firstCreditCard.SecureCode = "123";
            _passwordManager.ModifyCreditCardOnCurrentUser(firstCreditCard);
            List<CreditCard> creditCardAfterModify = _passwordManager.GetCreditCards();
            CollectionAssert.Contains(creditCardAfterModify, firstCreditCard);
        }

        [TestMethod]
        [ExpectedException(typeof(CreditCardAlreadyExistsException))]
        public void CreateCreditCardThatAlreadyExists()
        {
            Category firstCategoryOnUser = _passwordManager.CurrentUser.Categories[0];
            CreditCard creditCardAlreadyInPasswordManager = new CreditCard
            {
                User = _passwordManager.CurrentUser,
                Category = firstCategoryOnUser,
                Name = "MasterCard Black",
                Type = "Master",
                Number = "2354678713001111",
                SecureCode = "111",
                ExpirationDate = "02/30",
                Notes = "Límite 400 shenn UYU"
            };
            _passwordManager.CreateCreditCard(creditCardAlreadyInPasswordManager);

            CreditCard newCreditCard = new CreditCard
            {
                User = _passwordManager.CurrentUser,
                Category = firstCategoryOnUser,
                Name = "MasterCard Black",
                Type = "Master",
                Number = "2354678713001111",
                SecureCode = "111",
                ExpirationDate = "02/30",
                Notes = "Límite 400 shenn UYU"
            };
            _passwordManager.CreateCreditCard(newCreditCard);
        }

        [TestMethod]
        [ExpectedException(typeof(CreditCardNotBelongToCurrentUserException))]
        public void ModifyCreditCardFromAnotherUser()
        {
            User newUser = new User()
            {
                MasterName = "Santiago",
                MasterPass = "HolaSoySantiago1"
            };
            Category newCategory = new Category()
            {
                Name = "NewCategory"
            };
            newUser.Categories.Add(newCategory);
            CreditCard newCreditCard = new CreditCard
            {
                User = newUser,
                Category = newCategory,
                Name = "MasterCard Black",
                Type = "Master",
                Number = "2354678713001111",
                SecureCode = "111",
                ExpirationDate = "02/30",
                Notes = "Límite 400 shenn UYU"
            };
            _passwordManager.ModifyCreditCardOnCurrentUser(newCreditCard);
        }


        [TestMethod]
        [ExpectedException(typeof(CreditCardNotBelongToCurrentUserException))]
        public void VerifyUserWhenCreatingCreditCard()
        {
            User newUser = new User()
            {
                MasterName = "Santiago",
                MasterPass = "HolaSoySantiago1"
            };
            Category newCategory = new Category()
            {
                Name = "NewCategory"
            };
            newUser.Categories.Add(newCategory);
            CreditCard newCreditCard = new CreditCard
            {
                User = newUser,
                Category = newCategory,
                Name = "MasterCard Black",
                Type = "Master",
                Number = "2354678713001111",
                SecureCode = "111",
                ExpirationDate = "02/30",
                Notes = "Límite 400 shenn UYU"
            };
            _passwordManager.CreateCreditCard(newCreditCard);
        }


        [DataRow("ABC")]
        [DataRow("Abcdefghijklmnopqrstuvwxy")]
        [DataRow("Abcdefghijk lmnopqrstuvwx")]
        [DataRow("A B")]
        [DataRow("Banco Santander")]
        [DataTestMethod]
        public void SetValidNameOnCard(string text)
        {
            _cardInitialize.Name = text;
        }

        [DataRow("AB")]
        [DataRow("A ")]
        [DataRow("")]
        [DataTestMethod]
        [ExpectedException(typeof(CreditCardNameTooShortException))]
        public void SeInvalidNameOnCardTooShort(string text)
        {
            _cardInitialize.Name = text;
        }

        [DataRow("Abcdefghijklmnopqrstuvwxyz")]
        [DataRow("Abcdefghijk lmnopqrstuvwxy")]
        [DataTestMethod]
        [ExpectedException(typeof(CreditCardNameTooLongException))]
        public void SeInvalidNameOnCardTooLong(string text)
        {
            _cardInitialize.Name = text;
        }

        [DataRow("ABC")]
        [DataRow("Abcdefghijklmnopqrstuvwxy")]
        [DataRow("Abcdefghijk lmnopqrstuvwx")]
        [DataRow("A B")]
        [DataRow("Banco Santander")]
        [DataTestMethod]
        public void SetValidTypeOnCard(string text)
        {
            _cardInitialize.Type = text;
        }

        [DataRow("AB")]
        [DataRow("A ")]
        [DataRow("")]
        [DataTestMethod]
        [ExpectedException(typeof(CreditCardTypeTooShortException))]
        public void SeInvalidTypeOnCardTooShort(string text)
        {
            _cardInitialize.Type = text;
        }

        [DataRow("Abcdefghijklmnopqrstuvwxyz")]
        [DataRow("Abcdefghijk lmnopqrstuvwxy")]
        [DataTestMethod]
        [ExpectedException(typeof(CreditCardTypeTooLongException))]
        public void SeInvalidTypeOnCardTooLong(string text)
        {
            _cardInitialize.Type = text;
        }

        [DataRow("124")]
        [DataRow("434")]
        [DataRow("333")]
        [DataRow("9832")]
        [DataRow("3432")]
        [DataTestMethod]
        public void SetValidSecureCodeOnCard(string text)
        {
            _cardInitialize.SecureCode = text;
        }

        [DataRow("23")]
        [DataRow("")]
        [DataRow("343442323342342")]
        [DataTestMethod]
        [ExpectedException(typeof(CreditCardSecureCodeWrongSizeException))]
        public void SeInvalidSecureCodeOnCardWrongSize(string text)
        {
            _cardInitialize.SecureCode = text;
        }

        [DataRow("3rr")]
        [DataRow("23s")]
        [DataRow("s2s")]
        [DataRow("@34")]
        [DataTestMethod]
        [ExpectedException(typeof(CreditCardSecureCodeInvalidCharactersException))]
        public void SeInvalidSecureCodeOnCardInvalidCharacters(string text)
        {
            _cardInitialize.SecureCode = text;
        }

        [DataRow("12/24")]
        [DataRow("11/44")]
        [DataRow("01/43")]
        [DataRow("02/23")]
        [DataRow("09/43")]
        [DataTestMethod]
        public void SetValidExpirationDateOnCard(string text)
        {
            _cardInitialize.ExpirationDate = text;
        }

        [DataRow("00/24")]
        [DataRow("71/44")]
        [DataRow("31/43")]
        [DataRow("18/23")]
        [DataRow("30/43")]
        [DataTestMethod]
        [ExpectedException(typeof(CreditCardExpirationDateInvalidMonthException))]
        public void SetInvalidExpirationDateOnCardInvalidMonth(string text)
        {
            _cardInitialize.ExpirationDate = text;
        }

        [DataRow("aa/24")]
        [DataRow("")]
        [DataRow("0143")]
        [DataRow("02.23")]
        [DataRow("09@43")]
        [DataRow("aa/bb")]
        [DataTestMethod]
        [ExpectedException(typeof(CreditCardExpirationDateInvalidFormatException))]
        public void SetInvalidExpirationDateOnCardInvalidFormat(string text)
        {
            _cardInitialize.ExpirationDate = text;
        }

        [TestMethod]
        public void CreditCardEqualityWithInvalidObject()
        {
            Assert.IsFalse(_cardInitialize.Equals(new object()));
        }

        [TestMethod]
        public void CreditCardId()
        {
            _cardInitialize.Id = 1;
            Assert.AreEqual<int>(_cardInitialize.Id, 1);
        }

        [TestMethod]
        public void CreditCardDifferentId()
        {
            _cardInitialize.Id = 1254;
            Assert.AreNotEqual<int>(_cardInitialize.Id, 1);
        }

    }


}


