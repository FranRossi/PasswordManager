
namespace Obligatorio1_DA1.Exceptions
{
    public class CreditCardNameTooShortException : ValidationException
    {
        public CreditCardNameTooShortException()
        {
            this.message = "El nombre seleccionado para la tarjeta es muy corto.";
        }
    }
}