using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Utilities;
using Presentation.PasswordStrengthWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentation
{

    struct colorComponent
    {
        public PasswordStrengthColor Color { get; set; }
        public Label Label { get; set; }
        public Button Button { get; set; }
    }
    public partial class PasswordStrength : UserControl
    {
        private PasswordManager _myPasswordManager;
        private PasswordStrengthChart _chartPanel;
        private List<colorComponent> _colorCmp;
        public PasswordStrength(PasswordManager pPasswordManager)
        {
            _myPasswordManager = pPasswordManager;
            InitializeComponent();
            SetColorsLabelsAndButtons();
            LoadColorQuantities();
            LoadChart();
            ShowChart();
        }


        private void LoadColorQuantities()
        {
            List<PasswordReportByColor> report = this._myPasswordManager.GetPasswordReportByColor();
            foreach (PasswordReportByColor entry in report)
            {
                colorComponent cmp = _colorCmp.Find(component => component.Color == entry.Color);
                int quantity = entry.Quantity;
                cmp.Label.Text = quantity.ToString();
                if (quantity == 0)
                    cmp.Button.Enabled = false;
                else
                    cmp.Button.Enabled = true;

            }
        }

        public void Reload()
        {
            LoadColorQuantities();
            ReloadChart();
        }

        private void LoadChart()
        {
            bool enoughtPasswordToShow;
            List<PasswordReportByCategoryAndColor> report = this._myPasswordManager.GetPasswordReportByCategoryAndColor();
            enoughtPasswordToShow = (report.Count() > 0);

            if (enoughtPasswordToShow)
            {
                _chartPanel = new PasswordStrengthChart(report);
            }
            else
                btnShowChart.Enabled = false;
        }

        private void ReloadChart()
        {
            List<PasswordReportByCategoryAndColor> report = _myPasswordManager.GetPasswordReportByCategoryAndColor();
            _chartPanel = new PasswordStrengthChart(report);
        }
        private void ShowChart()
        {
            pnlChartList.Controls.Clear();
            pnlChartList.Controls.Add(this._chartPanel);
            btnShowChart.Enabled = false;
        }

        private void ShowPasswordList(PasswordStrengthColor color)
        {
            pnlChartList.Controls.Clear();
            UserControl passwordList = new PasswordListOfStrengthColor(_myPasswordManager, color);
            pnlChartList.Controls.Add(passwordList);
            btnShowChart.Enabled = true;
        }

        private void btnShowChart_Click(object sender, EventArgs e)
        {
            ReloadChart();
            ShowChart();
        }

        private void btnShowPasswordsRed_Click(object sender, EventArgs e)
        {
            ShowPasswordList(PasswordStrengthColor.Red);
        }

        private void btnShowPasswordsOrange_Click(object sender, EventArgs e)
        {
            ShowPasswordList(PasswordStrengthColor.Orange);
        }


        private void btnShowPasswordsYellow_Click(object sender, EventArgs e)
        {
            ShowPasswordList(PasswordStrengthColor.Yellow);
        }

        private void btnShowPasswordsLightGreen_Click(object sender, EventArgs e)
        {
            ShowPasswordList(PasswordStrengthColor.LightGreen);
        }

        private void btnShowPasswordsDarkGreen_Click(object sender, EventArgs e)
        {
            ShowPasswordList(PasswordStrengthColor.DarkGreen);
        }
        private void SetColorsLabelsAndButtons()
        {
            _colorCmp = new List<colorComponent>
            {
                new colorComponent{Color = PasswordStrengthColor.DarkGreen, Label = lblDarkGreenQuantity, Button = btnShowPasswordsDarkGreen },
                new colorComponent{Color = PasswordStrengthColor.LightGreen, Label = lblLightGreenQuantity, Button = btnShowPasswordsLightGreen },
                new colorComponent{Color = PasswordStrengthColor.Yellow, Label = lblYellowQuantity, Button = btnShowPasswordsYellow },
                new colorComponent{Color = PasswordStrengthColor.Orange, Label = lblOrangeQuantity, Button = btnShowPasswordsOrange },
                new colorComponent{Color = PasswordStrengthColor.Red, Label = lblRedQuantity, Button = btnShowPasswordsRed },
        };
        }
    }
}
