using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Utilities
{
    public class BasicEncryption : IEncryption
    {

        public string Encrypt(string textToEncrypt, string key)
        {
            return textToEncrypt + key;
        }
        public string Decrypt(string encryptedText, string key)
        {
            int originalTextLength = encryptedText.Length - key.Length;
            string decryptedText = encryptedText.Substring(0, originalTextLength);
            return decryptedText;
        }

    }
}
