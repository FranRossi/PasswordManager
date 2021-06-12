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
        private SessionController _sessionController;

        public PasswordColorReportController()
        {
            _sessionController = SessionController.GetInstance();
            _passwords = new DataAccessPassword();
        }

        public List<PasswordReportByCategoryAndColor> GetPasswordReportByCategoryAndColor()
        {
            List<PasswordReportByCategoryAndColor> report = _passwords.GetPasswordReportByCategoryAndColor();
            return report;
        }

        public List<PasswordReportByColor> GetPasswordReportByColor()
        {
            User currentUser = _sessionController.CurrentUser;
            List<PasswordReportByColor> report = _passwords.GetPasswordReportByColor(currentUser);
            return report;
        }

        public List<Password> GetPasswordsByColor(PasswordStrengthColor color)
        {
            User currentUser = _sessionController.CurrentUser;
            List<Password> passwords = _passwords.GetPasswordsByColor(color, currentUser);
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