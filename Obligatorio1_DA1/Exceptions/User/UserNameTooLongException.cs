
namespace Obligatorio1_DA1.Exceptions
{
    public class UserNameTooLongException : ValidationException
    {
        public UserNameTooLongException()
        {
            this.messageToDisplay = "El nomber ingresado es demasiado largo (max. 25 caracteres)";
        }
    }
}
