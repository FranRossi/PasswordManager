using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Exceptions
{
    public class PasswordTooShortException : ValidationException
    {
        private string message;
        public override string Message => this.message;

        public PasswordTooShortException()
        {
            this.message = "La contaseña ingresada es demasiado corta (min. 5 caracteres).";
        }
    }
}
