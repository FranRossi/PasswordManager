namespace Obligatorio1_DA1.Exceptions
{

    public class CreditCardAlreadyExistsException : ValidationException
    {
        public CreditCardAlreadyExistsException()
        {
            this.message = "La tarjeta ya existe en el sistema.";
        }
    }
}