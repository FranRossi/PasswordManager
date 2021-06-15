using Obligatorio1_DA1.Domain;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.CreditCardUserControls
{
    public partial class ShowCreditCard : Form
    {
        private CreditCard _myCreditCard;
        public ShowCreditCard(CreditCard creditCard)
        {
            InitializeComponent();
            _myCreditCard = creditCard;
            LoadInformation();
        }

        private void LoadInformation()
        {
            txtCategory.Text = _myCreditCard.Category.ToString();
            txtName.Text = _myCreditCard.Name;
            txtType.Text = _myCreditCard.Type;
            txtDate.Text = _myCreditCard.ExpirationDate;
            txtNotes.Text = _myCreditCard.Notes;

            txtCode.Text = _myCreditCard.SecureCode;
            ShowFullInformation();
        }

        private async void ShowFullInformation()
        {
            txtCode.PasswordChar = '\0';
            mtxtNumber.Text = _myCreditCard.Number;
            btnShow.Enabled = false;

            int secondsFullInformationIsShown = 30;
            await Task.Delay(TimeSpan.FromSeconds(secondsFullInformationIsShown));
            HideFullInformation();
        }

        private void HideFullInformation()
        {
            mtxtNumber.Text = _myCreditCard.SecretNumber;
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
