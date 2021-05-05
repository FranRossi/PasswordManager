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
    public partial class CreateCreditCard : Form
    {
        private PasswordManager _myPasswordManager;
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
            try
            {
                /*CreditCard newCreditCard{
                    {
                        User user = new User();
                        Category = cbCategory.SelectedItem,
                     Name = txtName.Text,
                     Type = "Visa",
                     Number = "2354678713003498",
                     SecureCode = "189",
                     ExpirationDate = "10/21",
                     Notes = "Límite 400k UYU"
                     };*/


            }
            catch (Exception exception)
            {
                return;
            }
        }
    }
}
