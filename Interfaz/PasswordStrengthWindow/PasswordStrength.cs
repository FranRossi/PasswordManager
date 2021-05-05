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
    public partial class PasswordStrength : UserControl
    {
        private PasswordManager _passwordManager;
        private PasswordStrengthChart chartPanel;
        public PasswordStrength(PasswordManager passwordManager)
        {
            this._passwordManager = passwordManager;
            InitializeComponent();
            this.ShowChart();
            this.SetColorQuantities();
        }

        private void SetColorQuantities()
        {
            Dictionary<PasswordStrengthColor, Label> labelOfColor = new Dictionary<PasswordStrengthColor, Label>();
            labelOfColor.Add(PasswordStrengthColor.DarkGreen, lblDarkGreenQuantity);
            labelOfColor.Add(PasswordStrengthColor.LightGreen, lblLightGreenQuantity);
            labelOfColor.Add(PasswordStrengthColor.Yellow, lblYellowQuantity);
            labelOfColor.Add(PasswordStrengthColor.Orange, lblOrangeQuantity);
            labelOfColor.Add(PasswordStrengthColor.Red, lblRedQuantity);


            List<passwordReportByColor> report = this._passwordManager.GetPasswordReportByColor(null);
            foreach (passwordReportByColor entry in report)
            {
                Label lbl = labelOfColor[entry.Color];
                lbl.Text = entry.Quantity.ToString();
            }
        }

        private void ShowChart()
        {
            if (this.chartPanel == null)
            {
                this.chartPanel = new PasswordStrengthChart(new List<Obligatorio1_DA1.Utilities.passwordReportByCategoryAndColor>());
            }
            pnlChartList.Controls.Clear();
            pnlChartList.Controls.Add(chartPanel);
        }

        private void btmShowChart_Click(object sender, EventArgs e)
        {
            this.ShowChart();
        }
    }
}
