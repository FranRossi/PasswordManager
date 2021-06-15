using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessCategory
{
    public interface IDataAccessPassword<Password> : IDataAccessItem<Password>
    {

        bool CheckPasswordNotSharedTwice(Password newPassword, User userShareTo);
        bool CheckTextIsDuplicate(Password password, User currentUser);
        List<Password> GetSharedPasswordsWithCurrentUser(User currentUser);
        List<Password> GetPasswordsByColor(PasswordStrengthColor passColor, User currentUser);
        List<PasswordReportByColor> GetPasswordReportByColor(User currentUser);
        List<PasswordReportByCategoryAndColor> GetPasswordReportByCategoryAndColor(User currentUser);
    }
}

