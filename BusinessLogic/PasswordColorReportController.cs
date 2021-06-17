using System.Collections.Generic;
using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Domain;
using DataAccessInterfaces;
using DataAccessFactory;
using BusinessInterfaces;

namespace BusinessLogic
{
    public class PasswordColorReportController : IPasswordColorReportController
    {
        private IDataAccessPassword _passwords;
        private SessionController _sessionController;
        private User _currentUser;

        public PasswordColorReportController()
        {
            _sessionController = SessionController.GetInstance();
            _currentUser = _sessionController.CurrentUser;
            _passwords = FactoryDataAccessInterfaces.CreateDataAccessPassword();
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