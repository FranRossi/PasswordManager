using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1;
using Obligatorio1_DA1.Domain;
using System;
using Obligatorio1_DA1.Exceptions;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestCard
    {
        private Card _card;


        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                this._card = new Card
                {
                    Category = "Personal",
                    Name = "Visa Gold",
                    Type = "Visa",
                    Number = "2354678713003498",
                    SecureCode = "189",
                    ExpirationDate = "10/21",
                    Notes = "Límite 400k UYU"
                };
            }
            catch (Exception exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }
        }


        [TestMethod]
        public void GetCategoryCard()
        {
            Assert.AreEqual<string>(this._card.Category, "Personal");
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
        [ExpectedException(typeof(NumberCardLengthIncorrect))]
        public void CreateInvalidCardNumberTooShort()
        {
            Card newCard = new Card
            {
                Category = "Work",
                Name = "Visa Black",
                Type = "Visa",
                Number = "23546787130034",
                SecureCode = "189",
                ExpirationDate = "10/21",
                Notes = "This is a note"
            };

        }

        [TestMethod]
        [ExpectedException(typeof(NumberCardInvalidCharacters))]
        public void CreateInvalidCardNumberWithWrongCharacteres()
        {
            Card newCard = new Card
            {
                Category = "Personal",
                Name = "Visa Gold",
                Type = "Visa",
                Number = "2s46f871/00r3498",
                SecureCode = "189",
                ExpirationDate = "10/21",
                Notes = "Límite 400k UYU"
            };
        }

        [TestMethod]
        [ExpectedException(typeof(NumberCardLengthIncorrect))]
        public void CreateInvalidCardNumberTooLong()
        {
            Card newCard = new Card
            {
                Category = "Work",
                Name = "Visa Black",
                Type = "Visa",
                Number = "2354 6787 1300 3498 134",
                SecureCode = "189",
                ExpirationDate = "10/21",
                Notes = "This is a note"
            };

        }



        [TestMethod]
        public void CreateNewCardWithoutNotes()
        {
            try
            {
                Card newCard = new Card
                {
                    Category = "Work",
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
            string cardNumberShowingOnlyLast4Digits = this._card.ShowOnly4LastDigits();
            Assert.AreEqual<string>("XXXX XXXX XXXX 3498", cardNumberShowingOnlyLast4Digits);
        }

    }


}


