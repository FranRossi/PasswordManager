using System;
using Repository;
using System.Collections.Generic;
using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Domain;
using System.Linq;

namespace BusinessLogic
{
    public interface IPasswordColorReportController
    {
        List<PasswordReportByCategoryAndColor> GetPasswordReportByCategoryAndColor();

        List<PasswordReportByColor> GetPasswordReportByColor();

        List<Password> GetPasswordsByColor(PasswordStrengthColor color);

        bool PasswordIsNotGreenSecure(Password password);

    }
}