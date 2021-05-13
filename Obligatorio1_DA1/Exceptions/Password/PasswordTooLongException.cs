
namespace Obligatorio1_DA1.Exceptions
{
    public class PasswordTooLongException : ValidationException
    {
        public PasswordTooLongException()
        {
            this.message = "La contaseña ingresada es demasiado larga (max. 25 caracteres)";
        }
    }
}
