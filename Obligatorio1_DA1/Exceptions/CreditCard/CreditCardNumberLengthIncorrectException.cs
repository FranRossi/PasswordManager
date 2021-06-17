
namespace Obligatorio1_DA1.Exceptions
{
    public class CreditCardNumberLengthIncorrectException : ValidationException
    {
        public CreditCardNumberLengthIncorrectException()
        {
            this.messageToDisplay = "El número ingresado tiene que ser de 16 números.";
        }
    }
}
