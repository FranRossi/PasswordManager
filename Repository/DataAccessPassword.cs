using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
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
                context.Categories.Attach(pPassword.Category);
                context.Users.Attach(pPassword.User);
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
                Password passwordToModify = context.Passwords.FirstOrDefault(pass => pass.Id == pPassword.Id);
                passwordToModify.Category = pPassword.Category;
                passwordToModify.LastModification = pPassword.LastModification;
                passwordToModify.Notes = pPassword.Notes;
                passwordToModify.Pass = pPassword.Pass;
                passwordToModify.Site = pPassword.Site;
                passwordToModify.Username = pPassword.Username;
                context.SaveChanges();
            }
        }

        public IEnumerable<Password> GetAll(String pMasterName)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                IEnumerable<Password> passwords = context.Passwords.Where(pass => pass.User.MasterName == pMasterName);
                return passwords;
            }
        }
    }
}
