using System;
using System.Collections.Generic;
using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;
using System.Linq;

namespace Obligatorio1_DA1.Domain
{
    public class PasswordManager
    {
        public User CurrentUser { get; private set; }
        private List<User> _users;
        private List<Password> _passwords;
        private List<CreditCard> _creditCards;

        public PasswordManager()
        {
            _users = new List<User>();
            _passwords = new List<Password>();
            _creditCards = new List<CreditCard>();
        }

        public void CreateUser(User newUser)
        {
            if (_users.Exists(user => user.Name == newUser.Name))
                throw new UsernameAlreadyTakenException();
            _users.Add(newUser);
            CurrentUser = newUser;
        }

        public void Login(string name, string password)
        {
            foreach (User user in _users)
                if (user.Name == name)
                    if (user.Pass == password)
                    {
                        CurrentUser = user;
                        return;
                    }
                    else
                        throw new LogInException();
            throw new LogInException();
        }


        public List<Category> GetCategoriesFromCurrentUser()
        {
            return this.CurrentUser.Categories;
        }

        public void CreateCategoryOnCurrentUser(Category category)
        {
            if (this.CurrentUser.Categories.Contains(category))
                throw new CategoryAlreadyAddedException();
            this.CurrentUser.Categories.Add(category);
        }

        public void ModifyCategoryOnCurrentUser(Category oldCategory, Category newCategory)
        {
            foreach (Category categoryIterator in CurrentUser.Categories)
            {
                if (categoryIterator.Equals(oldCategory))
                    categoryIterator.Name = newCategory.Name;
            }
        }


        public void CreatePassword(Password password)
        {
            this._passwords.Add(password);
        }

        public List<Password> GetPasswords()
        {
            return this._passwords.Where(pass => pass.User == CurrentUser).ToList();
        }

        public List<Password> GetSharedPasswordsWithCurrentUser()
        {
            return this._passwords.Where(pass => pass.ShareWith.Contains(CurrentUser)).ToList();
        }

        public void DeletePassword(Password password)
        {
            this._passwords.Remove(password);
        }

        public void ModifyPasswordOnCurrentUser(Password oldPassword, Password newPassword)
        {
            foreach (Password passwordIterator in this.GetPasswords())
            {
                if (passwordIterator.Equals(oldPassword))
                {
                    passwordIterator.Username = newPassword.Username;
                    passwordIterator.Pass = newPassword.Pass;
                    passwordIterator.Category = newPassword.Category;
                    passwordIterator.Site = newPassword.Site;
                    passwordIterator.Notes = newPassword.Notes;
                }
            }
        }

        public List<passwordReportByCategoryAndColor> GetPasswordReportByCategoryAndColor()
        {
            List<passwordReportByCategoryAndColor> report = new List<passwordReportByCategoryAndColor>();

            foreach (Category category in GetCategoriesFromCurrentUser())
            {
                foreach (PasswordStrengthColor color in Enum.GetValues(typeof(PasswordStrengthColor)))
                {
                    report.Add(new passwordReportByCategoryAndColor
                    {
                        Category = category,
                        Color = color,
                        Quantity = this.GetPasswords().Count(pass => pass.Category == category && pass.PasswordStrength == color)
                    }
                    );
                }
            }
            return report;
        }

        public List<passwordReportByColor> GetPasswordReportByColor()
        {
            List<passwordReportByColor> report = new List<passwordReportByColor>();
            foreach (PasswordStrengthColor color in Enum.GetValues(typeof(PasswordStrengthColor)))
            {
                report.Add(new passwordReportByColor
                {
                    Color = color,
                    Quantity = this.GetPasswords().Count(pass => pass.PasswordStrength == color)
                }
                );
            }
            return report;
        }

        public List<Password> GetPasswordsByColor(PasswordStrengthColor color)
        {
            List<Password> passwords = this.GetPasswords().FindAll(pass => pass.PasswordStrength == color);
            return passwords;
        }



        public void CreateCreditCard(CreditCard creditCard)
        {
            this._creditCards.Add(creditCard);
        }

        public List<CreditCard> GetCreditCards()
        {
            return this._creditCards.Where(card => card.User.Equals(CurrentUser)).ToList();
        }

        public void DeleteCreditCard(CreditCard card)
        {
            this._creditCards.Remove(card);
        }

        public void ModifyCreditCardOnCurrentUser(CreditCard oldCreditCard, CreditCard newCreditCard)
        {
            foreach (CreditCard creditCardIterator in this.GetCreditCards())
            {
                if (creditCardIterator.Equals(oldCreditCard))
                {
                    creditCardIterator.Category = newCreditCard.Category;
                    creditCardIterator.Notes = newCreditCard.Notes;
                    creditCardIterator.Name = newCreditCard.Name;
                    creditCardIterator.Number = newCreditCard.Number;
                    creditCardIterator.SecureCode = newCreditCard.SecureCode;
                    creditCardIterator.ExpirationDate = newCreditCard.ExpirationDate;
                    creditCardIterator.Type = newCreditCard.Type;
                }
            }
        }


        public List<Item> GetBreachedItems(string dataBreach)
        {
            List<Item> breachedItems = new List<Item>();
            string[] splittedDataBreach = dataBreach.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            for (int i = 0; i < splittedDataBreach.Length; i++)
            {
                foreach (Password pass in _passwords)
                    //Redefinir equals de user
                    if (pass.Pass == splittedDataBreach[i] && pass.User.Name == CurrentUser.Name)
                        breachedItems.Add(pass);
                foreach (CreditCard card in _creditCards)
                    //aca tmb
                    if (card.Number == splittedDataBreach[i] && card.User.Name == CurrentUser.Name)
                        breachedItems.Add(card);
            }
            return breachedItems;
        }


    }
}