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
            VerifyUserUniqueness(newUser);
            _users.Add(newUser);
            CurrentUser = newUser;
        }

        private void VerifyUserUniqueness(User newUser)
        {
            if (!_users.CheckUniqueness(newUser))
                throw new UsernameAlreadyTakenException();
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
            VerifyCategoryUniqueness(newCategory);
            _categories.Add(newCategory);
        }

        private void VerifyCategoryUniqueness(Category newCategory)
        {
            if (!_categories.CheckUniqueness(newCategory))
                throw new CategoryAlreadyAddedException();
        }

        public void ModifyCategoryOnCurrentUser(Category modifiedCategory)
        {
            VerifyCategoryUniqueness(modifiedCategory);
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
            List<Password> passwordsSharedWithMe = _passwords.GetSharedPasswordsWithCurrentUser(CurrentUser);
            return passwordsSharedWithMe;
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
            List<PasswordReportByCategoryAndColor> report = _passwords.GetPasswordReportByCategoryAndColor();
            return report;
        }

        public List<PasswordReportByColor> GetPasswordReportByColor()
        {
            List<PasswordReportByColor> report = _passwords.GetPasswordReportByColor();
            return report;
        }

        public List<Password> GetPasswordsByColor(PasswordStrengthColor color)
        {
            List<Password> passwords = _passwords.GetPasswordsByColor(color);
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
            List<User> usersNotSharedWith = _users.GetUsersPassNotSharedWith(password);
            return usersNotSharedWith;
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

        public List<Item> SaveBreachedItems<T>(DataBreach<T> dataBreach)
        {
            List<Item> breachedItems = new List<Item>();
            HashSet<string> dataBreachItems = dataBreach.DataBreachItems;
            foreach (string dataBreachItem in dataBreachItems)
            {
                foreach (Password pass in _passwordsList)
                    if (pass.Pass == dataBreachItem && pass.User.Equals(CurrentUser))
                        breachedItems.Add(pass);
                foreach (CreditCard card in _creditCardsList)
                    if (card.Number == dataBreachItem && card.User.Equals(CurrentUser))
                        breachedItems.Add(card);
            }
            return breachedItems;
        }

        public void SharePassword(Password passwordToShare, User userShareTo)
        {
            VerifyPasswordNotSharedWithOwner(passwordToShare, userShareTo);
            if (VerifyPasswordNotSharedWithUserTwice(passwordToShare, userShareTo))
                _users.SharePassword(passwordToShare, userShareTo);
        }

        private void VerifyPasswordNotSharedWithOwner(Password passwordToShare, User userShareTo)
        {
            if (passwordToShare.User.Equals(userShareTo))
                throw new PasswordSharedWithSameUserException();
        }

        private bool VerifyPasswordNotSharedWithUserTwice(Password passwordToShare, User userShareTo)
        {
            bool isNotShared = _passwords.CheckPasswordNotSharedTwice(passwordToShare, userShareTo);
            return isNotShared;
        }

        public void UnSharePassword(Password passwordToShare, User userUnshareTo)
        {
            _users.UnSharePassword(passwordToShare, userUnshareTo);
        }

        public List<User> GetUsersSharedWith(Password password)
        {
            List<User> usersSharedWith = _users.GetUsersPassSharedWith(password);
            return usersSharedWith;
        }
    }
}