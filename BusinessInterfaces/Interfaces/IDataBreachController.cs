using System.Collections.Generic;
using Obligatorio1_DA1.Domain;

namespace BusinessInterfaces
{
    public interface IDataBreachController
    {
        List<Item> SaveBreachedItems(DataBreachReport dataBreachReport);

        List<DataBreachReport> GetDataBreachReportsFromCurrentUser();

        bool VerifyPasswordHasBeenBreached(Password passwordToCheck);

    }
}