using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Obligatorio1_DA1.Utilities
{
    public class AesEncryption : IEncryption
    {
        static byte[] IV = new byte[16];

        public AesEncryption()
        {
            IV = Encoding.ASCII.GetBytes("ALSweFKJfasfFJLd");
        }
        public string Encrypt(string textToEncrypt, string key)
        {
            key = "ALSweFKJdfgfFsdfALSweFKJdfgfFsdf";
            key = key.PadLeft(32, '0');

            /*            key = "ALSweFKJdfgfFsdfALSweFKJdfgfFsdf";
                        byte[] keyInByte = Encoding.ASCII.GetBytes(key);
                        byte[] encryptedBytes = EncryptStringToBytes_Aes(textToEncrypt, keyInByte);
                        char[] encryptedBytesInChars = Encoding.ASCII.GetChars(encryptedBytes);
                        string encryptedString = new string(encryptedBytesInChars);*/
            string encryptedText = EncryptAes(textToEncrypt, key);
            return encryptedText;
        }
        public string Decrypt(string encryptedText, string key)
        {
            key = "ALSweFKJdfgfFsdfALSweFKJdfgfFsdf";
            key = key.PadLeft(32, '0');
            /*           ;
                        byte[] keyInByte = Encoding.ASCII.GetBytes(key);
                        byte[] encryptedTextInByte = Encoding.ASCII.GetBytes(encryptedText);
                        string decryptedText = DecryptStringFromBytes_Aes(encryptedTextInByte, keyInByte);*/
            string decryptedText = DecryptAes(encryptedText, key);
            return decryptedText;
        }

        /*       private byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key)
               {
                   // Check arguments.
                   if (plainText == null || plainText.Length <= 0)
                       throw new ArgumentNullException("plainText");
                   if (Key == null || Key.Length <= 0)
                       throw new ArgumentNullException("Key");
                   if (IV == null || IV.Length <= 0)
                       throw new ArgumentNullException("IV");
                   byte[] encrypted;

                   // Create an Aes object
                   // with the specified key and IV.
                   using (Aes aesAlg = Aes.Create())
                   {
                       aesAlg.Key = Key;
                       aesAlg.IV = IV;

                       // Create an encryptor to perform the stream transform.
                       ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                       // Create the streams used for encryption.
                       using (MemoryStream msEncrypt = new MemoryStream())
                       {
                           using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                           {
                               using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                               {
                                   //Write all data to the stream.
                                   swEncrypt.Write(plainText);
                               }
                               encrypted = msEncrypt.ToArray();
                           }
                       }
                   }

                   return encrypted;
               }

               private string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key)
               {
                   // Check arguments.
                   if (cipherText == null || cipherText.Length <= 0)
                       throw new ArgumentNullException("cipherText");
                   if (Key == null || Key.Length <= 0)
                       throw new ArgumentNullException("Key");
                   if (IV == null || IV.Length <= 0)
                       throw new ArgumentNullException("IV");

                   // Declare the string used to hold
                   // the decrypted text.
                   string plaintext = null;

                   // Create an Aes object
                   // with the specified key and IV.
                   using (Aes aesAlg = Aes.Create())
                   {
                       aesAlg.Key = Key;
                       aesAlg.IV = IV;

                       // Create a decryptor to perform the stream transform.
                       ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                       // Create the streams used for decryption.
                       using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                       {
                           using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                           {
                               using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                               {

                                   // Read the decrypted bytes from the decrypting stream
                                   // and place them in a string.
                                   plaintext = srDecrypt.ReadToEnd();
                               }
                           }
                       }
                   }

                   return plaintext;
               }
       */

        private static readonly Encoding encoding = Encoding.UTF8;
        public static string EncryptAes(string plainText, string key)
        {
            try
            {
                RijndaelManaged aes = new RijndaelManaged();
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.PKCS7;
                aes.Mode = CipherMode.CBC;

                aes.Key = encoding.GetBytes(key);
                aes.GenerateIV();

                ICryptoTransform AESEncrypt = aes.CreateEncryptor(aes.Key, aes.IV);
                byte[] buffer = encoding.GetBytes(plainText);

                string encryptedText = Convert.ToBase64String(AESEncrypt.TransformFinalBlock(buffer, 0, buffer.Length));

                String mac = "";

                mac = BitConverter.ToString(HmacSHA256(Convert.ToBase64String(aes.IV) + encryptedText, key)).Replace("-", "").ToLower();

                var keyValues = new Dictionary<string, object>
                {
                    { "iv", Convert.ToBase64String(aes.IV) },
                    { "value", encryptedText },
                    { "mac", mac },
                };

                JavaScriptSerializer serializer = new JavaScriptSerializer();

                return Convert.ToBase64String(encoding.GetBytes(serializer.Serialize(keyValues)));
            }
            catch (Exception e)
            {
                throw new Exception("Error encrypting: " + e.Message);
            }
        }

        public static string DecryptAes(string plainText, string key)
        {
            try
            {
                RijndaelManaged aes = new RijndaelManaged();
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.PKCS7;
                aes.Mode = CipherMode.CBC;
                aes.Key = encoding.GetBytes(key);

                // Base 64 decode
                byte[] base64Decoded = Convert.FromBase64String(plainText);
                string base64DecodedStr = encoding.GetString(base64Decoded);

                // JSON Decode base64Str
                JavaScriptSerializer ser = new JavaScriptSerializer();
                var payload = ser.Deserialize<Dictionary<string, string>>(base64DecodedStr);

                aes.IV = Convert.FromBase64String(payload["iv"]);

                ICryptoTransform AESDecrypt = aes.CreateDecryptor(aes.Key, aes.IV);
                byte[] buffer = Convert.FromBase64String(payload["value"]);

                return encoding.GetString(AESDecrypt.TransformFinalBlock(buffer, 0, buffer.Length));
            }
            catch (Exception e)
            {
                throw new Exception("Error decrypting: " + e.Message);
            }
        }

        static byte[] HmacSHA256(String data, String key)
        {
            using (HMACSHA256 hmac = new HMACSHA256(encoding.GetBytes(key)))
            {
                return hmac.ComputeHash(encoding.GetBytes(data));
            }
        }
    }

}

