
namespace Obligatorio1_DA1.Exceptions
{
    public class CreditCardSecureCodeInvalidCharactersException : ValidationException
    {
        public CreditCardSecureCodeInvalidCharactersException()
        {
            this.message = "El codigo de seguridad de la tarjeta solo puede estar formado por numeros.";
        }
    }
}