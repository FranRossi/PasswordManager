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
        public PasswordStrengthChart(List<passwordReportByCategoryAndColor> chartData)
        {
            InitializeComponent();
            LoadChart(chartData);
        }

        private void LoadChart(List<passwordReportByCategoryAndColor> chartData)
        {
            List<string> categories = new List<string> { "Persona", "Trabajo", "Facultad" };
            List<string> colors = new List<string> { "Rojo", "Amarillo", "Verde" };
            Random rand = new Random();
            foreach (string color in colors)
            {
                this.chartPasswordStrength.Series.Add(color);
                foreach (string category in categories)
                {
                    this.chartPasswordStrength.Series[color].Points.AddXY(category, rand.Next());
                }
            }
        }
    }
}
