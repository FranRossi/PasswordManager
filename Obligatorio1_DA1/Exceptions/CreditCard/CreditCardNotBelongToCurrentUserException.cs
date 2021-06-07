
namespace Obligatorio1_DA1.Exceptions
{
    public class CreditCardNotBelongToCurrentUserException : ValidationException
    {
        public CreditCardNotBelongToCurrentUserException()
        {
            this.messageToDisplay = "Esta tarjeta no pertenece al usuario que esta logeado";
        }
    }
}