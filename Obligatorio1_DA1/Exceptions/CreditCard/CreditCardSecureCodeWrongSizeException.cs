namespace Obligatorio1_DA1.Exceptions
{

    public class CreditCardSecureCodeWrongSizeException : ValidationException
    {
        public CreditCardSecureCodeWrongSizeException()
        {
            this.message = "El codigo de la tarjeta debe ser de 3 dígitos.";
        }
    }
}