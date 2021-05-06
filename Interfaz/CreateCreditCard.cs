using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
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
    public partial class CreateCreditCard : Form
    {
        private PasswordManager _myPasswordManager;
        private CreditCard _myCreditCard;

        public CreateCreditCard(PasswordManager pPasswordManager)
        {
            InitializeComponent();
            _myPasswordManager = pPasswordManager;
            LoadComboBoxCategory();
        }

        public CreateCreditCard(PasswordManager pPasswordManager, CreditCard pCreditCard)
        {
            InitializeComponent();
            _myPasswordManager = pPasswordManager;
            _myCreditCard = pCreditCard;
            LoadComboBoxCategory();
            LoadFromCreditCard();
        }


        private void LoadComboBoxCategory()
        {
            cbCategory.DataSource = _myPasswordManager.GetCategoriesFromCurrentUser();
        }

        private void LoadFromCreditCard()
        {
            txtName.Text = _myCreditCard.Name;
            txtType.Text = _myCreditCard.Type;
            txtNumber.Text = _myCreditCard.Number;
            txtSecureCode.Text = _myCreditCard.SecureCode;
            txtExpirationDate.Text = _myCreditCard.ExpirationDate;
            txtNotes.Text = _myCreditCard.Notes;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (CategoryIsSelectedComboBox())
            {
                try
                {
                    if (_myCreditCard == null)
                        CreateNewCreditCard();
                    else
                        ModifyCreditCard();
                }
                catch (ValidationException exception)
                {
                    lblError.Text = exception.Message;
                }
            }
            else
                lblError.Text = "Debe seleccionar una categoría";
        }

        private void ModifyCreditCard()
        {

        }

        private void CreateNewCreditCard()
        {
            CreditCard newCreditCard = CreateCreditCardObject();
            _myPasswordManager.CreateCreditCard(newCreditCard);
            CloseForm();

        }

        private CreditCard CreateCreditCardObject()
        {
            CreditCard newCreditCard = new CreditCard
            {
                User = _myPasswordManager.CurrentUser,
                Category = (Category)cbCategory.SelectedItem,
                Name = txtName.Text,
                Type = txtType.Text,
                Number = txtNumber.Text,
                SecureCode = txtSecureCode.Text,
                ExpirationDate = txtExpirationDate.Text,
                Notes = txtNotes.Text,
            };

            return newCreditCard;
        }

        private void CloseForm()
        {
            this.Close();
        }

        private Boolean CategoryIsSelectedComboBox()
        {
            return cbCategory.SelectedItem != null;
        }
    }
}
