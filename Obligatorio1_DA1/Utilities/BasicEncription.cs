using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Utilities
{
    public class BasicEncription : IEncription
    {
        public string Decript(string encriptedText, string key)
        {
            return "hello world";
        }

        public string Encript(string textToEncript, string key)
        {
            return "asdfasdf";
        }
    }
}
