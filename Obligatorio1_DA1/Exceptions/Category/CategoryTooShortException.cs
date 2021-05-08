using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Exceptions
{
    public class CategoryTooShortException : ValidationException
    {
        public CategoryTooShortException()
        {
            this.message = "La categoria es demasiado corta (min. 3 caracteres). ";
        }
    }
}
