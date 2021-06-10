
using System;
using System.Collections.Generic;

namespace Obligatorio1_DA1.Domain
{
    public class DataBreachReport
    {
        public HashSet<DataBreachReportEntry> Entries { get; set; }
        public DateTime Date { get; set; }
        public int Id { get; set; }
        public List<Item> BreachedItems { get; set; }
        public User User { get; set; }

        public DataBreachReport(HashSet<DataBreachReportEntry> breachReport, User curentUser)
        {
            this.Date = DateTime.Today;
            this.Entries = breachReport;
            this.User = curentUser;
        }

        private DataBreachReport() { }
    }
}
