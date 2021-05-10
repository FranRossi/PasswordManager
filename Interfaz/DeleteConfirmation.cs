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
    public partial class DeleteConfirmation : Form
    {
        public DeleteConfirmation(string item)
        {
            InitializeComponent();
            this.lblConfirmationMessage.Text += item;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void chPopUp_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DontShowAgainPopUp = this.chPopUp.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
