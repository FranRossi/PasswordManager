
namespace Obligatorio1_DA1.Exceptions
{
    public class CreditCardExpirationDateInvalidMonthException : ValidationException
    {
        public CreditCardExpirationDateInvalidMonthException()
        {
            this.messageToDisplay = "El mes ingresado en la fecha de expiración es inválido.";
        }
    }
}