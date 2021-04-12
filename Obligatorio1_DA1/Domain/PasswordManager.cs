using System;
using System.Text.RegularExpressions;

namespace Obligatorio1_DA1
{
    public class PasswordManager
    {
        public void createUser(string name, string pass)
        {
            if (pass.Length < 5)
                throw new ArgumentException("The password is too short (min. 5 characters).");
            else if (pass.Length > 25)
                throw new ArgumentException("The password is too long (max. 25 characters).");
            Regex regex = new Regex(@"^[ -~]+$", RegexOptions.Compiled);
            if (!regex.IsMatch(pass))
                throw new ArgumentException("The password contains invalid characters (32-126 in ascii).");
        }
    }
}