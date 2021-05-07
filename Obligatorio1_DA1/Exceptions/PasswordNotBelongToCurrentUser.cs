namespace Obligatorio1_DA1.Exceptions
{
    public class PasswordNotBelongToCurrentUser : ValidationException
    {
        public PasswordNotBelongToCurrentUser()
        {
            this.message = "Esta contraseña no pertenece al Usuario que esta logeado";
        }
    }
}