using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1;
using Obligatorio1_DA1.Domain;
using System;
using Obligatorio1_DA1.Exceptions;
using System.Collections.Generic;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestCreditCard
    {
        private CreditCard _card;
        private PasswordManager _passwordManager;
        private User _user;
        private Category _category;


        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                _passwordManager = new PasswordManager();
                _user = new User()
                {
                    Name = "Gonzalo",
                    Pass = "HolaSoyGonzalo123"
                };

                _passwordManager.CreateUser(_user);
                _category = new Category()
                {
                    Name = "Personal"
                };
                _passwordManager.CreateCategoryOnCurrentUser(_category);
                _card = new CreditCard
                {
                    User = _user,
                    Category = _category,
                    Name = "Visa Gold",
                    Type = "Visa",
                    Number = "2354678713003498",
                    SecureCode = "189",
                    ExpirationDate = "10/21",
                    Notes = "Límite 400k UYU"
                };
                _passwordManager.CreateCreditCard(_card);
            }
            catch (Exception exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }
        }


        [TestMethod]
        public void CreateValidCreditCard()
        {
            _user = new User()
            {
                Name = "Mauricio",
                Pass = "HolaSoyGonzalo123"
            };
            _category = new Category()
            {
                Name = "Personal"
            };
            _user.Categories.Add(_category);
            CreditCard creditCard = new CreditCard
            {
                User = _user,
                Category = _category,
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
            Assert.AreEqual<string>(this._card.Category.Name, "Personal");
        }

        [TestMethod]
        public void GetExpirationDateCard()
        {
            Assert.AreEqual<string>(this._card.ExpirationDate, "10/21");
        }

        [TestMethod]
        public void GetNameCard()
        {
            Assert.AreEqual<string>(this._card.Name, "Visa Gold");
        }

        [TestMethod]
        public void GetNotesCard()
        {
            Assert.AreEqual<string>(this._card.Notes, "Límite 400k UYU");
        }

        [TestMethod]
        public void GetSecureCodeCard()
        {
            Assert.AreEqual<string>(this._card.SecureCode, "189");
        }

        [TestMethod]
        public void GetTypeCard()
        {
            Assert.AreEqual<string>(this._card.Type, "Visa");
        }

        [TestMethod]
        [ExpectedException(typeof(CreditCardNumberLengthIncorrect))]
        public void CreateInvalidCardNumberTooShort()
        {
            this._card.Number = "235467871";
        }

        [TestMethod]
        [ExpectedException(typeof(CreditCardNumberInvalidCharacters))]
        public void CreateInvalidCardNumberWithWrongCharacters()
        {
            this._card.Number = "2s46f871/00r3498";
        }

        [TestMethod]
        [ExpectedException(typeof(CreditCardNumberLengthIncorrect))]
        public void CreateInvalidCardNumberTooLong()
        {
            this._card.Number = "2354 6787 1300 3498 134/00r3498";
        }



        [TestMethod]
        public void CreateNewCardWithoutNotes()
        {
            try
            {
                CreditCard newCard = new CreditCard
                {
                    User = _user,
                    Category = _category,
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
            string cardNumberShowingOnlyLast4Digits = this._card.SecretNumber;
            Assert.AreEqual<string>("XXXX XXXX XXXX 3498", cardNumberShowingOnlyLast4Digits);
        }


        [TestMethod]
        public void GetCreditCards()
        {
            List<CreditCard> creditCards = this._passwordManager.GetCreditCards();
            CollectionAssert.Contains(creditCards, this._card);
        }

        [TestMethod]
        public void DeleteACreditCard()
        {
            this._passwordManager.DeleteCreditCard(this._card);
            List<CreditCard> creditCards = this._passwordManager.GetCreditCards();
            CollectionAssert.DoesNotContain(creditCards, this._card);
        }

        [TestMethod]
        public void DeleteACreditCardNotInPasswordManager()
        {
            try
            {
                User user = new User()
                {
                    Name = "Felipe",
                    Pass = "12345",
                };
                user.Categories.Add(this._category);
                CreditCard newCreditCard = new CreditCard
                {
                    User = user,
                    Category = this._category,
                    Name = "MasterCard Black",
                    Type = "Master",
                    Number = "2354678713001111",
                    SecureCode = "111",
                    ExpirationDate = "02/30",
                    Notes = "Límite 400 shenn UYU"
                };
                this._passwordManager.DeleteCreditCard(newCreditCard);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void GetCreditCardsOnlyFromCurrentUser()
        {
            User user = new User()
            {
                Name = "Felipe",
                Pass = "12345",
            };
            user.Categories.Add(this._category);
            CreditCard _card2 = new CreditCard
            {
                User = user,
                Category = this._category,
                Name = "MasterCard Black",
                Type = "Master",
                Number = "2354678713001111",
                SecureCode = "111",
                ExpirationDate = "02/30",
                Notes = "Límite 400 shenn UYU"
            };
            this._passwordManager.CreateCreditCard(_card2);
            List<CreditCard> creditCards = this._passwordManager.GetCreditCards();
            CollectionAssert.DoesNotContain(creditCards, _card2);
        }

        [TestMethod]
        public void GetCreditCardsRefferingToSameUser()
        {
            User user = new User()
            {
                Name = "Gonzalo",
                Pass = "HolaSoyGonzalo123",
            };
            user.Categories.Add(this._category);
            CreditCard _card2 = new CreditCard
            {
                User = user,
                Category = this._category,
                Name = "MasterCard Black",
                Type = "Master",
                Number = "2354678713001111",
                SecureCode = "111",
                ExpirationDate = "02/30",
                Notes = "Límite 400 shenn UYU"
            };
            this._passwordManager.CreateCreditCard(_card2);
            List<CreditCard> creditCards = this._passwordManager.GetCreditCards();
            CollectionAssert.Contains(creditCards, _card2);
        }

        [TestMethod]
        public void ModifyCreditCard()
        {
            CreditCard _card2 = new CreditCard
            {
                User = _passwordManager.CurrentUser,
                Category = this._category,
                Name = "MasterCard Black",
                Type = "Master",
                Number = "2354678713001111",
                SecureCode = "111",
                ExpirationDate = "02/30",
                Notes = "Límite 400 shenn UYU"
            };
            this._passwordManager.ModifyCreditCardOnCurrentUser(this._card, _card2);
            List<CreditCard> creditCards = this._passwordManager.GetCreditCards();
            CollectionAssert.Contains(creditCards, _card2);
        }

        [TestMethod]
        [ExpectedException(typeof(CreditCardAlreadyExistsException))]
        public void ModifyCreditCardThatAlreadyExists()
        {
            CreditCard creditCardAlreadyInPasswordManager = new CreditCard
            {
                User = _passwordManager.CurrentUser,
                Category = this._category,
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
                Category = this._category,
                Name = "MasterCard Black",
                Type = "Master",
                Number = "2354678713001111",
                SecureCode = "111",
                ExpirationDate = "02/30",
                Notes = "Límite 400 shenn UYU"
            };
            this._passwordManager.ModifyCreditCardOnCurrentUser(this._card, newCreditCard);
        }

        [TestMethod]
        [ExpectedException(typeof(CreditCardAlreadyExistsException))]
        public void CreateCreditCardThatAlreadyExists()
        {
            CreditCard creditCardAlreadyInPasswordManager = new CreditCard
            {
                User = _passwordManager.CurrentUser,
                Category = this._category,
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
                Category = this._category,
                Name = "MasterCard Black",
                Type = "Master",
                Number = "2354678713001111",
                SecureCode = "111",
                ExpirationDate = "02/30",
                Notes = "Límite 400 shenn UYU"
            };
            this._passwordManager.CreateCreditCard(newCreditCard);
        }

        [TestMethod]
        [ExpectedException(typeof(CreditCardNotBelongToCurrentUserException))]
        public void ModifyCreditCardFromAnotherUser()
        {
            User newUser = new User()
            {
                Name = "Santiago",
                Pass = "HolaSoySantiago1"
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
            this._passwordManager.ModifyCreditCardOnCurrentUser(this._card, newCreditCard);
        }

        [DataRow("ABC")]
        [DataRow("Abcdefghijklmnopqrstuvwxy")]
        [DataRow("Abcdefghijk lmnopqrstuvwx")]
        [DataRow("A B")]
        [DataRow("Banco Santander")]
        [DataTestMethod]
        public void SetValidNameOnCard(string text)
        {
            this._card.Name = text;
        }

        [DataRow("AB")]
        [DataRow("A ")]
        [DataRow("")]
        [DataTestMethod]
        [ExpectedException(typeof(CreditCardNameTooShortException))]
        public void SeInvalidNameOnCardTooShort(string text)
        {
            this._card.Name = text;
        }



    }


}


