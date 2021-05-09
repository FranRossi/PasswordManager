namespace Obligatorio1_DA1.Exceptions
{

    public class CreditCardTypeTooShortException : ValidationException
    {
        public CreditCardTypeTooShortException()
        {
            this.message = "El tipo seleccionado para la tarjeta es muy corto.";
        }
    }
}