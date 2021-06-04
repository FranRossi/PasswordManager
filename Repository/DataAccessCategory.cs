using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataAccessCategory
    {
        public void Add(Category pCategory, string masterName)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Database.ExecuteSqlCommand("INSERT INTO Categories(Name, User_MasterName)" +
                                        "VALUES('" + pCategory.Name + "', '" + masterName + "')");
                context.SaveChanges();
            }
        }

        public void Delete(Category pCategroy)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Category categoryToDelete = context.Categories.FirstOrDefault(c => c.Id == pCategroy.Id);
                context.Categories.Remove(categoryToDelete);
                context.SaveChanges();
            }
        }


        public IEnumerable<Category> GetAll(string pMasterName)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                List<Category> categories = context.Users.Include("Categories").FirstOrDefault(u => u.MasterName == pMasterName).Categories;
                return categories;
            }
        }

        public void Modify(Category pCategroy)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Category categoryToModfy = context.Categories.FirstOrDefault(c => c.Id == pCategroy.Id);
                categoryToModfy.Name = pCategroy.Name;
                context.SaveChanges();
            }
        }
    }


}
