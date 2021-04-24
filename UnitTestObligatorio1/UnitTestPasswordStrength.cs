using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Utilities;
using System;
using System.Text.RegularExpressions;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestPasswordStrength
    {
        [DataRow("23985023")]
        [DataRow("abcde876")]
        [DataRow("-d45023")]
        [DataRow("sAT4-@")]
        [DataRow("sT4-@")]
        [DataTestMethod]
        public void CreatePasswordWithRedStrength(string password)
        {
            try
            {
                Password pass = new Password
                {
                    Category = "Facultad",
                    Site = "ort.edu.uy",
                    Username = "239850",
                    Pass = password,
                    Notes = "No me roben la cuenta"
                };
                Assert.AreEqual(pass.PasswordStrength, PasswordStrengthColor.Red);
            }
            catch (ValidationException ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [DataRow("239850232")]
        [DataRow("abcst333de8762")]
        [DataRow("-d4502-s--ss-3")]
        [DataRow("sAT4-@sesesior")]
        [DataRow("sT4-@234a")]
        [DataTestMethod]
        public void CreatePasswordWithOrangeStrength(string password)
        {
            try
            {
                Password pass = new Password
                {
                    Category = "Facultad",
                    Site = "ort.edu.uy",
                    Username = "239850",
                    Pass = password,
                    Notes = "No me roben la cuenta"
                };
                Assert.AreEqual(pass.PasswordStrength, PasswordStrengthColor.Orange);
            }
            catch (ValidationException ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [DataRow("AAHTNINESHRIIHH")]
        [DataRow("nethiseanthneaa")]
        [DataRow("14893470823575754543")]
        [DataRow("(!&*($$^&#^@($&)&@$)#")]
        [DataRow("AAHTNINESHRIIH5453453")]
        [DataRow("nethiseant3232323hnea")]
        [DataRow("n$#@$ntdtshneaa")]
        [DataRow("14893470823@#@#@754543")]
        [DataRow("ARDSDSRUDEIR@@#")]
        [DataTestMethod]
        public void createPasswordWithYellowStrength(string password)
        {
            try
            {
                Password pass = new Password
                {
                    Category = "Facultad",
                    Site = "ort.edu.uy",
                    Username = "239850",
                    Pass = password,
                    Notes = "No me roben la cuenta"
                };
                Assert.AreEqual(pass.PasswordStrength, PasswordStrengthColor.Yellow);
            }
            catch (ValidationException ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [DataRow("AAHTNrtsrHRIISH")]
        [DataRow("netMUN2hiseanthnea")]
        [DataRow("148srtarst#$#@$5754543")]
        [DataRow("chau123(!&*($$^&#^@($*@#&")]
        [DataRow("HOLA123(!&*($$^&#^@($@#&")]
        [DataTestMethod]
        public void CreatePasswordWithLightGreenStrength(string password)
        {
            try
            {
                Password pass = new Password
                {
                    Category = "Facultad",
                    Site = "ort.edu.uy",
                    Username = "239850",
                    Pass = password,
                    Notes = "No me roben la cuenta"
                };
                Assert.AreEqual(pass.PasswordStrength, PasswordStrengthColor.LightGreen);
            }
            catch (ValidationException ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [DataRow("AAHTNrtsr#3IIHH")]
        [DataRow("3#@rstaAaartsaa")]
        [DataRow("#stsrtARSRT2332")]
        [DataRow("Chau123(!&*($$^&#^@#&")]
        [DataTestMethod]
        public void CreatePasswordWithDarkGreenStrength(string password)
        {
            try
            {
                Password pass = new Password
                {
                    Category = "Facultad",
                    Site = "ort.edu.uy",
                    Username = "AlfredoJuanGarciaPerez",
                    Pass = password,
                    Notes = "No me roben la cuenta"
                };
                Assert.AreEqual(pass.PasswordStrength, PasswordStrengthColor.DarkGreen);
            }
            catch (ValidationException ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }


    }
}
