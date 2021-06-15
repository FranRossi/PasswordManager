using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Utilities;
using System.Collections.Generic;

namespace DataAccessInterfaces
{
    public interface IDataAccessPassword : IDataAccessItem<Password>
    {

        bool CheckPasswordNotSharedTwice(Password newPassword, User userShareTo);
        bool CheckTextIsDuplicate(Password password, User currentUser);
        List<Password> GetSharedPasswordsWithCurrentUser(User currentUser);
        List<Password> GetPasswordsByColor(PasswordStrengthColor passColor, User currentUser);
        List<PasswordReportByColor> GetPasswordReportByColor(User currentUser);
        List<PasswordReportByCategoryAndColor> GetPasswordReportByCategoryAndColor(User currentUser);
    }
}

