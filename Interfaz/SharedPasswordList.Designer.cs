
namespace Presentation
{
    partial class SharedPasswordList
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnUnShare = new System.Windows.Forms.Button();
            this.btnShare = new System.Windows.Forms.Button();
            this.btnSharedPasswords = new System.Windows.Forms.Button();
            this.tblSharedWith = new System.Windows.Forms.DataGridView();
            this.lblSharedWith = new System.Windows.Forms.Label();
            this.cbUsersNotSharedWith = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSharedWith)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPassword
            // 
            this.tblPassword.AllowUserToAddRows = false;
            this.tblPassword.AllowUserToDeleteRows = false;
            this.tblPassword.AllowUserToResizeColumns = false;
            this.tblPassword.AllowUserToResizeRows = false;
            this.tblPassword.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblPassword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPassword.Location = new System.Drawing.Point(32, 82);
            this.tblPassword.MultiSelect = false;
            this.tblPassword.Name = "tblPassword";
            this.tblPassword.ReadOnly = true;
            this.tblPassword.RowHeadersVisible = false;
            this.tblPassword.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblPassword.Size = new System.Drawing.Size(437, 182);
            this.tblPassword.TabIndex = 0;
            this.tblPassword.SelectionChanged += new System.EventHandler(this.tblPassword_SelectionChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblPassword.Location = new System.Drawing.Point(31, 54);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(112, 22);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Contraseñas";
            // 
            // btnUnShare
            // 
            this.btnUnShare.Location = new System.Drawing.Point(565, 320);
            this.btnUnShare.Name = "btnUnShare";
            this.btnUnShare.Size = new System.Drawing.Size(107, 23);
            this.btnUnShare.TabIndex = 4;
            this.btnUnShare.Text = "Descompartir";
            this.btnUnShare.UseVisualStyleBackColor = true;
            this.btnUnShare.Click += new System.EventHandler(this.btnUnShare_Click);
            // 
            // btnShare
            // 
            this.btnShare.Location = new System.Drawing.Point(149, 320);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(99, 23);
            this.btnShare.TabIndex = 2;
            this.btnShare.Text = "Compartir";
            this.btnShare.UseVisualStyleBackColor = true;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // btnSharedPasswords
            // 
            this.btnSharedPasswords.Location = new System.Drawing.Point(564, 14);
            this.btnSharedPasswords.Name = "btnSharedPasswords";
            this.btnSharedPasswords.Size = new System.Drawing.Size(196, 23);
            this.btnSharedPasswords.TabIndex = 5;
            this.btnSharedPasswords.Text = "Volver a Lista de Constraseñas";
            this.btnSharedPasswords.UseVisualStyleBackColor = true;
            this.btnSharedPasswords.Click += new System.EventHandler(this.btnSharedPasswords_Click);
            // 
            // tblSharedWith
            // 
            this.tblSharedWith.AllowUserToAddRows = false;
            this.tblSharedWith.AllowUserToDeleteRows = false;
            this.tblSharedWith.AllowUserToResizeColumns = false;
            this.tblSharedWith.AllowUserToResizeRows = false;
            this.tblSharedWith.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblSharedWith.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSharedWith.Location = new System.Drawing.Point(565, 82);
            this.tblSharedWith.MultiSelect = false;
            this.tblSharedWith.Name = "tblSharedWith";
            this.tblSharedWith.ReadOnly = true;
            this.tblSharedWith.RowHeadersVisible = false;
            this.tblSharedWith.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblSharedWith.Size = new System.Drawing.Size(158, 182);
            this.tblSharedWith.TabIndex = 3;
            this.tblSharedWith.SelectionChanged += new System.EventHandler(this.tblSharedWith_SelectionChanged);
            // 
            // lblSharedWith
            // 
            this.lblSharedWith.AutoSize = true;
            this.lblSharedWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblSharedWith.Location = new System.Drawing.Point(560, 54);
            this.lblSharedWith.Name = "lblSharedWith";
            this.lblSharedWith.Size = new System.Drawing.Size(136, 22);
            this.lblSharedWith.TabIndex = 8;
            this.lblSharedWith.Text = "Compartida con";
            // 
            // cbUsersNotSharedWith
            // 
            this.cbUsersNotSharedWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsersNotSharedWith.FormattingEnabled = true;
            this.cbUsersNotSharedWith.Location = new System.Drawing.Point(149, 293);
            this.cbUsersNotSharedWith.Name = "cbUsersNotSharedWith";
            this.cbUsersNotSharedWith.Size = new System.Drawing.Size(121, 21);
            this.cbUsersNotSharedWith.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(36, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Compartir con:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitle.Location = new System.Drawing.Point(30, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(224, 25);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Compartir Constraseñas";
            // 
            // SharedPasswordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbUsersNotSharedWith);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.btnSharedPasswords);
            this.Controls.Add(this.btnUnShare);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tblPassword);
            this.Controls.Add(this.lblSharedWith);
            this.Controls.Add(this.tblSharedWith);
            this.Name = "SharedPasswordList";
            this.Size = new System.Drawing.Size(780, 399);
            ((System.ComponentModel.ISupportInitialize)(this.tblPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSharedWith)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.DataGridView tblPassword;
        private System.Windows.Forms.Button btnUnShare;
        private System.Windows.Forms.Button btnShare;
        private System.Windows.Forms.Button btnSharedPasswords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSharedWith;
        private System.Windows.Forms.DataGridView tblSharedWith;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbUsersNotSharedWith;
    }
}
