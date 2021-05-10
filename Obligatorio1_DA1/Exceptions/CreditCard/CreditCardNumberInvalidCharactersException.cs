using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Exceptions
{
    public class CreditCardNumberInvalidCharactersException : ValidationException
    {
        public CreditCardNumberInvalidCharactersException()
        {
            this.message = "El número contiene caracteres inválidos. (Solo digitos separados por espacios)";
        }
    }
}
