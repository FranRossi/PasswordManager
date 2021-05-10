using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Utilities;
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
            DataBreachFromString dataBreach = new DataBreachFromString()
            {
                Data = txtDataBreach.Text
            };
            List<Item> breachResult = _myPasswordManager.GetBreachedItems(dataBreach);
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
            foreach (DataGridViewColumn column in tblDataBreachCreditCard.Columns)
            {
                switch (column.Name)
                {
                    case "Name":
                        column.HeaderText = "Nombre";
                        break;
                    case "Number":
                        column.HeaderText = "Numero";
                        break;
                    case "Type":
                        column.HeaderText = "Tipo";
                        break;
                    default:
                        column.Visible = false;
                        break;
                }
            }
        }

        private void LoadTblPassword(List<Password> passwords)
        {
            tblDataBreachPassword.DataSource = passwords;
            foreach (DataGridViewColumn column in tblDataBreachPassword.Columns)
            {
                switch (column.Name)
                {
                    case "Site":
                        column.HeaderText = "Sitio";
                        break;
                    case "username":
                        column.HeaderText = "Nombre de usuario";
                        break;
                    case "Category":
                        column.HeaderText = "Categoria";
                        break;
                    default:
                        column.Visible = false;
                        break;
                }
            }
        }
    }
}
