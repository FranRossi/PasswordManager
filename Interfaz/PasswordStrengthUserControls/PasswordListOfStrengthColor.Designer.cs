
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
            this.btmModify = new System.Windows.Forms.Button();
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
            // btmModify
            // 
            this.btmModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmModify.Location = new System.Drawing.Point(300, 268);
            this.btmModify.Name = "btmModify";
            this.btmModify.Size = new System.Drawing.Size(138, 28);
            this.btmModify.TabIndex = 4;
            this.btmModify.Text = "Modificar";
            this.btmModify.UseVisualStyleBackColor = true;
            // 
            // PasswordListOfStrenghtColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btmModify);
            this.Controls.Add(this.tblPassword);
            this.Name = "PasswordListOfStrenghtColor";
            this.Size = new System.Drawing.Size(463, 314);
            ((System.ComponentModel.ISupportInitialize)(this.tblPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblPassword;
        private System.Windows.Forms.Button btmModify;
    }
}
