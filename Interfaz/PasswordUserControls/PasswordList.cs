using BusinessLogic;
using Obligatorio1_DA1.Domain;
using Presentation.PasswordUserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentation
{
    public partial class PasswordList : UserControl
    {
        private PasswordManager _myPasswordManager;
        private Password _selectedPassword;
        public PasswordList(PasswordManager pPasswordManager)
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
                    case "LastModification":
                        column.HeaderText = "Última Modificación";
                        break;
                    default:
                        column.Visible = false;
                        break;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UpdateSelectedPassword();
            if (_selectedPassword != null)
            {
                if (ShowConfirmationPopUp())
                {
                    _myPasswordManager.DeletePassword(_selectedPassword);
                    lblMessage.Text = "Contraseña eliminada exitosamente.";
                    LoadTblPassword();
                }
            }
            else
            {
                lblMessage.Text = "Debe seleccionar la contraseña que desea eliminar.";
            }
        }

        private bool ShowConfirmationPopUp()
        {
            if (!Properties.Settings.Default.DontShowAgainPopUpPassword)
            {
                Form DeleteConfirmationPopUp = new DeleteConfirmation("constraseña");
                DialogResult resultConfirmation = DeleteConfirmationPopUp.ShowDialog();
                DeleteConfirmationPopUp.Close();
                return resultConfirmation == DialogResult.OK;
            }
            return true;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form createPassword = new CreateModifyPassword(_myPasswordManager);
            createPassword.FormClosing += new FormClosingEventHandler(RefreshForm);
            createPassword.ShowDialog();
        }

        private void RefreshForm(object sender, FormClosingEventArgs e)
        {
            LoadTblPassword();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            UpdateSelectedPassword();
            if (_selectedPassword != null)
            {
                Form createPassword = new CreateModifyPassword(_myPasswordManager, _selectedPassword);
                createPassword.FormClosing += new FormClosingEventHandler(RefreshForm);
                createPassword.ShowDialog();
            }
            else
            {
                lblMessage.Text = "Debe seleccionar la contraseña que desea modificar.";
            }
        }


        private void btnSharedPasswords_Click(object sender, EventArgs e)
        {
            UpdateSelectedPassword();
            if (_selectedPassword != null)
            {
                Panel parentPanel = (Panel)this.Parent;
                MainWindow main = (MainWindow)parentPanel.Parent;
                main.ShowSharedPasswordList(_selectedPassword);
            }
            else
            {
                lblMessage.Text = "Debe seleccionar la contraseña que desea compartir.";
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            UpdateSelectedPassword();
            if (_selectedPassword != null)
            {
                Form showPassord = new ShowPassword(_selectedPassword);
                showPassord.ShowDialog();
            }
            else
            {
                lblMessage.Text = "Debe seleccionar la contraseña que desea mostrar.";
            }
        }

    }
}
