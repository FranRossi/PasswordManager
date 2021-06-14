using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataAccessDataBreach : IDataAccessDataBreach
    {
        public List<Item> AddDataBreachReport(DataBreachReport dataBreachReport)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                List<Item> breachedItems = new List<Item>();
                HashSet<DataBreachReportEntry> dataBreachItems = dataBreachReport.Entries;
                User dataBreachUserFromDB = context.Users.FirstOrDefault(u => u.MasterName == dataBreachReport.User.MasterName);
                User originalUser = dataBreachReport.User;
                dataBreachReport.User = dataBreachUserFromDB;
                foreach (DataBreachReportEntry dataBreachItem in dataBreachItems)
                {
                    foreach (Password pass in context.Passwords.Include("User").Include("Category"))
                    {
                        if (pass.User.Equals(dataBreachUserFromDB))
                        {
                            SynchronizeLocalAndDBUsersDecryptionKey(originalUser, pass.User);
                            if (pass.Pass == dataBreachItem.Value)
                                breachedItems.Add(pass);
                        }
                    }
                    foreach (CreditCard card in context.CreditCards.Include("User").Include("Category"))
                        if (card.Number == dataBreachItem.Value && card.User.Equals(dataBreachUserFromDB))
                            breachedItems.Add(card);
                }
                dataBreachReport.BreachedItems = breachedItems;
                SaveDataBreach(dataBreachReport, context);
                return breachedItems;
            }
        }

        private void SynchronizeLocalAndDBUsersDecryptionKey(User originalUser, User user)
        {
            user.DecryptionKey = originalUser.DecryptionKey;
        }

        private void SaveDataBreach(DataBreachReport dataBreachReport, PasswordManagerDBContext context)
        {
            context.DataBreachReports.Add(dataBreachReport);
            context.SaveChanges();
        }

        public bool CheckIfPasswordHasBeenBreached(User currentUser, Password passwordToCheck)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                bool passwordHasBeenBreached = false;
                List<DataBreachReport> dataBreachReportsForCurrentUser = GetDataBreachReportsFromUser(currentUser);

                foreach (DataBreachReport breach in dataBreachReportsForCurrentUser)
                {
                    passwordHasBeenBreached = breach.BreachedItems.Contains(passwordToCheck);
                    if (passwordHasBeenBreached)
                        return passwordHasBeenBreached;
                }

                return passwordHasBeenBreached;
            }
        }

        public List<DataBreachReport> GetDataBreachReportsFromUser(User user)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                List<DataBreachReport> reports = context.DataBreachReports.Include("User").Include("BreachedItems").Include("Entries").Where(report => report.User.MasterName == user.MasterName).ToList();
                foreach (DataBreachReport report in reports)
                    SynchronizeLocalAndDBUsersDecryptionKey(user, report.User);
                return reports;
            }
        }
    }
}
