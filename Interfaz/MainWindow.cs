using Obligatorio1_DA1.Domain;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class MainWindow : Form
    {

        private bool userWantsToLogOut;

        public MainWindow()
        {
            InitializeComponent();
            userWantsToLogOut = false;
        }

        private void tsmiPasswords_Click(object sender, EventArgs e)
        {
            ShowPasswords();
        }

        private void tsmiCreditCards_Click(object sender, EventArgs e)
        {
            UserControl creditCardsList = new CreditCardList();
            pnlMainScreen.Controls.Clear();
            pnlMainScreen.Controls.Add(creditCardsList);
        }

        private void tsmiCategories_Click(object sender, EventArgs e)
        {
            UserControl categories = new Categories();
            pnlMainScreen.Controls.Clear();
            pnlMainScreen.Controls.Add(categories);
        }

        private void tsmiDataBreaches_Click(object sender, EventArgs e)
        {
            UserControl dataBreaches = new DataBreach();
            pnlMainScreen.Controls.Clear();
            pnlMainScreen.Controls.Add(dataBreaches);
        }

        private void tsmiPasswordStrength_Click(object sender, EventArgs e)
        {
            UserControl passwordsStrength = new PasswordStrength();
            pnlMainScreen.Controls.Clear();
            pnlMainScreen.Controls.Add(passwordsStrength);
        }

        public void ShowSharedPasswordList(Password selectedPassword)
        {
            UserControl sharedPassswordsList = new SharedPasswordList(selectedPassword);
            pnlMainScreen.Controls.Clear();
            pnlMainScreen.Controls.Add(sharedPassswordsList);
        }

        public void ShowPasswords()
        {
            UserControl passswordsList = new PasswordList();
            pnlMainScreen.Controls.Clear();
            pnlMainScreen.Controls.Add(passswordsList);
        }

        private void tsmiSharedWithMe_Click(object sender, EventArgs e)
        {
            UserControl passwordsSharedWithMe = new PasswordsSharedWithMe();
            pnlMainScreen.Controls.Clear();
            pnlMainScreen.Controls.Add(passwordsSharedWithMe);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UserPressedExitOnMainWindow()) { 
                Form logOut = new LogOutWindow(e);
                logOut.ShowDialog();
            }
        }

        private void tsmiDataBreachHistory_Click(object sender, EventArgs e)
        {
            UserControl dataBreachHistory = new DataBreachHistory();
            pnlMainScreen.Controls.Clear();
            pnlMainScreen.Controls.Add(dataBreachHistory);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            userWantsToLogOut = true;
            Close();
        }

        private bool UserPressedExitOnMainWindow()
        {
            return !userWantsToLogOut;
        }

    }
}
