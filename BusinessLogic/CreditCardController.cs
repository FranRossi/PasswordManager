using System.Collections.Generic;
using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Domain;
using System.Linq;
using DataAccessInterfaces;
using FactoryDataAccess;

namespace BusinessLogic
{
    public class CreditCardController : ICreditCardController
    {
        private SessionController _sessionController;
        private CategoryController _categoryController;
        private IDataAccessCreditCard<CreditCard> _creditCards;

        public CreditCardController()
        {
            _creditCards = FactoryDataAccessInterfaces.CreateDataAccessCreditCard();
            _sessionController = SessionController.GetInstance();
            _categoryController = new CategoryController();
        }

        public void CreateCreditCard(CreditCard newCreditCard)
        {
            VerifyCreditCardBelongToCurrentUser(newCreditCard);
            VerifyCreditCardUniqueness(newCreditCard);
            _categoryController.VerifyItemCategoryBelongsToUser(newCreditCard);
            _creditCards.Add(newCreditCard);
        }

        private void VerifyCreditCardUniqueness(CreditCard newCreditCard)
        {
            if (!_creditCards.CheckUniqueness(newCreditCard))
                throw new CreditCardAlreadyExistsException();
        }

        public List<CreditCard> GetCreditCards()
        {
            string currentUserMasterName = _sessionController.GetCurrentUserMasterName();
            return _creditCards.GetAll(currentUserMasterName).ToList();
        }

        public void ModifyCreditCardOnCurrentUser(CreditCard newCreditCard)
        {
            VerifyCreditCardBelongToCurrentUser(newCreditCard);
            VerifyCreditCardUniqueness(newCreditCard);
            _categoryController.VerifyItemCategoryBelongsToUser(newCreditCard);
            _creditCards.Modify(newCreditCard);
        }

        public void DeleteCreditCard(CreditCard card)
        {
            _creditCards.Delete(card);
        }

        private void VerifyCreditCardBelongToCurrentUser(CreditCard newCreditCard)
        {
            if (!(newCreditCard.User.Equals(_sessionController.CurrentUser)))
                throw new CreditCardNotBelongToCurrentUserException();
        }
    }
}