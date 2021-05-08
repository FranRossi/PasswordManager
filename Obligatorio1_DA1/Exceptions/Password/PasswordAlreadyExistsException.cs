

namespace Obligatorio1_DA1.Exceptions
{
    public class PasswordAlreadyExistsException : ValidationException
    {
        public PasswordAlreadyExistsException()
        {
            this.message = "La contraseña ya existe en el sistema.";
        }
    }
}