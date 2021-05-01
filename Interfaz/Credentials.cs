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

namespace Interfaz
{
    public partial class Credentials : Form
    {
        private PasswordManager _myPasswordManager;
        public Credentials()
        {
            InitializeComponent();
            _myPasswordManager = new PasswordManager();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Hide();
            btnSignUp.Hide();
            ValidateLogin();
        }

        private void ValidateLogin()
        {
            string userName = txtUserName.Text;
            string masterPassword = txtMasterPassword.Text;
            _myPasswordManager.Login(userName, masterPassword);
            MainScreenLogin();

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            btnLogin.Hide();
            btnSignUp.Hide();
            SignUpToPasswordManager();
        }

        private void SignUpToPasswordManager()
        {
            string userName = txtUserName.Text;
            string masterPassword = txtMasterPassword.Text;
            _myPasswordManager.CreateUser(userName, masterPassword);
            MainScreenLogin();
        }

        private void MainScreenLogin()
        {
            UserControl mainScreen = new MainScreen(_myPasswordManager);
            pnlMainScreen.Controls.Add(mainScreen);
        }

    }
}
