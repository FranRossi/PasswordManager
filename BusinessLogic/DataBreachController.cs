using System.Collections.Generic;
using Obligatorio1_DA1.Domain;
using DataAccessInterfaces;
using DataAccessFactory;
using BusinessInterfaces;

namespace BusinessLogic
{
    public class DataBreachController : IDataBreachController
    {
        private SessionController _sessionController;
        private IDataAccessDataBreach _dataBreaches;

        public DataBreachController()
        {
            _dataBreaches = FactoryDataAccessInterfaces.CreateDataAccessDataBreach();
            _sessionController = SessionController.GetInstance();
        }

        public List<Item> SaveBreachedItems(DataBreachReport dataBreachReport)
        {
            List<Item> breachedItems = _dataBreaches.AddDataBreachReport(dataBreachReport);
            return breachedItems;
        }

        public List<DataBreachReport> GetDataBreachReportsFromCurrentUser()
        {
            List<DataBreachReport> reports = _dataBreaches.GetDataBreachReportsFromUser(_sessionController.CurrentUser);
            return reports;
        }

        public bool VerifyPasswordHasBeenBreached(Password passwordToCheck)
        {
            bool passwordIsBreached = _dataBreaches.CheckIfPasswordHasBeenBreached(_sessionController.CurrentUser, passwordToCheck);
            return passwordIsBreached;
        }

    }
}