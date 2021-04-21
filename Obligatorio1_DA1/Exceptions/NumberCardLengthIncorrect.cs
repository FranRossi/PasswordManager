using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Exceptions
{

    public class NumberCardLengthIncorrect : ValidationException
    {
        private string message;
        public override string Message => this.message;

        public NumberCardLengthIncorrect()
        {
            this.message = "El número ingresado tiene que ser de 16 números.";
        }
    }
}
