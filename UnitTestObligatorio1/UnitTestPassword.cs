using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1;
using Obligatorio1_DA1.Domain;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestPassword
    {

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

        [TestMethod]
        public void createNewPasswordNoNotes()
        {
            try
            {
                Password pass = new Password
                {
                    Category = "Work",
                    Site = "work.com",
                    Username = "Joseph",
                    Pass = "wwwjosph"
                };
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }

        }



        [DataRow(1, true, false, false, false, "[A-Z]+")]
        [DataRow(1, false, true, false, false, "[a-z]+")]
        [DataRow(1, true, true, false, false, "^(?=.*[a-zA-Z]).{2}$")]
        [DataRow(1, false, false, true, false, "[0-9]+")]
        [DataRow(1, false, false, false, true, "([ -/]|[:-@]|[\\[-`]|[\\|-~])+")]
        [DataRow(4, true, true, true, true, "[ -~]{4}")]
        [DataRow(20, true, true, true, true, "[ -~]{20}")]
        [DataTestMethod]
        public void generateValidPassword
               (int length, Boolean upercase, Boolean lowercase, Boolean digits, Boolean specialDigits, string regex)
        {
            string pass = Password.generate(length, upercase, lowercase, digits, specialDigits);
            Regex r = new Regex(regex);
            Assert.IsTrue(r.IsMatch(pass), "Password: " + pass + " Regex: " + regex);
        }



    }
}
