using BusinessLogic;
using Obligatorio1_DA1.Domain;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class MainWindow : Form
    {
        private PasswordManager _myPasswordManager;
        public MainWindow(PasswordManager passwordManager)
        {

            InitializeComponent();
            _myPasswordManager = passwordManager;
        }

        private void tsmiPasswords_Click(object sender, EventArgs e)
        {
            ShowPasswords();
        }

        private void tsmiCreditCards_Click(object sender, EventArgs e)
        {
            UserControl creditCardsList = new CreditCardList(_myPasswordManager);
            pnlMainScreen.Controls.Clear();
            pnlMainScreen.Controls.Add(creditCardsList);
        }

        private void tsmiCategories_Click(object sender, EventArgs e)
        {
            UserControl categories = new Categories(_myPasswordManager);
            pnlMainScreen.Controls.Clear();
            pnlMainScreen.Controls.Add(categories);
        }

        private void tsmiDataBreaches_Click(object sender, EventArgs e)
        {
            UserControl dataBreaches = new DataBreach(_myPasswordManager);
            pnlMainScreen.Controls.Clear();
            pnlMainScreen.Controls.Add(dataBreaches);
        }

        private void tsmiPasswordStrength_Click(object sender, EventArgs e)
        {
            UserControl passwordsStrength = new PasswordStrength(_myPasswordManager);
            pnlMainScreen.Controls.Clear();
            pnlMainScreen.Controls.Add(passwordsStrength);
        }

        public void ShowSharedPasswordList(Password selectedPassword)
        {
            UserControl sharedPassswordsList = new SharedPasswordList(_myPasswordManager, selectedPassword);
            pnlMainScreen.Controls.Clear();
            pnlMainScreen.Controls.Add(sharedPassswordsList);
        }

        public void ShowPasswords()
        {
            UserControl passswordsList = new PasswordList(_myPasswordManager);
            pnlMainScreen.Controls.Clear();
            pnlMainScreen.Controls.Add(passswordsList);
        }

        private void tsmiSharedWithMe_Click(object sender, EventArgs e)
        {
            UserControl passwordsSharedWithMe = new PasswordsSharedWithMe(_myPasswordManager);
            pnlMainScreen.Controls.Clear();
            pnlMainScreen.Controls.Add(passwordsSharedWithMe);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form logOut = new LogOutWindow(e);
            logOut.ShowDialog();
        }
    }
}
