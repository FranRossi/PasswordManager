using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Utilities;
using Repository;
using System;
using System.Collections.Generic;

namespace UnitTestObligatorio1
{

    [TestClass]
    public abstract class UnitTestEncryption
    {
        protected abstract IEncryption GetEncryption();
        protected IEncryption encryption;

        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                encryption = GetEncryption();

            }
            catch (Exception exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }

        }

        [DataRow("mySuperSecurePassword", "keyy")]
        [DataRow("12321pass werod", "keyadsfy")]
        [DataRow("hello world", "asdfasd")]
        [DataTestMethod]
        public void EncryptDifferentThanOrignal(string textToEncrypt, string key)
        {
            string encryptedText = encryption.Encrypt(textToEncrypt, key);
            Assert.AreNotEqual(textToEncrypt, encryptedText, "Original: " + textToEncrypt + " Result: " + encryptedText);
        }

        [DataRow("mySuperSecurePassword", "keyy")]
        [DataRow("12321pass werod", "keyadsfy")]
        [DataRow("hello world", "asdfasd")]
        [DataTestMethod]
        public void SameTextAndKeyGiveSameResult(string textToEncrypt, string key)
        {
            string encryptedText = encryption.Encrypt(textToEncrypt, key);
            string secondEncryptedText = encryption.Encrypt(textToEncrypt, key);
            Assert.AreEqual(encryptedText, secondEncryptedText, "First: " + encryptedText + " Second: " + secondEncryptedText);
        }


        [DataRow("mySuperSecurePassword", "keyy")]
        [DataRow("12321pass werod", "keyadsfy")]
        [DataRow("hello world", "asdfasd")]
        [DataTestMethod]
        public void Decrypt(string textToEncrypt, string key)
        {
            string encryptedText = encryption.Encrypt(textToEncrypt, key);
            string decryptedText = encryption.Decrypt(encryptedText, key);
            Assert.AreEqual(textToEncrypt, decryptedText, "Original: " + textToEncrypt + " Result: " + decryptedText);
        }

        [TestMethod]
        [ExpectedException(typeof(EncryptionException))]
        public void InvalidKey()
        {
            try
            {
                string encryptedText = encryption.Encrypt("superSecretPassword", "❤");
            }
            catch (Exception exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }
        }
    }
}
