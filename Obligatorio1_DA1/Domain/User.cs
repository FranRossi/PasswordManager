using Obligatorio1_DA1.Utilities;
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
                throw new ArgumentException("The name is too short (min. 5 characters).");
            if (!Validator.maxLength(name, 25))
                throw new ArgumentException("The name is too long (max. 25 characters).");
        }

        private void validatePassword(string pass)
        {

            if (!Validator.minLength(pass, 5))
                throw new ArgumentException("The password is too short (min. 5 characters).");
            if (!Validator.maxLength(pass, 25))
                throw new ArgumentException("The password is too long (max. 25 characters).");
            if (!Validator.asciiCharacterRange(pass))
                throw new ArgumentException("The password contains invalid characters (32-126 in ascii).");
        }

    }
}