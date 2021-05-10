namespace Obligatorio1_DA1.Exceptions
{

    public class CreditCardExpirationDateInvalidMonthException : ValidationException
    {
        public CreditCardExpirationDateInvalidMonthException()
        {
            this.message = "El mes ingresado en la fecha de expiración de la tarjeta es inválido.";
        }
    }
}