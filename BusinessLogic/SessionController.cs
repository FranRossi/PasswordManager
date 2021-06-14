using System;
using Repository;
using System.Collections.Generic;
using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Domain;
using System.Linq;

namespace BusinessLogic
{
    public class SessionController : ISessionController
    {
        private static SessionController _instance;
        public static SessionController GetInstance()
        {
            if (_instance == null)
                _instance = new SessionController();
            return _instance;
        }

        public User CurrentUser { get; private set; }

        private IDataAccessUser _users;

        public SessionController()
        {
            _users = new DataAccessUser();
        }

        public void CreateUser(User newUser)
        {
            VerifyUserUniqueness(newUser);
            newUser.ValidatePassword();
            newUser.HashPassword();
            _users.Add(newUser);
            this.CurrentUser = newUser;
        }

        private void VerifyUserUniqueness(User newUser)
        {
            if (!_users.CheckUniqueness(newUser))
                throw new UsernameAlreadyTakenException();
        }

        public void Login(string name, string password)
        {
            User userToLogin = new User
            {
                MasterName = name,
                MasterPass = password
            };
            userToLogin.HashPassword();
            User userFromDB = _users.Login(userToLogin);

            if (userFromDB == null)
                throw new LogInException();

            userFromDB.DecryptionKey = password;
            this.CurrentUser = userFromDB;
        }

        public string GetCurrentUserMasterName()
        {
            return this.CurrentUser.MasterName;
        }
    }
}