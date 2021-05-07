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
        private List<User> usersNotSharedWith;
        public SharedPasswordList(PasswordManager pPasswordManager)
        {
            InitializeComponent();
            _myPasswordManager = pPasswordManager;
            LoadTblPassword();
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
            cbUsersNotSharedWith.Items.Clear();
            usersNotSharedWith = this._myPasswordManager.GetUsersPassNotSharedWith(selectedPassword);
            if (usersNotSharedWith.Count == 0)
            {
                cbUsersNotSharedWith.Enabled = false;
                btnShare.Enabled = false;
            }
            else
                ShowcbUsersNotSharedWith(usersNotSharedWith);
        }

        private void ShowcbUsersNotSharedWith(List<User> usersNotSharedWith)
        {
            cbUsersNotSharedWith.Enabled = true;
            btnShare.Enabled = true;
            foreach (User user in usersNotSharedWith)
            {
                cbUsersNotSharedWith.Items.Add(user.ToString());
            }
            cbUsersNotSharedWith.SelectedItem = cbUsersNotSharedWith.Items[0];
        }

        private void LoadTblSharedWith(Password selectedPassword)
        {
            List<User> users = selectedPassword.GetUsersSharedWith();
            tblSharedWith.DataSource = null;
            tblSharedWith.Rows.Clear();
            tblSharedWith.DataSource = users;
            FormatSharedListOnTable();
            tblSharedWith.CurrentCell = null;
            btnUnShare.Enabled = false;
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
            Password selectedPassword = (Password)tblPassword.CurrentRow.DataBoundItem;
            LoadTblSharedWith(selectedPassword);
            LoadcbUsersNotSharedWith(selectedPassword);
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            Password selectedPassword = (Password)tblPassword.CurrentRow.DataBoundItem;
            int index = cbUsersNotSharedWith.SelectedIndex;
            User selectedUser = usersNotSharedWith.ElementAt(index);
            selectedPassword.ShareWithUser(selectedUser);
            LoadcbUsersNotSharedWith(selectedPassword);
            LoadTblSharedWith(selectedPassword);
        }

        private void btnUnShare_Click(object sender, EventArgs e)
        {
            User user = (User)tblSharedWith.CurrentRow.DataBoundItem;
            Password selectedPassword = (Password)tblPassword.CurrentRow.DataBoundItem;
            // descompartir 
            LoadTblSharedWith(selectedPassword);
        }

        private void tblSharedWith_SelectionChanged(object sender, EventArgs e)
        {
            btnUnShare.Enabled = true;
        }
    }
}
