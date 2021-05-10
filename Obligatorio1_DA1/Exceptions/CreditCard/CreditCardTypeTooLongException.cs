namespace Obligatorio1_DA1.Exceptions
{

    public class CreditCardTypeTooLongException : ValidationException
    {
        public CreditCardTypeTooLongException()
        {
            this.message = "El tipo seleccionado para la tarjeta es muy corto.";
        }
    }
}