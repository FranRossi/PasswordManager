using System.Collections.Generic;
using Obligatorio1_DA1.Domain;

namespace BusinessInterfaces
{
    public interface IPasswordController
    {
        void CreatePassword(Password newPassword);

        void VerifyPassword(Password passwordToCheck);

        List<Password> GetPasswords();

        void DeletePassword(Password password);

        void ModifyPasswordOnCurrentUser(Password newPassword);

        bool PasswordTextIsDuplicate(Password password);
    }
}