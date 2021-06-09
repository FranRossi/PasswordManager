
namespace Obligatorio1_DA1.Exceptions
{
    public class UserNameTooShortException : ValidationException
    {
        public UserNameTooShortException()
        {
            this.messageToDisplay = "El nombre ingresado es demasiado corto (min. 5 caracteres).";
        }
    }
}
