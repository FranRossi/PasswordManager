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
            if (!Validator.stringIsExactlyThisLong(19, number))
                throw new NumberCardLengthIncorrect();
        }

        public string showOnly4LastDigits()
        {
            return convertCardNumberIntoSecretNumber();
        }

        private string convertCardNumberIntoSecretNumber()
        {
            string regularNumber = this.Number;
            string secretNumber = regularNumber.Substring(14);
            return secretNumber.Insert(0, "XXXX XXXX XXXX ");
        }
    }
}