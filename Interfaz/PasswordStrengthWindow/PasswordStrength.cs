using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Utilities;
using Presentation.PasswordStrengthWindow;
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

    struct colorComponent
    {
        public PasswordStrengthColor Color { get; set; }
        public Label Label { get; set; }
        public Button Button { get; set; }
    }
    public partial class PasswordStrength : UserControl
    {
        private PasswordManager _passwordManager;
        private PasswordStrengthChart chartPanel;
        private List<colorComponent> colorCmp;
        public PasswordStrength(PasswordManager passwordManager)
        {
            this._passwordManager = passwordManager;
            InitializeComponent();
            this.SetColorsLabelsAndButtons();
            this.SetColorQuantities();
            this.ShowChart();

        }


        private void SetColorQuantities()
        {
            List<passwordReportByColor> report = this._passwordManager.GetPasswordReportByColor();
            foreach (passwordReportByColor entry in report)
            {
                colorComponent cmp = colorCmp.Find(component => component.Color == entry.Color);
                int quantity = entry.Quantity;
                cmp.Label.Text = quantity.ToString();
                if (quantity == 0)
                    cmp.Button.Enabled = false;



            }
        }

        private void ShowChart()
        {
            bool enoughtPasswordToShow = true;
            if (this.chartPanel == null)
            {
                List<passwordReportByCategoryAndColor> report = this._passwordManager.GetPasswordReportByCategoryAndColor();
                if (report.Count() > 0)
                    this.chartPanel = new PasswordStrengthChart(report);
                else
                    enoughtPasswordToShow = false;
            }
            if (enoughtPasswordToShow)
            {
                pnlChartList.Controls.Clear();
                pnlChartList.Controls.Add(chartPanel);
            }
            else
            {
                btmShowChart.Enabled = false;
            }
        }
        private void ShowPasswordList(PasswordStrengthColor color)
        {
            pnlChartList.Controls.Clear();
            List<Password> password = this._passwordManager.GetPasswordsByColor(color);
            UserControl passwordList = new PasswordListOfStrenghtColor(password);
            pnlChartList.Controls.Add(passwordList);
        }

        private void btmShowChart_Click(object sender, EventArgs e)
        {
            this.ShowChart();
        }

        private void btmShowPasswordsRed_Click(object sender, EventArgs e)
        {
            ShowPasswordList(PasswordStrengthColor.Red);
        }

        private void btmShowPasswordsOrange_Click(object sender, EventArgs e)
        {
            ShowPasswordList(PasswordStrengthColor.Orange);
        }


        private void btmShowPasswordsYellow_Click(object sender, EventArgs e)
        {
            ShowPasswordList(PasswordStrengthColor.Yellow);
        }

        private void btmShowPasswordsLightGreen_Click(object sender, EventArgs e)
        {
            ShowPasswordList(PasswordStrengthColor.LightGreen);
        }

        private void btmShowPasswordsDarkGreen_Click(object sender, EventArgs e)
        {
            ShowPasswordList(PasswordStrengthColor.DarkGreen);
        }
        private void SetColorsLabelsAndButtons()
        {
            this.colorCmp = new List<colorComponent>
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
