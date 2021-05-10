namespace Obligatorio1_DA1.Exceptions
{

    public class CreditCardExpirationDateInvalidFormatException : ValidationException
    {
        public CreditCardExpirationDateInvalidFormatException()
        {
            this.message = "El formato de la fecha de expiración de la tarjeta es inválido, debería ser mes/año. (Ejemplo: 05/22).";
        }
    }
}