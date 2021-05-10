namespace Obligatorio1_DA1.Exceptions
{

    public class CreditCardNumberInvalidCharacterException : ValidationException
    {
        public CreditCardNumberInvalidCharacterException()
        {
            this.message = "El número contiene caracteres inválidos. (Solo digitos separados por espacios)";
        }
    }
}