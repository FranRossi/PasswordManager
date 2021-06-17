using System.Collections.Generic;
using Obligatorio1_DA1.Domain;

namespace BusinessInterfaces
{
    public interface ICategoryController
    {
        List<Category> GetCategoriesFromCurrentUser();

        void CreateCategoryOnCurrentUser(string category);

        void ModifyCategoryOnCurrentUser(Category modifiedCategory);

        void VerifyItemCategoryBelongsToUser(Item newItem);
    }
}
