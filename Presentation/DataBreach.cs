﻿using BusinessInterfaces;
using BusinessFactory;
using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Presentation
{
    public partial class DataBreach : UserControl
    {

        private ISessionController _mySessionController;
        private IDataBreachController _myDatabreachController;
        private Password _selectedPassword;
        private bool _isTextFileBreach;

        public DataBreach()
        {
            InitializeComponent();
            _mySessionController = FactoryBusinessInterfaces.GetInstanceSessionController();
            _myDatabreachController = FactoryBusinessInterfaces.CreateDataBreachController();
            _isTextFileBreach = false;
        }

        private void btnVerifyDataBreach_Click(object sender, EventArgs e)
        {
            if (txtDataBreach.TextLength > 0)
                LoadDataBreach();
            else
                lblMessage.Text = "Ingresar datos en el campo de texto para verificar el Data Breach";
        }

        private void LoadTables(List<Item> breachResults)
        {
            List<Password> passwords = new List<Password>();
            List<CreditCard> creditCards = new List<CreditCard>();
            foreach (Item breachedItem in breachResults)
            {
                if (breachedItem.GetType().Equals(typeof(Password)))
                    passwords.Add((Password)breachedItem);
                else
                    creditCards.Add((CreditCard)breachedItem);
            }
            LoadTblCreditCard(creditCards);
            LoadTblPassword(passwords);
        }

        private void LoadDataBreach()
        {
            IDataBreachReader<string> dataBreachReader;
            if (_isTextFileBreach)
                dataBreachReader = new DataBreachReaderFromTextFile();
            else
                dataBreachReader = new DataBreachReaderFromString();
            HashSet<DataBreachReportEntry> dataBreachEntries = dataBreachReader.GetDataBreachEntries(txtDataBreach.Text);
            DataBreachReport dataBreachReport = new DataBreachReport(dataBreachEntries, _mySessionController.CurrentUser);
            List<Item> breachResult = _myDatabreachController.SaveBreachedItems(dataBreachReport);
            LoadTables(breachResult);
            lblMessage.Text = "";
        }

        private void LoadTblCreditCard(List<CreditCard> creditCards)
        {
            tblDataBreachCreditCard.DataSource = creditCards;
            foreach (DataGridViewColumn column in tblDataBreachCreditCard.Columns)
            {
                switch (column.Name)
                {
                    case "Name":
                        column.HeaderText = "Nombre";
                        break;
                    case "Number":
                        column.HeaderText = "Numero";
                        break;
                    case "Type":
                        column.HeaderText = "Tipo";
                        break;
                    default:
                        column.Visible = false;
                        break;
                }
            }
        }

        private void LoadTblPassword(List<Password> passwords)
        {
            tblDataBreachPassword.DataSource = passwords;
            foreach (DataGridViewColumn column in tblDataBreachPassword.Columns)
            {
                switch (column.Name)
                {
                    case "Site":
                        column.HeaderText = "Sitio";
                        break;
                    case "Username":
                        column.HeaderText = "Nombre de usuario";
                        break;
                    default:
                        column.Visible = false;
                        break;
                }
            }
        }

        private void btnModifyPass_Click(object sender, EventArgs e)
        {
            UpdateSelectedPassword();
            if (_selectedPassword != null)
            {
                Form createPassword = new CreateModifyPassword(_selectedPassword);
                createPassword.FormClosing += new FormClosingEventHandler(RefreshForm);
                createPassword.ShowDialog();
                _selectedPassword = null;
            }
            else
            {
                lblMessage.Text = "Debe seleccionar la contraseña que desea modificar.";
            }
        }

        private void UpdateSelectedPassword()
        {
            if (tblDataBreachPassword.SelectedCells.Count > 0)
            {
                try
                {
                    _selectedPassword = (Password)tblDataBreachPassword.SelectedCells[0].OwningRow.DataBoundItem;
                }
                catch (InvalidCastException exception)
                {
                    lblMessage.Text = "Error al seleccionar la contraseña.";
                }
            }
        }
        private void RefreshForm(object sender, FormClosingEventArgs e)
        {
            LoadDataBreach();
        }

        private void btnOpenTextFile_Click(object sender, EventArgs e)
        {
            try
            {
                string fileString = CreateDialog();
                txtDataBreach.Text = fileString;
                txtDataBreach.Enabled = false;
                btnCancel.Visible = true;
                _isTextFileBreach = true;
            }
            catch (ArgumentException ex)
            {
                lblMessage.Text = "El archivo seleccionado no es válido o no se puede leer.";
            }
        }

        private string CreateDialog()
        {
            openFileDialog.ShowDialog();
            string filename = openFileDialog.FileName;
            return File.ReadAllText(filename);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            txtDataBreach.Enabled = true;
            txtDataBreach.Text = "";
            _isTextFileBreach = false;
        }
    }
}
