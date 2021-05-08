
namespace Presentation
{
    partial class PasswordList
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
            this.pnlList = new System.Windows.Forms.Panel();
            this.tblPassword = new System.Windows.Forms.DataGridView();
            this.lblTIitle = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSharedPasswords = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPassword)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.tblPassword);
            this.pnlList.Controls.Add(this.lblTIitle);
            this.pnlList.Location = new System.Drawing.Point(6, 6);
            this.pnlList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(1160, 525);
            this.pnlList.TabIndex = 0;
            // 
            // tblPassword
            // 
            this.tblPassword.AllowUserToAddRows = false;
            this.tblPassword.AllowUserToDeleteRows = false;
            this.tblPassword.AllowUserToResizeRows = false;
            this.tblPassword.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblPassword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPassword.Location = new System.Drawing.Point(12, 85);
            this.tblPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tblPassword.Name = "tblPassword";
            this.tblPassword.ReadOnly = true;
            this.tblPassword.RowHeadersVisible = false;
            this.tblPassword.RowHeadersWidth = 62;
            this.tblPassword.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblPassword.Size = new System.Drawing.Size(1130, 420);
            this.tblPassword.TabIndex = 6;
            // 
            // lblTIitle
            // 
            this.lblTIitle.AutoSize = true;
            this.lblTIitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTIitle.Location = new System.Drawing.Point(4, 22);
            this.lblTIitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTIitle.Name = "lblTIitle";
            this.lblTIitle.Size = new System.Drawing.Size(183, 36);
            this.lblTIitle.TabIndex = 0;
            this.lblTIitle.Text = "Contraseñas";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1029, 17);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 35);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(886, 17);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(112, 35);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(752, 17);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSharedPasswords
            // 
            this.btnSharedPasswords.Location = new System.Drawing.Point(409, 11);
            this.btnSharedPasswords.Name = "btnSharedPasswords";
            this.btnSharedPasswords.Size = new System.Drawing.Size(75, 23);
            this.btnSharedPasswords.TabIndex = 3;
            this.btnSharedPasswords.Text = "Compartir";
            this.btnSharedPasswords.UseVisualStyleBackColor = true;
            this.btnSharedPasswords.Click += new System.EventHandler(this.btnSharedPasswords_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 31);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 20);
            this.lblMessage.TabIndex = 4;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.lblMessage);
            this.pnlButtons.Controls.Add(this.btnSharedPasswords);
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnModify);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Location = new System.Drawing.Point(6, 542);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1160, 68);
            this.pnlButtons.TabIndex = 1;
            // 
            // PasswordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PasswordList";
            this.Size = new System.Drawing.Size(1170, 614);
            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPassword)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Label lblTIitle;
        private System.Windows.Forms.DataGridView tblPassword;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSharedPasswords;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel pnlButtons;
    }
}
