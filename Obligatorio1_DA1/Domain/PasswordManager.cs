using System;

namespace Obligatorio1_DA1
{
    public class PasswordManager
    {
        public void createUser(string name, string pass)
        {
            if (pass.Length < 5)
                throw new ArgumentException("The password is too short (min. 5 characters).");
        }
    }
}