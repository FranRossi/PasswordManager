using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Utilities;
using System;
using System.Text.RegularExpressions;

namespace UnitTestObligatorio1
{
    [TestClass]
    public class UnitTestPasswordGeneration
    {
        private Password _password;
        private PasswordManager _passwordManager;
        private User _user;
        private Category _category;

        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                _passwordManager = new PasswordManager();
                _user = new User()
                {
                    MasterName = "Gonzalo",
                    MasterPass = "HolaSoyGonzalo123"
                };
                _category = new Category()
                {
                    Name = "Personal"
                };
                _user.Categories.Add(_category);
                _password = new Password
                {
                    User = _user,
                    Category = _category,
                    Site = "ort.edu.uy",
                    Username = "239850",
                    Pass = "239850Ort2019",
                    Notes = "No me roben la cuenta"
                };
                _passwordManager.CreateUser(_user);
                _passwordManager.CreatePassword(_password);
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
        public void GenerateValidPassword
       (int length, bool uppercase, bool lowercase, bool digits, bool specialDigits, string regex)
        {
            PasswordGenerationOptions options = new PasswordGenerationOptions
            {
                Length = length,
                Uppercase = uppercase,
                Lowercase = lowercase,
                Digits = digits,
                SpecialDigits = specialDigits
            };
            string pass = Password.GenerateRandomPassword(options);
            Regex regexToCheck = new Regex(regex);
            Assert.IsTrue(regexToCheck.IsMatch(pass), "Password: " + pass + " Regex: " + regex);
        }

        [DataRow(6, false, false, false, false)]
        [DataRow(9, false, false, false, false)]
        [DataTestMethod]
        [ExpectedException(typeof(PasswordGenerationNotSelectedCharacterTypesException))]
        public void GenerateInvalidNotTypesSelectedPassword
               (int length, bool uppercase, bool lowercase, bool digits, bool specialDigits)
        {
            PasswordGenerationOptions options = new PasswordGenerationOptions
            {
                Length = length,
                Uppercase = uppercase,
                Lowercase = lowercase,
                Digits = digits,
                SpecialDigits = specialDigits
            };
            string pass = Password.GenerateRandomPassword(options);
        }

        [DataRow(4, true, false, false, false)]
        [DataRow(2, true, true, false, true)]
        [DataTestMethod]
        [ExpectedException(typeof(PasswordGenerationTooShortException))]
        public void GenerateInvalidTooShortPassword
            (int length, bool uppercase, bool lowercase, bool digits, bool specialDigits)
        {
            PasswordGenerationOptions options = new PasswordGenerationOptions
            {
                Length = length,
                Uppercase = uppercase,
                Lowercase = lowercase,
                Digits = digits,
                SpecialDigits = specialDigits
            };
            string pass = Password.GenerateRandomPassword(options);
        }

        [DataRow(3434, true, false, false, false)]
        [DataRow(26, true, true, false, true)]
        [DataTestMethod]
        [ExpectedException(typeof(PasswordGenerationTooLongException))]
        public void GenerateInvalidTooLongPassword
            (int length, bool uppercase, bool lowercase, bool digits, bool specialDigits)
        {
            PasswordGenerationOptions options = new PasswordGenerationOptions
            {
                Length = length,
                Uppercase = uppercase,
                Lowercase = lowercase,
                Digits = digits,
                SpecialDigits = specialDigits
            };
            string pass = Password.GenerateRandomPassword(options);
        }
    }
}
