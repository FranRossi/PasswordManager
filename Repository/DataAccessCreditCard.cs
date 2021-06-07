using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataAccessCreditCard : IDataAccessCreditCard<CreditCard>
    {
        public void Add(CreditCard pCreditCard)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Category cardCategory = pCreditCard.Category;
                User cardUser = pCreditCard.User;
                Category cardCategoryFromDB = context.Categories.FirstOrDefault(c => c.Id == cardCategory.Id);
                User cardUserFromDB = context.Users.FirstOrDefault(u => u.MasterName == cardUser.MasterName);
                pCreditCard.Category = cardCategoryFromDB;
                pCreditCard.User = cardUserFromDB;

                context.Categories.Attach(cardCategoryFromDB);
                context.Users.Attach(cardUserFromDB);
                context.CreditCards.Add(pCreditCard);
                context.SaveChanges();
            }
        }

        public void Delete(CreditCard pCreditCard)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                CreditCard creditCardToDelete = context.CreditCards.FirstOrDefault(c => c.Id == pCreditCard.Id);
                context.CreditCards.Remove(creditCardToDelete);
                context.SaveChanges();
            }
        }

        public IEnumerable<CreditCard> GetAll(string pMasterName)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                IEnumerable<CreditCard> creditCards = context.CreditCards.Include("Category").Include("User").Where(card => card.User.MasterName == pMasterName).ToList();
                return creditCards;
            }
        }

        public void Modify(CreditCard pCreditCard)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Category cardCategory = pCreditCard.Category;
                User cardUser = pCreditCard.User;
                Category cardCategoryFromDB = context.Categories.FirstOrDefault(c => c.Id == cardCategory.Id);
                User cardUserFromDB = context.Users.FirstOrDefault(u => u.MasterName == cardUser.MasterName);
                CreditCard creditCardToModify = context.CreditCards.FirstOrDefault(c => c.Id == pCreditCard.Id);

                creditCardToModify.Category = cardCategoryFromDB;
                creditCardToModify.User = cardUserFromDB;
                creditCardToModify.Number = pCreditCard.Number;
                creditCardToModify.SecureCode = pCreditCard.SecureCode;
                creditCardToModify.ExpirationDate = pCreditCard.ExpirationDate;
                creditCardToModify.Type = pCreditCard.Type;
                creditCardToModify.Notes = pCreditCard.Notes;
                creditCardToModify.Name = pCreditCard.Name;
                context.SaveChanges();
            }
        }

        public bool CheckUniqueness(CreditCard newCreditCard)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {

                CreditCard cardToCheck = context.CreditCards.FirstOrDefault
                    (c => c.Number == newCreditCard.Number && c.Id != newCreditCard.Id);
                bool creditCardIsNull = cardToCheck == null;
                return creditCardIsNull;
            }
        }
    }
}
