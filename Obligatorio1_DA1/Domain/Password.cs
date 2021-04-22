using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MissingFieldException = Obligatorio1_DA1.Exceptions.MissingFieldException;

namespace Obligatorio1_DA1.Domain
{
    public class Password
    {
        private string category;
        private string site;
        private string username;
        private string pass;
        private string notes;
        public PasswordStrengthColor PasswordStrength { get; private set; }

        public string Category
        {
            get => category;
            set
            {
                validateCategory(value);
                category = value;
            }

        }

        private void validateCategory(string value)
        {
            if (!Validator.minLengthOfString(value, 3))
                throw new CategoryTooShortException();
            if (!Validator.maxLengthOfString(value, 15))
                throw new CategoryTooLongException();
        }
        public string Site
        {
            get => site;
            set
            {
                validateSite(value);
                site = value;
            }

        }

        private void validateSite(string value)
        {
            if (!Validator.minLengthOfString(value, 3))
                throw new SiteTooShortException();
            if (!Validator.maxLengthOfString(value, 25))
                throw new SiteTooLongException();
        }
        public string Username
        {
            get => username;
            set
            {
                validateUsername(value);
                username = value;
            }
        }

        private void validateUsername(string username)
        {
            if (username == null)
                throw new MissingFieldException("nombre de usuario");
            if (!Validator.minLengthOfString(username, 5))
                throw new UsernameTooShortException();
            if (!Validator.maxLengthOfString(username, 25))
                throw new UsernameTooLongException();

        }

        public string Pass
        {
            get => pass;
            set
            {
                validatePass(value);
                pass = value;
                this.PasswordStrength = calculatePasswordStrength(value);
            }

        }

        private void validatePass(string value)
        {
            if (!Validator.minLengthOfString(value, 5))
                throw new PasswordTooShortException();
            if (!Validator.maxLengthOfString(value, 25))
                throw new PasswordTooLongException();
        }

        public string Notes
        {
            get => notes;
            set
            {
                validateNotes(value);
                notes = value;
            }

        }

        private void validateNotes(string value)
        {
            if (value == null)
                return;
            if (!Validator.maxLengthOfString(value, 250))
                throw new NotesTooLongException();
        }

        public static string generateRandomPassword(int length, Boolean uppercase, Boolean lowercase, Boolean digits, Boolean specialDigits)
        {
            if (length < 5 || length > 25)
                throw new ArgumentException();
            if (!(uppercase || lowercase || digits || specialDigits))
                throw new ArgumentException();

            const string uppercaseSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowercaseSet = "abcdefghijklmnopqrstuvwxyz";
            const string digitsSet = "0123456789";
            const string specialDigitsSet = " !\"#$%&\'()*+,-./:;<=>?@[\\]^_`{|}~";

            List<char> validChars = new List<char>();
            string pass = "";
            Random random = new Random();

            if (uppercase)
                addRandomCharFromSubSet(ref pass, uppercaseSet, random, validChars);

            if (lowercase)
                addRandomCharFromSubSet(ref pass, lowercaseSet, random, validChars);

            if (digits)
                addRandomCharFromSubSet(ref pass, digitsSet, random, validChars);

            if (specialDigits)
                addRandomCharFromSubSet(ref pass, specialDigitsSet, random, validChars);


            while (pass.Length < length)
                addRandomChar(ref pass, validChars, random);

            return pass;
        }
        private static void addRandomCharFromSubSet(ref string word, string subSet, Random random, List<char> mainSet)
        {
            List<char> newValidChars = subSet.ToList();
            addRandomChar(ref word, newValidChars, random);
            mainSet.AddRange(newValidChars);
        }
        private static void addRandomChar(ref string word, List<char> validChars, Random random)
        {
            char randomChar = validChars[random.Next(0, validChars.Count - 1)];
            int index = random.Next(0, word.Length);
            word = word.Insert(index, randomChar + "");
        }

        private PasswordStrengthColor calculatePasswordStrength(string pass)
        {
            if (isRedStrength(pass))
                return PasswordStrengthColor.Red;
            if (isOrangeStrength(pass))
                return PasswordStrengthColor.Orange;
            return calculateLargePasswordStrength(pass);
        }

        private PasswordStrengthColor calculateLargePasswordStrength(string pass)
        {
            bool hasUpperCase, hasLowerCase, hasNumber, hasSymbol;
            hasUpperCase = hasLowerCase = hasNumber = hasSymbol = false;
            int typeCount = 0;
            for (int i = 0; i < pass.Length && typeCount < 4; i++)
            {
                if (isLowerCase(pass.ElementAt(i)) && !hasLowerCase)
                {
                    typeCount++;
                    hasLowerCase = true;
                }
                else if (isUpperCase(pass.ElementAt(i)) && !hasUpperCase)
                {
                    typeCount++;
                    hasUpperCase = true;
                }
                else if (isNumber(pass.ElementAt(i)) && !hasNumber)
                {
                    typeCount++;
                    hasNumber = true;
                }
                else if (isSymbol(pass.ElementAt(i)) && !hasSymbol)
                {
                    typeCount++;
                    hasSymbol = true;
                }
            }
            if (hasLowerCase && hasUpperCase && typeCount == 2)
                return PasswordStrengthColor.LightGreen;
            return checkResultDependingOnTypeCount(typeCount);
        }

        private PasswordStrengthColor checkResultDependingOnTypeCount(int typeCount)
        {
            switch (typeCount)
            {
                case 3:
                    return PasswordStrengthColor.LightGreen;
                case 4:
                    return PasswordStrengthColor.DarkGreen;
                default:
                    return PasswordStrengthColor.Yellow;
            }
        }

        private bool isRedStrength(string pass)
        {
            Regex regex = new Regex(@"^.{1,8}$", RegexOptions.Compiled);
            return regex.IsMatch(pass);
        }

        private bool isOrangeStrength(string pass)
        {
            Regex regex = new Regex(@"^.{8,14}$", RegexOptions.Compiled);
            return regex.IsMatch(pass);
        }

        private bool isSymbol(char character)
        {
            Regex regex = new Regex(@"^[ -/:-@[-`{-~]+$", RegexOptions.Compiled);
            return regex.IsMatch(character.ToString());
        }
        private bool isNumber(char character)
        {
            Regex regex = new Regex(@"^[0-9]+$", RegexOptions.Compiled);
            return regex.IsMatch(character.ToString());
        }

        private bool isUpperCase(char character)
        {
            Regex regex = new Regex(@"^[A-Z]+$", RegexOptions.Compiled);
            return regex.IsMatch(character.ToString());
        }

        private bool isLowerCase(char character)
        {
            Regex regex = new Regex(@"^[a-z]+$", RegexOptions.Compiled);
            return regex.IsMatch(character.ToString());
        }


    }


}
