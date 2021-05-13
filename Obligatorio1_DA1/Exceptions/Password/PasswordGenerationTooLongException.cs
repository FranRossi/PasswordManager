
namespace Obligatorio1_DA1.Exceptions
{
    public class PasswordGenerationTooLongException : ValidationException
    {
        public PasswordGenerationTooLongException()
        {
            this.message = "La contaseña que desea generar es demasiado larga (max. 25 caracteres).";
        }
    }
}
