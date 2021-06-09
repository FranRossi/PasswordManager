using BusinessLogic;
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
    public partial class DataBreachHistory : UserControl
    {
        private PasswordManager _myPasswordManager;
        private Password _selectedPassword;
        public DataBreachHistory(PasswordManager passwordManager)
        {
            InitializeComponent();
            _myPasswordManager = passwordManager;
            LoadDataBreach();
        }

        private void LoadDataBreach()
        {
            List<DataBreachReport> reports = _myPasswordManager.GetDataBreachReportsFromCurrentUser();

        }

        private void FormatPasswordListOnTable()
        {
            foreach (DataGridViewColumn column in tblReports.Columns)
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
    }
}
