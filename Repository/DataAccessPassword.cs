using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataAccessPassword : IDataAccessPassword<Password>
    {
        public void Add(Password newPassword)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Category passwordCategory = newPassword.Category;
                User passwordUser = newPassword.User;
                Category passwordCategoryFromDB = context.Categories.FirstOrDefault(c => c.Id == passwordCategory.Id);
                User passwordUserFromDB = context.Users.FirstOrDefault(u => u.MasterName == passwordUser.MasterName);
                newPassword.User = passwordUserFromDB;
                newPassword.Category = passwordCategoryFromDB;

                context.Categories.Attach(passwordCategoryFromDB);
                context.Users.Attach(passwordUserFromDB);
                context.Passwords.Add(newPassword);
                context.SaveChanges();
            }
        }

        public void Delete(Password password)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Password passwordToDelete = context.Passwords.FirstOrDefault(pass => pass.Id == password.Id);
                context.Passwords.Remove(passwordToDelete);
                context.SaveChanges();
            }
        }

        public void Modify(Password modifiedPassword)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Category passwordCategory = modifiedPassword.Category;
                User passwordUser = modifiedPassword.User;
                Category passwordCategoryFromDB = context.Categories.FirstOrDefault(c => c.Id == passwordCategory.Id);
                User passwordUserFromDB = context.Users.FirstOrDefault(u => u.MasterName == passwordUser.MasterName);
                Password passwordToModify = context.Passwords.FirstOrDefault(pass => pass.Id == modifiedPassword.Id);

                passwordToModify.User = passwordUserFromDB;
                passwordToModify.Category = passwordCategoryFromDB;
                passwordToModify.LastModification = modifiedPassword.LastModification;
                passwordToModify.Notes = modifiedPassword.Notes;
                passwordToModify.EncryptedPass = modifiedPassword.EncryptedPass;
                passwordToModify.PasswordStrength = modifiedPassword.PasswordStrength;
                passwordToModify.Site = modifiedPassword.Site;
                passwordToModify.Username = modifiedPassword.Username;
                context.Categories.Attach(passwordCategoryFromDB);
                context.Users.Attach(passwordUserFromDB);
                context.SaveChanges();
            }
        }

        public IEnumerable<Password> GetAll(String userMasterName)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                IEnumerable<Password> passwords = context.Passwords.Include("Category").Include("User").Where(pass => pass.User.MasterName == userMasterName).ToList();
                return passwords;
            }
        }

        public bool CheckUniqueness(Password newPassword)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Password passToCheck = context.Passwords.Include("User").FirstOrDefault
                    (p => p.User.MasterName == newPassword.User.MasterName && p.Site == newPassword.Site && p.Username == newPassword.Username &&
                     p.Id != newPassword.Id);
                bool passwordIsNull = passToCheck == null;
                return passwordIsNull;
            }
        }

        public bool CheckPasswordNotSharedTwice(Password newPassword, User userShareTo)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Password passwordFromDB = context.Passwords.Include("SharedWith").Include("User").FirstOrDefault(pass => pass.Id == newPassword.Id);
                bool userDoesntKnowPassword = !passwordFromDB.SharedWith.Contains(userShareTo);
                return userDoesntKnowPassword;
            }
        }

        public List<Password> GetSharedPasswordsWithCurrentUser(User currentUser)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                List<Password> passwordList = context.Passwords.Include("SharedWith").Include("User").ToList();
                List<Password> passwordsSharedWithMe = passwordList.Where(pass => pass.SharedWith.Contains(currentUser)).ToList();
                return passwordsSharedWithMe;
            }
        }

        public List<Password> GetPasswordsByColor(PasswordStrengthColor passColor, User currentUser)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                List<Password> passwords = context.Passwords.Include("User").Include("Category").Where(
                            pass => pass.PasswordStrength == passColor && pass.User.MasterName == currentUser.MasterName).ToList();
                foreach (Password pass in passwords)
                    SynchronizeLocalAndDBUsersDecryptionKey(currentUser, pass.User);
                return passwords;
            }
        }

        public List<PasswordReportByColor> GetPasswordReportByColor(User currentUser)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                List<PasswordReportByColor> report = new List<PasswordReportByColor>();
                foreach (PasswordStrengthColor passColor in Enum.GetValues(typeof(PasswordStrengthColor)))
                {
                    report.Add(new PasswordReportByColor
                    {
                        Color = passColor,
                        Quantity = context.Passwords.Count(pass => pass.PasswordStrength == passColor && pass.User.MasterName == currentUser.MasterName)
                    }
                    );
                }
                return report;
            }
        }

        public List<PasswordReportByCategoryAndColor> GetPasswordReportByCategoryAndColor(User currentUser)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                List<PasswordReportByCategoryAndColor> report = new List<PasswordReportByCategoryAndColor>();
                List<Category> categories = context.Users.Include("Categories").FirstOrDefault(u => u.MasterName == currentUser.MasterName).Categories;

                foreach (Category category in categories)
                {
                    foreach (PasswordStrengthColor color in Enum.GetValues(typeof(PasswordStrengthColor)))
                    {
                        report.Add(new PasswordReportByCategoryAndColor
                        {
                            Category = category,
                            Color = color,
                            Quantity = context.Passwords.Include("User").Include("Category").Count(
                                    pass => pass.Category.Name == category.Name && pass.PasswordStrength == color
                                        && pass.User.MasterName == currentUser.MasterName)
                        }
                        );
                    }
                }
                return report;
            }
        }

        public bool CheckTextIsDuplicate(Password password, User currentUser)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Password passToCheck = context.Passwords.FirstOrDefault
                    (p => p.EncryptedPass == password.EncryptedPass && p.User.MasterName == currentUser.MasterName);
                bool passTextIsDuplicate = passToCheck != null;
                return passTextIsDuplicate;
            }
        }

        private void SynchronizeLocalAndDBUsersDecryptionKey(User originalUser, User user)
        {
            user.DecryptionKey = originalUser.DecryptionKey;
        }
    }
}
