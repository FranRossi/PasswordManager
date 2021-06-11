
namespace Obligatorio1_DA1.Exceptions
{
    public class EncryptionException : ValidationException
    {
        public EncryptionException()
        {
            this.messageToDisplay = "Clave o texto a encriptar no validos. ";
        }
    }
}
