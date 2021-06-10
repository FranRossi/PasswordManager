
namespace Presentation
{
    partial class DataBreachHistory
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
            this.tblPasswords = new System.Windows.Forms.DataGridView();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tblReports = new System.Windows.Forms.DataGridView();
            this.lblSharedWith = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblPasswords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReports)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPasswords
            // 
            this.tblPasswords.AllowUserToAddRows = false;
            this.tblPasswords.AllowUserToDeleteRows = false;
            this.tblPasswords.AllowUserToResizeRows = false;
            this.tblPasswords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblPasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPasswords.Location = new System.Drawing.Point(352, 87);
            this.tblPasswords.MultiSelect = false;
            this.tblPasswords.Name = "tblPasswords";
            this.tblPasswords.ReadOnly = true;
            this.tblPasswords.RowHeadersVisible = false;
            this.tblPasswords.RowHeadersWidth = 62;
            this.tblPasswords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblPasswords.Size = new System.Drawing.Size(410, 231);
            this.tblPasswords.TabIndex = 24;
            this.tblPasswords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblPasswords_CellContentClick);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(-1, 377);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 23;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitle.Location = new System.Drawing.Point(19, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(248, 25);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Historico de Data Breaches";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblPassword.Location = new System.Drawing.Point(20, 59);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 22);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Reportes";
            // 
            // tblReports
            // 
            this.tblReports.AllowUserToAddRows = false;
            this.tblReports.AllowUserToDeleteRows = false;
            this.tblReports.AllowUserToResizeColumns = false;
            this.tblReports.AllowUserToResizeRows = false;
            this.tblReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblReports.Location = new System.Drawing.Point(18, 87);
            this.tblReports.MultiSelect = false;
            this.tblReports.Name = "tblReports";
            this.tblReports.ReadOnly = true;
            this.tblReports.RowHeadersVisible = false;
            this.tblReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblReports.Size = new System.Drawing.Size(309, 231);
            this.tblReports.TabIndex = 15;
            this.tblReports.SelectionChanged += new System.EventHandler(this.tblReports_SelectionChanged);
            // 
            // lblSharedWith
            // 
            this.lblSharedWith.AutoSize = true;
            this.lblSharedWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblSharedWith.Location = new System.Drawing.Point(348, 62);
            this.lblSharedWith.Name = "lblSharedWith";
            this.lblSharedWith.Size = new System.Drawing.Size(112, 22);
            this.lblSharedWith.TabIndex = 20;
            this.lblSharedWith.Text = "Contraseñas";
            // 
            // DataBreachHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblPasswords);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tblReports);
            this.Controls.Add(this.lblSharedWith);
            this.Name = "DataBreachHistory";
            this.Size = new System.Drawing.Size(776, 368);
            ((System.ComponentModel.ISupportInitialize)(this.tblPasswords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblPasswords;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.DataGridView tblReports;
        private System.Windows.Forms.Label lblSharedWith;
    }
}
