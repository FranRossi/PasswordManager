using Obligatorio1_DA1.Domain;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentation
{
    public partial class PasswordsSharedWithMe : UserControl
    {
        private PasswordManager _myPasswordManager;
        public PasswordsSharedWithMe(PasswordManager pPasswordManager)
        {
            InitializeComponent();
            _myPasswordManager = pPasswordManager;
            LoadTblPassword();
        }

        private void LoadTblPassword()
        {
            List<Password> passwords = _myPasswordManager.GetSharedPasswordsWithCurrentUser();
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
                    case "CategorySharedWithMe":
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
    }
}
