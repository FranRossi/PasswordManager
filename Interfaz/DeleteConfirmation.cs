using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class DeleteConfirmation : Form
    {
        private string _itemType;
        public DeleteConfirmation(string pItem)
        {
            InitializeComponent();
            lblConfirmationMessage.Text += pItem;
            _itemType = pItem;
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
