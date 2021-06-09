using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.SqlClient;
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
                passwordToModify.Pass = modifiedPassword.Pass;
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
                Password passToCheck = context.Passwords.FirstOrDefault
                    (p => p.Site == newPassword.Site && p.Username == newPassword.Username &&
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

        public List<Password> GetPasswordsByColor(PasswordStrengthColor passColor)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                List<Password> passwords = context.Passwords.Include("User").Where(pass => pass.PasswordStrength == passColor).ToList();
                return passwords;
            }
        }

        public List<PasswordReportByColor> GetPasswordReportByColor()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                List<PasswordReportByColor> report = new List<PasswordReportByColor>();
                foreach (PasswordStrengthColor passColor in Enum.GetValues(typeof(PasswordStrengthColor)))
                {
                    report.Add(new PasswordReportByColor
                    {
                        Color = passColor,
                        Quantity = context.Passwords.Count(pass => pass.PasswordStrength == passColor)
                    }
                    );
                }
                return report;
            }
        }

        public List<PasswordReportByCategoryAndColor> GetPasswordReportByCategoryAndColor()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                List<PasswordReportByCategoryAndColor> report = new List<PasswordReportByCategoryAndColor>();
                List<Password> passwordsWithCategories = context.Passwords.Include("Category").ToList();

                foreach (Category category in context.Categories)
                {
                    foreach (PasswordStrengthColor color in Enum.GetValues(typeof(PasswordStrengthColor)))
                    {
                        report.Add(new PasswordReportByCategoryAndColor
                        {
                            Category = category,
                            Color = color,
                            Quantity = passwordsWithCategories.Count(pass => pass.Category.Equals(category) && pass.PasswordStrength == color)
                        }
                        );
                    }
                }
                return report;
            }
        }
    }
}
