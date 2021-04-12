using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
            if (pass.Length < 5)
                throw new ArgumentException("The password is too short (min. 5 characters).");
            else if (pass.Length > 25)
                throw new ArgumentException("The password is too long (max. 25 characters).");
            Regex regex = new Regex(@"^[ -~]+$", RegexOptions.Compiled);
            if (!regex.IsMatch(pass))
                throw new ArgumentException("The password contains invalid characters (32-126 in ascii).");
            if (userList.Exists(user => user.Name == name))
                throw new ArgumentException("The username is already taken");

            User newUser = new User(name, pass);
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