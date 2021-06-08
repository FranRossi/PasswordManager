
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
        public User User { get; set; }

        public abstract HashSet<string> GetDataBreachItems(T data);

        public DataBreach()
        {
            this.Date = DateTime.Today;
        }
    }
}
