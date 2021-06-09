
namespace Obligatorio1_DA1.Exceptions
{
    public class CategoryTooLongException : ValidationException
    {
        public CategoryTooLongException()
        {
            this.messageToDisplay = "La categoria es demasiado larga (max. 15 caracteres). ";
        }
    }
}
