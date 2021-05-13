
namespace Presentation
{
    partial class PasswordsSharedWithMe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlList = new System.Windows.Forms.Panel();
            this.tblPassword = new System.Windows.Forms.DataGridView();
            this.CategorySharedWithMe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTIitle = new System.Windows.Forms.Label();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.tblPassword);
            this.pnlList.Controls.Add(this.lblTIitle);
            this.pnlList.Location = new System.Drawing.Point(3, 2);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(780, 399);
            this.pnlList.TabIndex = 1;
            // 
            // tblPassword
            // 
            this.tblPassword.AllowUserToAddRows = false;
            this.tblPassword.AllowUserToDeleteRows = false;
            this.tblPassword.AllowUserToResizeRows = false;
            this.tblPassword.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblPassword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPassword.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategorySharedWithMe});
            this.tblPassword.Location = new System.Drawing.Point(9, 54);
            this.tblPassword.Name = "tblPassword";
            this.tblPassword.ReadOnly = true;
            this.tblPassword.RowHeadersVisible = false;
            this.tblPassword.RowTemplate.DefaultCellStyle.NullValue = "Compartida conmigo";
            this.tblPassword.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblPassword.Size = new System.Drawing.Size(768, 343);
            this.tblPassword.TabIndex = 6;
            // 
            // CategorySharedWithMe
            // 
            this.CategorySharedWithMe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.NullValue = "Compartida conmigo";
            this.CategorySharedWithMe.DefaultCellStyle = dataGridViewCellStyle1;
            this.CategorySharedWithMe.HeaderText = "Categoria";
            this.CategorySharedWithMe.Name = "CategorySharedWithMe";
            this.CategorySharedWithMe.ReadOnly = true;
            // 
            // lblTIitle
            // 
            this.lblTIitle.AutoSize = true;
            this.lblTIitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTIitle.Location = new System.Drawing.Point(3, 14);
            this.lblTIitle.Name = "lblTIitle";
            this.lblTIitle.Size = new System.Drawing.Size(314, 25);
            this.lblTIitle.TabIndex = 0;
            this.lblTIitle.Text = "Contraseñas compartidas conmigo";
            // 
            // PasswordsSharedWithMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlList);
            this.Name = "PasswordsSharedWithMe";
            this.Size = new System.Drawing.Size(790, 411);
            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.DataGridView tblPassword;
        private System.Windows.Forms.Label lblTIitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategorySharedWithMe;
    }
}