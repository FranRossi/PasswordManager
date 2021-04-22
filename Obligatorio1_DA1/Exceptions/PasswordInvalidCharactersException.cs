using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Exceptions
{
    public class PasswordInvalidCharactersException : ValidationException
    {
        public PasswordInvalidCharactersException()
        {
            this.message = "La contaseña solo puede contener caracteres alfanumericos y simbolos entre 32 y 16 en ASCII.";
        }
    }
}
