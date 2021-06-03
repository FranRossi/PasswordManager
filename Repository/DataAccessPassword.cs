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


    }
}
