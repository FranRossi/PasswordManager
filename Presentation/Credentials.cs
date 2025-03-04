﻿using BusinessInterfaces;
using BusinessFactory;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Credentials : UserControl
    {

        private ISessionController _mySessionController;
        public Credentials()
        {
            InitializeComponent();
            Properties.Settings.Default.Reset();
            ShowHidePassword(false);
            _mySessionController = FactoryBusinessInterfaces.GetInstanceSessionController();
            //TestData testData = new TestData();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string masterPassword = txtMasterPassword.Text;
            try
            {
                _mySessionController.Login(userName, masterPassword);
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
                User newUser = new User(userName, masterPassword);
                _mySessionController.CreateUser(newUser);
                ShowMainScreen();
            }
            catch (ValidationException exception)
            {
                lblMessage.Text = exception.Message;
            }
        }

        private void CleanTextBoxesAndMessages()
        {
            txtUserName.Text = "";
            txtMasterPassword.Text = "";
            lblMessage.Text = "";
        }

        private void ShowMainScreen()
        {
            CleanTextBoxesAndMessages();
            Form currentForm = this.FindForm();
            currentForm.Hide();
            Form mainForm = new MainWindow();
            mainForm.Closed += (s, args) => currentForm.Show();
            mainForm.Show();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool showPasswordChecked = cbShowPassword.Checked;
            ShowHidePassword(showPasswordChecked);
        }

        private void ShowHidePassword(bool showPassword)
        {
            if (showPassword)
                txtMasterPassword.PasswordChar = '\0';
            else
                txtMasterPassword.PasswordChar = '*';
        }
    }
}
