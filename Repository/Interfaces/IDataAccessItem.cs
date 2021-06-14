using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IDataAccessItem<T>
    {
        void Add(T entry);
        void Delete(T entry);
        void Modify(T entry);
        IEnumerable<T> GetAll(String pMasterName);
        bool CheckUniqueness(T item);
    }
}

