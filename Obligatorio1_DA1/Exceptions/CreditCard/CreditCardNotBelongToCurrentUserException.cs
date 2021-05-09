namespace Obligatorio1_DA1.Exceptions
{

    public class CreditCardNotBelongToCurrentUserException : ValidationException
    {
        public CreditCardNotBelongToCurrentUserException()
        {
            this.message = "Esta tarjeta de crédito no pertenece al usuario que esta logeado";
        }
    }
}