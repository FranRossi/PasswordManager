using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class LogOutWindow : Form
    {
        private FormClosingEventArgs _mainWindowsClosingEvent;
        public LogOutWindow(FormClosingEventArgs pMainWindowsClosingEvent)
        {
            InitializeComponent();
            _mainWindowsClosingEvent = pMainWindowsClosingEvent;

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
            Close();
        }

        private void KeepMainWindowOpen()
        {
            _mainWindowsClosingEvent.Cancel = true;
        }

        private void CloseMainWindow()
        {
            _mainWindowsClosingEvent.Cancel = false;
        }

    }
}
