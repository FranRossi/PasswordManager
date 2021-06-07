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
    public abstract class UnitTestEncription
    {
        protected abstract IEncription GetEncription();
        protected IEncription encription;

        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                encription = GetEncription();

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
        public void EncriptDifferentThanOrignal()
        {
            string textToEncript = "hello world";
            string key = "keyy";
            string encriptedText = encription.Encript(textToEncript, key);
            Assert.AreNotEqual(textToEncript, encriptedText);
        }

        [DataRow("mySuperSecurePassword")]
        [DataRow("hello world")]
        [DataTestMethod]
        public void Decript(string textToEncript)
        {
            string key = "keyy";
            string encriptedText = encription.Encript(textToEncript, key);
            string decriptedText = encription.Decript(encriptedText, key);
            Assert.AreEqual(textToEncript, decriptedText);
        }

    }
}
