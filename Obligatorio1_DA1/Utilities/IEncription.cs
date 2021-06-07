using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Utilities
{
    public interface IEncription
    {
        string Encript(string textToEncript, string key);
        string Decript(string encriptedText, string key);
    }
}
