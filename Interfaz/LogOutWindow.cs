using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class LogOutWindow : Form
    {
        private FormClosingEventArgs _myMainWindowsClosingEvent;
        public LogOutWindow(FormClosingEventArgs mainWindowsClosingEvent)
        {
            InitializeComponent();
            _myMainWindowsClosingEvent = mainWindowsClosingEvent;

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
            _myMainWindowsClosingEvent.Cancel = true;
        }

        private void CloseMainWindow()
        {
            _myMainWindowsClosingEvent.Cancel = false;
        }

    }
}
