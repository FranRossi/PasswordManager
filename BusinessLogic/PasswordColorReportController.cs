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
        private User _currentUser;

        public PasswordColorReportController()
        {
            _sessionController = SessionController.GetInstance();
            _currentUser = _sessionController.CurrentUser;
            _passwords = new DataAccessPassword();
        }

        public List<PasswordReportByCategoryAndColor> GetPasswordReportByCategoryAndColor()
        {
            List<PasswordReportByCategoryAndColor> report = _passwords.GetPasswordReportByCategoryAndColor(_currentUser);
            return report;
        }

        public List<PasswordReportByColor> GetPasswordReportByColor()
        {
            List<PasswordReportByColor> report = _passwords.GetPasswordReportByColor(_currentUser);
            return report;
        }

        public List<Password> GetPasswordsByColor(PasswordStrengthColor color)
        {
            List<Password> passwords = _passwords.GetPasswordsByColor(color, _currentUser);
            return passwords;
        }

        public bool PasswordIsNotGreenSecure(Password password)
        {
            PasswordStrengthColor lightGreen = PasswordStrengthColor.LightGreen;
            PasswordStrengthColor darkGreen = PasswordStrengthColor.DarkGreen;
            bool passwordIsNotGreenSecure = password.PasswordStrength != darkGreen && password.PasswordStrength != lightGreen;
            return passwordIsNotGreenSecure;
        }


    }
}