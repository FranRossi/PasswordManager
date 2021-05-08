using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Exceptions
{
    public class PasswordGenerationNotSelectedCharacterTypes : ValidationException
    {
        public PasswordGenerationNotSelectedCharacterTypes()
        {
            this.message = "Debe seleccionar al menos un tipo de caracteres para incluir en su contraseñas.";
        }
    }
}
