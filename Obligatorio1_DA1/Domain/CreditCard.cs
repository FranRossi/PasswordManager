using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;
using System;

namespace Obligatorio1_DA1.Domain
{
    public class CreditCard : Item
    {
        public const int CreditCardLength = 16;
        public const int MinUsernameLength = 3;
        public const int MaxUsernameLength = 25;
        public const int MinTypeLength = 3;
        public const int MaxTypeLength = 25;
        public const int SecureCodeLength = 3;

        private string number;
        private string name;
        private string type;
        private string secureCode;
        public string Name
        {
            get => name;
            set
            {
                ValidateName(value);
                name = value;
            }
        }
        public string Type
        {
            get => type;
            set
            {
                ValidateType(value);
                type = value;
            }
        }
        public string Number
        {
            get => number;
            set
            {
                ValidateNumber(value);
                number = value;
            }
        }
        public string SecretNumber
        {
            get => ShowOnly4LastDigits();
        }
        public string SecureCode
        {
            get => secureCode;
            set
            {
                ValidateSecureCode(value);
                secureCode = value;
            }
        }
        public string ExpirationDate { get; set; }


        private void ValidateNumber(string number)
        {
            if (!Validator.StringIsExactlyThisLong(CreditCard.CreditCardLength, number))
                throw new CreditCardNumberLengthIncorrect();
            if (!Validator.NumberCardOnlyDigits(number))
                throw new CreditCardNumberInvalidCharacters();
        }

        private void ValidateName(string name)
        {
            if (!Validator.MinLengthOfString(name, CreditCard.MinUsernameLength))
                throw new CreditCardNameTooShortException();
            if (!Validator.MaxLengthOfString(name, CreditCard.MaxUsernameLength))
                throw new CreditCardNameTooLongException();
        }

        private void ValidateType(string type)
        {
            if (!Validator.MinLengthOfString(type, CreditCard.MinTypeLength))
                throw new CreditCardTypeTooShortException();
            if (!Validator.MaxLengthOfString(type, CreditCard.MaxTypeLength))
                throw new CreditCardTypeTooLongException();
        }

        private void ValidateSecureCode(string secureCode)
        {
            if (!Validator.StringIsExactlyThisLong(CreditCard.SecureCodeLength, secureCode))
                throw new CreditCardSecureCodeWrongSizeException();
        }

        public string ShowOnly4LastDigits()
        {
            string numberCardWithSpaces = AgregateSpacesToNumberCard(this.Number);
            return ConvertCardNumberIntoSecretNumber(numberCardWithSpaces);
        }

        private string ConvertCardNumberIntoSecretNumber(string numberCard)
        {
            int creditCardLast4DigitsPosition = 14;
            string secretNumber = numberCard.Substring(creditCardLast4DigitsPosition);
            return secretNumber.Insert(0, "XXXX XXXX XXXX");
        }

        private static string AgregateSpacesToNumberCard(string numberCardWithoutSpaces)
        {
            int[] spacesAt = { 4, 9, 14 };
            int indexSpace = 0;
            int numbersPerDivision = 4;
            int numberCardLength = numberCardWithoutSpaces.Length;
            for (int i = 0; i < numberCardLength; i++)
            {
                if (i % numbersPerDivision == 0 && i != 0)
                {
                    numberCardWithoutSpaces = numberCardWithoutSpaces.Insert(spacesAt[indexSpace], " ");
                    indexSpace++;
                }
            }
            return numberCardWithoutSpaces;

        }

        public override bool Equals(object obj)
        {
            CreditCard creditCardToCompare;
            try
            {
                creditCardToCompare = (CreditCard)obj;
            }
            catch (Exception e)
            {
                return false;
            }
            return creditCardToCompare.Number == this.Number;
        }


    }
}
