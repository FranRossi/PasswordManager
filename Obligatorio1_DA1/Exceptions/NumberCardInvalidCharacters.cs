using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Exceptions
{
    public class NumberCardInvalidCharacters : ValidationException
    {
        private string message;
        public override string Message => this.message;

        public NumberCardInvalidCharacters()
        {
            this.message = "El número contiene caracteres inválidos. (Solo digitos separados por espacios)";
        }
    }
}
