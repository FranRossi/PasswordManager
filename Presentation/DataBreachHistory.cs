using BusinessInterfaces;
using BusinessFactory;
using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation
{
    public partial class DataBreachHistory : UserControl
    {
        private IDataBreachController _myDatabreachController;
        private DataBreachReport _selectedReport;
        public DataBreachHistory()
        {
            InitializeComponent();
            _myDatabreachController = FactoryBusinessInterfaces.CreateDataBreachController();
            LoadTblDataBreach();
        }

        private void LoadTblDataBreach()
        {
            List<DataBreachReport> reports = _myDatabreachController.GetDataBreachReportsFromCurrentUser();
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
                        column.HeaderText = "Cantidad de datos expuestos";
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
            FormatPasswordListOnTable(report.Date);
        }


        private void FormatPasswordListOnTable(DateTime reportDatetime)
        {
            CreateTblPasswordModifyButton(reportDatetime);
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
                    case "ModifyButton":
                        column.HeaderText = "Modificar";
                        break;
                    default:
                        column.Visible = false;
                        break;
                }
            }
            if (tblPasswords.Rows.Count > 0)
                tblPasswords.Rows[0].Selected = false;
        }

        private void CreateTblPasswordModifyButton(DateTime reportDatetime)
        {
            DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
            uninstallButtonColumn.Name = "ModifyButton";
            uninstallButtonColumn.Text = "✏️";
            uninstallButtonColumn.UseColumnTextForButtonValue = true;
            uninstallButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            int columnIndex = 0;
            if (tblPasswords.Columns["ModifyButton"] == null)
            {
                tblPasswords.Columns.Insert(columnIndex, uninstallButtonColumn);
            }
            CalculateModifiableRows(reportDatetime);
        }

        private void CalculateModifiableRows(DateTime reportDatetime)
        {
            for (int i = 0; i < tblPasswords.Rows.Count; i++)
            {
                Password password = (Password)tblPasswords.Rows[i].DataBoundItem;
                if (password.LastModification <= reportDatetime)
                    tblPasswords.Rows[i].DefaultCellStyle.BackColor = Color.IndianRed;
                else
                {
                    DataGridViewButtonCell button = (DataGridViewButtonCell)tblPasswords.Rows[i].Cells[0];
                    DataGridViewCellStyle dataGridViewCellStyleCustom = new DataGridViewCellStyle
                    {
                        Padding = new Padding(70, 0, 0, 0)
                    };
                    button.Style = dataGridViewCellStyleCustom;
                    tblPasswords.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        private void tblPasswords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                try
                {
                    Password selectedPassword = (Password)tblPasswords.SelectedCells[0].OwningRow.DataBoundItem;
                    Form createPassword = new CreateModifyPassword(selectedPassword);
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
