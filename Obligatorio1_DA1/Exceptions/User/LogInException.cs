
namespace Obligatorio1_DA1.Exceptions
{
    public class LogInException : ValidationException
    {
        public LogInException()
        {
            this.messageToDisplay = "El nombre usuario o contraseña son incorrectos.";
        }
    }
}
