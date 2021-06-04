using System;
using Repository;
using System.Collections.Generic;
using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Domain;
using System.Linq;

namespace BusinessLogic
{
    public class PasswordManager
    {
        public User CurrentUser { get; private set; }
        private List<User> _usersList;
        private List<Password> _passwords;
        private List<CreditCard> _creditCards;

        private DataAccessUser _users;

        public PasswordManager()
        {
            _usersList = new List<User>();
            _passwords = new List<Password>();
            _creditCards = new List<CreditCard>();

            _users = new DataAccessUser();
        }

        public void CreateUser(User newUser)
        {
            ValidateUser(newUser);
            _users.Add(newUser);
            CurrentUser = newUser;
        }

        public void Login(string name, string password)
        {
            User userFromDB = _users.Login(name, password);

            if (userFromDB == null)
                throw new LogInException();

            CurrentUser = userFromDB;
        }

        private void ValidateUser(User newUser)
        {
            if (_usersList.Contains(newUser))
                throw new UsernameAlreadyTakenException();
        }


        public List<Category> GetCategoriesFromCurrentUser()
        {
            return this.CurrentUser.Categories.ToList();
        }

        public void CreateCategoryOnCurrentUser(string category)
        {
            this.CurrentUser.AddOneCategory(category);
        }

        public void ModifyCategoryOnCurrentUser(Category oldCategory, Category newCategory)
        {
            this.CurrentUser.ModifyCategory(oldCategory, newCategory);
        }


        public void CreatePassword(Password password)
        {
            VerifyNonExistenceOfPasswordOnPasswordList(password);
            VerifyPasswordBelongToCurrentUser(password);
            _passwords.Add(password);
        }

        public List<Password> GetPasswords()
        {
            return _passwords.Where(pass => pass.User == CurrentUser).ToList();
        }

        public List<Password> GetSharedPasswordsWithCurrentUser()
        {
            return _passwords.Where(pass => pass.SharedWith.Contains(CurrentUser)).ToList();
        }

        public void DeletePassword(Password password)
        {
            _passwords.Remove(password);
        }

        public void ModifyPasswordOnCurrentUser(Password oldPassword, Password newPassword)
        {
            if (!oldPassword.Equals(newPassword))
                VerifyNonExistenceOfPasswordOnPasswordList(newPassword);

            foreach (Password passwordIterator in this.GetPasswords())
            {
                if (passwordIterator.Equals(oldPassword))
                {
                    VerifyPasswordBelongToCurrentUser(newPassword);
                    passwordIterator.Username = newPassword.Username;
                    passwordIterator.Pass = newPassword.Pass;
                    passwordIterator.Category = newPassword.Category;
                    passwordIterator.Site = newPassword.Site;
                    passwordIterator.Notes = newPassword.Notes;
                    passwordIterator.LastModification = newPassword.LastModification;
                }
            }
        }

        private void VerifyPasswordBelongToCurrentUser(Password newPassword)
        {
            if (!(newPassword.User.Equals(this.CurrentUser)))
                throw new PasswordNotBelongToCurrentUserException();
        }

        private void VerifyNonExistenceOfPasswordOnPasswordList(Password newPassword)
        {
            if (_passwords.Contains(newPassword))
                throw new PasswordAlreadyExistsException();
        }

        public List<PasswordReportByCategoryAndColor> GetPasswordReportByCategoryAndColor()
        {
            List<PasswordReportByCategoryAndColor> report = new List<PasswordReportByCategoryAndColor>();

            foreach (Category category in GetCategoriesFromCurrentUser())
            {
                foreach (PasswordStrengthColor color in Enum.GetValues(typeof(PasswordStrengthColor)))
                {
                    report.Add(new PasswordReportByCategoryAndColor
                    {
                        Category = category,
                        Color = color,
                        Quantity = this.GetPasswords().Count(pass => pass.Category.Equals(category) && pass.PasswordStrength == color)
                    }
                    );
                }
            }
            return report;
        }

        public List<PasswordReportByColor> GetPasswordReportByColor()
        {
            List<PasswordReportByColor> report = new List<PasswordReportByColor>();
            foreach (PasswordStrengthColor color in Enum.GetValues(typeof(PasswordStrengthColor)))
            {
                report.Add(new PasswordReportByColor
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
            List<Password> passwords = this.GetPasswords().FindAll(pass => pass.PasswordStrength == color).ToList();
            return passwords;
        }



        public void CreateCreditCard(CreditCard creditCard)
        {
            VerifyNonExistenceOfCreditCardOnCreditCardList(creditCard);
            VerifyCreditCardBelongToCurrentUser(creditCard);
            _creditCards.Add(creditCard);
        }

        public List<CreditCard> GetCreditCards()
        {
            return _creditCards.Where(card => card.User.Equals(CurrentUser)).ToList();
        }

        public void DeleteCreditCard(CreditCard card)
        {
            _creditCards.Remove(card);
        }




        public List<User> GetUsersPassNotSharedWith(Password password)
        {
            List<User> usersNotShareWith = _usersList.Except(password.SharedWith).ToList();
            usersNotShareWith.Remove(CurrentUser);
            return usersNotShareWith;
        }

        public void ModifyCreditCardOnCurrentUser(CreditCard oldCreditCard, CreditCard newCreditCard)
        {
            if (!oldCreditCard.Equals(newCreditCard))
                VerifyNonExistenceOfCreditCardOnCreditCardList(newCreditCard);

            foreach (CreditCard creditCardIterator in this.GetCreditCards())
            {
                if (creditCardIterator.Equals(oldCreditCard))
                {
                    VerifyCreditCardBelongToCurrentUser(newCreditCard);
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

        private void VerifyCreditCardBelongToCurrentUser(CreditCard newCreditCard)
        {
            if (!(newCreditCard.User.Equals(this.CurrentUser)))
                throw new CreditCardNotBelongToCurrentUserException();
        }

        private void VerifyNonExistenceOfCreditCardOnCreditCardList(CreditCard newCreditCard)
        {
            if (this._creditCards.Contains(newCreditCard))
                throw new CreditCardAlreadyExistsException();
        }

        public List<Item> GetBreachedItems<T>(IDataBreach<T> dataBreach)
        {
            List<Item> breachedItems = new List<Item>();
            string dataBreachString = dataBreach.GetDataBreachString();
            string[] splittedDataBreach = dataBreachString.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            for (int i = 0; i < splittedDataBreach.Length; i++)
            {
                foreach (Password pass in _passwords)
                    if (pass.Pass == splittedDataBreach[i] && pass.User.Equals(CurrentUser))
                        breachedItems.Add(pass);
                foreach (CreditCard card in _creditCards)
                    if (card.Number == splittedDataBreach[i] && card.User.Equals(CurrentUser))
                        breachedItems.Add(card);
            }
            return breachedItems;
        }

        public void SharePassword(Password passwordToShare, User userShareTo)
        {
            passwordToShare.ShareWithUser(userShareTo);
        }

        public void UnSharePassword(Password passwordToShare, User userUnshareTo)
        {
            passwordToShare.UnShareWithUser(userUnshareTo);
        }

        public List<User> GetUsersSharedWith(Password pass)
        {
            return pass.SharedWith.ToList();
        }
    }
}