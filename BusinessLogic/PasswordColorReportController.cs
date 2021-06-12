using System;
using Repository;
using System.Collections.Generic;
using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Domain;
using System.Linq;

namespace BusinessLogic
{
    public class PasswordColorReportController
    {
        private IDataAccessPassword<Password> _passwords;

        public PasswordColorReportController()
        {
            _passwords = new DataAccessPassword();
        }

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


    }
}