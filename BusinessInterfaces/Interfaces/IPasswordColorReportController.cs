using Obligatorio1_DA1.Domain;
using System.Collections.Generic;
using Obligatorio1_DA1.Utilities;

namespace BusinessInterfaces
{
    public interface IPasswordColorReportController
    {
        List<PasswordReportByCategoryAndColor> GetPasswordReportByCategoryAndColor();

        List<PasswordReportByColor> GetPasswordReportByColor();

        List<Password> GetPasswordsByColor(PasswordStrengthColor color);

        bool PasswordIsNotGreenSecure(Password password);

    }
}