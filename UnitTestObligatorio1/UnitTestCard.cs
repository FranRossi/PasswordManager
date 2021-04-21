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
        [TestMethod]
        public void createNewCard()
        {
            try
            {
                Card card = new Card
                {
                    Category = "Personal",
                    Name = "Visa Gold",
                    Type = "Visa",
                    Number = "2354 6787 1300 3498",
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
        [ExpectedException(typeof(NumberCardLengthIncorrect))]
        public void createInvalidCardNumberTooShort()
        {
            Card card = new Card
            {
                Category = "Work",
                Name = "Visa Black",
                Type = "Visa",
                Number = "2354 6787 1300 34",
                SecureCode = "189",
                ExpirationDate = "10/21",
                Notes = "This is a note"
            };

        }

        [TestMethod]
        [ExpectedException(typeof(NumberCardLengthIncorrect))]
        public void createInvalidCardNumberTooLong()
        {
            Card card = new Card
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
        public void createNewCardWithoutNotes()
        {
            try
            {
                Card card = new Card
                {
                    Category = "Work",
                    Name = "Visa Black",
                    Type = "Visa",
                    Number = "2354 6787 1300 3498",
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
        public void createCardShowingOnlyLast4Digits()
        {

            Card card = new Card
            {
                Category = "Work",
                Name = "Visa Black",
                Type = "Visa",
                Number = "2354 6787 1300 3498",
                SecureCode = "189",
                ExpirationDate = "10/21",
                Notes = "Límite 400k UYU"
            };
            string cardNumberShowingOnlyLast4Digits = card.showOnly4LastDigits();
            StringAssert.Equals("XXXX XXXX XXXX 3498", cardNumberShowingOnlyLast4Digits);

        }




    }




}


