using Obligatorio1_DA1.Domain;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.PasswordUserControls
{
    public partial class ShowPassword : Form
    {
        private Password _myPasswordToShow;
        public ShowPassword(Password password)
        {
            InitializeComponent();
            _myPasswordToShow = password;
            LoadInformation();
        }

        private void LoadInformation()
        {
            txtCategory.Text = _myPasswordToShow.Category.ToString();
            txtSite.Text = _myPasswordToShow.Site;
            txtUser.Text = _myPasswordToShow.Username;
            txtNotes.Text = _myPasswordToShow.Notes;

            txtPassword.Text = _myPasswordToShow.Pass;
            ShowPassField();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowPassField();
        }

        private async void ShowPassField()
        {
            txtPassword.PasswordChar = '\0';
            btnShow.Enabled = false;

            int secondsPasswordFieldIsShown = 30;
            await Task.Delay(TimeSpan.FromSeconds(secondsPasswordFieldIsShown));
            HidePassField();
        }

        private void HidePassField()
        {
            txtPassword.PasswordChar = '*';
            btnShow.Enabled = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
