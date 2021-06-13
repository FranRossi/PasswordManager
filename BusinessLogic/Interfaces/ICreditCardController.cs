using System;
using Repository;
using System.Collections.Generic;
using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Domain;
using System.Linq;

namespace BusinessLogic
{
    public interface ICreditCardController
    {
        void CreateCreditCard(CreditCard newCreditCard);

        List<CreditCard> GetCreditCards();

        void ModifyCreditCardOnCurrentUser(CreditCard newCreditCard);

        void DeleteCreditCard(CreditCard card);

    }
}