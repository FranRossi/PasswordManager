using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1;
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
        private Password _password;
        private User _user;
        private Category _category;

        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                _user = new User()
                {
                    Name = "Gonzalo",
                    MasterPass = "HolaSoyGonzalo123"
                };
                _category = new Category()
                {
                    Name = "Personal"
                };
                _user.Categories.Add(_category);
                this._password = new Password
                {
                    User = _user,
                    Category = _category,
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
                this._password.Pass = password;
                Assert.AreEqual(this._password.PasswordStrength, PasswordStrengthColor.Red);
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
                this._password.Pass = password;
                Assert.AreEqual(this._password.PasswordStrength, PasswordStrengthColor.Orange);
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
        public void CreatePasswordWithYellowStrength(string password)
        {
            try
            {
                this._password.Pass = password;
                Assert.AreEqual(this._password.PasswordStrength, PasswordStrengthColor.Yellow);
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
                this._password.Pass = password;
                Assert.AreEqual(this._password.PasswordStrength, PasswordStrengthColor.LightGreen);
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
                this._password.Pass = password;
                Assert.AreEqual(this._password.PasswordStrength, PasswordStrengthColor.DarkGreen);
            }
            catch (ValidationException ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }
    }
}

