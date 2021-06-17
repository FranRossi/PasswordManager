using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Utilities
{
    public class AdvancedHash : IHash
    {
        public string Hash(string textToHash, string salt)
        {
            string textWithSalt = textToHash + salt;
            byte[] bytesToHash = Encoding.ASCII.GetBytes(textWithSalt);
            SHA256 mySHA256 = SHA256.Create();
            byte[] hashedBytes = mySHA256.ComputeHash(bytesToHash);
            string hashedBytesInText = Encoding.ASCII.GetString(hashedBytes);
            return hashedBytesInText;
        }
    }
}
