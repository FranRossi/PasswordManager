
using System;
using System.Collections.Generic;

namespace Obligatorio1_DA1.Domain
{
    public class DataBreachReaderFromTextFile : IDataBreachReader<string>
    {
        public HashSet<DataBreachReportEntry> GetDataBreachEntries(string data)
        {
            HashSet<DataBreachReportEntry> dataBreachItems = new HashSet<DataBreachReportEntry>();
            string[] splittedDataBreach = data.Split(new[] { "\t" }, StringSplitOptions.None);
            foreach (string stringItem in splittedDataBreach)
            {
                if (stringItem.Length > 0)
                {
                    DataBreachReportEntry newEntry = new DataBreachReportEntry()
                    {
                        Value = stringItem
                    };
                    dataBreachItems.Add(newEntry);
                }

            }
            return dataBreachItems;
        }
    }
}
