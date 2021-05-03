
namespace Interfaz
{
    partial class MainWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMainScreen = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlMainScreen
            // 
            this.pnlMainScreen.Location = new System.Drawing.Point(11, 11);
            this.pnlMainScreen.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMainScreen.Name = "pnlMainScreen";
            this.pnlMainScreen.Size = new System.Drawing.Size(780, 399);
            this.pnlMainScreen.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 421);
            this.Controls.Add(this.pnlMainScreen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "PasswordManager";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMainScreen;
    }
}