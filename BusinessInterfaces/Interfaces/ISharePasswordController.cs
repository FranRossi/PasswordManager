using System.Collections.Generic;
using Obligatorio1_DA1.Domain;

namespace BusinessInterfaces
{
    public interface ISharePasswordController
    {
        void SharePassword(Password passwordToShare, User userShareTo);

        void UnSharePassword(Password passwordToShare, User userUnshareTo);

        List<User> GetUsersSharedWith(Password password);

        List<User> GetUsersPassNotSharedWith(Password password);

        List<Password> GetSharedPasswordsWithCurrentUser();
    }
}