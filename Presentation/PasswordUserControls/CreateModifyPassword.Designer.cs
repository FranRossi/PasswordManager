﻿
namespace Presentation
{
    partial class CreateModifyPassword
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
            this.gpbCreditCard = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cbSymbol = new System.Windows.Forms.CheckBox();
            this.cbDigit = new System.Windows.Forms.CheckBox();
            this.cbLowercase = new System.Windows.Forms.CheckBox();
            this.cbUppercase = new System.Windows.Forms.CheckBox();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.pnlPassword.SuspendLayout();
            this.gpbCreditCard.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPassword
            // 
            this.pnlPassword.Controls.Add(this.gpbCreditCard);
            this.pnlPassword.Controls.Add(this.lblPassword);
            this.pnlPassword.Location = new System.Drawing.Point(11, 11);
            this.pnlPassword.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(401, 536);
            this.pnlPassword.TabIndex = 2;
            // 
            // gpbCreditCard
            // 
            this.gpbCreditCard.BackColor = System.Drawing.SystemColors.Menu;
            this.gpbCreditCard.Controls.Add(this.lblMessage);
            this.gpbCreditCard.Controls.Add(this.groupBox1);
            this.gpbCreditCard.Controls.Add(this.btnAccept);
            this.gpbCreditCard.Controls.Add(this.txtNotes);
            this.gpbCreditCard.Controls.Add(this.lblNotes);
            this.gpbCreditCard.Controls.Add(this.lblPass);
            this.gpbCreditCard.Controls.Add(this.lblUser);
            this.gpbCreditCard.Controls.Add(this.txtUserName);
            this.gpbCreditCard.Controls.Add(this.lblSite);
            this.gpbCreditCard.Controls.Add(this.txtSite);
            this.gpbCreditCard.Controls.Add(this.cbCategory);
            this.gpbCreditCard.Controls.Add(this.lblCategory);
            this.gpbCreditCard.Location = new System.Drawing.Point(2, 34);
            this.gpbCreditCard.Margin = new System.Windows.Forms.Padding(2);
            this.gpbCreditCard.Name = "gpbCreditCard";
            this.gpbCreditCard.Padding = new System.Windows.Forms.Padding(2);
            this.gpbCreditCard.Size = new System.Drawing.Size(397, 502);
            this.gpbCreditCard.TabIndex = 1;
            this.gpbCreditCard.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(9, 477);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbShowPassword);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.cbSymbol);
            this.groupBox1.Controls.Add(this.cbDigit);
            this.groupBox1.Controls.Add(this.cbLowercase);
            this.groupBox1.Controls.Add(this.cbUppercase);
            this.groupBox1.Controls.Add(this.nudLength);
            this.groupBox1.Controls.Add(this.lblLength);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Location = new System.Drawing.Point(115, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 243);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(107, 201);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(70, 27);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Generar";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cbSymbol
            // 
            this.cbSymbol.AutoSize = true;
            this.cbSymbol.Location = new System.Drawing.Point(17, 173);
            this.cbSymbol.Name = "cbSymbol";
            this.cbSymbol.Size = new System.Drawing.Size(132, 17);
            this.cbSymbol.TabIndex = 9;
            this.cbSymbol.Text = "Especiales (!,$,[,{,<,...)";
            this.cbSymbol.UseVisualStyleBackColor = true;
            // 
            // cbDigit
            // 
            this.cbDigit.AutoSize = true;
            this.cbDigit.Location = new System.Drawing.Point(17, 150);
            this.cbDigit.Name = "cbDigit";
            this.cbDigit.Size = new System.Drawing.Size(105, 17);
            this.cbDigit.TabIndex = 8;
            this.cbDigit.Text = "Dígitos (1,2,3,...)";
            this.cbDigit.UseVisualStyleBackColor = true;
            // 
            // cbLowercase
            // 
            this.cbLowercase.AutoSize = true;
            this.cbLowercase.Location = new System.Drawing.Point(17, 127);
            this.cbLowercase.Name = "cbLowercase";
            this.cbLowercase.Size = new System.Drawing.Size(124, 17);
            this.cbLowercase.TabIndex = 7;
            this.cbLowercase.Text = "Minúsculas (a,b,c,...)";
            this.cbLowercase.UseVisualStyleBackColor = true;
            // 
            // cbUppercase
            // 
            this.cbUppercase.AutoSize = true;
            this.cbUppercase.Location = new System.Drawing.Point(17, 104);
            this.cbUppercase.Name = "cbUppercase";
            this.cbUppercase.Size = new System.Drawing.Size(130, 17);
            this.cbUppercase.TabIndex = 6;
            this.cbUppercase.Text = "Mayúsculas (A,B,C,...)";
            this.cbUppercase.UseVisualStyleBackColor = true;
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(53, 70);
            this.nudLength.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudLength.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(100, 20);
            this.nudLength.TabIndex = 5;
            this.nudLength.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(14, 72);
            this.lblLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(34, 13);
            this.lblLength.TabIndex = 18;
            this.lblLength.Text = "Largo";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(17, 11);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(207, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(222, 439);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(140, 27);
            this.btnAccept.TabIndex = 12;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(132, 364);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(2);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(207, 64);
            this.txtNotes.TabIndex = 11;
            this.txtNotes.Text = "";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(36, 367);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 13;
            this.lblNotes.Text = "Notas";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(35, 120);
            this.lblPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(61, 13);
            this.lblPass.TabIndex = 7;
            this.lblPass.Text = "Contraseña";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(35, 84);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Usuario";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(132, 81);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(207, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(35, 51);
            this.lblSite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(27, 13);
            this.lblSite.TabIndex = 3;
            this.lblSite.Text = "Sitio";
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(132, 48);
            this.txtSite.Margin = new System.Windows.Forms.Padding(2);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(207, 20);
            this.txtSite.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(132, 17);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(207, 21);
            this.cbCategory.TabIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(36, 20);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(54, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Categoría";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(2, 10);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 13);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Contraseña";
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Location = new System.Drawing.Point(17, 36);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(117, 17);
            this.cbShowPassword.TabIndex = 19;
            this.cbShowPassword.Text = "Mostrar contraseña";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // CreateModifyPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 558);
            this.Controls.Add(this.pnlPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateModifyPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordManager";
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.gpbCreditCard.ResumeLayout(false);
            this.gpbCreditCard.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.GroupBox gpbCreditCard;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox cbSymbol;
        private System.Windows.Forms.CheckBox cbDigit;
        private System.Windows.Forms.CheckBox cbLowercase;
        private System.Windows.Forms.CheckBox cbUppercase;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox cbShowPassword;
    }
}