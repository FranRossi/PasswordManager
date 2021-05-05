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

namespace Presentation.PasswordStrengthWindow
{
    public partial class PasswordListOfStrenghtColor : UserControl
    {
        public PasswordListOfStrenghtColor(List<Password> passwords)
        {
            InitializeComponent();
            LoadPasswords(passwords);
        }

        public void LoadPasswords(List<Password> passwords)
        {
            tblPassword.DataSource = null;
            tblPassword.Rows.Clear();
            tblPassword.DataSource = passwords;
            foreach (DataGridViewColumn column in tblPassword.Columns)
            {
                switch (column.Name)
                {
                    case "Site":
                        column.HeaderText = "Sitio";
                        break;
                    case "username":
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
    }
}
