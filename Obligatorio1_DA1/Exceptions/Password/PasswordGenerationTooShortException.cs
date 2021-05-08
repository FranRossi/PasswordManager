using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Exceptions
{
    public class PasswordGenerationTooShortException : ValidationException
    {
        public PasswordGenerationTooShortException()
        {
            this.message = "La contaseña que desea generar es demasiado corta (min. 5 caracteres).";
        }
    }
}
