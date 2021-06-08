using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Utilities;
using Repository;
using System;
using System.Collections.Generic;

namespace UnitTestObligatorio1
{

    [TestClass]
    public abstract class UnitTestHash
    {
        protected abstract IHash GetHash();
        protected IHash hashing;

        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                hashing = GetHash();

            }
            catch (Exception exception)
            {
                Assert.Fail("Expected no exception, but got: " + exception.Message);
            }

        }

        [DataRow("mySuperSecurePassword")]
        [DataRow("12321pass werod")]
        [DataRow("hello world")]
        [DataTestMethod]
        public void HashDifferentThanOrignal(string textToHash)
        {
            string salt = "abcedfghi";
            string hashedText = hashing.Hash(textToHash, salt);
            Assert.AreNotEqual(textToHash, hashedText, "Original: " + textToHash + " Result: " + hashedText);
        }

        [TestMethod]
        public void DifferentSaltProduceDifferentHashed()
        {
            string firstSalt = "qwerty123";
            string textToHash = "hello world";
            string hashedTextFirstSalt = hashing.Hash(textToHash, firstSalt);

            string differentSalt = "asldfjasdf";
            string hashedTextDifferentSalt = hashing.Hash(textToHash, differentSalt);

            Assert.AreNotEqual(hashedTextFirstSalt, hashedTextDifferentSalt);

        }
    }
}
