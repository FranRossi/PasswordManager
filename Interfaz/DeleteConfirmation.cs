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
        private DialogResult dialogResult;

        public DialogResult DialogResult { get => dialogResult; set => dialogResult = value; }
        public DeleteConfirmation()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void chPopUp_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DontShowAgainPopUp = this.chPopUp.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
