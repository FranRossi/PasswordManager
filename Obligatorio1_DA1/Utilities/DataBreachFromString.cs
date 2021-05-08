using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Utilities
{
    public class DataBreachFromString : IDataBreach<string>
    {
        public string Data { set; private get; }

        public string GetToDataBreachString()
        {
            return this.Data;
        }
    }
}
