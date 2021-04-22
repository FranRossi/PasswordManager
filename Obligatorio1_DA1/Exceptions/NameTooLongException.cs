using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Exceptions
{
    public class NameTooLongException : ValidationException
    {
        public NameTooLongException()
        {
            this.message = "El nomber ingresado es demasiado largo (max. 25 caracteres)";
        }
    }
}
