
namespace Presentation
{
    partial class CreateModifyCreditCard
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
            this.pnlCreditCard = new System.Windows.Forms.Panel();
            this.gpbCreditCard = new System.Windows.Forms.GroupBox();
            this.mtxtNumber = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSecureCode = new System.Windows.Forms.MaskedTextBox();
            this.mtxtExpirationDate = new System.Windows.Forms.MaskedTextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblSecureCode = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCreditCard = new System.Windows.Forms.Label();
            this.pnlCreditCard.SuspendLayout();
            this.gpbCreditCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCreditCard
            // 
            this.pnlCreditCard.Controls.Add(this.gpbCreditCard);
            this.pnlCreditCard.Controls.Add(this.lblCreditCard);
            this.pnlCreditCard.Location = new System.Drawing.Point(2, -5);
            this.pnlCreditCard.Name = "pnlCreditCard";
            this.pnlCreditCard.Size = new System.Drawing.Size(597, 646);
            this.pnlCreditCard.TabIndex = 0;
            // 
            // gpbCreditCard
            // 
            this.gpbCreditCard.BackColor = System.Drawing.SystemColors.Menu;
            this.gpbCreditCard.Controls.Add(this.mtxtNumber);
            this.gpbCreditCard.Controls.Add(this.mtxtSecureCode);
            this.gpbCreditCard.Controls.Add(this.mtxtExpirationDate);
            this.gpbCreditCard.Controls.Add(this.lblError);
            this.gpbCreditCard.Controls.Add(this.btnAccept);
            this.gpbCreditCard.Controls.Add(this.txtNotes);
            this.gpbCreditCard.Controls.Add(this.lblNotes);
            this.gpbCreditCard.Controls.Add(this.lblExpirationDate);
            this.gpbCreditCard.Controls.Add(this.lblSecureCode);
            this.gpbCreditCard.Controls.Add(this.lblNumber);
            this.gpbCreditCard.Controls.Add(this.lblType);
            this.gpbCreditCard.Controls.Add(this.txtType);
            this.gpbCreditCard.Controls.Add(this.lblName);
            this.gpbCreditCard.Controls.Add(this.txtName);
            this.gpbCreditCard.Controls.Add(this.cbCategory);
            this.gpbCreditCard.Controls.Add(this.lblCategory);
            this.gpbCreditCard.Location = new System.Drawing.Point(20, 52);
            this.gpbCreditCard.Name = "gpbCreditCard";
            this.gpbCreditCard.Size = new System.Drawing.Size(574, 574);
            this.gpbCreditCard.TabIndex = 1;
            this.gpbCreditCard.TabStop = false;
            // 
            // mtxtNumber
            // 
            this.mtxtNumber.Location = new System.Drawing.Point(204, 192);
            this.mtxtNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtxtNumber.Mask = "0000 0000 0000 0000";
            this.mtxtNumber.Name = "mtxtNumber";
            this.mtxtNumber.Size = new System.Drawing.Size(302, 26);
            this.mtxtNumber.TabIndex = 3;
            this.mtxtNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtNumber.ValidatingType = typeof(int);
            // 
            // mtxtSecureCode
            // 
            this.mtxtSecureCode.Location = new System.Drawing.Point(204, 245);
            this.mtxtSecureCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtxtSecureCode.Mask = "0000";
            this.mtxtSecureCode.Name = "mtxtSecureCode";
            this.mtxtSecureCode.Size = new System.Drawing.Size(302, 26);
            this.mtxtSecureCode.TabIndex = 4;
            this.mtxtSecureCode.ValidatingType = typeof(int);
            // 
            // mtxtExpirationDate
            // 
            this.mtxtExpirationDate.Location = new System.Drawing.Point(204, 298);
            this.mtxtExpirationDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtxtExpirationDate.Mask = "00/00";
            this.mtxtExpirationDate.Name = "mtxtExpirationDate";
            this.mtxtExpirationDate.Size = new System.Drawing.Size(302, 26);
            this.mtxtExpirationDate.TabIndex = 5;
            this.mtxtExpirationDate.ValidatingType = typeof(System.DateTime);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(6, 515);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 16;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(304, 468);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(204, 42);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(204, 366);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(302, 73);
            this.txtNotes.TabIndex = 6;
            this.txtNotes.Text = "";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(60, 371);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(51, 20);
            this.lblNotes.TabIndex = 13;
            this.lblNotes.Text = "Notas";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(58, 303);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(97, 20);
            this.lblExpirationDate.TabIndex = 11;
            this.lblExpirationDate.Text = "Vencimiento";
            // 
            // lblSecureCode
            // 
            this.lblSecureCode.AutoSize = true;
            this.lblSecureCode.Location = new System.Drawing.Point(58, 249);
            this.lblSecureCode.Name = "lblSecureCode";
            this.lblSecureCode.Size = new System.Drawing.Size(59, 20);
            this.lblSecureCode.TabIndex = 9;
            this.lblSecureCode.Text = "Código";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(58, 197);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(65, 20);
            this.lblNumber.TabIndex = 7;
            this.lblNumber.Text = "Número";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(58, 142);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 20);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Tipo";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(204, 137);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(302, 26);
            this.txtType.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(58, 91);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(204, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(302, 26);
            this.txtName.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(204, 38);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(302, 28);
            this.cbCategory.TabIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(60, 43);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(78, 20);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Categoría";
            // 
            // lblCreditCard
            // 
            this.lblCreditCard.AutoSize = true;
            this.lblCreditCard.Location = new System.Drawing.Point(15, 18);
            this.lblCreditCard.Name = "lblCreditCard";
            this.lblCreditCard.Size = new System.Drawing.Size(58, 20);
            this.lblCreditCard.TabIndex = 0;
            this.lblCreditCard.Text = "Tarjeta";
            // 
            // CreateModifyCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 649);
            this.Controls.Add(this.pnlCreditCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateModifyCreditCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordManager";
            this.pnlCreditCard.ResumeLayout(false);
            this.pnlCreditCard.PerformLayout();
            this.gpbCreditCard.ResumeLayout(false);
            this.gpbCreditCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCreditCard;
        private System.Windows.Forms.Label lblCreditCard;
        private System.Windows.Forms.GroupBox gpbCreditCard;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblSecureCode;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.MaskedTextBox mtxtExpirationDate;
        private System.Windows.Forms.MaskedTextBox mtxtSecureCode;
        private System.Windows.Forms.MaskedTextBox mtxtNumber;
    }
}