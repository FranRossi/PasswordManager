using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.PasswordUserControls
{
    public partial class ShowPassword : Form
    {
        private Password _password;
        public ShowPassword(Password password)
        {
            InitializeComponent();
            _password = password;
            LoadInformation();
        }

        private void LoadInformation()
        {
            txtCategory.Text = _password.Category.ToString();
            txtSite.Text = _password.Site;
            txtUser.Text = _password.Username;
            txtNotes.Text = _password.Notes;

            txtPassword.Text = _password.Pass;
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

            await Task.Delay(TimeSpan.FromSeconds(3));
            HidePassField();
        }

        private void HidePassField()
        {
            txtPassword.PasswordChar = '*';
            btnShow.Enabled = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
