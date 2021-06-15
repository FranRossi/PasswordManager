using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Utilities
{
    public static class PasswordGeneration
    {
        public static string GenerateRandomPassword(PasswordGenerationOptions selectedOptions)
        {
            ValidatePasswordGenerationOptions(selectedOptions);

            const string uppercaseSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowercaseSet = "abcdefghijklmnopqrstuvwxyz";
            const string digitsSet = "0123456789";
            const string specialDigitsSet = " !\"#$%&\'()*+,-./:;<=>?@[\\]^_`{|}~";

            List<char> validChars = new List<char>();
            string pass = "";
            Random randomNumber = new Random();

            if (selectedOptions.Uppercase)
                AddRandomCharFromSubSet(ref pass, uppercaseSet, randomNumber, validChars);
            if (selectedOptions.Lowercase)
                AddRandomCharFromSubSet(ref pass, lowercaseSet, randomNumber, validChars);
            if (selectedOptions.Digits)
                AddRandomCharFromSubSet(ref pass, digitsSet, randomNumber, validChars);
            if (selectedOptions.SpecialDigits)
                AddRandomCharFromSubSet(ref pass, specialDigitsSet, randomNumber, validChars);

            while (pass.Length < selectedOptions.Length)
                AddRandomCharAtRandomPosition(ref pass, validChars, randomNumber);

            return pass;
        }

        private static void ValidatePasswordGenerationOptions(PasswordGenerationOptions selectedOptions)
        {
            if (selectedOptions.Length > Password.MaxPasswordLength)
                throw new PasswordGenerationTooLongException();
            if (selectedOptions.Length < Password.MinPasswordLength)
                throw new PasswordGenerationTooShortException();
            if (!(selectedOptions.Uppercase || selectedOptions.Lowercase || selectedOptions.Digits || selectedOptions.SpecialDigits))
                throw new PasswordGenerationNotSelectedCharacterTypesException();
        }

        private static void AddRandomCharFromSubSet(ref string word, string subSet, Random randomnumber, List<char> mainSet)
        {
            List<char> newValidChars = subSet.ToList();
            AddRandomCharAtRandomPosition(ref word, newValidChars, randomnumber);
            mainSet.AddRange(newValidChars);
        }

        private static void AddRandomCharAtRandomPosition(ref string word, List<char> validChars, Random randomNumber)
        {
            int indexFirstValidChart = 0;
            int indexLastValidChart = validChars.Count - 1;
            char randomChar = validChars[randomNumber.Next(indexFirstValidChart, indexLastValidChart)];

            int indexStartWord = 0;
            int index = randomNumber.Next(indexStartWord, word.Length);
            word = word.Substring(indexStartWord, index) + randomChar + word.Substring(index);
        }

    }
}
