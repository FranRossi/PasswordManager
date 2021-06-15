using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessCategory
{
    public interface IDataAccessCategory
    {
        void Add(Category newCategory);
        void Modify(Category modifiedcategory);
        IEnumerable<Category> GetAll(string userMasterName);
        bool CheckUniqueness(Category category);
        bool CategoryBelongsToUser(Category category, User user);
    }
}

