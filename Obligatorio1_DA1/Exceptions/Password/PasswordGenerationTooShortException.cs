
namespace Obligatorio1_DA1.Exceptions
{
    public class PasswordGenerationTooShortException : ValidationException
    {
        public PasswordGenerationTooShortException()
        {
            this.messageToDisplay = "La contaseña que desea generar es demasiado corta (min. 5 caracteres).";
        }
    }
}
