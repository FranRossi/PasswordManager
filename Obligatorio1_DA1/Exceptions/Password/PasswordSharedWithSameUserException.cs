
namespace Obligatorio1_DA1.Exceptions
{
    public class PasswordSharedWithSameUserException : ValidationException
    {
        public PasswordSharedWithSameUserException()
        {
            this.message = "Un usuario no se puede compartir la contraseña a si mismo";
        }
    }
}
