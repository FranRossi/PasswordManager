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
            lblCategoryContent.Text = _password.Category.ToString();
            lblSiteContent.Text = _password.Site;
            lblUserContent.Text = _password.Username;
            lblPasswordContent.Text = _password.Pass;
            lblNotesContent.Text = _password.Notes;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
