using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Exceptions
{
    public class LogInException : ValidationException
    {
        private string message;
        public override string Message => this.message;
        public LogInException()
        {
            this.message = "El nombre usuario o contraseña son incorrectos.";
        }
    }
}
