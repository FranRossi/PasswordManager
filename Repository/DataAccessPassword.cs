using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataAccessPassword : IDataAccess<Password>
    {
        public void Add(Password pPassword)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Category passwordCategory = pPassword.Category;
                User passwordUser = pPassword.User;
                Category passwordCategoryFromDB = context.Categories.FirstOrDefault(c => c.Id == passwordCategory.Id);
                User passwordUserFromDB = context.Users.FirstOrDefault(u => u.MasterName == passwordUser.MasterName);
                pPassword.User = passwordUserFromDB;
                pPassword.Category = passwordCategoryFromDB;

                context.Categories.Attach(passwordCategoryFromDB);
                context.Users.Attach(passwordUserFromDB);
                context.Passwords.Add(pPassword);
                context.SaveChanges();
            }
        }

        public void Delete(Password pPassword)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Password passwordToDelete = context.Passwords.FirstOrDefault(pass => pass.Id == pPassword.Id);
                context.Passwords.Remove(passwordToDelete);
                context.SaveChanges();
            }
        }

        public void Modify(Password pPassword)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Category passwordCategory = pPassword.Category;
                User passwordUser = pPassword.User;
                Category passwordCategoryFromDB = context.Categories.FirstOrDefault(c => c.Id == passwordCategory.Id);
                User passwordUserFromDB = context.Users.FirstOrDefault(u => u.MasterName == passwordUser.MasterName);
                Password passwordToModify = context.Passwords.FirstOrDefault(pass => pass.Id == pPassword.Id);

                passwordToModify.User = passwordUserFromDB;
                passwordToModify.Category = passwordCategoryFromDB;
                passwordToModify.LastModification = pPassword.LastModification;
                passwordToModify.Notes = pPassword.Notes;
                passwordToModify.Pass = pPassword.Pass;
                passwordToModify.Site = pPassword.Site;
                passwordToModify.Username = pPassword.Username;
                context.Categories.Attach(passwordCategoryFromDB);
                context.Users.Attach(passwordUserFromDB);
                context.SaveChanges();
            }
        }

        public IEnumerable<Password> GetAll(String pMasterName)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                IEnumerable<Password> passwords = context.Passwords.Include("Category").Where(pass => pass.User.MasterName == pMasterName).ToList();
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

        public List<Password> GetSharedPasswordsWithCurrentUser(User pCurrentUser)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                List<Password> passwordList = context.Passwords.Include("SharedWith").ToList();
                List<Password> passwordsSharedWithMe = passwordList.Where(pass => pass.SharedWith.Contains(pCurrentUser)).ToList();
                return passwordsSharedWithMe;
            }
        }
    }
}
