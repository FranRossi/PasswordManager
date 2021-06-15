using Obligatorio1_DA1.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.PasswordStrengthWindow
{
    public partial class PasswordStrengthChart : UserControl
    {
        private Dictionary<PasswordStrengthColor, Color> _presentationColor;
        public PasswordStrengthChart(List<PasswordReportByCategoryAndColor> chartData)
        {
            InitializeComponent();
            SetPresentationColor();
            LoadChart(chartData);
        }

        private void LoadChart(List<PasswordReportByCategoryAndColor> chartDataToLoad)
        {
            foreach (PasswordStrengthColor passColor in (PasswordStrengthColor[])Enum.GetValues(typeof(PasswordStrengthColor)))
            {
                chartPasswordStrength.Series.Add(passColor.ToString());
                chartPasswordStrength.Series[passColor.ToString()].Color = _presentationColor[passColor];
                chartPasswordStrength.Series[passColor.ToString()].IsVisibleInLegend = false;
            }

            foreach (PasswordReportByCategoryAndColor entry in chartDataToLoad)
            {
                chartPasswordStrength.Series[entry.Color.ToString()].Points.AddXY(entry.Category.Name, entry.Quantity);
            }
            chartPasswordStrength.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            Color chartHorizontalLines = Color.FromArgb(218, 218, 218);
            chartPasswordStrength.ChartAreas[0].AxisY.MajorGrid.LineColor = chartHorizontalLines;
        }
        private void SetPresentationColor()
        {
            _presentationColor = new Dictionary<PasswordStrengthColor, Color>();
            _presentationColor.Add(PasswordStrengthColor.DarkGreen, Color.FromArgb(85, 130, 61));
            _presentationColor.Add(PasswordStrengthColor.LightGreen, Color.FromArgb(148, 208, 94));
            _presentationColor.Add(PasswordStrengthColor.Yellow, Color.FromArgb(255, 254, 68));
            _presentationColor.Add(PasswordStrengthColor.Orange, Color.FromArgb(241, 121, 58));
            _presentationColor.Add(PasswordStrengthColor.Red, Color.FromArgb(195, 0, 4));
        }
    }
}
