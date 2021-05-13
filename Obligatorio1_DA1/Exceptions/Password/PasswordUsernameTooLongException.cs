
namespace Obligatorio1_DA1.Exceptions
{
    public class PasswordUsernameTooLongException : ValidationException
    {
        public PasswordUsernameTooLongException()
        {
            this.message = "El nombre de usuario ingresado es demasiado largo (max. 25 caracteres). ";
        }
    }
}
