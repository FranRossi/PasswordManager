
namespace Obligatorio1_DA1.Exceptions
{
    public class CreditCardTypeTooLongException : ValidationException
    {
        public CreditCardTypeTooLongException()
        {
            this.messageToDisplay = "El tipo seleccionado para la tarjeta es muy corto.";
        }
    }
}