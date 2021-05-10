using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;
using System;
using System.Text.RegularExpressions;

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
        private string expirationDate;
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
        public string ExpirationDate
        {
            get => expirationDate;
            set
            {
                ValidateExpirationDate(value);
                expirationDate = value;
            }

        }


        private void ValidateNumber(string number)
        {
            if (!Validator.StringIsExactlyThisLong(CreditCard.CreditCardLength, number))
                throw new CreditCardNumberIncorrectLengthException();
            if (!Validator.OnlyDigits(number))
                throw new CreditCardNumberInvalidCharacterException();
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
            if (!Validator.OnlyDigits(secureCode))
                throw new CreditCardSecureCodeInvalidCharacterException();
        }

        private void ValidateExpirationDate(string expirationDate)
        {
            if (!ValidateFormatExpirationDate(expirationDate))
                throw new CreditCardExpirationDateInvalidFormatException();
            if (!ValidateMonthExpirationDate(expirationDate))
                throw new CreditCardExpirationDateInvalidMonthException();
        }

        private bool ValidateMonthExpirationDate(string expirationDate)
        {
            Regex validMonth = new Regex(@"^(?:0[1-9])|(?:1[0-2])", RegexOptions.Compiled);
            return validMonth.IsMatch(expirationDate);
        }

        private bool ValidateFormatExpirationDate(string expirationDate)
        {
            Regex validMonth = new Regex(@"^[0-9]{2}/[0-9]{2}$", RegexOptions.Compiled);
            return validMonth.IsMatch(expirationDate);
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
            catch (InvalidCastException e)
            {
                return false;
            }
            return creditCardToCompare.Number == this.Number;
        }


    }
}
