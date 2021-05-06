using Obligatorio1_DA1.Utilities;
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
    public partial class PasswordStrengthChart : UserControl
    {
        private Dictionary<PasswordStrengthColor, Color> presentationColor;
        public PasswordStrengthChart(List<passwordReportByCategoryAndColor> chartData)
        {
            InitializeComponent();
            SetPresentationColor();
            LoadChart(chartData);
        }

        private void LoadChart(List<passwordReportByCategoryAndColor> chartData)
        {
            foreach (PasswordStrengthColor color in (PasswordStrengthColor[])Enum.GetValues(typeof(PasswordStrengthColor)))
            {
                this.chartPasswordStrength.Series.Add(color.ToString());
                this.chartPasswordStrength.Series[color.ToString()].Color = this.presentationColor[color];
                this.chartPasswordStrength.Series[color.ToString()].IsVisibleInLegend = false;
            }

            foreach (passwordReportByCategoryAndColor entry in chartData)
            {
                this.chartPasswordStrength.Series[entry.Color.ToString()].Points.AddXY(entry.Category.Name, entry.Quantity);
            }
        }
        private void SetPresentationColor()
        {
            presentationColor = new Dictionary<PasswordStrengthColor, Color>();
            presentationColor.Add(PasswordStrengthColor.DarkGreen, Color.FromArgb(85, 130, 61));
            presentationColor.Add(PasswordStrengthColor.LightGreen, Color.FromArgb(148, 208, 94));
            presentationColor.Add(PasswordStrengthColor.Yellow, Color.FromArgb(255, 254, 68));
            presentationColor.Add(PasswordStrengthColor.Orange, Color.FromArgb(241, 121, 58));
            presentationColor.Add(PasswordStrengthColor.Red, Color.FromArgb(195, 0, 4));
        }
    }
}
