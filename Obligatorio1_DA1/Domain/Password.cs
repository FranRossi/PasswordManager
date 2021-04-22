using Obligatorio1_DA1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Obligatorio1_DA1.Domain
{
    public class Password
    {
        public string Category { get; set; }
        public string Site { get; set; }
        public string Username { get; set; }

        private string pass;
        public string Pass
        {
            get => pass;
            set
            {
                pass = value;
                this.PasswordStrength = calculatePasswordStrength(value);
            }
        }
        public string Notes { get; set; }
        public PasswordStrengthColor PasswordStrength { get; private set; }

        public static string generate(int length, Boolean uppercase, Boolean lowercase, Boolean digits, Boolean specialDigits)
        {
            if (length < 5 || length > 25)
                throw new ArgumentException();
            if (!(uppercase || lowercase || digits || specialDigits))
                throw new ArgumentException();

            List<char> validChars = new List<char>();
            string pass = "";
            Random random = new Random();

            if (uppercase)
                addRandomCharFromSubSet(ref pass, "ABCDEFGHIJKLMNOPQRSTUVWXYZ", random, validChars);

            if (lowercase)
                addRandomCharFromSubSet(ref pass, "abcdefghijklmnopqrstuvwxyz", random, validChars);

            if (digits)
                addRandomCharFromSubSet(ref pass, "0123456789", random, validChars);

            if (specialDigits)
                addRandomCharFromSubSet(ref pass, " !\"#$%&\'()*+,-./:;<=>?@[\\]^_`{|}~", random, validChars);


            while (pass.Length < length)
                addRandomChar(ref pass, validChars, random);

            return pass;
        }
        private static void addRandomCharFromSubSet(ref string word, string subSet, Random random, List<char> mainSet)
        {
            List<char> listofValidChars = subSet.ToList();
            addRandomChar(ref word, listofValidChars, random);
            mainSet.AddRange(listofValidChars);
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
