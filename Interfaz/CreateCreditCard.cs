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

        private void LoadComboBoxCategory()
        {
            cbCategory.DataSource = _myPasswordManager.GetCategoriesFromCurrentUser();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (CategoryIsSelectedComboBox())
            {
                try
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
                    _myPasswordManager.CreateCreditCard(newCreditCard);
                    CloseForm();

                }
                catch (ValidationException exception)
                {
                    lblError.Text = exception.Message;
                }
            }
            else
                lblError.Text = "Debe seleccionar una categoría";
        }

        private void CloseForm()
        {
            this.Close();
        }
        private Boolean CategoryIsSelectedComboBox()

        {
            if (cbCategory.SelectedItem == null)
                return false;

            return true;
        }
    }
}
