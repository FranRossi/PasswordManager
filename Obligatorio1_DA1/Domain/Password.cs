using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Obligatorio1_DA1.Domain
{
    public class Password : Item
    {
        public const int MaxSiteLength = 25;
        public const int MinSiteLength = 3;
        public const int MaxUsernameLength = 25;
        public const int MinUsernameLength = 5;
        public const int MaxPasswordLength = 25;
        public const int MinPasswordLength = 5;

        private string _site;
        private string _username;
        private string _pass;
        private List<User> _sharedWith;
        private DateTime _lastModification;

        public Password()
        {
            LastModification = DateTime.Today;
        }

        public PasswordStrengthColor PasswordStrength { get; private set; }

        public List<User> SharedWith
        {
            get
            {
                if (_sharedWith == null)
                {
                    _sharedWith = new List<User>();
                }
                return _sharedWith;
            }
        }

        public string Site
        {
            get => _site;
            set
            {
                ValidateSite(value);
                _site = value;
            }

        }

        public string Username
        {
            get => _username;
            set
            {
                ValidateUsername(value);
                _username = value;
            }
        }

        public string Pass
        {
            get => _pass;
            set
            {
                ValidatePass(value);
                _pass = Encript(value);
                this.PasswordStrength = CalculatePasswordStrength(value);
            }

        }

        public string DecyptedPass
        {
            get => ShowDecyptedPass();
        }

        private string ShowDecyptedPass()
        {
            IEncription encription = new BasicEncription();
            string decyptedPassword = encription.Decript(Pass, Username);
            return decyptedPassword;
        }

        private string Encript(string pass)
        {
            IEncription encription = new BasicEncription();
            string encriptedPassword = encription.Encript(pass, Username);
            return encriptedPassword;

        }

        public DateTime LastModification
        {
            get => _lastModification;
            set
            {
                _lastModification = value;
            }
        }


        private void ValidateSite(string value)
        {
            if (!Validator.MinLengthOfString(value, Password.MinSiteLength))
                throw new PasswordSiteTooShortException();
            if (!Validator.MaxLengthOfString(value, Password.MaxSiteLength))
                throw new PasswordSiteTooLongException();
        }

        private void ValidateUsername(string username)
        {
            if (!Validator.MinLengthOfString(username, Password.MinUsernameLength))
                throw new PasswordUsernameTooShortException();
            if (!Validator.MaxLengthOfString(username, Password.MaxUsernameLength))
                throw new PasswordUsernameTooLongException();
        }

        private void ValidatePass(string value)
        {
            if (!Validator.MinLengthOfString(value, Password.MinPasswordLength))
                throw new PasswordTooShortException();
            if (!Validator.MaxLengthOfString(value, Password.MaxPasswordLength))
                throw new PasswordTooLongException();
        }

        public static string GenerateRandomPassword(PasswordGenerationOptions options)
        {
            ValidatePasswordGenerationOptions(options);

            const string uppercaseSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowercaseSet = "abcdefghijklmnopqrstuvwxyz";
            const string digitsSet = "0123456789";
            const string specialDigitsSet = " !\"#$%&\'()*+,-./:;<=>?@[\\]^_`{|}~";

            List<char> validChars = new List<char>();
            string pass = "";
            Random random = new Random();

            if (options.Uppercase)
                AddRandomCharFromSubSet(ref pass, uppercaseSet, random, validChars);
            if (options.Lowercase)
                AddRandomCharFromSubSet(ref pass, lowercaseSet, random, validChars);
            if (options.Digits)
                AddRandomCharFromSubSet(ref pass, digitsSet, random, validChars);
            if (options.SpecialDigits)
                AddRandomCharFromSubSet(ref pass, specialDigitsSet, random, validChars);

            while (pass.Length < options.Length)
                AddRandomCharAtRandomPosition(ref pass, validChars, random);

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

        private static void AddRandomCharFromSubSet(ref string word, string subSet, Random random, List<char> mainSet)
        {
            List<char> newValidChars = subSet.ToList();
            AddRandomCharAtRandomPosition(ref word, newValidChars, random);
            mainSet.AddRange(newValidChars);
        }

        private static void AddRandomCharAtRandomPosition(ref string word, List<char> validChars, Random random)
        {
            int indexFirstValidChart = 0;
            int indexLastValidChart = validChars.Count - 1;
            char randomChar = validChars[random.Next(indexFirstValidChart, indexLastValidChart)];

            int indexStartWord = 0;
            int index = random.Next(indexStartWord, word.Length);
            word = word.Substring(indexStartWord, index) + randomChar + word.Substring(index);
        }

        private PasswordStrengthColor CalculatePasswordStrength(string pass)
        {
            if (IsRedStrength(pass))
                return PasswordStrengthColor.Red;
            if (IsOrangeStrength(pass))
                return PasswordStrengthColor.Orange;
            return CalculateLargePasswordStrength(pass);
        }

        private PasswordStrengthColor CalculateLargePasswordStrength(string pass)
        {
            bool hasUpperCase, hasLowerCase, hasNumber, hasSymbol;
            hasUpperCase = hasLowerCase = hasNumber = hasSymbol = false;
            int typeCount = 0;
            int maxTypeCount = 4;
            for (int i = 0; i < pass.Length && typeCount < maxTypeCount; i++)
            {
                if (IsLowerCase(pass.ElementAt(i)) && !hasLowerCase)
                {
                    typeCount++;
                    hasLowerCase = true;
                }
                else if (IsUpperCase(pass.ElementAt(i)) && !hasUpperCase)
                {
                    typeCount++;
                    hasUpperCase = true;
                }
                else if (IsNumber(pass.ElementAt(i)) && !hasNumber)
                {
                    typeCount++;
                    hasNumber = true;
                }
                else if (IsSymbol(pass.ElementAt(i)) && !hasSymbol)
                {
                    typeCount++;
                    hasSymbol = true;
                }
            }
            if (hasLowerCase && hasUpperCase && typeCount == 2)
                return PasswordStrengthColor.LightGreen;
            return CheckResultDependingOnTypeCount(typeCount);
        }

        private PasswordStrengthColor CheckResultDependingOnTypeCount(int typeCount)
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

        private bool IsRedStrength(string pass)
        {
            Regex lengthBetween1And8 = new Regex(@"^.{1,8}$", RegexOptions.Compiled);
            return lengthBetween1And8.IsMatch(pass);
        }

        private bool IsOrangeStrength(string pass)
        {
            Regex lengthBetween8And14 = new Regex(@"^.{8,14}$", RegexOptions.Compiled);
            return lengthBetween8And14.IsMatch(pass);
        }

        private bool IsSymbol(char character)
        {
            Regex isSymbol = new Regex(@"^[ -/:-@[-`{-~]+$", RegexOptions.Compiled);
            return isSymbol.IsMatch(character.ToString());
        }

        private bool IsNumber(char character)
        {
            Regex isNumber = new Regex(@"^[0-9]+$", RegexOptions.Compiled);
            return isNumber.IsMatch(character.ToString());
        }

        private bool IsUpperCase(char character)
        {
            Regex isUpperCase = new Regex(@"^[A-Z]+$", RegexOptions.Compiled);
            return isUpperCase.IsMatch(character.ToString());
        }

        private bool IsLowerCase(char character)
        {
            Regex isLowerCase = new Regex(@"^[a-z]+$", RegexOptions.Compiled);
            return isLowerCase.IsMatch(character.ToString());
        }

        public void ShareWithUser(User userShareWith)
        {
            if (this.User == userShareWith)
            {
                throw new PasswordSharedWithSameUserException();
            }
            if (!this.SharedWith.Contains(userShareWith))
                this.SharedWith.Add(userShareWith);
        }

        public void UnShareWithUser(User userRemoveShare)
        {
            this.SharedWith.Remove(userRemoveShare);
        }


        public override bool Equals(object obj)
        {
            Password passwordToCompare;
            try
            {
                passwordToCompare = (Password)obj;
            }
            catch (InvalidCastException e)
            {
                return false;
            }
            return CheckEqualityOfPassword(passwordToCompare, this);
        }

        private bool CheckEqualityOfPassword(Password passwordToCompare, Password password)
        {
            bool userObjectAreEqual = passwordToCompare.User.Equals(password.User);
            bool userNameAreEqual = passwordToCompare.Username.ToLower() == password.Username.ToLower();
            bool siteAreEqual = passwordToCompare.Site.ToLower() == password.Site.ToLower();

            return (userNameAreEqual && siteAreEqual && userObjectAreEqual);
        }


    }


}
