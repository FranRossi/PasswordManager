using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Domain
{
    public class Password
    {
        public string Category { get; set; }
        public string Site { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public string Notes { get; set; }

        public static string generate(int length, Boolean uppercase, Boolean lowercase, Boolean digits, Boolean specialDigits)
        {
            List<char> validChars = new List<char>();
            string pass = "";

            if (uppercase)
            {
                List<char> uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToList();
                addRandomChar(ref pass, uppercaseLetters);
                validChars.AddRange(uppercaseLetters);
            }
            if (lowercase)
            {
                List<char> lowercaseLetters = "abcdefghijklmnopqrstuvwxyz".ToList();
                addRandomChar(ref pass, lowercaseLetters);
                validChars.AddRange(lowercaseLetters);
            }
            if (digits)
            {
                List<char> digitList = "0123456789".ToList();
                addRandomChar(ref pass, digitList);
                validChars.AddRange(digitList);
            }
            if (specialDigits)
            {
                List<char> specialDigitList = " !\"#$%&\'()*+,-./:;<=>?@[\\]^_`{|}~".ToList();
                addRandomChar(ref pass, specialDigitList);
                validChars.AddRange(specialDigitList);
            }
            while (pass.Length < length)
                addRandomChar(ref pass, validChars);

            return pass;
        }

        private static void addRandomChar(ref string word, List<char> validChars)
        {
            Random random = new Random();
            char randomChar = validChars[random.Next(0, validChars.Count - 1)];
            word += randomChar;
        }
    }


}
