using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Exceptions
{
    public class NameTooShortException : ValidationException
    {
        private string message;
        public override string Message => this.message;

        public NameTooShortException()
        {
            this.message = "El nombre ingresado es demasiado corto (min. 5 caracteres).";
        }
    }
}
