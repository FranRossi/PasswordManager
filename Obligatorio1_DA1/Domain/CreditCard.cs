﻿using Obligatorio1_DA1.Utilities;
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
        public const int MinSecureCodeLength = 3;
        public const int MaxSecureCodeLength = 4;

        private string _number;
        private string _name;
        private string _type;
        private string _secureCode;
        private string _expirationDate;

        public string Name
        {
            get => _name;
            set
            {
                ValidateName(value);
                _name = value;
            }
        }
        public string Type
        {
            get => _type;
            set
            {
                ValidateType(value);
                _type = value;
            }
        }
        public string Number
        {
            get => _number;
            set
            {
                ValidateNumber(value);
                _number = value;
            }
        }
        public string SecretNumber
        {
            get => ShowOnly4LastDigits();
        }
        public string SecureCode
        {
            get => _secureCode;
            set
            {
                ValidateSecureCode(value);
                _secureCode = value;
            }
        }
        public string ExpirationDate
        {
            get => _expirationDate;
            set
            {
                ValidateExpirationDate(value);
                _expirationDate = value;
            }

        }


        private void ValidateNumber(string numberToValidate)
        {
            if (!Validator.StringIsExactlyThisLong(CreditCard.CreditCardLength, numberToValidate))
                throw new CreditCardNumberLengthIncorrectException();
            if (!Validator.OnlyDigits(numberToValidate))
                throw new CreditCardNumberInvalidCharactersException();
        }

        private void ValidateName(string nameToValidate)
        {
            if (!Validator.MinLengthOfString(nameToValidate, CreditCard.MinUsernameLength))
                throw new CreditCardNameTooShortException();
            if (!Validator.MaxLengthOfString(nameToValidate, CreditCard.MaxUsernameLength))
                throw new CreditCardNameTooLongException();
        }

        private void ValidateType(string typeToValidate)
        {
            if (!Validator.MinLengthOfString(typeToValidate, CreditCard.MinTypeLength))
                throw new CreditCardTypeTooShortException();
            if (!Validator.MaxLengthOfString(typeToValidate, CreditCard.MaxTypeLength))
                throw new CreditCardTypeTooLongException();
        }

        private void ValidateSecureCode(string secureCodeToValidate)
        {
            if (!Validator.LengthOfStringBetweenTwoNumbers(secureCodeToValidate, CreditCard.MinSecureCodeLength, CreditCard.MaxSecureCodeLength))
                throw new CreditCardSecureCodeWrongSizeException();
            if (!Validator.OnlyDigits(secureCodeToValidate))
                throw new CreditCardSecureCodeInvalidCharactersException();
        }

        private void ValidateExpirationDate(string expirationDateToValidate)
        {
            if (!ValidateFormatExpirationDate(expirationDateToValidate))
                throw new CreditCardExpirationDateInvalidFormatException();
            if (!ValidateMonthExpirationDate(expirationDateToValidate))
                throw new CreditCardExpirationDateInvalidMonthException();
        }

        private bool ValidateMonthExpirationDate(string expirationDateToValidate)
        {
            Regex validMonth = new Regex(@"^(?:0[1-9])|(?:1[0-2])", RegexOptions.Compiled);
            return validMonth.IsMatch(expirationDateToValidate);
        }

        private bool ValidateFormatExpirationDate(string expirationDateToValidate)
        {
            Regex validMonth = new Regex(@"^[0-9]{2}/[0-9]{2}$", RegexOptions.Compiled);
            return validMonth.IsMatch(expirationDateToValidate);
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
