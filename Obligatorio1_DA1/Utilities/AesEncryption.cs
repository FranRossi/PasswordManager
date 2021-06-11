using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Web.Script.Serialization;

namespace Obligatorio1_DA1.Utilities
{
    public class AesEncryption : IEncryption
    {
        private static char keyPaddingChar = '0';
        private static int keyLength = 32;
        private static byte[] IV = new byte[] { 237, 187, 70, 157, 153, 181, 4, 169, 105, 218, 240, 155, 181, 155, 44, 19 };
        public string Encrypt(string textToEncrypt, string key)
        {
            key = key.PadLeft(keyLength, keyPaddingChar);
            string encryptedText = EncryptAes(textToEncrypt, key);
            return encryptedText;
        }
        public string Decrypt(string encryptedText, string key)
        {
            key = key.PadLeft(keyLength, keyPaddingChar);
            string decryptedText = DecryptAes(encryptedText, key);
            return decryptedText;
        }

        private static readonly Encoding encoding = Encoding.UTF8;


        // Modifed from: https://gist.github.com/doncadavona/fd493b6ced456371da8879c22bb1c263 11/6/2021
        private static string EncryptAes(string plainText, string key)
        {
            try
            {
                RijndaelManaged aes = new RijndaelManaged();
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.PKCS7;
                aes.Mode = CipherMode.CBC;
                aes.Key = encoding.GetBytes(key);
                aes.IV = IV;

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

        private static string DecryptAes(string plainText, string key)
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

        private static byte[] HmacSHA256(String data, String key)
        {
            using (HMACSHA256 hmac = new HMACSHA256(encoding.GetBytes(key)))
            {
                return hmac.ComputeHash(encoding.GetBytes(data));
            }
        }
    }

}

