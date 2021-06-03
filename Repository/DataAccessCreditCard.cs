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

        public void Modify(CreditCard entry)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                CreditCard creditCardToModify = context.CreditCards.FirstOrDefault(c => c.Id == entry.Id);
                context.CreditCards.
                context.SaveChanges();
            }
        }
    }
}
