
namespace Presentation.CreditCardUserControls
{
    partial class ShowCreditCard
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
            this.mtxtNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlPassword.SuspendLayout();
            this.gpbPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPassword
            // 
            this.pnlPassword.Controls.Add(this.gpbPassword);
            this.pnlPassword.Controls.Add(this.lblTitle);
            this.pnlPassword.Location = new System.Drawing.Point(2, 17);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(490, 606);
            this.pnlPassword.TabIndex = 4;
            // 
            // gpbPassword
            // 
            this.gpbPassword.BackColor = System.Drawing.SystemColors.Menu;
            this.gpbPassword.Controls.Add(this.mtxtNumber);
            this.gpbPassword.Controls.Add(this.txtDate);
            this.gpbPassword.Controls.Add(this.lblDate);
            this.gpbPassword.Controls.Add(this.txtCode);
            this.gpbPassword.Controls.Add(this.lblCode);
            this.gpbPassword.Controls.Add(this.btnShow);
            this.gpbPassword.Controls.Add(this.txtNotes);
            this.gpbPassword.Controls.Add(this.txtCategory);
            this.gpbPassword.Controls.Add(this.txtName);
            this.gpbPassword.Controls.Add(this.txtType);
            this.gpbPassword.Controls.Add(this.lblNumber);
            this.gpbPassword.Controls.Add(this.btnAccept);
            this.gpbPassword.Controls.Add(this.lblNotes);
            this.gpbPassword.Controls.Add(this.lblTipo);
            this.gpbPassword.Controls.Add(this.lblName);
            this.gpbPassword.Controls.Add(this.lblCategory);
            this.gpbPassword.Location = new System.Drawing.Point(26, 52);
            this.gpbPassword.Name = "gpbPassword";
            this.gpbPassword.Size = new System.Drawing.Size(434, 540);
            this.gpbPassword.TabIndex = 1;
            this.gpbPassword.TabStop = false;
            // 
            // mtxtNumber
            // 
            this.mtxtNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtNumber.Location = new System.Drawing.Point(146, 185);
            this.mtxtNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtxtNumber.Mask = "AAAA AAAA AAAA AAAA";
            this.mtxtNumber.Name = "mtxtNumber";
            this.mtxtNumber.ReadOnly = true;
            this.mtxtNumber.Size = new System.Drawing.Size(206, 19);
            this.mtxtNumber.TabIndex = 34;
            this.mtxtNumber.Text = "1111111111111111";
            this.mtxtNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtNumber.ValidatingType = typeof(int);
            // 
            // txtDate
            // 
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Location = new System.Drawing.Point(146, 308);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(195, 52);
            this.txtDate.TabIndex = 33;
            this.txtDate.Text = "Date Placeholder";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(14, 308);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(101, 20);
            this.lblDate.TabIndex = 32;
            this.lblDate.Text = "Vencimiento:";
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Location = new System.Drawing.Point(146, 246);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(195, 52);
            this.txtCode.TabIndex = 31;
            this.txtCode.Text = "Code Placeholder";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(14, 246);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(63, 20);
            this.lblCode.TabIndex = 30;
            this.lblCode.Text = "Código:";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(350, 214);
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
            this.txtNotes.Location = new System.Drawing.Point(146, 359);
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
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Location = new System.Drawing.Point(146, 75);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(280, 52);
            this.txtName.TabIndex = 26;
            this.txtName.Text = "Name Placeholder ";
            // 
            // txtType
            // 
            this.txtType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtType.Location = new System.Drawing.Point(146, 126);
            this.txtType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtType.Multiline = true;
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(260, 42);
            this.txtType.TabIndex = 25;
            this.txtType.Text = "Type Placeholder";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(14, 185);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(69, 20);
            this.lblNumber.TabIndex = 9;
            this.lblNumber.Text = "Number:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(328, 477);
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
            this.lblNotes.Location = new System.Drawing.Point(20, 372);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(55, 20);
            this.lblNotes.TabIndex = 13;
            this.lblNotes.Text = "Notas:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 126);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 20);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Nombre:";
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(21, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tarjeta";
            // 
            // ShowCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 632);
            this.Controls.Add(this.pnlPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ShowCreditCard";
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
        private System.Windows.Forms.GroupBox gpbPassword;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MaskedTextBox mtxtNumber;
    }
}