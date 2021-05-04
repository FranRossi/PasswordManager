using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Utilities;
using System;

namespace Obligatorio1_DA1.Domain
{
    public class Category
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                ValidateName(value);
                _name = value;
            }
        }

        private void ValidateName(string value)
        {
            if (!Validator.MinLengthOfString(value, 3))
                throw new CategoryTooShortException();
            if (!Validator.MaxLengthOfString(value, 15))
                throw new CategoryTooLongException();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}