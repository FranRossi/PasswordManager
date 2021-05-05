
namespace Presentation.PasswordStrengthWindow
{
    partial class PasswordListOfStrenghtColor
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
            this.tblPassword = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPassword
            // 
            this.tblPassword.AllowUserToAddRows = false;
            this.tblPassword.AllowUserToDeleteRows = false;
            this.tblPassword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPassword.Location = new System.Drawing.Point(0, 0);
            this.tblPassword.Name = "tblPassword";
            this.tblPassword.ReadOnly = true;
            this.tblPassword.Size = new System.Drawing.Size(463, 253);
            this.tblPassword.TabIndex = 0;
            // 
            // PasswordListOfStrenghtColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblPassword);
            this.Name = "PasswordListOfStrenghtColor";
            this.Size = new System.Drawing.Size(463, 314);
            ((System.ComponentModel.ISupportInitialize)(this.tblPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblPassword;
    }
}
