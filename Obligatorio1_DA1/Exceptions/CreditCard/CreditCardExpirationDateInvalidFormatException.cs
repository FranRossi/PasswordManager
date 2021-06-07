
namespace Obligatorio1_DA1.Exceptions
{
    public class CreditCardExpirationDateInvalidFormatException : ValidationException
    {
        public CreditCardExpirationDateInvalidFormatException()
        {
            this.messageToDisplay = "El formato de fecha de expiración es inválido, debería ser mes/año.";
        }
    }
}