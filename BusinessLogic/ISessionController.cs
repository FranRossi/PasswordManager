using System;
using Repository;
using System.Collections.Generic;
using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Domain;
using System.Linq;

namespace BusinessLogic
{
    public interface ISessionController
    {
        User CurrentUser { get; }

        void CreateUser(User newUser);

        void Login(string name, string password);

        string GetCurrentUserMasterName();
    }
}