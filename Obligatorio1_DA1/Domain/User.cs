﻿using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;
using System;
using System.Collections.Generic;

namespace Obligatorio1_DA1.Domain
{
    public class User
    {
        private string pass;
        private string name;
        private List<Category> categories;
        public string Name
        {
            get => name;
            set
            {
                ValidateName(value);
                name = value;
            }
        }
        public string Pass
        {
            get => pass;
            set
            {
                ValidatePassword(value);
                pass = value;
            }
        }

        public List<Category> Categories
        {
            get => categories;
            private set
            {
                categories = value;
            }
        }

        public User(string name, string pass)
        {
            this.Name = name;
            this.Pass = pass;
            this.Categories = new List<Category>();
        }

        public User()
        {
            this.Categories = new List<Category>();
        }

        private void ValidateName(string name)
        {
            if (!Validator.MinLengthOfString(name, 5))
                throw new UserNameTooShortException();
            if (!Validator.MaxLengthOfString(name, 25))
                throw new UserNameTooLongException();
        }

        private void ValidatePassword(string pass)
        {
            if (!Validator.MinLengthOfString(pass, 5))
                throw new PasswordTooShortException();
            if (!Validator.MaxLengthOfString(pass, 25))
                throw new PasswordTooLongException();
            if (!Validator.AsciiCharacterRangeForPassword(pass))
                throw new PasswordInvalidCharactersException();
        }

        public override bool Equals(object obj)
        {
            User userToCompare;
            try
            {
                userToCompare = (User)obj;
            }
            catch (Exception e)
            {
                return false;
            }
            return userToCompare.Name == this.Name;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}