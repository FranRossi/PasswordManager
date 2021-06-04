using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataAccessUser
    {
        public void Add(User pUser)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Users.Add(pUser);
                context.SaveChanges();
            }
        }

        public User Login(string name, string password)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                User loggedInUser = context.Users.Include("Categories").FirstOrDefault(u => u.MasterName == name && u.MasterPass == password);
                return loggedInUser;
            }
        }
    }
}

