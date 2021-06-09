
namespace Obligatorio1_DA1.Exceptions
{
    public class ItemInvalidCategoryException : ValidationException
    {
        public ItemInvalidCategoryException()
        {
            this.messageToDisplay = "El usuario no tiene la categoria seleccionada para la contraseña.";
        }
    }
}
