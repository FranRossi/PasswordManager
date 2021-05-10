
namespace Presentation
{
    partial class CreditCardList
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
            this.lblTIitle = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tblCreditCard = new System.Windows.Forms.DataGridView();
            this.pnlList = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCreditCard = new System.Windows.Forms.Button();
            this.btnModifyCreditCard = new System.Windows.Forms.Button();
            this.btnDeleteCreditCard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblCreditCard)).BeginInit();
            this.pnlList.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTIitle
            // 
            this.lblTIitle.AutoSize = true;
            this.lblTIitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTIitle.Location = new System.Drawing.Point(3, 14);
            this.lblTIitle.Name = "lblTIitle";
            this.lblTIitle.Size = new System.Drawing.Size(83, 25);
            this.lblTIitle.TabIndex = 4;
            this.lblTIitle.Text = "Tarjetas";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(35, 326);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 5;
            // 
            // tblCreditCard
            // 
            this.tblCreditCard.AllowUserToAddRows = false;
            this.tblCreditCard.AllowUserToDeleteRows = false;
            this.tblCreditCard.AllowUserToResizeRows = false;
            this.tblCreditCard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblCreditCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCreditCard.Location = new System.Drawing.Point(8, 55);
            this.tblCreditCard.MultiSelect = false;
            this.tblCreditCard.Name = "tblCreditCard";
            this.tblCreditCard.ReadOnly = true;
            this.tblCreditCard.RowHeadersVisible = false;
            this.tblCreditCard.RowHeadersWidth = 62;
            this.tblCreditCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblCreditCard.Size = new System.Drawing.Size(753, 273);
            this.tblCreditCard.TabIndex = 7;
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.tblCreditCard);
            this.pnlList.Controls.Add(this.lblTIitle);
            this.pnlList.Location = new System.Drawing.Point(4, 3);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(773, 341);
            this.pnlList.TabIndex = 8;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.label1);
            this.pnlButtons.Controls.Add(this.btnAddCreditCard);
            this.pnlButtons.Controls.Add(this.btnModifyCreditCard);
            this.pnlButtons.Controls.Add(this.btnDeleteCreditCard);
            this.pnlButtons.Location = new System.Drawing.Point(4, 352);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(773, 44);
            this.pnlButtons.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // btnAddCreditCard
            // 
            this.btnAddCreditCard.Location = new System.Drawing.Point(501, 11);
            this.btnAddCreditCard.Name = "btnAddCreditCard";
            this.btnAddCreditCard.Size = new System.Drawing.Size(75, 23);
            this.btnAddCreditCard.TabIndex = 2;
            this.btnAddCreditCard.Text = "Agregar";
            this.btnAddCreditCard.UseVisualStyleBackColor = true;
            this.btnAddCreditCard.Click += new System.EventHandler(this.btnAddCreditCard_Click);
            // 
            // btnModifyCreditCard
            // 
            this.btnModifyCreditCard.Location = new System.Drawing.Point(591, 11);
            this.btnModifyCreditCard.Name = "btnModifyCreditCard";
            this.btnModifyCreditCard.Size = new System.Drawing.Size(75, 23);
            this.btnModifyCreditCard.TabIndex = 1;
            this.btnModifyCreditCard.Text = "Modificar";
            this.btnModifyCreditCard.UseVisualStyleBackColor = true;
            this.btnModifyCreditCard.Click += new System.EventHandler(this.btnModifyCreditCard_Click);
            // 
            // btnDeleteCreditCard
            // 
            this.btnDeleteCreditCard.Location = new System.Drawing.Point(686, 11);
            this.btnDeleteCreditCard.Name = "btnDeleteCreditCard";
            this.btnDeleteCreditCard.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCreditCard.TabIndex = 0;
            this.btnDeleteCreditCard.Text = "Eliminar";
            this.btnDeleteCreditCard.UseVisualStyleBackColor = true;
            this.btnDeleteCreditCard.Click += new System.EventHandler(this.btnDeleteCreditCard_Click);
            // 
            // CreditCardList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pnlList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreditCardList";
            this.Size = new System.Drawing.Size(780, 399);
            ((System.ComponentModel.ISupportInitialize)(this.tblCreditCard)).EndInit();
            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTIitle;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DataGridView tblCreditCard;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCreditCard;
        private System.Windows.Forms.Button btnModifyCreditCard;
        private System.Windows.Forms.Button btnDeleteCreditCard;
    }
}
