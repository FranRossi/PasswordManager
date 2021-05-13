
namespace Presentation.PasswordStrengthWindow
{
    partial class PasswordStrengthChart
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartPasswordStrength = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartPasswordStrength)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPasswordStrength
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPasswordStrength.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPasswordStrength.Legends.Add(legend1);
            this.chartPasswordStrength.Location = new System.Drawing.Point(0, 0);
            this.chartPasswordStrength.Name = "chartPasswordStrength";
            this.chartPasswordStrength.Size = new System.Drawing.Size(463, 314);
            this.chartPasswordStrength.TabIndex = 1;
            this.chartPasswordStrength.Text = "Cantidad de Constrañas por Categoría/Grupo";
            // 
            // PasswordStrengthChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartPasswordStrength);
            this.Name = "PasswordStrengthChart";
            this.Size = new System.Drawing.Size(463, 314);
            ((System.ComponentModel.ISupportInitialize)(this.chartPasswordStrength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPasswordStrength;
    }
}
