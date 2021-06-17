
namespace Obligatorio1_DA1.Exceptions
{
    public class CategoryTooShortException : ValidationException
    {
        public CategoryTooShortException()
        {
            this.messageToDisplay = "La categoria es demasiado corta (min. 3 caracteres). ";
        }
    }
}
