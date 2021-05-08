namespace Obligatorio1_DA1.Exceptions
{

    public class CreditCardAlreadyExistsException : ValidationException
    {
        public CreditCardAlreadyExistsException()
        {
            this.message = "La tarjeta de crédito/débito ya existe en el sistema.";
        }
    }
}