
using System;
using System.Collections.Generic;

namespace Obligatorio1_DA1.Domain
{
    public interface DataBreachReader<T>
    {
        HashSet<DataBreachReportEntry> GetDataBreachItems(T data);
    }
}
