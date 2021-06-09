
namespace Obligatorio1_DA1.Exceptions
{
    public class PasswordInvalidCharactersException : ValidationException
    {
        public PasswordInvalidCharactersException()
        {
            this.messageToDisplay = "La contaseña solo puede contener caracteres alfanumericos y simbolos entre 32 y 16 en ASCII.";
        }
    }
}
