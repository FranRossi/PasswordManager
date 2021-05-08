using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Exceptions
{
    public class PasswordSiteTooShortException : ValidationException
    {
        public PasswordSiteTooShortException()
        {
            this.message = "El sitio es demasiado corto (min. 3 caracteres). ";
        }
    }
}
