namespace Obligatorio1_DA1.Exceptions
{

    public class CreditCardNotBelongToCurrentUserException : ValidationException
    {
        public CreditCardNotBelongToCurrentUserException()
        {
            this.message = "Esta tarjeta de crédito/débito no pertenece al Usuario que esta logeado";
        }
    }
}