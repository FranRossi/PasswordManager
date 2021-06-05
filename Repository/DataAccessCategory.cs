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
        public void Add(Category pCategory)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Users.Attach(pCategory.User);
                context.Categories.Add(pCategory);
                context.SaveChanges();
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

        public bool CheckUniqueness(Category pCategroy)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                string userMasterName = pCategroy.getUserMasterName();
                List<Category> currentUserCategories = context.Users.Include("Categories").FirstOrDefault(u => u.MasterName == userMasterName).Categories;
                bool categoryIsUnique = !currentUserCategories.Contains(pCategroy);
                return categoryIsUnique;
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


    }


}
