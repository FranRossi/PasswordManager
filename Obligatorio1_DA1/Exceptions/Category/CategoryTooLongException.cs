
namespace Obligatorio1_DA1.Exceptions
{
    public class CategoryTooLongException : ValidationException
    {
        public CategoryTooLongException()
        {
            this.message = "La categoria es demasiado larga (max. 15 caracteres). ";
        }
    }
}
