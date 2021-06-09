using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;
using System;
using System.Collections.Generic;

namespace Obligatorio1_DA1.Domain
{
    public class User
    {
        public const int MaxNameLength = 25;
        public const int MinNameLength = 5;
        public const int MaxPasswordLength = 25;
        public const int MinPasswordLength = 5;

        private string _masterPass;
        private string _masterName;
        private List<Category> _categories;
        public string MasterName
        {
            get => _masterName;
            set
            {
                ValidateName(value);
                _masterName = value;
            }
        }
        public string MasterPass
        {
            get => _masterPass;
            set
            {
                ValidatePassword(value);
                string hashedPassword = HashPassword(value);
                _masterPass = hashedPassword;
            }
        }
        public List<Category> Categories
        {
            get => _categories;
            private set
            {
                _categories = value;
            }
        }


        public User(string newName, string newPass)
        {
            this.MasterName = newName;
            this.MasterPass = newPass;
            this.Categories = new List<Category>();
        }

        public User()
        {
            this.Categories = new List<Category>();
        }

        private void ValidateName(string nameToValidate)
        {
            if (!Validator.MinLengthOfString(nameToValidate, User.MinNameLength))
                throw new UserNameTooShortException();
            if (!Validator.MaxLengthOfString(nameToValidate, User.MaxNameLength))
                throw new UserNameTooLongException();
        }

        private void ValidatePassword(string passToValidate)
        {
            if (!Validator.MinLengthOfString(passToValidate, User.MinPasswordLength))
                throw new PasswordTooShortException();
            if (!Validator.MaxLengthOfString(passToValidate, User.MaxPasswordLength))
                throw new PasswordTooLongException();
            if (!Validator.AsciiCharacterRangeForPassword(passToValidate))
                throw new PasswordInvalidCharactersException();
        }

        public override bool Equals(object obj)
        {
            User userToCompare;
            try
            {
                userToCompare = (User)obj;
            }
            catch (InvalidCastException e)
            {
                return false;
            }
            return userToCompare.MasterName == this.MasterName;
        }

        public override string ToString()
        {
            return this.MasterName;
        }

        private string HashPassword(string password)
        {
            IHash hashing = new BasicHash();
            string hashedPass = hashing.Hash(password, MasterName);
            return hashedPass;
        }
    }
}