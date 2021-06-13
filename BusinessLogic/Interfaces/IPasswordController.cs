using System;
using Repository;
using System.Collections.Generic;
using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Domain;
using System.Linq;

namespace BusinessLogic
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