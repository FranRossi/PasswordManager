using DataAccessInterfaces;
using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataAccessCreditCard : IDataAccessCreditCard
    {
        public void Add(CreditCard newCreditCard)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Category cardCategory = newCreditCard.Category;
                User cardUser = newCreditCard.User;
                Category cardCategoryFromDB = context.Categories.FirstOrDefault(c => c.Id == cardCategory.Id);
                User cardUserFromDB = context.Users.FirstOrDefault(u => u.MasterName == cardUser.MasterName);
                newCreditCard.Category = cardCategoryFromDB;
                newCreditCard.User = cardUserFromDB;

                context.Categories.Attach(cardCategoryFromDB);
                context.Users.Attach(cardUserFromDB);
                context.CreditCards.Add(newCreditCard);
                context.SaveChanges();
            }
        }

        public void Delete(CreditCard creditCard)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                CreditCard creditCardToDelete = context.CreditCards.FirstOrDefault(c => c.Id == creditCard.Id);
                context.CreditCards.Remove(creditCardToDelete);
                context.SaveChanges();
            }
        }

        public IEnumerable<CreditCard> GetAll(string userMasterName)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                IEnumerable<CreditCard> creditCards = context.CreditCards.Include("Category").Include("User").Where(card => card.User.MasterName == userMasterName).ToList();
                return creditCards;
            }
        }

        public void Modify(CreditCard modifiedCreditCard)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Category cardCategory = modifiedCreditCard.Category;
                User cardUser = modifiedCreditCard.User;
                Category cardCategoryFromDB = context.Categories.FirstOrDefault(c => c.Id == cardCategory.Id);
                User cardUserFromDB = context.Users.FirstOrDefault(u => u.MasterName == cardUser.MasterName);
                CreditCard creditCardToModify = context.CreditCards.FirstOrDefault(c => c.Id == modifiedCreditCard.Id);

                creditCardToModify.Category = cardCategoryFromDB;
                creditCardToModify.User = cardUserFromDB;
                creditCardToModify.Number = modifiedCreditCard.Number;
                creditCardToModify.SecureCode = modifiedCreditCard.SecureCode;
                creditCardToModify.ExpirationDate = modifiedCreditCard.ExpirationDate;
                creditCardToModify.Type = modifiedCreditCard.Type;
                creditCardToModify.Notes = modifiedCreditCard.Notes;
                creditCardToModify.Name = modifiedCreditCard.Name;
                context.SaveChanges();
            }
        }

        public bool CheckUniqueness(CreditCard newCreditCard)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {

                CreditCard cardToCheck = context.CreditCards.Include("User").FirstOrDefault
                    (c => newCreditCard.User.MasterName == c.User.MasterName
                    && c.Number == newCreditCard.Number && c.Id != newCreditCard.Id);
                bool creditCardIsNull = cardToCheck == null;
                return creditCardIsNull;
            }
        }
    }
}
