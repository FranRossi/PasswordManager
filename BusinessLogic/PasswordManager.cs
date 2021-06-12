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
        private SessionController _sessionController;
        private CategoryController _categoryController;
        private IDataAccessUser _users;
        private IDataAccessCreditCard<CreditCard> _creditCards;
        private IDataAccessPassword<Password> _passwords;
        private IDataAccessDataBreach _dataBreaches;

        public PasswordManager()
        {
            _users = new DataAccessUser();
            _creditCards = new DataAccessCreditCard();
            _passwords = new DataAccessPassword();
            _dataBreaches = new DataAccessDataBreach();
            _sessionController = SessionController.GetInstance();
            _categoryController = new CategoryController();
        }

        //-------------------------------------------------PASSWORD COLOR REPORT CONTROLLER--------------------------------------------------

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

        public bool PasswordIsNotGreenSecure(Password password)
        {
            PasswordStrengthColor lightGreen = PasswordStrengthColor.LightGreen;
            PasswordStrengthColor darkGreen = PasswordStrengthColor.DarkGreen;
            return password.PasswordStrength != lightGreen && password.PasswordStrength != darkGreen;
        }


        //----------------------------------------------------CREDIT CARD CONTROLLER---------------------------------------
        public void CreateCreditCard(CreditCard newCreditCard)
        {
            VerifyCreditCardBelongToCurrentUser(newCreditCard);
            VerifyCreditCardUniqueness(newCreditCard);
            _categoryController.VerifyItemCategoryBelongsToUser(newCreditCard);
            _creditCards.Add(newCreditCard);
        }

        private void VerifyCreditCardUniqueness(CreditCard newCreditCard)
        {
            if (!_creditCards.CheckUniqueness(newCreditCard))
                throw new CreditCardAlreadyExistsException();
        }

        public List<CreditCard> GetCreditCards()
        {
            string currentUserMasterName = _sessionController.GetCurrentUserMasterName();
            return _creditCards.GetAll(currentUserMasterName).ToList();
        }

        public void ModifyCreditCardOnCurrentUser(CreditCard newCreditCard)
        {
            VerifyCreditCardBelongToCurrentUser(newCreditCard);
            VerifyCreditCardUniqueness(newCreditCard);
            _categoryController.VerifyItemCategoryBelongsToUser(newCreditCard);
            _creditCards.Modify(newCreditCard);
        }

        public void DeleteCreditCard(CreditCard card)
        {
            _creditCards.Delete(card);
        }

        private void VerifyCreditCardBelongToCurrentUser(CreditCard newCreditCard)
        {
            if (!(newCreditCard.User.Equals(_sessionController.CurrentUser)))
                throw new CreditCardNotBelongToCurrentUserException();
        }


        //--------------------------------------------DATA BREACH CONTROLLER----------------------------------------------------------------
        public List<Item> SaveBreachedItems(DataBreachReport dataBreachReport)
        {
            //TODO VER SI HACER VOID Y CARGAR DATABREACH
            List<Item> breachedItems = _dataBreaches.AddDataBreachReport(dataBreachReport);
            return breachedItems;
        }

        public List<DataBreachReport> GetDataBreachReportsFromCurrentUser()
        {
            List<DataBreachReport> reports = _dataBreaches.GetDataBreachReportsFromUser(_sessionController.GetCurrentUserMasterName());
            return reports;
        }

        public bool VerifyPasswordHasBeenBreached(Password passwordToCheck)
        {
            bool passwordIsBreached = _dataBreaches.CheckIfPasswordHasBeenBreached(_sessionController.CurrentUser, passwordToCheck);
            return passwordIsBreached;
        }


        //-------------------------------------------------------SHARE PASSWORD CONTROLLER------------------------------------------------
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

        public List<User> GetUsersPassNotSharedWith(Password password)
        {
            List<User> usersNotSharedWith = _users.GetUsersPassNotSharedWith(password);
            return usersNotSharedWith;
        }

        public List<Password> GetSharedPasswordsWithCurrentUser()
        {
            List<Password> passwordsSharedWithMe = _passwords.GetSharedPasswordsWithCurrentUser(_sessionController.CurrentUser);
            return passwordsSharedWithMe;
        }
    }
}