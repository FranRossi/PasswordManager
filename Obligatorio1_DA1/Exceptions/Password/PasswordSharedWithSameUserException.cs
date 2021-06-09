
namespace Obligatorio1_DA1.Exceptions
{
    public class PasswordSharedWithSameUserException : ValidationException
    {
        public PasswordSharedWithSameUserException()
        {
            this.messageToDisplay = "Un usuario no se puede compartir la contraseña a si mismo";
        }
    }
}
