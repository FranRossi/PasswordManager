
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
            this.tblCreditCards = new System.Windows.Forms.DataGridView();
            this.btnAddsCreditCard = new System.Windows.Forms.Button();
            this.btnDeleteCreditCard = new System.Windows.Forms.Button();
            this.btnModifiesCreditCard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblCreditCards)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCreditCards
            // 
            this.tblCreditCards.AllowUserToAddRows = false;
            this.tblCreditCards.AllowUserToDeleteRows = false;
            this.tblCreditCards.AllowUserToOrderColumns = true;
            this.tblCreditCards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblCreditCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCreditCards.Location = new System.Drawing.Point(57, 99);
            this.tblCreditCards.MultiSelect = false;
            this.tblCreditCards.Name = "tblCreditCards";
            this.tblCreditCards.RowHeadersWidth = 62;
            this.tblCreditCards.RowTemplate.Height = 28;
            this.tblCreditCards.Size = new System.Drawing.Size(945, 345);
            this.tblCreditCards.TabIndex = 0;
            // 
            // btnAddsCreditCard
            // 
            this.btnAddsCreditCard.Location = new System.Drawing.Point(658, 501);
            this.btnAddsCreditCard.Name = "btnAddsCreditCard";
            this.btnAddsCreditCard.Size = new System.Drawing.Size(85, 42);
            this.btnAddsCreditCard.TabIndex = 1;
            this.btnAddsCreditCard.Text = "Agregar";
            this.btnAddsCreditCard.UseVisualStyleBackColor = true;
            this.btnAddsCreditCard.Click += new System.EventHandler(this.btnAddsCreditCard_Click);
            // 
            // btnDeleteCreditCard
            // 
            this.btnDeleteCreditCard.Location = new System.Drawing.Point(885, 501);
            this.btnDeleteCreditCard.Name = "btnDeleteCreditCard";
            this.btnDeleteCreditCard.Size = new System.Drawing.Size(85, 42);
            this.btnDeleteCreditCard.TabIndex = 2;
            this.btnDeleteCreditCard.Text = "Eliminar";
            this.btnDeleteCreditCard.UseVisualStyleBackColor = true;
            this.btnDeleteCreditCard.Click += new System.EventHandler(this.btnDeleteCreditCard_Click);
            // 
            // btnModifiesCreditCard
            // 
            this.btnModifiesCreditCard.Location = new System.Drawing.Point(772, 501);
            this.btnModifiesCreditCard.Name = "btnModifiesCreditCard";
            this.btnModifiesCreditCard.Size = new System.Drawing.Size(85, 42);
            this.btnModifiesCreditCard.TabIndex = 3;
            this.btnModifiesCreditCard.Text = "Modificar";
            this.btnModifiesCreditCard.UseVisualStyleBackColor = true;
            // 
            // CreditCardList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnModifiesCreditCard);
            this.Controls.Add(this.btnDeleteCreditCard);
            this.Controls.Add(this.btnAddsCreditCard);
            this.Controls.Add(this.tblCreditCards);
            this.Name = "CreditCardList";
            this.Size = new System.Drawing.Size(1110, 623);
            ((System.ComponentModel.ISupportInitialize)(this.tblCreditCards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblCreditCards;
        private System.Windows.Forms.Button btnAddsCreditCard;
        private System.Windows.Forms.Button btnDeleteCreditCard;
        private System.Windows.Forms.Button btnModifiesCreditCard;
    }
}
