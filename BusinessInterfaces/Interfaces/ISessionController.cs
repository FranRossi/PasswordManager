using Obligatorio1_DA1.Domain;

namespace BusinessInterfaces
{
    public interface ISessionController
    {
        User CurrentUser { get; }

        void CreateUser(User newUser);

        void Login(string name, string password);

        string GetCurrentUserMasterName();
    }
}