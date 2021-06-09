
namespace Obligatorio1_DA1.Exceptions
{
    public class PasswordSiteTooLongException : ValidationException
    {
        public PasswordSiteTooLongException()
        {
            this.messageToDisplay = "El sitio es demasiado largo (max. 25 caracteres). ";
        }
    }
}
