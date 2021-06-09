using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Utilities
{
    public interface IEncryption
    {
        string Encrypt(string textToEncrypt, string key);
        string Decrypt(string encryptedText, string key);
    }
}
