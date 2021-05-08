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
    public partial class LogOutWindow : Form
    {
        private PasswordManager _myPasswordManager;
        private FormClosingEventArgs _mainWindowsClosingEvent;
        public LogOutWindow(PasswordManager pPasswordManager, FormClosingEventArgs mainWindowsClosingEvent)
        {
            InitializeComponent();
            _myPasswordManager = pPasswordManager;
            _mainWindowsClosingEvent = mainWindowsClosingEvent;
            _mainWindowsClosingEvent.Cancel = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _mainWindowsClosingEvent.Cancel = false;
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            _mainWindowsClosingEvent.Cancel = false;
            Form cw = new CredentialWindow(_myPasswordManager);
            cw.Show();
            this.Close();
        }
    }
}
