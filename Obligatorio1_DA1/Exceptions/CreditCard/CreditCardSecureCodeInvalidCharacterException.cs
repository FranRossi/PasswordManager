namespace Obligatorio1_DA1.Exceptions
{

    public class CreditCardSecureCodeInvalidCharacterException : ValidationException
    {
        public CreditCardSecureCodeInvalidCharacterException()
        {
            this.message = "El codigo de seguridad de la tarjeta solo puede estar formado por numeros.";
        }
    }
}