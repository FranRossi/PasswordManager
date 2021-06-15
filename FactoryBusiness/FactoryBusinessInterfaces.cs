using BusinessInterfaces;
using BusinessLogic;


namespace FactoryBusiness
{
    public static class FactoryBusinessInterfaces
    {
        public static ISessionController GetInstanceSessionController()
        {
            return SessionController.GetInstance();
        }

        public static ICategoryController CreateCategoryController()
        {
            return new CategoryController();
        }

        public static ICreditCardController CreateCreditCardController()
        {
            return new CreditCardController();
        }

        public static IDataBreachController CreateDataBreachController()
        {
            return new DataBreachController();
        }

        public static IPasswordColorReportController CreatePasswordColorReportController()
        {
            return new PasswordColorReportController();
        }

        public static IPasswordController CreatePasswordController()
        {
            return new PasswordController();
        }

        public static ISharePasswordController CreateSharePasswordController()
        {
            return new SharePasswordController();
        }
    }
}
