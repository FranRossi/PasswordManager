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

namespace Presentation
{
    public partial class SharedPasswordList : UserControl
    {
        private PasswordManager _myPasswordManager;
        private Password _selectedPassword;
        private User _selectedShareWithUser;
        private User _selectedUnShareWithUser;
        private List<User> _usersNotSharedWith;
        public SharedPasswordList(PasswordManager pPasswordManager, Password pSelectedPassword)
        {
            InitializeComponent();
            _myPasswordManager = pPasswordManager;
            _selectedPassword = pSelectedPassword;
            LoadTblPassword();
            SetSelectedPassoword();
        }

        private void SetSelectedPassoword()
        {
            tblPassword.ClearSelection();
            foreach (DataGridViewRow row in tblPassword.Rows)
            {
                Password pass = (Password)row.DataBoundItem;
                if (pass.Equals(_selectedPassword))
                {
                    tblPassword.CurrentCell = row.Cells[1];
                    return;
                }
            }
            UpdateSelectedPassword();
        }

        private void LoadTblPassword()
        {
            List<Password> passwords = _myPasswordManager.GetPasswords();
            tblPassword.DataSource = null;
            tblPassword.Rows.Clear();
            tblPassword.DataSource = passwords;
            FormatPasswordListOnTable();
        }

        private void FormatPasswordListOnTable()
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

        private void LoadcbUsersNotSharedWith(Password selectedPassword)
        {
            cbUsersNotSharedWith.DataSource = null;
            _usersNotSharedWith = this._myPasswordManager.GetUsersPassNotSharedWith(selectedPassword);
            if (_usersNotSharedWith.Count == 0)
            {
                ChangeComboBoxState(cbUsersNotSharedWith, false);
                ChangeButtonState(btnShare, false);
            }
            else
                ShowcbUsersNotSharedWith(_usersNotSharedWith);
        }

        private void ShowcbUsersNotSharedWith(List<User> usersNotSharedWith)
        {
            ChangeComboBoxState(cbUsersNotSharedWith, true);
            ChangeButtonState(btnShare, true);
            cbUsersNotSharedWith.DataSource = usersNotSharedWith;
        }

        private void LoadTblSharedWith(Password selectedPassword)
        {
            List<User> users = _myPasswordManager.GetUsersSharedWith(selectedPassword);
            tblSharedWith.DataSource = null;
            tblSharedWith.Rows.Clear();
            tblSharedWith.DataSource = users;
            FormatSharedListOnTable();
            if (users.Count == 0)
            {
                ChangeButtonState(btnUnShare, false);
            }
            else
                ChangeButtonState(btnUnShare, true);
        }

        private void FormatSharedListOnTable()
        {

            foreach (DataGridViewColumn column in tblSharedWith.Columns)
            {
                switch (column.Name)
                {
                    case "Name":
                        column.HeaderText = "Nombre";
                        break;
                    default:
                        column.Visible = false;
                        break;
                }
            }
        }

        private void tblPassword_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelectedPassword();
            LoadTblSharedWith(_selectedPassword);
            LoadcbUsersNotSharedWith(_selectedPassword);
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            UpdateSelectedPassword();
            UpdateSelectedShareWithUser();
            _myPasswordManager.SharePassword(_selectedPassword, _selectedShareWithUser);
            LoadcbUsersNotSharedWith(_selectedPassword);
            LoadTblSharedWith(_selectedPassword);
        }

        private void btnUnShare_Click(object sender, EventArgs e)
        {
            UpdateSelectedPassword();
            UpdateSelectedUnShareWithUser();
            _myPasswordManager.UnSharePassword(_selectedPassword, _selectedUnShareWithUser);
            LoadcbUsersNotSharedWith(_selectedPassword);
            LoadTblSharedWith(_selectedPassword);
        }



        private void btnSharedPasswords_Click(object sender, EventArgs e)
        {
            Panel parentPanel = (Panel)this.Parent;
            MainWindow main = (MainWindow)parentPanel.Parent;
            main.ShowPasswords();
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

        private void UpdateSelectedShareWithUser()
        {
            if (cbUsersNotSharedWith.SelectedIndex > -1)
            {
                try
                {
                    _selectedShareWithUser = (User)cbUsersNotSharedWith.SelectedItem;
                }
                catch (InvalidCastException exception)
                {
                    lblMessage.Text = "Error al seleccionar el usuario para compartir.";
                }
            }
        }
        private void UpdateSelectedUnShareWithUser()
        {
            if (tblSharedWith.SelectedCells.Count > 0)
            {
                try
                {
                    _selectedUnShareWithUser = (User)tblSharedWith.SelectedCells[0].OwningRow.DataBoundItem;
                    ChangeButtonState(btnUnShare, true);
                }
                catch (InvalidCastException exception)
                {
                    ChangeButtonState(btnUnShare, false);
                    lblMessage.Text = "Error al seleccionar el usuario para descompartir.";
                }
            }
        }

        private void ChangeButtonState(Button btn, bool state)
        {
            try
            {
                btn.Enabled = state;
            }
            catch (IndexOutOfRangeException exception) { };
        }

        private void ChangeComboBoxState(ComboBox cb, bool state)
        {
            try
            {
                cb.Enabled = state;
            }
            catch (IndexOutOfRangeException exception) { };
        }

    }
}
