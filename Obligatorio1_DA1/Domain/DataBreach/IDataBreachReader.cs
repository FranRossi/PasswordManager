
using System;
using System.Collections.Generic;

namespace Obligatorio1_DA1.Domain
{
    public interface IDataBreachReader<T>
    {
        HashSet<DataBreachReportEntry> GetDataBreachItems(T data);
    }
}
