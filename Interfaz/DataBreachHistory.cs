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
        private DataBreachReport _selectedReport;
        public DataBreachHistory(PasswordManager passwordManager)
        {
            InitializeComponent();
            _myPasswordManager = passwordManager;
            LoadTblDataBreach();
        }

        private void LoadTblDataBreach()
        {
            List<DataBreachReport> reports = _myPasswordManager.GetDataBreachReportsFromCurrentUser();
            tblReports.DataSource = null;
            tblReports.Rows.Clear();
            tblReports.DataSource = reports;
            FormatReportListOnTable();
        }

        private void FormatReportListOnTable()
        {
            foreach (DataGridViewColumn column in tblReports.Columns)
            {
                switch (column.Name)
                {
                    case "Date":
                        column.HeaderText = "Fecha";
                        break;
                    case "EntryQuantity":
                        column.HeaderText = "Cantidad de entradas";
                        break;
                    case "ItemQuantity":
                        column.HeaderText = "Cantidad de items expuestos";
                        break;
                    default:
                        column.Visible = false;
                        break;
                }
            }
        }

        private void UpdateSelectedReport()
        {
            if (tblReports.SelectedCells.Count > 0)
            {
                try
                {
                    _selectedReport = (DataBreachReport)tblReports.SelectedCells[0].OwningRow.DataBoundItem;
                }
                catch (InvalidCastException exception)
                {
                    lblMessage.Text = "Error al seleccionar el reporte.";
                }
            }
        }

        private void tblReports_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelectedReport();
            LoadTblPassword(_selectedReport);
        }

        private void LoadTblPassword(DataBreachReport report)
        {
            List<Item> items = report.BreachedItems;
            List<Password> passwords = new List<Password>();
            foreach (Item i in items)
            {
                if (i.GetType().Equals(typeof(Password)))
                    passwords.Add((Password)i);
            }
            tblPasswords.DataSource = null;
            tblPasswords.Rows.Clear();
            tblPasswords.DataSource = passwords;
            FormatPasswordListOnTable();
        }


        private void FormatPasswordListOnTable()
        {
            DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
            uninstallButtonColumn.Name = "uninstall_column";
            uninstallButtonColumn.Text = "✍";
            uninstallButtonColumn.UseColumnTextForButtonValue = true;
            uninstallButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            int columnIndex = 0;
            if (tblPasswords.Columns["uninstall_column"] == null)
            {
                tblPasswords.Columns.Insert(columnIndex, uninstallButtonColumn);
            }
            for (int i = 0; i < tblPasswords.Rows.Count; i++)
            {

                //DateTime Id = (DateTime)((DataRowView)tblPasswords.Rows[i].DataBoundItem)["LastModification"];
                if (i % 2 == 0)
                {
                    DataGridViewButtonCell button = (DataGridViewButtonCell)tblPasswords.Rows[i].Cells[0];
                    DataGridViewCellStyle dataGridViewCellStyleCustom = new DataGridViewCellStyle();
                    dataGridViewCellStyleCustom.Padding = new Padding(70, 0, 0, 0);
                    button.Style = dataGridViewCellStyleCustom;
                }
            }
            foreach (DataGridViewColumn column in tblPasswords.Columns)
            {
                switch (column.Name)
                {
                    case "Site":
                        column.HeaderText = "Sitio";
                        break;
                    case "Username":
                        column.HeaderText = "Nombre de usuario";
                        break;
                    case "LastModification":
                        column.HeaderText = "Última Modificación";
                        break;
                    case "uninstall_column":
                        column.HeaderText = "Modificar";
                        break;
                    default:
                        column.Visible = false;
                        break;
                }
            }

        }

        private void tblPasswords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                try
                {
                    Password selectedPassword = (Password)tblPasswords.SelectedCells[0].OwningRow.DataBoundItem;
                    Form createPassword = new CreateModifyPassword(_myPasswordManager, selectedPassword);
                    createPassword.FormClosing += new FormClosingEventHandler(RefreshForm);
                    createPassword.ShowDialog();
                }
                catch (InvalidCastException exception)
                {
                    lblMessage.Text = "Error al seleccionar la contraseña.";
                }
            }
        }

        private void RefreshForm(object sender, FormClosingEventArgs e)
        {
            LoadTblDataBreach();
        }
    }
}
