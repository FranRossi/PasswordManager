using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;
using System;

namespace Obligatorio1_DA1.Domain
{
    public class CreditCard : Item
    {
        private string number;
        public string Name { get; set; }
        public string Type { get; set; }
        public string Number
        {
            get => number;
            set
            {
                ValidateNumber(value);
                number = value;
            }
        }
        public string SecureCode { get; set; }
        public string ExpirationDate { get; set; }


        private void ValidateNumber(string number)
        {
            if (!Validator.StringIsExactlyThisLong(16, number))
                throw new NumberCardLengthIncorrect();
            if (!Validator.NumberCardOnlyDigits(number))
                throw new NumberCardInvalidCharacters();
        }

        public string ShowOnly4LastDigits()
        {
            string numberCardWithSpaces = AgregateSpacesToNumberCard(this.Number);
            return ConvertCardNumberIntoSecretNumber(numberCardWithSpaces);
        }

        private string ConvertCardNumberIntoSecretNumber(string numberCard)
        {
            string secretNumber = numberCard.Substring(14);
            return secretNumber.Insert(0, "XXXX XXXX XXXX");
        }

        private static string AgregateSpacesToNumberCard(string numberCardWithoutSpaces)
        {
            int[] spacesAt = { 4, 9, 14 };
            int indexSpace = 0;
            int numberCardLength = numberCardWithoutSpaces.Length;
            for (int i = 0; i < numberCardLength; i++)
            {
                if (i % 4 == 0 && i != 0)
                {
                    numberCardWithoutSpaces = numberCardWithoutSpaces.Insert(spacesAt[indexSpace], " ");
                    indexSpace++;
                }
            }
            return numberCardWithoutSpaces;

        }


    }
}