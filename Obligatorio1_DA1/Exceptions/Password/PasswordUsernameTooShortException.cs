﻿
namespace Obligatorio1_DA1.Exceptions
{
    public class PasswordUsernameTooShortException : ValidationException
    {
        public PasswordUsernameTooShortException()
        {
            this.messageToDisplay = "El nombre de usuario ingresado es demasiado corto (min. 5 caracteres). ";
        }
    }
}
