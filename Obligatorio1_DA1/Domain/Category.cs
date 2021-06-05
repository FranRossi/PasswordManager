using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Utilities;
using System;

namespace Obligatorio1_DA1.Domain
{
    public class Category
    {
        public const int MinNameLength = 3;
        public const int MaxNameLength = 15;

        private string _name;
        public int Id { get; set; }
        public string Name
        {
            get => _name;
            set
            {
                ValidateName(value);
                _name = value;
            }
        }

        public User User { get; set; }

        private void ValidateName(string value)
        {
            if (!Validator.MinLengthOfString(value, Category.MinNameLength))
                throw new CategoryTooShortException();
            if (!Validator.MaxLengthOfString(value, Category.MaxNameLength))
                throw new CategoryTooLongException();
        }

        public override string ToString()
        {
            return this.Name;
        }

        public override bool Equals(object obj)
        {
            Category categoryToCompare;
            try
            {
                categoryToCompare = (Category)obj;
            }
            catch (InvalidCastException e)
            {
                return false;
            }
            return categoryToCompare.Name.ToLower() == this.Name.ToLower();
        }

        public string getUserMasterName()
        {
            return this.User.MasterName;
        }
    }
}