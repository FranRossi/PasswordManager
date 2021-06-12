using System;
using Repository;
using System.Collections.Generic;
using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Domain;
using System.Linq;

namespace BusinessLogic
{
    public class DataBreachController
    {
        private SessionController _sessionController;
        private IDataAccessDataBreach _dataBreaches;

        public DataBreachController()
        {
            _dataBreaches = new DataAccessDataBreach();
            _sessionController = SessionController.GetInstance();
        }

        public List<Item> SaveBreachedItems(DataBreachReport dataBreachReport)
        {
            //TODO VER SI HACER VOID Y CARGAR DATABREACH
            List<Item> breachedItems = _dataBreaches.AddDataBreachReport(dataBreachReport);
            return breachedItems;
        }

        public List<DataBreachReport> GetDataBreachReportsFromCurrentUser()
        {
            List<DataBreachReport> reports = _dataBreaches.GetDataBreachReportsFromUser(_sessionController.GetCurrentUserMasterName());
            return reports;
        }

        public bool VerifyPasswordHasBeenBreached(Password passwordToCheck)
        {
            bool passwordIsBreached = _dataBreaches.CheckIfPasswordHasBeenBreached(_sessionController.CurrentUser, passwordToCheck);
            return passwordIsBreached;
        }

    }
}