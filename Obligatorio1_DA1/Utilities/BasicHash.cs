using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Utilities
{
    public class BasicHash : IHash
    {
        public string Hash(string textToHash)
        {
            return textToHash + textToHash;
        }
    }
}
