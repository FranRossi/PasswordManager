using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.PasswordStrengthWindow
{
    public partial class PasswordListOfStrengthColor : UserControl
    {
        private PasswordManager _passwordManager;
        private PasswordStrengthColor _color;
        public PasswordListOfStrengthColor(PasswordManager passwordManager, PasswordStrengthColor color)
        {
            InitializeComponent();
            _passwordManager = passwordManager;
            _color = color;
            LoadPasswords();
        }

        public void LoadPasswords()
        {
            List<Password> passwords = this._passwordManager.GetPasswordsByColor(_color);
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

        private void btmModify_Click(object sender, EventArgs e)
        {
            Password _selectedPassword = (Password)tblPassword.SelectedCells[0].OwningRow.DataBoundItem;
            Form modifyPassowrd = new CreateModifyPassword(_passwordManager, _selectedPassword);
            modifyPassowrd.FormClosing += new FormClosingEventHandler(RefreshForm);
            modifyPassowrd.ShowDialog();
            ReloadParentData();
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
    }
}
