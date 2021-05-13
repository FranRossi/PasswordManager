
namespace Presentation.PasswordUserControls
{
    partial class ShowPassword
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
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.gpbPassword = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlPassword.SuspendLayout();
            this.gpbPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPassword
            // 
            this.pnlPassword.Controls.Add(this.gpbPassword);
            this.pnlPassword.Controls.Add(this.lblPassword);
            this.pnlPassword.Location = new System.Drawing.Point(16, 17);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(490, 512);
            this.pnlPassword.TabIndex = 3;
            // 
            // gpbPassword
            // 
            this.gpbPassword.BackColor = System.Drawing.SystemColors.Menu;
            this.gpbPassword.Controls.Add(this.btnShow);
            this.gpbPassword.Controls.Add(this.txtNotes);
            this.gpbPassword.Controls.Add(this.txtCategory);
            this.gpbPassword.Controls.Add(this.txtSite);
            this.gpbPassword.Controls.Add(this.txtUser);
            this.gpbPassword.Controls.Add(this.txtPassword);
            this.gpbPassword.Controls.Add(this.label1);
            this.gpbPassword.Controls.Add(this.btnAccept);
            this.gpbPassword.Controls.Add(this.lblNotes);
            this.gpbPassword.Controls.Add(this.lblUser);
            this.gpbPassword.Controls.Add(this.lblSite);
            this.gpbPassword.Controls.Add(this.lblCategory);
            this.gpbPassword.Location = new System.Drawing.Point(26, 52);
            this.gpbPassword.Name = "gpbPassword";
            this.gpbPassword.Size = new System.Drawing.Size(434, 422);
            this.gpbPassword.TabIndex = 1;
            this.gpbPassword.TabStop = false;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(350, 177);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(76, 35);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Mostrar";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNotes.Location = new System.Drawing.Point(146, 246);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(280, 97);
            this.txtNotes.TabIndex = 28;
            // 
            // txtCategory
            // 
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategory.Location = new System.Drawing.Point(146, 28);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategory.Multiline = true;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(280, 38);
            this.txtCategory.TabIndex = 27;
            this.txtCategory.Text = "Category Placeholder";
            // 
            // txtSite
            // 
            this.txtSite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSite.Location = new System.Drawing.Point(146, 75);
            this.txtSite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSite.Multiline = true;
            this.txtSite.Name = "txtSite";
            this.txtSite.ReadOnly = true;
            this.txtSite.Size = new System.Drawing.Size(280, 52);
            this.txtSite.TabIndex = 26;
            this.txtSite.Text = "Site Placeholder";
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Location = new System.Drawing.Point(146, 126);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(260, 42);
            this.txtUser.TabIndex = 25;
            this.txtUser.Text = "User Placeholder";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(146, 185);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(195, 52);
            this.txtPassword.TabIndex = 24;
            this.txtPassword.Text = "Password Placeholder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Contraseña:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(322, 351);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(105, 42);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(14, 246);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(55, 20);
            this.lblNotes.TabIndex = 13;
            this.lblNotes.Text = "Notas:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 126);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(68, 20);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Usuario:";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(12, 75);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(44, 20);
            this.lblSite.TabIndex = 3;
            this.lblSite.Text = "Sitio:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(14, 28);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(82, 20);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Categoría:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(21, 18);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 20);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Contraseña";
            // 
            // ShowPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 538);
            this.Controls.Add(this.pnlPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ShowPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordManager";
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.gpbPassword.ResumeLayout(false);
            this.gpbPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox gpbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnShow;
    }
}