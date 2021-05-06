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

        private void tblPassword_SelectionChanged(object sender, EventArgs e)
        {
            Password selectedPassword = (Password)tblPassword.CurrentRow.DataBoundItem;
            LoadTblSharedWith(selectedPassword);
        }

        private void LoadTblSharedWith(Password selectedPassword)
        {
            List<User> users = selectedPassword.GetUsersSharedWith();
            tblSharedWith.DataSource = null;
            tblSharedWith.Rows.Clear();
            tblSharedWith.DataSource = users;
            FormatSharedListOnTable();
        }

        private void FormatSharedListOnTable()
        {
            tblSharedWith.Columns[0].HeaderText = "Usuario";
        }


        /*        private void btnDelete_Click(object sender, EventArgs e)
                {
                    UpdateSelectedPassword();
                    if (_selectedPassword != null)
                    {
                        _myPasswordManager.DeletePassword(_selectedPassword);
                        this.lblMessage.Text = "Contraseña eliminada exitosamente.";
                        LoadTblPassword();
                    }
                    else
                    {
                        this.lblMessage.Text = "Debe seleccionar la contraseña que desea eliminar.";
                    }
                }

                private void UpdateSelectedPassword()
                {
                    if (tblPassword.SelectedCells.Count > 0)
                    {
                        try
                        {
                            _selectedPassword = (Password)tblPassword.SelectedCells[0].OwningRow.DataBoundItem;
                        }
                        catch (FormatException exception)
                        {
                            this.lblMessage.Text = "Error al seleccionar la contraseña.";
                        }
                    }
                }*/
    }
}
