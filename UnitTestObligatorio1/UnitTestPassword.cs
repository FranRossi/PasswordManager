using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Utilities;
using System;
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



        [DataRow(5, true, false, false, false, "^[A-Z]{5}$")]
        [DataRow(6, false, true, false, false, "^[a-z]{6}$")]
        [DataRow(8, true, true, false, false, "^([a-z]|[A-Z]){8}$")]
        [DataRow(15, false, false, true, false, "^[0-9]{15}$")]
        [DataRow(25, false, false, false, true, "^([ -/]|[:-@]|[[-`]|[{-~]){25}$")]
        [DataRow(6, true, true, true, true, "^[ -~]{6}$")]
        [DataRow(20, true, true, true, true, "^[ -~]{20}$")]
        [DataTestMethod]
        public void generateValidPassword
               (int length, Boolean upercase, Boolean lowercase, Boolean digits, Boolean specialDigits, string regex)
        {
            string pass = Password.generate(length, upercase, lowercase, digits, specialDigits);
            Regex r = new Regex(regex);
            Assert.IsTrue(r.IsMatch(pass), "Password: " + pass + " Regex: " + regex);
        }

        [DataRow(4, true, false, false, false)]
        [DataRow(6, false, false, false, false)]
        [DataTestMethod]
        [ExpectedException(typeof(ArgumentException),
            "The password is too short or to long(min. 5 characters, max 25).")]
        public void generateInvalidPassword
               (int length, Boolean upercase, Boolean lowercase, Boolean digits, Boolean specialDigits)
        {
            string pass = Password.generate(length, upercase, lowercase, digits, specialDigits);
        }


        [TestMethod]
        public void createPasswordWithRedStrength()
        {
            try
            {
                Password pass = new Password
                {
                    Category = "Facultad",
                    Site = "ort.edu.uy",
                    Username = "239850",
                    Pass = "239850",
                    Notes = "No me roben la cuenta"
                };
                Assert.AreEqual(pass.PasswordStrength, PasswordStrengthColor.Red);
            }
            catch (ValidationException ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void createPasswordWithOrangeStrength()
        {
            try
            {
                Password pass = new Password
                {
                    Category = "Facultad",
                    Site = "ort.edu.uy",
                    Username = "239850",
                    Pass = "239850058932",
                    Notes = "No me roben la cuenta"
                };
                Assert.AreEqual(pass.PasswordStrength, PasswordStrengthColor.Orange);
            }
            catch (ValidationException ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void createPasswordWithYellowStrength()
        {
            try
            {
                Password pass = new Password
                {
                    Category = "Facultad",
                    Site = "ort.edu.uy",
                    Username = "239850",
                    Pass = "alfredojuangarciaperez",
                    Notes = "No me roben la cuenta"
                };
                Assert.AreEqual(pass.PasswordStrength, PasswordStrengthColor.Yellow);
            }
            catch (ValidationException ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void createPasswordWithLightGreenStrength()
        {
            try
            {
                Password pass = new Password
                {
                    Category = "Facultad",
                    Site = "ort.edu.uy",
                    Username = "239850",
                    Pass = "AlfredoJuanGarciaPerez",
                    Notes = "No me roben la cuenta"
                };
                Assert.AreEqual(pass.PasswordStrength, PasswordStrengthColor.LightGreen);
            }
            catch (ValidationException ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }


    }
}
