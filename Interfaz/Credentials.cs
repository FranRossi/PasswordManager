using Obligatorio1_DA1;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
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
    public partial class Credentials : UserControl
    {

        private PasswordManager _myPasswordManager;
        public Credentials(PasswordManager pPasswordManager)
        {
            TestData testData = new TestData(pPasswordManager);
            InitializeComponent();
            _myPasswordManager = pPasswordManager;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string masterPassword = txtMasterPassword.Text;
            try
            {
                _myPasswordManager.Login(userName, masterPassword);
                ShowMainScreen();
            }
            catch (LogInException exception)
            {
                lblMessage.Text = exception.Message;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string masterPassword = txtMasterPassword.Text;
            try
            {
                _myPasswordManager.CreateUser(userName, masterPassword);
                ShowMainScreen();
            }
            catch (ValidationException exception)
            {
                lblMessage.Text = exception.Message;
            }
        }

        private void ShowMainScreen()
        {
            Form currentForm = this.FindForm();
            currentForm.Hide();
            Form mainForm = new MainWindow(_myPasswordManager);
            mainForm.Closed += (s, args) => currentForm.Close();
            mainForm.Show();
        }


    }
}
