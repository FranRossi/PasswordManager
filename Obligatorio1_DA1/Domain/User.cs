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
                _masterPass = value;
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


        public User(string name, string pass)
        {
            this.MasterName = name;
            this.Categories = new List<Category>();

            IHash hashing = new BasicHash();
            string hashedPass = hashing.Hash(pass, name);
            this.MasterPass = hashedPass;

        }

        public User()
        {
            this.Categories = new List<Category>();
        }

        private void ValidateName(string name)
        {
            if (!Validator.MinLengthOfString(name, User.MinNameLength))
                throw new UserNameTooShortException();
            if (!Validator.MaxLengthOfString(name, User.MaxNameLength))
                throw new UserNameTooLongException();
        }

        private void ValidatePassword(string pass)
        {
            if (!Validator.MinLengthOfString(pass, User.MinPasswordLength))
                throw new PasswordTooShortException();
            if (!Validator.MaxLengthOfString(pass, User.MaxPasswordLength))
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

        public void AddOneCategory(string newCategoryName)
        {
            //TODO SACAR
            Category newCategory = new Category { Name = newCategoryName };
            ValidateCategoryIsUnique(newCategory);
            this.Categories.Add(newCategory);
        }

        public void ModifyCategory(Category oldCategory, Category newCategory)
        {
            //TODO SACAR
            foreach (Category categoryIterator in this.Categories)
            {
                if (categoryIterator.Equals(oldCategory))
                    categoryIterator.Name = newCategory.Name;
            }
        }

        private void ValidateCategoryIsUnique(Category newCategory)
        {
            //TODO SACAR
            if (this.Categories.Contains(newCategory))
                throw new CategoryAlreadyAddedException();
        }
    }
}