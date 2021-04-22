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
            if (!Validator.minLengthOfString(name, 5))
                throw new NameTooShortException();
            if (!Validator.maxLengthOfString(name, 25))
                throw new NameTooLongException();
        }

        private void validatePassword(string pass)
        {
            if (!Validator.minLengthOfString(pass, 5))
                throw new PasswordTooShortException();
            if (!Validator.maxLengthOfString(pass, 25))
                throw new PasswordTooLongException();
            if (!Validator.asciiCharacterRangeForPassword(pass))
                throw new PasswordInvalidCharactersException();
        }

    }
}