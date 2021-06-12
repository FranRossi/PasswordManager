using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IDataAccessPassword<Password> : IDataAccessItem<Password>
    {

        bool CheckPasswordNotSharedTwice(Password newPassword, User userShareTo);

        List<Password> GetSharedPasswordsWithCurrentUser(User currentUser);

        List<Password> GetPasswordsByColor(PasswordStrengthColor passColor);

        List<PasswordReportByColor> GetPasswordReportByColor();

        List<PasswordReportByCategoryAndColor> GetPasswordReportByCategoryAndColor();

        bool CheckTextIsDuplicate(Password password, User currentUser);
    }
}

