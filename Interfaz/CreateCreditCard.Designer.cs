
namespace Presentation
{
    partial class CreateCreditCard
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.txtExpirationDate = new System.Windows.Forms.TextBox();
            this.lblSecureCode = new System.Windows.Forms.Label();
            this.txtSecureCode = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCreditCard = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlCreditCard.SuspendLayout();
            this.gpbCreditCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCreditCard
            // 
            this.pnlCreditCard.Controls.Add(this.gpbCreditCard);
            this.pnlCreditCard.Controls.Add(this.lblCreditCard);
            this.pnlCreditCard.Location = new System.Drawing.Point(41, 44);
            this.pnlCreditCard.Name = "pnlCreditCard";
            this.pnlCreditCard.Size = new System.Drawing.Size(491, 601);
            this.pnlCreditCard.TabIndex = 0;
            // 
            // gpbCreditCard
            // 
            this.gpbCreditCard.BackColor = System.Drawing.SystemColors.Menu;
            this.gpbCreditCard.Controls.Add(this.lblError);
            this.gpbCreditCard.Controls.Add(this.btnAccept);
            this.gpbCreditCard.Controls.Add(this.txtNotes);
            this.gpbCreditCard.Controls.Add(this.lblNotes);
            this.gpbCreditCard.Controls.Add(this.lblExpirationDate);
            this.gpbCreditCard.Controls.Add(this.txtExpirationDate);
            this.gpbCreditCard.Controls.Add(this.lblSecureCode);
            this.gpbCreditCard.Controls.Add(this.txtSecureCode);
            this.gpbCreditCard.Controls.Add(this.lblNumber);
            this.gpbCreditCard.Controls.Add(this.txtNumber);
            this.gpbCreditCard.Controls.Add(this.lblType);
            this.gpbCreditCard.Controls.Add(this.txtType);
            this.gpbCreditCard.Controls.Add(this.lblName);
            this.gpbCreditCard.Controls.Add(this.txtName);
            this.gpbCreditCard.Controls.Add(this.cbCategory);
            this.gpbCreditCard.Controls.Add(this.lblCategory);
            this.gpbCreditCard.Location = new System.Drawing.Point(25, 53);
            this.gpbCreditCard.Name = "gpbCreditCard";
            this.gpbCreditCard.Size = new System.Drawing.Size(433, 518);
            this.gpbCreditCard.TabIndex = 1;
            this.gpbCreditCard.TabStop = false;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(310, 462);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(105, 41);
            this.btnAccept.TabIndex = 15;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(183, 371);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(203, 73);
            this.txtNotes.TabIndex = 14;
            this.txtNotes.Text = "";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(39, 371);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(51, 20);
            this.lblNotes.TabIndex = 13;
            this.lblNotes.Text = "Notas";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(38, 303);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(97, 20);
            this.lblExpirationDate.TabIndex = 11;
            this.lblExpirationDate.Text = "Vencimiento";
            // 
            // txtExpirationDate
            // 
            this.txtExpirationDate.Location = new System.Drawing.Point(183, 303);
            this.txtExpirationDate.Name = "txtExpirationDate";
            this.txtExpirationDate.Size = new System.Drawing.Size(203, 26);
            this.txtExpirationDate.TabIndex = 10;
            // 
            // lblSecureCode
            // 
            this.lblSecureCode.AutoSize = true;
            this.lblSecureCode.Location = new System.Drawing.Point(38, 250);
            this.lblSecureCode.Name = "lblSecureCode";
            this.lblSecureCode.Size = new System.Drawing.Size(59, 20);
            this.lblSecureCode.TabIndex = 9;
            this.lblSecureCode.Text = "Código";
            // 
            // txtSecureCode
            // 
            this.txtSecureCode.Location = new System.Drawing.Point(183, 250);
            this.txtSecureCode.Name = "txtSecureCode";
            this.txtSecureCode.Size = new System.Drawing.Size(203, 26);
            this.txtSecureCode.TabIndex = 8;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(38, 197);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(65, 20);
            this.lblNumber.TabIndex = 7;
            this.lblNumber.Text = "Número";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(183, 197);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(203, 26);
            this.txtNumber.TabIndex = 6;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(38, 142);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 20);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Tipo";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(183, 142);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(203, 26);
            this.txtType.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(38, 91);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(183, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 26);
            this.txtName.TabIndex = 2;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(183, 43);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(203, 28);
            this.cbCategory.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(39, 43);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(78, 20);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Categoría";
            // 
            // lblCreditCard
            // 
            this.lblCreditCard.AutoSize = true;
            this.lblCreditCard.Location = new System.Drawing.Point(21, 18);
            this.lblCreditCard.Name = "lblCreditCard";
            this.lblCreditCard.Size = new System.Drawing.Size(58, 20);
            this.lblCreditCard.TabIndex = 0;
            this.lblCreditCard.Text = "Tarjeta";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(28, 468);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 16;
            // 
            // CreateCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 657);
            this.Controls.Add(this.pnlCreditCard);
            this.Name = "CreateCreditCard";
            this.Text = "CreateCreditCard";
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
        private System.Windows.Forms.TextBox txtExpirationDate;
        private System.Windows.Forms.Label lblSecureCode;
        private System.Windows.Forms.TextBox txtSecureCode;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
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
    }
}