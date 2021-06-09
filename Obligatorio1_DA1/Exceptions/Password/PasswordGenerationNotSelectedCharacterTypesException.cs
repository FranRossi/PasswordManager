
namespace Obligatorio1_DA1.Exceptions
{
    public class PasswordGenerationNotSelectedCharacterTypesException : ValidationException
    {
        public PasswordGenerationNotSelectedCharacterTypesException()
        {
            this.messageToDisplay = "Debe seleccionar al menos un tipo de caracteres para incluir en su contraseñas.";
        }
    }
}
