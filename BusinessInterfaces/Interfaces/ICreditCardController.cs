using System.Collections.Generic;
using Obligatorio1_DA1.Domain;


namespace BusinessInterfaces
{
    public interface ICreditCardController
    {
        void CreateCreditCard(CreditCard newCreditCard);

        List<CreditCard> GetCreditCards();

        void ModifyCreditCardOnCurrentUser(CreditCard newCreditCard);

        void DeleteCreditCard(CreditCard card);

    }
}