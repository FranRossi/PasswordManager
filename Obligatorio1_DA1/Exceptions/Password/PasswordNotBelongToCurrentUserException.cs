
namespace Obligatorio1_DA1.Exceptions
{
    public class PasswordNotBelongToCurrentUserException : ValidationException
    {
        public PasswordNotBelongToCurrentUserException()
        {
            this.message = "Esta contraseña no pertenece al Usuario que esta logeado sesión";
        }
    }
}