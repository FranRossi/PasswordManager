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
        private List<Password> _passwordsList;
        private List<CreditCard> _creditCardsList;

        private DataAccessUser _users;
        private DataAccessCategory _categories;
        private DataAccessCreditCard _creditCards;
        private DataAccessPassword _passwords;

        public PasswordManager()
        {
            _usersList = new List<User>();
            _passwordsList = new List<Password>();
            _creditCardsList = new List<CreditCard>();

            _users = new DataAccessUser();
            _categories = new DataAccessCategory();
            _creditCards = new DataAccessCreditCard();
            _passwords = new DataAccessPassword();
        }

        public void CreateUser(User newUser)
        {
            if (_users.CheckUniqueness(newUser))
                _users.Add(newUser);
            else
                throw new UsernameAlreadyTakenException();

            CurrentUser = newUser;
        }

        public void Login(string name, string password)
        {
            User userFromDB = _users.Login(name, password);

            if (userFromDB == null)
                throw new LogInException();

            CurrentUser = userFromDB;
        }


        public List<Category> GetCategoriesFromCurrentUser()
        {
            return _categories.GetAll(this.CurrentUser.MasterName).ToList();
        }

        public void CreateCategoryOnCurrentUser(string category)
        {
            Category newCategory = new Category
            {
                Name = category,
                User = CurrentUser
            };
            if (_categories.CheckUniqueness(newCategory))
                _categories.Add(newCategory);
            else
                throw new CategoryAlreadyAddedException();
        }

        public void ModifyCategoryOnCurrentUser(Category modifiedCategory)
        {
            _categories.Modify(modifiedCategory);
        }


        public void CreatePassword(Password newPassword)
        {
            VerifyPasswordBelongToCurrentUser(newPassword);
            VerifyPasswordUniqueness(newPassword);
            VerifyItemCategoryBelongsToUser(newPassword);
            _passwords.Add(newPassword);
        }

        public List<Password> GetPasswords()
        {
            string currentUserMasterName = CurrentUser.MasterName;
            return _passwords.GetAll(currentUserMasterName).ToList();
        }

        public List<Password> GetSharedPasswordsWithCurrentUser()
        {
            return _passwordsList.Where(pass => pass.SharedWith.Contains(CurrentUser)).ToList();
        }

        public void DeletePassword(Password password)
        {
            _passwords.Delete(password);
        }

        public void ModifyPasswordOnCurrentUser(Password newPassword)
        {
            VerifyPasswordBelongToCurrentUser(newPassword);
            VerifyPasswordUniqueness(newPassword);
            VerifyItemCategoryBelongsToUser(newPassword);
            _passwords.Modify(newPassword);
        }

        private void VerifyPasswordBelongToCurrentUser(Password newPassword)
        {
            if (!(newPassword.User.Equals(this.CurrentUser)))
                throw new PasswordNotBelongToCurrentUserException();
        }

        private void VerifyPasswordUniqueness(Password newPassword)
        {
            if (!_passwords.CheckUniqueness(newPassword))
                throw new PasswordAlreadyExistsException();
        }

        private void VerifyItemCategoryBelongsToUser(Item newItem)
        {
            bool categoryBelongsToUser = _categories.CategoryBelongsToUser(newItem.Category, newItem.User);
            if (!categoryBelongsToUser)
                throw new ItemInvalidCategoryException();
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

      

        public void CreateCreditCard(CreditCard newCreditCard)
        {
            VerifyCreditCardBelongToCurrentUser(newCreditCard);
            VerifyCreditCardUniqueness(newCreditCard);
            VerifyItemCategoryBelongsToUser(newCreditCard);
            _creditCards.Add(newCreditCard);
        }

        private void VerifyCreditCardUniqueness(CreditCard newCreditCard)
        {
            if (!_creditCards.CheckUniqueness(newCreditCard))
                throw new CreditCardAlreadyExistsException();
        }

        public List<CreditCard> GetCreditCards()
        {
            string currentUserMasterName = CurrentUser.MasterName;
            return _creditCards.GetAll(currentUserMasterName).ToList();
        }

        public void ModifyCreditCardOnCurrentUser(CreditCard newCreditCard)
        {
            VerifyCreditCardBelongToCurrentUser(newCreditCard);
            VerifyCreditCardUniqueness(newCreditCard);
            VerifyItemCategoryBelongsToUser(newCreditCard);
            _creditCards.Modify(newCreditCard);
        }

        public void DeleteCreditCard(CreditCard card)
        {
            _creditCards.Delete(card);
        }




        public List<User> GetUsersPassNotSharedWith(Password password)
        {
            List<User> usersNotShareWith = _usersList.Except(password.SharedWith).ToList();
            usersNotShareWith.Remove(CurrentUser);
            return usersNotShareWith;
        }


        private void VerifyCreditCardBelongToCurrentUser(CreditCard newCreditCard)
        {
            if (!(newCreditCard.User.Equals(this.CurrentUser)))
                throw new CreditCardNotBelongToCurrentUserException();
        }

        private void VerifyNonExistenceOfCreditCardOnCreditCardList(CreditCard newCreditCard)
        {
            //TODO SACAR
            if (this._creditCardsList.Contains(newCreditCard))
                throw new CreditCardAlreadyExistsException();
        }

        public List<Item> GetBreachedItems<T>(IDataBreach<T> dataBreach)
        {
            List<Item> breachedItems = new List<Item>();
            string dataBreachString = dataBreach.GetDataBreachString();
            string[] splittedDataBreach = dataBreachString.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            for (int i = 0; i < splittedDataBreach.Length; i++)
            {
                foreach (Password pass in _passwordsList)
                    if (pass.Pass == splittedDataBreach[i] && pass.User.Equals(CurrentUser))
                        breachedItems.Add(pass);
                foreach (CreditCard card in _creditCardsList)
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