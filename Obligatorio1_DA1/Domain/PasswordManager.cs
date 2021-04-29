using System;
using System.Collections.Generic;
using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;

namespace Obligatorio1_DA1.Domain
{
    public class PasswordManager
    {
        private List<User> _users;
        private List<Password> _passwords;

        public PasswordManager()
        {
            _users = new List<User>();
            _passwords = new List<Password>();
        }

        public void CreateUser(string name, string password)
        {
            User newUser = new User(name, password);
            if (_users.Exists(user => user.Name == name))
                throw new UsernameAlreadyTakenException();

            _users.Add(newUser);
        }

        public Boolean Login(string name, string password)
        {
            foreach (User user in _users)
                if (user.Name == name)
                    if (user.Pass == password)
                        return true;
                    else
                        return false;
            return false;
        }

        public void CreatePassword(Password password)
        {
            this._passwords.Add(password);
        }
    }
}