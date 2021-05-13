
namespace Obligatorio1_DA1.Exceptions
{
    public class CreditCardNameTooLongException : ValidationException
    {
        public CreditCardNameTooLongException()
        {
            this.message = "El nombre seleccionado para la tarjeta es muy largo.";
        }
    }
}