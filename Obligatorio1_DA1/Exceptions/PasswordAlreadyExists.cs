

namespace Obligatorio1_DA1.Exceptions
{
    public class PasswordAlreadyExists : ValidationException
    {
        public PasswordAlreadyExists()
        {
            this.message = "La contraseña ya existe en el sistema.";
        }
    }
}