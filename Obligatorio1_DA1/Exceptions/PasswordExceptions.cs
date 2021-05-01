using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Exceptions
{
    public class UsernameTooShortException : ValidationException
    {
        public UsernameTooShortException()
        {
            this.message = "El nombre de usuario ingresado es demasiado corto (min. 5 caracteres). ";
        }
    }
    public class UsernameTooLongException : ValidationException
    {
        public UsernameTooLongException()
        {
            this.message = "El nombre de usuario ingresado es demasiado largo (max. 25 caracteres). ";
        }
    }

    public class SiteTooShortException : ValidationException
    {
        public SiteTooShortException()
        {
            this.message = "El sitio es demasiado corto (min. 3 caracteres). ";
        }
    }
    public class SiteTooLongException : ValidationException
    {
        public SiteTooLongException()
        {
            this.message = "El sitio es demasiado largo (max. 25 caracteres). ";
        }
    }


    public class CategoryTooShortException : ValidationException
    {
        public CategoryTooShortException()
        {
            this.message = "La categoria es demasiado corta (min. 3 caracteres). ";
        }
    }
    public class CategoryTooLongException : ValidationException
    {
        public CategoryTooLongException()
        {
            this.message = "La categoria es demasiado larga (max. 15 caracteres). ";
        }
    }
    public class NotesTooLongException : ValidationException
    {
        public NotesTooLongException()
        {
            this.message = "Las notas son demasiado largas (max. 250 caracteres). ";
        }
    }

    public class PasswordSharedWithSameUserException : Exception
    {
        protected string message;
        public override string Message => this.message;

        public PasswordSharedWithSameUserException()
        {
            this.message = "Un usuario no se puede compartir la contraseña a si mismo";
        }
    }
}

