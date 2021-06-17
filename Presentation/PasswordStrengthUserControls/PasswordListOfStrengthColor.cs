using BusinessInterfaces;
using BusinessFactory;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentation.PasswordStrengthWindow
{
    public partial class PasswordListOfStrengthColor : UserControl
    {
        private IPasswordColorReportController _myPasswordColorReportController;
        private PasswordStrengthColor _passColor;
        private Password _selectedPassword;

        public PasswordListOfStrengthColor(PasswordStrengthColor color)
        {
            InitializeComponent();
            _myPasswordColorReportController = FactoryBusinessInterfaces.CreatePasswordColorReportController();
            _passColor = color;
            LoadPasswords();
        }

        public void LoadPasswords()
        {
            List<Password> passwords = this._myPasswordColorReportController.GetPasswordsByColor(_passColor);
            tblPassword.DataSource = null;
            tblPassword.Rows.Clear();
            tblPassword.DataSource = passwords;
            FormatPasswordList();
        }

        private void FormatPasswordList()
        {
            foreach (DataGridViewColumn column in tblPassword.Columns)
            {
                switch (column.Name)
                {
                    case "Site":
                        column.HeaderText = "Sitio";
                        break;
                    case "Username":
                        column.HeaderText = "Nombre de usuario";
                        break;
                    case "Category":
                        column.HeaderText = "Categoria";
                        break;
                    default:
                        column.Visible = false;
                        break;
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            UpdateSelectedPassword();
            if (_selectedPassword != null)
            {
                Form createPassword = new CreateModifyPassword(_selectedPassword);
                createPassword.FormClosing += new FormClosingEventHandler(RefreshForm);
                createPassword.ShowDialog();
                ReloadParentData();
            }
            else
            {
                lblMessage.Text = "Debe seleccionar la contraseña que desea modificar.";
            }
        }

        private void ReloadParentData()
        {
            Panel parentPanel = (Panel)this.Parent;
            PasswordStrength parentForm = (PasswordStrength)parentPanel.Parent;
            parentForm.Reload();
        }

        private void RefreshForm(object sender, FormClosingEventArgs e)
        {
            LoadPasswords();
        }

        private void UpdateSelectedPassword()
        {
            if (tblPassword.SelectedCells.Count > 0)
            {
                try
                {
                    _selectedPassword = (Password)tblPassword.SelectedCells[0].OwningRow.DataBoundItem;
                }
                catch (InvalidCastException exception)
                {
                    lblMessage.Text = "Error al seleccionar la contraseña.";
                }
            }
        }
    }
}
