using Obligatorio1_DA1.Exceptions;
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
            VerifyText(textToEncrypt);
            VerifyText(key);
            return textToEncrypt + key;
        }

        public string Decrypt(string encryptedText, string key)
        {
            VerifyText(encryptedText);
            VerifyText(key);
            int originalTextLength = encryptedText.Length - key.Length;
            string decryptedText = encryptedText.Substring(0, originalTextLength);
            return decryptedText;
        }
        private void VerifyText(string text)
        {
            bool isInAscci = System.Text.Encoding.UTF8.GetByteCount(text) == text.Length;
            if (!isInAscci)
                throw new EncryptionException();
        }

    }
}
