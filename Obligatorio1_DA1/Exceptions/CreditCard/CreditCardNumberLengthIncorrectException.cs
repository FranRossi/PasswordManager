
namespace Obligatorio1_DA1.Exceptions
{
    public class CreditCardNumberLengthIncorrectException : ValidationException
    {
        public CreditCardNumberLengthIncorrectException()
        {
            this.message = "El número ingresado tiene que ser de 16 números.";
        }
    }
}
