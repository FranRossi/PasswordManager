
using System;
using System.Collections.Generic;

namespace Obligatorio1_DA1.Domain
{
    public class DataBreachReport
    {
        public HashSet<string> DataBreachItems { get; set; }
        public DateTime Date { get; set; }
        public int Id { get; set; }
        public List<Item> BreachedItems { get; set; }
        public User User { get; set; }

        public DataBreachReport(HashSet<string> breachReport)
        {
            this.Date = DateTime.Today;
            this.DataBreachItems = breachReport;
        }
    }
}
