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
        public void Add(Category newCategory)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Users.Attach(newCategory.User);
                context.Categories.Add(newCategory);
                context.SaveChanges();
            }
        }

        public void Modify(Category modifiedcategory)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Category categoryToModify = context.Categories.FirstOrDefault(c => c.Id == modifiedcategory.Id);
                categoryToModify.Name = modifiedcategory.Name;
                context.SaveChanges();
            }
        }

        public bool CheckUniqueness(Category category)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                string userMasterName = category.GetUserMasterName();
                List<Category> currentUserCategories = context.Users.Include("Categories").FirstOrDefault(u => u.MasterName == userMasterName).Categories;
                bool categoryIsUnique = !currentUserCategories.Contains(category);
                return categoryIsUnique;
            }
        }

        public IEnumerable<Category> GetAll(string userMasterName)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                List<Category> categories = context.Users.Include("Categories").FirstOrDefault(u => u.MasterName == userMasterName).Categories;
                return categories;
            }
        }

        public bool CategoryBelongsToUser(Category category, User user)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                string userMasterName = user.MasterName;
                List<Category> currentUserCategories = context.Users.Include("Categories").FirstOrDefault(u => u.MasterName == userMasterName).Categories;
                bool belongsToUser = currentUserCategories.Contains(category);
                return belongsToUser;
            }
        }

    }


}
