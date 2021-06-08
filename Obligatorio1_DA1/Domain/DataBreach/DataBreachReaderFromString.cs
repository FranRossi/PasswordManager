
using System;
using System.Collections.Generic;

namespace Obligatorio1_DA1.Domain
{
    public class DataBreachReaderFromString : DataBreachReader<string>
    {
        public HashSet<string> GetDataBreachItems(string data)
        {
            HashSet<string> dataBreachItems = new HashSet<string>();
            string[] splittedDataBreach = data.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            foreach (string stringItem in splittedDataBreach)
            {
                if (stringItem.Length > 0)
                    dataBreachItems.Add(stringItem);
            }
            return dataBreachItems;
        }
    }
}
