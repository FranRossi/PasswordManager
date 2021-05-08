using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Utilities
{
    public interface IDataBreach<T>
    {
        T Data { set; }
        string GetToDataBreachString();
    }
}
