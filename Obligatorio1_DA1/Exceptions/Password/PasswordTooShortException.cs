
namespace Obligatorio1_DA1.Exceptions
{
    public class PasswordTooShortException : ValidationException
    {
        public PasswordTooShortException()
        {
            this.messageToDisplay = "La contaseña ingresada es demasiado corta (min. 5 caracteres).";
        }
    }
}
