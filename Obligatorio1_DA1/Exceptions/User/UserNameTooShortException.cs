using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Exceptions
{
    public class UserNameTooShortException : ValidationException
    {
        public UserNameTooShortException()
        {
            this.message = "El nombre ingresado es demasiado corto (min. 5 caracteres).";
        }
    }
}
