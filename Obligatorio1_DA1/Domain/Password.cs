using System;
using System.Collections.Generic;
using System.Linq;

namespace Obligatorio1_DA1.Domain
{
    public class Password
    {
        public string Category { get; set; }
        public string Site { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public string Notes { get; set; }

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
