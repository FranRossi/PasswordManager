using System.Collections.Generic;
using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Domain;
using DataAccessInterfaces;
using DataAccessFactory;
using BusinessInterfaces;

namespace BusinessLogic
{
    public class SharePasswordController : ISharePasswordController
    {
        private ISessionController _sessionController;
        private IDataAccessUser _users;
        private IDataAccessPassword<Password> _passwords;

        public SharePasswordController()
        {
            _users = FactoryDataAccessInterfaces.CreateDataAccessUser();
            _passwords = FactoryDataAccessInterfaces.CreateDataAccessPassword();
            _sessionController = SessionController.GetInstance();
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