namespace Obligatorio1_DA1.Exceptions
{

    public class CreditCardNumberIncorrectLengthException : ValidationException
    {
        public CreditCardNumberIncorrectLengthException()
        {
            this.message = "El número ingresado tiene que ser de 16 números.";
        }
    }
}