using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataAccessUser : IDataAccess<User>
    {
        public void Add(User pUser)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Users.Attach(pUser);
                context.SaveChanges();
            }
        }

        public void Delete(User pUser)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                User userToDelete = context.Users.FirstOrDefault(u => u.MasterName == pUser.MasterName);
                context.Users.Remove(userToDelete);
                context.SaveChanges();
            }
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException(); // TODO delete methode
        }

        public void Modify(User pUser)
        {
            throw new NotImplementedException(); // TODO delete methode

        }
    }
}

