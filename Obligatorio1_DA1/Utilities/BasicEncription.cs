using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Utilities
{
    public class BasicEncription : IEncription
    {

        public string Encript(string textToEncript, string key)
        {
            return textToEncript + key;
        }
        public string Decript(string encriptedText, string key)
        {
            int origianlTextLength = encriptedText.Length - key.Length;
            return encriptedText.Substring(0, origianlTextLength);
        }

    }
}
