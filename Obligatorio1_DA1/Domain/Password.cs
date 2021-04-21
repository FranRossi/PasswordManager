using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
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


    }


}
