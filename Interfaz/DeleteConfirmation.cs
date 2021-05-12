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
        private string _itemType;
        public DeleteConfirmation(string item)
        {
            InitializeComponent();
            lblConfirmationMessage.Text += item;
            _itemType = item;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void chPopUp_CheckedChanged(object sender, EventArgs e)
        {
            if (_itemType == "tarjeta")
                Properties.Settings.Default.DontShowAgainPopUpCreditCard = this.chPopUp.Checked;
            else
                Properties.Settings.Default.DontShowAgainPopUpPassword = this.chPopUp.Checked;

            Properties.Settings.Default.Save();
        }
    }
}
