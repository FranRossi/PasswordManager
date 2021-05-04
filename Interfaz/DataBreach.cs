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

        private PasswordManager _myPasswordManager;
        public DataBreach(PasswordManager pPasswordManager)
        {
            InitializeComponent();
            _myPasswordManager = pPasswordManager;
        }

        private void btnVerifyDataBreach_Click(object sender, EventArgs e)
        {
            List<Item> breachResult = _myPasswordManager.GetBreachedItems(txtDataBreach.Text);
            List<Password> passwords = new List<Password>();
            List<CreditCard> creditCards = new List<CreditCard>();
            foreach (Item i in breachResult)
            {
                if (i.GetType().Equals(typeof(Password)))
                    passwords.Add((Password)i);
                else
                    creditCards.Add((CreditCard)i);
            }
            LoadTblCreditCard(creditCards);
            LoadTblPassword(passwords);
        }

        private void LoadTblCreditCard(List<CreditCard> creditCards)
        {
            tblDataBreachCreditCard.DataSource = creditCards;
            foreach (DataGridViewColumn c in tblDataBreachCreditCard.Columns)
            {
                switch (c.Name)
                {
                    case "Name":
                        c.HeaderText = "Nombre";
                        break;
                    case "Number":
                        c.HeaderText = "Numero";
                        break;
                    case "Type":
                        c.HeaderText = "Tipo";
                        break;
                    default:
                        c.Visible = false;
                        break;
                }
            }
        }

        private void LoadTblPassword(List<Password> creditCards)
        {
            tblDataBreachPassword.DataSource = creditCards;
            foreach (DataGridViewColumn c in tblDataBreachPassword.Columns)
            {
                switch (c.Name)
                {
                    case "Site":
                        c.HeaderText = "Sitio";
                        break;
                    case "username":
                        c.HeaderText = "Nombre de usuario";
                        break;
                    case "Category":
                        c.HeaderText = "Categoria";
                        break;
                    default:
                        c.Visible = false;
                        break;
                }
            }
        }
    }
}
