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

            // in case the User closes the Window with the "X"
            KeepMainWindowOpen();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseMainWindow();
            System.Environment.Exit(0);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            CloseMainWindow();
            this.Close();
        }

        void KeepMainWindowOpen()
        {
            _mainWindowsClosingEvent.Cancel = true;
        }

        void CloseMainWindow()
        {
            _mainWindowsClosingEvent.Cancel = false;
        }
    }
}
