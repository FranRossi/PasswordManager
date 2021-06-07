
using System;
using System.Collections.Generic;

namespace Obligatorio1_DA1.Domain
{
    public abstract class DataBreach<T>
    {
        public HashSet<string> DataBreachItems { get; set; }
        public DateTime Date { get; set; }
        public int Id { get; set; }
        public List<Item> BreachedItems { get; set; }

        protected abstract HashSet<string> GetDataBreachString(T data);

        public DataBreach(T data)
        {
            this.DataBreachItems = GetDataBreachString(data);
            this.Date = DateTime.Today;
        }
    }
}
