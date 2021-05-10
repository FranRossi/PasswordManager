
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
            this.btnShow = new System.Windows.Forms.Button();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPassword)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.tblPassword);
            this.pnlList.Controls.Add(this.lblTIitle);
            this.pnlList.Location = new System.Drawing.Point(4, 4);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(773, 341);
            this.pnlList.TabIndex = 0;
            // 
            // tblPassword
            // 
            this.tblPassword.AllowUserToAddRows = false;
            this.tblPassword.AllowUserToDeleteRows = false;
            this.tblPassword.AllowUserToResizeRows = false;
            this.tblPassword.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblPassword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPassword.Location = new System.Drawing.Point(8, 55);
            this.tblPassword.MultiSelect = false;
            this.tblPassword.Name = "tblPassword";
            this.tblPassword.ReadOnly = true;
            this.tblPassword.RowHeadersVisible = false;
            this.tblPassword.RowHeadersWidth = 62;
            this.tblPassword.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblPassword.Size = new System.Drawing.Size(753, 273);
            this.tblPassword.TabIndex = 6;
            // 
            // lblTIitle
            // 
            this.lblTIitle.AutoSize = true;
            this.lblTIitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTIitle.Location = new System.Drawing.Point(3, 14);
            this.lblTIitle.Name = "lblTIitle";
            this.lblTIitle.Size = new System.Drawing.Size(124, 25);
            this.lblTIitle.TabIndex = 0;
            this.lblTIitle.Text = "Contraseñas";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(686, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(591, 11);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(496, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSharedPasswords
            // 
            this.btnSharedPasswords.Location = new System.Drawing.Point(401, 11);
            this.btnSharedPasswords.Margin = new System.Windows.Forms.Padding(2);
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
            this.lblMessage.Location = new System.Drawing.Point(8, 20);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 4;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnShow);
            this.pnlButtons.Controls.Add(this.lblMessage);
            this.pnlButtons.Controls.Add(this.btnSharedPasswords);
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnModify);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Location = new System.Drawing.Point(4, 352);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(773, 44);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(306, 11);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Mostrar ";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // PasswordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlList);
            this.Name = "PasswordList";
            this.Size = new System.Drawing.Size(780, 399);
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
        private System.Windows.Forms.Button btnShow;
    }
}
