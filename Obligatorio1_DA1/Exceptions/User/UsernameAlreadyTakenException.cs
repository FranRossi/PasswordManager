
namespace Obligatorio1_DA1.Exceptions
{
    public class UsernameAlreadyTakenException : ValidationException
    {
        public UsernameAlreadyTakenException()
        {
            this.messageToDisplay = "El usuario ingresado ya esta en uso.";
        }
    }
}
