
namespace Obligatorio1_DA1.Exceptions
{
    public class CreditCardSecureCodeWrongSizeException : ValidationException
    {
        public CreditCardSecureCodeWrongSizeException()
        {
            this.messageToDisplay = "El código de la tarjeta debe ser de 3 dígitos.";
        }
    }
}