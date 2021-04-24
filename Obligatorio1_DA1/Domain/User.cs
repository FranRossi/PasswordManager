using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;
using System;
using System.Collections.Generic;

namespace Obligatorio1_DA1
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
                validateName(value);
                name = value;
            }
        }
        public string Pass
        {
            get => pass;
            set
            {
                validatePassword(value);
                pass = value;
            }
        }

        public List<Category> Categories
        {
            get => categories;
            set
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

        private void validateName(string name)
        {
            if (!Validator.MinLengthOfString(name, 5))
                throw new NameTooShortException();
            if (!Validator.MaxLengthOfString(name, 25))
                throw new NameTooLongException();
        }

        private void validatePassword(string pass)
        {
            if (!Validator.MinLengthOfString(pass, 5))
                throw new PasswordTooShortException();
            if (!Validator.MaxLengthOfString(pass, 25))
                throw new PasswordTooLongException();
            if (!Validator.AsciiCharacterRangeForPassword(pass))
                throw new PasswordInvalidCharactersException();
        }

    }
}