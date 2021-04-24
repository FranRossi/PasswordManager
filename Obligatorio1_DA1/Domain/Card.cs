using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;
using System;

namespace Obligatorio1_DA1
{
    public class Card
    {
        private string number;
        public string Category { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Number
        {
            get => number;
            set
            {
                validateNumber(value);
                number = value;
            }
        }



        public string SecureCode { get; set; }
        public string ExpirationDate { get; set; }
        public string Notes { get; set; }


        private void validateNumber(string number)
        {
            if (!Validator.stringIsExactlyThisLong(16, number))
                throw new NumberCardLengthIncorrect();
            if (!Validator.numberCardOnlyDigits(number))
                throw new NumberCardInvalidCharacters();
        }

        public string showOnly4LastDigits()
        {
            string numberCardWithSpaces = agregateSpacesToNumberCard(this.Number);
            return convertCardNumberIntoSecretNumber(numberCardWithSpaces);
        }

        private string convertCardNumberIntoSecretNumber(string numberCard)
        {
            string secretNumber = numberCard.Substring(14);
            return secretNumber.Insert(0, "XXXX XXXX XXXX");
        }

        private static string agregateSpacesToNumberCard(string numberCardWithoutSpaces)
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