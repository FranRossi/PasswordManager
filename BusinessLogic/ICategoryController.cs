using System;
using Repository;
using System.Collections.Generic;
using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Domain;
using System.Linq;

namespace BusinessLogic
{
    public interface ICategoryController
    {
        List<Category> GetCategoriesFromCurrentUser();

        void CreateCategoryOnCurrentUser(string category);

        void VerifyCategoryUniqueness(Category newCategory);

        void ModifyCategoryOnCurrentUser(Category modifiedCategory);

        void VerifyItemCategoryBelongsToUser(Item newItem);
    }
}
