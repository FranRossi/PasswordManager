
namespace Obligatorio1_DA1.Exceptions
{
    public class CategoryAlreadyAddedException : ValidationException
    {
        public CategoryAlreadyAddedException()
        {
            this.message = "La categoría que esta intentando agregar ya pertenece a su usuario.";
        }
    }
}
