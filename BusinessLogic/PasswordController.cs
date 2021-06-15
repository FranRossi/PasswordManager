using System.Collections.Generic;
using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Domain;
using System.Linq;
using DataAccessInterfaces;
using FactoryDataAccess;

namespace BusinessLogic
{
    public class PasswordController : IPasswordController
    {
        private SessionController _sessionController;
        private CategoryController _categoryController;
        private IDataAccessPassword<Password> _passwords;

        public PasswordController()
        {
            _passwords = FactoryDataAccessInterfaces.CreateDataAccessPassword();
            _sessionController = SessionController.GetInstance();
            _categoryController = new CategoryController();
        }

        public void CreatePassword(Password newPassword)
        {
            VerifyPassword(newPassword);
            _passwords.Add(newPassword);
        }

        public void VerifyPassword(Password passwordToCheck)
        {
            VerifyPasswordBelongToCurrentUser(passwordToCheck);
            VerifyPasswordUniqueness(passwordToCheck);
            _categoryController.VerifyItemCategoryBelongsToUser(passwordToCheck);
        }

        public List<Password> GetPasswords()
        {
            string currentUserMasterName = _sessionController.GetCurrentUserMasterName();
            List<Password> passwordsFromDB = _passwords.GetAll(currentUserMasterName).ToList();
            AddPasswordKeyToPasswords(passwordsFromDB);
            return passwordsFromDB;
        }

        private void AddPasswordKeyToPasswords(List<Password> passwords)
        {
            passwords.ForEach(password => password.User.DecryptionKey = _sessionController.CurrentUser.DecryptionKey);
        }

        public void DeletePassword(Password password)
        {
            _passwords.Delete(password);
        }

        public void ModifyPasswordOnCurrentUser(Password newPassword)
        {
            VerifyPassword(newPassword);
            _passwords.Modify(newPassword);
        }

        private void VerifyPasswordBelongToCurrentUser(Password newPassword)
        {
            if (!(newPassword.User.Equals(_sessionController.CurrentUser)))
                throw new PasswordNotBelongToCurrentUserException();
        }

        private void VerifyPasswordUniqueness(Password newPassword)
        {
            if (!_passwords.CheckUniqueness(newPassword))
                throw new PasswordAlreadyExistsException();
        }

        public bool PasswordTextIsDuplicate(Password password)
        {
            bool passTextIsDuplicate = _passwords.CheckTextIsDuplicate(password, _sessionController.CurrentUser);
            return passTextIsDuplicate;
        }



    }
}