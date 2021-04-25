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
    public class UnitTestPassword
    {
        private Password _password;

        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                this._password = new Password
                {
                    Category = new Category()
                    {
                        Name = "Personal"
                    },
                    User = new User()
                    {
                        Name = "Gonzalo",
                        Pass = "HolaSoyGonzalo123"
                    },
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
        public void CreateNewPasswordWithoutNotes()
        {
            try
            {
                Password pass = new Password
                {
                    Category = new Category()
                    {
                        Name = "Work"
                    },
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

        [TestMethod]
        [ExpectedException(typeof(UsernameTooShortException))]
        public void CreateNewPasswordWithUsernameTooShort()
        {
            this._password.Username = "Tom";
        }

        [TestMethod]
        [ExpectedException(typeof(UsernameTooLongException))]
        public void CreateNewPasswordWithUsernameTooLong()
        {
            this._password.Username = "Hubert Blaine Wolfeschlegelsteinhausenbergerdorff ";
        }


        [TestMethod]
        [ExpectedException(typeof(PasswordTooShortException))]
        public void CreateNewPasswordTooShort()
        {
            this._password.Pass = "tom";
        }


        [TestMethod]
        [ExpectedException(typeof(PasswordTooLongException))]
        public void CreateNewPasswordTooLong()
        {
            this._password.Pass = "harryharryharryharryharryharry";
        }


        [TestMethod]
        [ExpectedException(typeof(SiteTooShortException))]
        public void CreateNewPasswordSiteTooShort()
        {
            this._password.Site = "hi";
        }


        [TestMethod]
        [ExpectedException(typeof(SiteTooLongException))]
        public void CreateNewSiteSiteTooLong()
        {
            this._password.Site = "htpps://wwww.harrywork.com/homepage/signup";
        }



        [TestMethod]
        [ExpectedException(typeof(NotesTooLongException))]
        public void CreateNewPasswordNotesTooLong()
        {
            this._password.Notes = "Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when " +
                "an unknown printer took a galley of type and scrambled it to make a type specimen book. " +
                "It has survived not only five centuries, but also the leap into electronic typesetting, remaining" +
                " essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets " +
                "containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus " +
                "PageMaker including versions of Lorem ";
        }



        [DataRow(5, true, false, false, false, "^[A-Z]{5}$")]
        [DataRow(6, false, true, false, false, "^[a-z]{6}$")]
        [DataRow(8, true, true, false, false, "^([a-z]|[A-Z]){8}$")]
        [DataRow(15, false, false, true, false, "^[0-9]{15}$")]
        [DataRow(25, false, false, false, true, "^([ -/]|[:-@]|[[-`]|[{-~]){25}$")]
        [DataRow(6, true, true, true, true, "^[ -~]{6}$")]
        [DataRow(20, true, true, true, true, "^[ -~]{20}$")]
        [DataTestMethod]
        public void GenerateValidPassword
               (int length, Boolean upercase, Boolean lowercase, Boolean digits, Boolean specialDigits, string regex)
        {
            string pass = Password.GenerateRandomPassword(length, upercase, lowercase, digits, specialDigits);
            Regex regexToCheck = new Regex(regex);
            Assert.IsTrue(regexToCheck.IsMatch(pass), "Password: " + pass + " Regex: " + regex);
        }

        [DataRow(4, true, false, false, false)]
        [DataRow(6, false, false, false, false)]
        [DataTestMethod]
        [ExpectedException(typeof(ArgumentException),
            "The password is too short or to long(min. 5 characters, max 25).")]
        public void GenerateInvalidPassword
               (int length, Boolean upercase, Boolean lowercase, Boolean digits, Boolean specialDigits)
        {
            string pass = Password.GenerateRandomPassword(length, upercase, lowercase, digits, specialDigits);
        }



        [TestMethod]
        [ExpectedException(typeof(Obligatorio1_DA1.Exceptions.MissingFieldException))]
        public void CreateNewPasswordWithoutUsername()
        {
            Password pass = new Password
            {
                Site = "work.com",
                Pass = "wwwjosph",
                Notes = "This is my work.com password"
            };
        }

    }

}
