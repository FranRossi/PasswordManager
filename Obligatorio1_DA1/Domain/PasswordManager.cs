using System;
using System.Collections.Generic;
using Obligatorio1_DA1.Utilities;

namespace Obligatorio1_DA1
{
    public class PasswordManager
    {
        private List<User> userList;

        public PasswordManager()
        {
            userList = new List<User>();
        }

        public void createUser(string name, string pass)
        {
            User newUser = new User(name, pass);
            if (userList.Exists(user => user.Name == name))
                throw new ArgumentException("The username is already taken");

            userList.Add(newUser);
        }

        public Boolean login(string name, string pass)
        {
            foreach (User user in userList)
                if (user.Name == name)
                    if (user.Pass == pass)
                        return true;
                    else
                        return false;
            return false;
        }
    }
}