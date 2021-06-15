using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;

namespace UnitTestObligatorio1
{
    public class Services
    {
        public void DataBaseCleanup()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM PASSWORDS");
                context.Database.ExecuteSqlCommand("DELETE FROM CREDITCARDS");
                context.Database.ExecuteSqlCommand("DELETE FROM DATABREACHREPORTS");
                context.Database.ExecuteSqlCommand("DELETE FROM USERS");
            }

        }

    }
}
