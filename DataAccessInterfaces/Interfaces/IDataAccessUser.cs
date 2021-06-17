using Obligatorio1_DA1.Domain;
using System.Collections.Generic;

namespace DataAccessInterfaces
{
    public interface IDataAccessUser
    {
        void Add(User newUser);
        User Login(User userToLogIn);
        bool CheckUniqueness(User newUser);
        List<User> GetUsersPassNotSharedWith(Password password);
        List<User> GetUsersPassSharedWith(Password password);
        void SharePassword(Password passwordToShare, User userShareTo);
        void UnSharePassword(Password passwordToShare, User userShareTo);
    }
}

