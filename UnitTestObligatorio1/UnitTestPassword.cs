using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
using System;
using System.Text.RegularExpressions;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestPassword
    {

        [TestMethod]
        public void createValidNewPassword()
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
        public void createNewPasswordWithoutNotes()
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

        [TestMethod]
        [ExpectedException(typeof(UsernameTooShortException))]
        public void createNewPasswordWithUsernameTooShort()
        {
            Password pass = new Password
            {
                Username = "Tom",
                Category = "Work",
                Site = "work.com",
                Pass = "wwwjosph",
                Notes = "My work password"
            };

        }

        [TestMethod]
        [ExpectedException(typeof(UsernameTooLongException))]
        public void createNewPasswordWithUsernameTooLong()
        {
            Password pass = new Password
            {
                Username = "Hubert Blaine Wolfeschlegelsteinhausenbergerdorff ",
                Category = "Work",
                Site = "work.com",
                Pass = "wwwjosph",
                Notes = "My work password"
            };

        }

        [TestMethod]
        [ExpectedException(typeof(PasswordTooShortException))]
        public void createNewPasswordTooShort()
        {
            Password pass = new Password
            {
                Username = "Thomas",
                Category = "Work",
                Site = "work.com",
                Pass = "tom",
                Notes = "My work password"
            };

        }

        [TestMethod]
        [ExpectedException(typeof(PasswordTooLongException))]
        public void createNewPasswordTooLong()
        {
            Password pass = new Password
            {
                Username = "Harry ",
                Category = "Work",
                Site = "work.com",
                Pass = "harryharryharryharryharryharry",
                Notes = "My work password"
            };

        }


        [TestMethod]
        [ExpectedException(typeof(SiteTooShortException))]
        public void createNewPasswordSiteTooShort()
        {
            Password pass = new Password
            {
                Username = "Thomas",
                Category = "Work",
                Site = "hi",
                Pass = "thomast.com",
                Notes = "My work password"
            };

        }

        [TestMethod]
        [ExpectedException(typeof(SiteTooLongException))]
        public void createNewSiteSiteTooLong()
        {
            Password pass = new Password
            {
                Username = "Harry ",
                Category = "Work",
                Site = "htpps://wwww.harrywork.com/homepage/signup",
                Pass = "harryharr",
                Notes = "My work password"
            };

        }

        [TestMethod]
        [ExpectedException(typeof(CategoryTooShortException))]
        public void createNewPasswordCategoryTooShort()
        {
            Password pass = new Password
            {
                Username = "Thomas",
                Category = "Me",
                Site = "work.com",
                Pass = "thomas123",
                Notes = "My work password"
            };

        }

        [TestMethod]
        [ExpectedException(typeof(CategoryTooLongException))]
        public void createNewPasswordCategoryTooLong()
        {
            Password pass = new Password
            {
                Username = "Harry ",
                Category = "Passwords of previous work at the factory",
                Site = "work.com",
                Pass = "harryharryyharry",
                Notes = "My work password"
            };

        }

        [TestMethod]
        [ExpectedException(typeof(NotesTooLongException))]
        public void createNewPasswordNotesTooLong()
        {
            Password pass = new Password
            {
                Username = "Harry ",
                Category = "Work",
                Site = "work.com",
                Pass = "harryh",
                Notes = "Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when " +
                "an unknown printer took a galley of type and scrambled it to make a type specimen book. " +
                "It has survived not only five centuries, but also the leap into electronic typesetting, remaining" +
                " essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets " +
                "containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus " +
                "PageMaker including versions of Lorem "
            };

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
            string pass = Password.generateRandomPassword(length, upercase, lowercase, digits, specialDigits);
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
            string pass = Password.generateRandomPassword(length, upercase, lowercase, digits, specialDigits);
        }


        [TestMethod]
        [ExpectedException(typeof(Obligatorio1_DA1.Exceptions.MissingFieldException))]
        public void createNewPasswordWithoutUsername()
        {
            Password pass = new Password
            {
                Category = "Work",
                Site = "work.com",
                Pass = "wwwjosph",
                Notes = "This is my work.com password"
            };
        }



    }
}
