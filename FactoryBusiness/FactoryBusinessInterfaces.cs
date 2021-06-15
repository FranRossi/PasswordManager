using BusinessInterfaces;
using BusinessLogic;


namespace FactoryBusiness
{
    public static class FactoryBusinessInterfaces
    {
        public static ICategoryController CreateDataAccessCategory()
        {
            return new CategoryController();
        }

        public static IDataAccessCreditCard<CreditCard> CreateDataAccessCreditCard()
        {
            return new DataAccessCreditCard();
        }

        public static IDataAccessPassword<Password> CreateDataAccessPassword()
        {
            return new DataAccessPassword();
        }

        public static IDataAccessDataBreach CreateDataAccessDataBreach()
        {
            return new DataAccessDataBreach();
        }

        public static IDataAccessUser CreateDataAccessUser()
        {
            return new DataAccessUser();
        }
    }
}
