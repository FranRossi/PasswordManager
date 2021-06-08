
using System;
using System.Collections.Generic;

namespace Obligatorio1_DA1.Domain
{
    public interface DataBreachReader<T>
    {
        HashSet<string> GetDataBreachItems(T data);
    }
}
