using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;
using System;

namespace Obligatorio1_DA1
{
    class User
    {
        private string pass;
        private string name;
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


        public User(string name, string pass)
        {
            this.Name = name;
            this.Pass = pass;
        }

        private void validateName(string name)
        {
            if (!Validator.minLength(name, 5))
                throw new NameTooShortException();
            if (!Validator.maxLength(name, 25))
                throw new ArgumentException("The name is too long (max. 25 characters).");
        }

        private void validatePassword(string pass)
        {

            if (!Validator.minLength(pass, 5))
                throw new PasswordTooShortException();
            if (!Validator.maxLength(pass, 25))
                throw new PasswordTooLongException();
            if (!Validator.asciiCharacterRange(pass))
                throw new PasswordInvalidCharactersException();
        }

    }
}