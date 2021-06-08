using BusinessLogic;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentation
{
    public partial class DataBreach : UserControl
    {

        private PasswordManager _myPasswordManager;
        private Password _selectedPassword;

        public DataBreach(PasswordManager pPasswordManager)
        {
            InitializeComponent();
            _myPasswordManager = pPasswordManager;
        }

        private void btnVerifyDataBreach_Click(object sender, EventArgs e)
        {
            LoadDataBreach();
        }

        private void LoadTables(List<Item> breachResult)
        {
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

        private void LoadDataBreach()
        {
            DataBreachFromString dataBreach = new DataBreachFromString();
            List<Item> breachResult = _myPasswordManager.SaveBreachedItems(dataBreach);
            LoadTables(breachResult);
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

        private void btnModifyPass_Click(object sender, EventArgs e)
        {
            UpdateSelectedPassword();
            if (_selectedPassword != null)
            {
                Form createPassword = new CreateModifyPassword(_myPasswordManager, _selectedPassword);
                createPassword.FormClosing += new FormClosingEventHandler(RefreshForm);
                createPassword.ShowDialog();
            }
            else
            {
                lblMessage.Text = "Debe seleccionar la contraseña que desea modificar.";
            }
        }

        private void UpdateSelectedPassword()
        {
            if (tblDataBreachPassword.SelectedCells.Count > 0)
            {
                try
                {
                    _selectedPassword = (Password)tblDataBreachPassword.SelectedCells[0].OwningRow.DataBoundItem;
                }
                catch (InvalidCastException exception)
                {
                    lblMessage.Text = "Error al seleccionar la contraseña.";
                }
            }
        }
        private void RefreshForm(object sender, FormClosingEventArgs e)
        {
            LoadDataBreach();
        }
    }
}
