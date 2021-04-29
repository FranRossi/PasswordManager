﻿using System;
using System.Collections.Generic;
using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;

namespace Obligatorio1_DA1.Domain
{
    public class PasswordManager
    {
        private List<User> users;
        private List<Password> passwords;

        public PasswordManager()
        {
            users = new List<User>();
            passwords = new List<Password>();
        }

        public void CreateUser(string name, string password)
        {
            User newUser = new User(name, password);
            if (users.Exists(user => user.Name == name))
                throw new UsernameAlreadyTakenException();

            users.Add(newUser);
        }

        public Boolean Login(string name, string password)
        {
            foreach (User user in users)
                if (user.Name == name)
                    if (user.Pass == password)
                        return true;
                    else
                        return false;
            return false;
        }

        public void CreatePassword(Password password)
        {
            this.passwords.Add(password);
        }
    }
}