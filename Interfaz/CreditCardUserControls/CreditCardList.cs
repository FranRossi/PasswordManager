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
    public partial class CreditCardList : UserControl
    {
        private PasswordManager _myPasswordManager;
        private CreditCard _selectedCreditCard;
        public CreditCardList(PasswordManager pPasswordManager)
        {
            InitializeComponent();
            _myPasswordManager = pPasswordManager;
            LoadTblCreditCard();
        }

        private void LoadTblCreditCard()
        {
            List<CreditCard> creditCards = _myPasswordManager.GetCreditCards();
            tblCreditCard.DataSource = null;
            tblCreditCard.Rows.Clear();
            tblCreditCard.DataSource = creditCards;
            FormatCreditCardListOnTable();
        }

        private void FormatCreditCardListOnTable()
        {
            foreach (DataGridViewColumn column in tblCreditCard.Columns)
            {
                switch (column.Name)
                {
                    case "Category":
                        column.HeaderText = "Categoria";
                        break;
                    case "Name":
                        column.HeaderText = "Nombre";
                        break;
                    case "Type":
                        column.HeaderText = "Tipo";
                        break;
                    case "SecretNumber":
                        column.HeaderText = "Numero";
                        break;
                    case "ExpirationDate":
                        column.HeaderText = "Vencimiento";
                        break;
                    default:
                        column.Visible = false;
                        break;
                }
            }
        }

        private void btnAddCreditCard_Click(object sender, EventArgs e)
        {
            Form createCreditCard = new CreateModifyCreditCard(_myPasswordManager);
            createCreditCard.FormClosing += new FormClosingEventHandler(RefreshForm);
            createCreditCard.ShowDialog();
        }

        private void RefreshForm(object sender, FormClosingEventArgs e)
        {
            LoadTblCreditCard();
        }

        private void btnDeleteCreditCard_Click(object sender, EventArgs e)
        {
            UpdateSelectedCreditCard();
            if (_selectedCreditCard != null)
            {
                if (ShowConfirmationPopUp())
                {
                    _myPasswordManager.DeleteCreditCard(_selectedCreditCard);
                    this.lblMessage.Text = "Tarjeta eliminada exitosamente.";
                    LoadTblCreditCard();
                }
            }
            else
            {
                this.lblMessage.Text = "Debe seleccionar la tarjeta que desea eliminar.";
            }

        }

        private bool ShowConfirmationPopUp()
        {
            if (!Properties.Settings.Default.DontShowAgainPopUp)
            {
                Form DeleteConfirmationPopUp = new DeleteConfirmation("Tarjeta");
                DialogResult resultConfirmation = DeleteConfirmationPopUp.ShowDialog();
                DeleteConfirmationPopUp.Close();
                return resultConfirmation == DialogResult.OK;
            }
            return true;
        }

        private void btnModifyCreditCard_Click(object sender, EventArgs e)
        {
            UpdateSelectedCreditCard();
            if (_selectedCreditCard != null)
            {
                Form createCreditCard = new CreateModifyCreditCard(_myPasswordManager, _selectedCreditCard);
                createCreditCard.FormClosing += new FormClosingEventHandler(RefreshForm);
                createCreditCard.ShowDialog();
            }
            else
            {
                this.lblMessage.Text = "Debe seleccionar la tarjeta que desea eliminar.";
            }

        }

        private void UpdateSelectedCreditCard()
        {
            if (tblCreditCard.SelectedCells.Count > 0)
            {
                try
                {
                    _selectedCreditCard = (CreditCard)tblCreditCard.CurrentRow.DataBoundItem;
                }
                catch (FormatException exception)
                {
                    this.lblMessage.Text = "Error al seleccionar la tarjeta.";
                }
            }
        }
    }
}
