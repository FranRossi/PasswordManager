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

namespace Presentation.CreditCardUserControls
{
    public partial class ShowCreditCard : Form
    {
        private CreditCard _creditCard;
        public ShowCreditCard(CreditCard creditCard)
        {
            InitializeComponent();
            _creditCard = creditCard;
            LoadInformation();
        }

        private void LoadInformation()
        {
            txtCategory.Text = _creditCard.Category.ToString();
            txtName.Text = _creditCard.Name;
            txtType.Text = _creditCard.Type;
            txtDate.Text = _creditCard.ExpirationDate;
            txtNotes.Text = _creditCard.Notes;

            txtCode.Text = _creditCard.SecureCode;
            ShowFullInformation();
        }

        private async void ShowFullInformation()
        {
            txtCode.PasswordChar = '\0';
            mtxtNumber.Text = _creditCard.Number;
            btnShow.Enabled = false;

            int secondsFullInformationIsShown = 30;
            await Task.Delay(TimeSpan.FromSeconds(secondsFullInformationIsShown));
            HideFullInformation();
        }

        private void HideFullInformation()
        {
            mtxtNumber.Text = _creditCard.SecretNumber;
            txtCode.PasswordChar = '*';
            btnShow.Enabled = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowFullInformation();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
