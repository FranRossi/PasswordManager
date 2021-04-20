using Obligatorio1_DA1.Utilities;
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

        private string pass;
        public string Pass
        {
            get => pass;
            set
            {
                pass = value;
                this.PasswordStrength = calculatePasswordStrength();
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

        private PasswordStrengthColor calculatePasswordStrength()
        {
            PasswordStrengthColor result = PasswordStrengthColor.Red;
            return result;
        }


    }


}
