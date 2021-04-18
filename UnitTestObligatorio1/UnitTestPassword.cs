using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1;
using Obligatorio1_DA1.Domain;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace UnitTestObligatorio1
{
    [TestClass]
    class UnitTestPassword
    {
        PasswordManager passwordManager;
        [TestInitialize]
        public void createPasswordManagerBeforeTests()
        {
            passwordManager = new PasswordManager();
            passwordManager.createUser("Pepe", "Pepe$123");
        }

        [TestMethod]
        public void createNewPassword()
        {
            try
            {
                Password pass = new Password
                {
                    Category = "Facultad",
                    Site = "ort.edu.uy",
                    Username = "239850",
                    Pass = "239850Ort2019",
                    Notes = "No me roben la cuenta"
                };
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }

        }

        [DataRow(12, false, true, false, false, "[a-z]{" + "12}+")]
        [DataRow(12, false, true, false, false, "[a-z]{" + "34}+")]
        [DataRow(12, false, true, false, false, "[a-z]{" + "12}+")]
        [DataTestMethod]
        public void generateValidPassword
               (int length, Boolean upercase, Boolean lowercase, Boolean digits, Boolean specialDigits, string regex)
        {
            string pass = Password.generate(length, upercase, lowercase, digits, specialDigits);
            Regex r = new Regex(regex);
            Assert.IsTrue(r.IsMatch(pass));
        }



    }
}
