
namespace Obligatorio1_DA1.Exceptions
{
    public class PasswordAlreadyExistsException : ValidationException
    {
        public PasswordAlreadyExistsException()
        {
            this.messageToDisplay = "La contraseña ya existe en el sistema.";
        }
    }
}