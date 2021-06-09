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
        private IEncryption encryption;

        public Password()
        {
            LastModification = DateTime.Today;
            encryption = new BasicEncryption();
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
                _pass = value;
                this.PasswordStrength = CalculatePasswordStrength(value);
            }

        }

        public string DecryptedPass
        {
            get => ShowDecryptedPass();
        }

        private string ShowDecryptedPass()
        {
            string decyptedPassword = encryption.Decrypt(this.Pass, this.User.PasswordsKey);
            return decyptedPassword;
        }

        public void Encrypt()
        {
            string encryptedPassword = encryption.Encrypt(this.Pass, this.User.PasswordsKey);
            this._pass = encryptedPassword;
        }

        public DateTime LastModification
        {
            get => _lastModification;
            set
            {
                _lastModification = value;
            }
        }


        private void ValidateSite(string siteToValidate)
        {
            if (!Validator.MinLengthOfString(siteToValidate, Password.MinSiteLength))
                throw new PasswordSiteTooShortException();
            if (!Validator.MaxLengthOfString(siteToValidate, Password.MaxSiteLength))
                throw new PasswordSiteTooLongException();
        }

        private void ValidateUsername(string usernameToValidate)
        {
            if (!Validator.MinLengthOfString(usernameToValidate, Password.MinUsernameLength))
                throw new PasswordUsernameTooShortException();
            if (!Validator.MaxLengthOfString(usernameToValidate, Password.MaxUsernameLength))
                throw new PasswordUsernameTooLongException();
        }

        public void ValidatePass()
        {
            string passToValidate = this._pass;
            if (!Validator.MinLengthOfString(passToValidate, Password.MinPasswordLength))
                throw new PasswordTooShortException();
            if (!Validator.MaxLengthOfString(passToValidate, Password.MaxPasswordLength))
                throw new PasswordTooLongException();
        }

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

        private PasswordStrengthColor CalculatePasswordStrength(string passToCheckedStrength)
        {
            if (IsRedStrength(passToCheckedStrength))
                return PasswordStrengthColor.Red;
            if (IsOrangeStrength(passToCheckedStrength))
                return PasswordStrengthColor.Orange;
            return CalculateLargePasswordStrength(passToCheckedStrength);
        }

        private PasswordStrengthColor CalculateLargePasswordStrength(string passToCheckedStrength)
        {
            bool hasUpperCase, hasLowerCase, hasNumber, hasSymbol;
            hasUpperCase = hasLowerCase = hasNumber = hasSymbol = false;
            int typeCount = 0;
            int maxTypeCount = 4;
            for (int i = 0; i < passToCheckedStrength.Length && typeCount < maxTypeCount; i++)
            {
                if (IsLowerCase(passToCheckedStrength.ElementAt(i)) && !hasLowerCase)
                {
                    typeCount++;
                    hasLowerCase = true;
                }
                else if (IsUpperCase(passToCheckedStrength.ElementAt(i)) && !hasUpperCase)
                {
                    typeCount++;
                    hasUpperCase = true;
                }
                else if (IsNumber(passToCheckedStrength.ElementAt(i)) && !hasNumber)
                {
                    typeCount++;
                    hasNumber = true;
                }
                else if (IsSymbol(passToCheckedStrength.ElementAt(i)) && !hasSymbol)
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

        private bool IsRedStrength(string passToCheckedStrength)
        {
            Regex lengthBetween1And8 = new Regex(@"^.{1,8}$", RegexOptions.Compiled);
            return lengthBetween1And8.IsMatch(passToCheckedStrength);
        }

        private bool IsOrangeStrength(string passToCheckedStrength)
        {
            Regex lengthBetween8And14 = new Regex(@"^.{8,14}$", RegexOptions.Compiled);
            return lengthBetween8And14.IsMatch(passToCheckedStrength);
        }

        private bool IsSymbol(char characterToCheck)
        {
            Regex isSymbol = new Regex(@"^[ -/:-@[-`{-~]+$", RegexOptions.Compiled);
            return isSymbol.IsMatch(characterToCheck.ToString());
        }

        private bool IsNumber(char characterToCheck)
        {
            Regex isNumber = new Regex(@"^[0-9]+$", RegexOptions.Compiled);
            return isNumber.IsMatch(characterToCheck.ToString());
        }

        private bool IsUpperCase(char characterToCheck)
        {
            Regex isUpperCase = new Regex(@"^[A-Z]+$", RegexOptions.Compiled);
            return isUpperCase.IsMatch(characterToCheck.ToString());
        }

        private bool IsLowerCase(char characterToCheck)
        {
            Regex isLowerCase = new Regex(@"^[a-z]+$", RegexOptions.Compiled);
            return isLowerCase.IsMatch(characterToCheck.ToString());
        }

        public void ShareWithUser(User userShareWith)
        {
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
