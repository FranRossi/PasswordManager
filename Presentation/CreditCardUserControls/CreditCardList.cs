using Obligatorio1_DA1.Domain;
using BusinessInterfaces;
using Presentation.CreditCardUserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessFactory;

namespace Presentation
{
    public partial class CreditCardList : UserControl
    {
        private ICreditCardController _myCreditCardController;
        private CreditCard _selectedCreditCard;
        public CreditCardList()
        {
            InitializeComponent();
            _myCreditCardController = FactoryBusinessInterfaces.CreateCreditCardController();
            LoadTblCreditCard();
        }

        private void LoadTblCreditCard()
        {
            List<CreditCard> creditCards = _myCreditCardController.GetCreditCards();
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
            Form createCreditCard = new CreateModifyCreditCard();
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
                    _myCreditCardController.DeleteCreditCard(_selectedCreditCard);
                    lblMessage.Text = "Tarjeta eliminada exitosamente.";
                    LoadTblCreditCard();
                }
            }
            else
            {
                lblMessage.Text = "Debe seleccionar la tarjeta que desea eliminar.";
            }

        }

        private bool ShowConfirmationPopUp()
        {
            if (!Properties.Settings.Default.DontShowAgainPopUpCreditCard)
            {
                Form DeleteConfirmationPopUp = new DeleteConfirmation("tarjeta");
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
                Form createCreditCard = new CreateModifyCreditCard(_selectedCreditCard);
                createCreditCard.FormClosing += new FormClosingEventHandler(RefreshForm);
                createCreditCard.ShowDialog();
            }
            else
            {
                lblMessage.Text = "Debe seleccionar la tarjeta que desea modificar.";
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
                catch (InvalidCastException exception)
                {
                    lblMessage.Text = "Error al seleccionar la tarjeta.";
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            UpdateSelectedCreditCard();
            if (_selectedCreditCard != null)
            {
                Form showPassord = new ShowCreditCard(_selectedCreditCard);
                showPassord.ShowDialog();
            }
            else
            {
                lblMessage.Text = "Debe seleccionar la tarjeta que desea mostrar.";
            }
        }

    }
}
