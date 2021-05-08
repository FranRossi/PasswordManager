using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Exceptions
{
    public class ItemNotesTooLongException : ValidationException
    {
        public ItemNotesTooLongException()
        {
            this.message = "Las notas son demasiado largas (max. 250 caracteres). ";
        }
    }
}
