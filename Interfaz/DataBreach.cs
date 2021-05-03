using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class DataBreach : UserControl
    {
        private PasswordManager _passwordManager;

        private PasswordManager _myPasswordManager;
        public DataBreach(PasswordManager pPasswordManager)
        {
            InitializeComponent();
            _myPasswordManager = pPasswordManager;
        }

        private void btnVerifyDataBreach_Click(object sender, EventArgs e)
        {
            List<Item> breachResult = _passwordManager.GetBreachedItems(txtDataBreach.Text, _currentUser);
            List<Password> passwords = new List<Password>();
            List<CreditCard> creditCards = new List<CreditCard>();
            foreach (Item i in breachResult)
            {
                if (i.GetType().Equals(typeof(Password)))
                    passwords.Add((Password)i);
                else
                    creditCards.Add((CreditCard)i);
            }
            tblDataBreachCreditCard.DataSource = creditCards;
            tblDataBreachPassword.DataSource = passwords;
        }
    }
}
