
namespace Obligatorio1_DA1.Exceptions
{
    public class ItemInvalidCategoryException : ValidationException
    {
        public ItemInvalidCategoryException()
        {
            this.message = "El usuario no tiene la categoria seleccionada para la contraseña.";
        }
    }
}
