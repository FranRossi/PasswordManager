using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Exceptions
{
    public class CategoryAlreadyAddedException : ValidationException
    {
        public CategoryAlreadyAddedException()
        {
            this.message = "La que esta intentando agregar ya pertenece a su usuario.";
        }
    }
}
