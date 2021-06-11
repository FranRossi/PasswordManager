﻿using System;
using Repository;
using System.Collections.Generic;
using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Domain;
using System.Linq;

namespace BusinessLogic
{
    public class CategoryController
    {
        private SessionController _sessionController;
        private DataAccessUser _users;
        private DataAccessCategory _categories;
        private DataAccessCreditCard _creditCards;
        private DataAccessPassword _passwords;
        private DataAccessDataBreach _dataBreaches;

        public CategoryController()
        {
            _users = new DataAccessUser();
            _categories = new DataAccessCategory();
            _creditCards = new DataAccessCreditCard();
            _passwords = new DataAccessPassword();
            _dataBreaches = new DataAccessDataBreach();
            _sessionController = SessionController.GetInstance();
        }

        //-------------------------------------------------CATEGORY CONTROLLER--------------------------------------------------
        public List<Category> GetCategoriesFromCurrentUser()
        {
            return _categories.GetAll(_sessionController.GetCurrentUserMasterName()).ToList();
        }

        public void CreateCategoryOnCurrentUser(string category)
        {
            Category newCategory = new Category
            {
                Name = category,
                User = _sessionController.CurrentUser
            };
            VerifyCategoryUniqueness(newCategory);
            _categories.Add(newCategory);
        }

        private void VerifyCategoryUniqueness(Category newCategory)
        {
            if (!_categories.CheckUniqueness(newCategory))
                throw new CategoryAlreadyAddedException();
        }

        public void ModifyCategoryOnCurrentUser(Category modifiedCategory)
        {
            VerifyCategoryUniqueness(modifiedCategory);
            _categories.Modify(modifiedCategory);
        }

        public void VerifyItemCategoryBelongsToUser(Item newItem)
        {
            bool categoryBelongsToUser = _categories.CategoryBelongsToUser(newItem.Category, newItem.User);
            if (!categoryBelongsToUser)
                throw new ItemInvalidCategoryException();
        }
    }
}