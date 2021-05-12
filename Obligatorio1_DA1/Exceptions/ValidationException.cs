using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Exceptions
{
    public abstract class ValidationException : Exception
    {
        protected string message;
        public override string Message => this.message;
    }
}
