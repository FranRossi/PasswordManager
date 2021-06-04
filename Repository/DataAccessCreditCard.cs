using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataAccessCreditCard : IDataAccess<CreditCard>
    {
        public void Add(CreditCard pCreditCard)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Categories.Attach(pCreditCard.Category);
                context.Users.Attach(pCreditCard.User);
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

        public IEnumerable<CreditCard> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Modify(CreditCard pCreditCard)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                CreditCard creditCardToModify = context.CreditCards.FirstOrDefault(c => c.Id == pCreditCard.Id);
                
                creditCardToModify.Category = pCreditCard.Category;
                creditCardToModify.Number = pCreditCard.Number;
                creditCardToModify.SecureCode = pCreditCard.SecureCode;
                creditCardToModify.ExpirationDate = pCreditCard.ExpirationDate;
                creditCardToModify.Type = pCreditCard.Type;
                creditCardToModify.Notes = pCreditCard.Notes;
                creditCardToModify.Name = pCreditCard.Name;
                context.SaveChanges();
             }
        }

    }
}
