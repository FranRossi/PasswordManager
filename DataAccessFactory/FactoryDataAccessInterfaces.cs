using DataAccessInterfaces;
using Obligatorio1_DA1.Domain;
using Repository;

namespace DataAccessFactory
{
    public static class FactoryDataAccessInterfaces
    {
        public static IDataAccessCategory CreateDataAccessCategory()
        {
            return new DataAccessCategory();
        }

        public static IDataAccessCreditCard CreateDataAccessCreditCard()
        {
            return new DataAccessCreditCard();
        }

        public static IDataAccessPassword CreateDataAccessPassword()
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
