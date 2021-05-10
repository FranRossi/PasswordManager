using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Exceptions
{
    public class PasswordSharedWithSameUserException : Exception
    {
        protected string message;
        public override string Message => this.message;

        public PasswordSharedWithSameUserException()
        {
            this.message = "Un usuario no se puede compartir la contraseña a si mismo";
        }
    }
}
