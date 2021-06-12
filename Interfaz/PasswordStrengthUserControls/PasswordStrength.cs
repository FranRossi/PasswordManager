using BusinessLogic;
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
        private PasswordColorReportController _myPasswordColorReportController;
        private PasswordStrengthChart _chartPanel;
        private List<colorComponent> _colorsCmp;
        public PasswordStrength(PasswordManager passwordManager)
        {
            _myPasswordManager = passwordManager;
            _myPasswordColorReportController = new PasswordColorReportController();
            InitializeComponent();
            SetColorsLabelsAndButtons();
            LoadColorQuantities();
            LoadChart();
            ShowChart();
        }


        private void LoadColorQuantities()
        {
            List<PasswordReportByColor> reportsByPassColor = this._myPasswordColorReportController.GetPasswordReportByColor();
            foreach (PasswordReportByColor entry in reportsByPassColor)
            {
                colorComponent componentByPassColor = _colorsCmp.Find(component => component.Color == entry.Color);
                int quantity = entry.Quantity;
                componentByPassColor.Label.Text = quantity.ToString();
                if (quantity == 0)
                    componentByPassColor.Button.Enabled = false;
                else
                    componentByPassColor.Button.Enabled = true;
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
            List<PasswordReportByCategoryAndColor> reportsByPassColor = this._myPasswordColorReportController.GetPasswordReportByCategoryAndColor();
            enoughtPasswordToShow = (reportsByPassColor.Count() > 0);

            if (enoughtPasswordToShow)
            {
                _chartPanel = new PasswordStrengthChart(reportsByPassColor);
            }
            else
                btnShowChart.Enabled = false;
        }

        private void ReloadChart()
        {
            List<PasswordReportByCategoryAndColor> reportsByPassColor = _myPasswordColorReportController.GetPasswordReportByCategoryAndColor();
            _chartPanel = new PasswordStrengthChart(reportsByPassColor);
        }
        private void ShowChart()
        {
            pnlChartList.Controls.Clear();
            pnlChartList.Controls.Add(this._chartPanel);
            btnShowChart.Enabled = false;
        }

        private void ShowPasswordList(PasswordStrengthColor passColor)
        {
            pnlChartList.Controls.Clear();
            UserControl passwordsToShow = new PasswordListOfStrengthColor(_myPasswordManager, passColor);
            pnlChartList.Controls.Add(passwordsToShow);
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
            _colorsCmp = new List<colorComponent>
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
