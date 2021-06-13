using System;
using Repository;
using System.Collections.Generic;
using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Domain;
using System.Linq;

namespace BusinessLogic
{
    public interface IDataBreachController
    {
        List<Item> SaveBreachedItems(DataBreachReport dataBreachReport);

        List<DataBreachReport> GetDataBreachReportsFromCurrentUser();

        bool VerifyPasswordHasBeenBreached(Password passwordToCheck);

    }
}