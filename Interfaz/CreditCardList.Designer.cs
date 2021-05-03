
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
            this.categoryCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDateCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblCreditCards)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCreditCards
            // 
            this.tblCreditCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCreditCards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryCard,
            this.nameCard,
            this.typeCard,
            this.creditCardNumber,
            this.expirationDateCard});
            this.tblCreditCards.Location = new System.Drawing.Point(81, 99);
            this.tblCreditCards.Name = "tblCreditCards";
            this.tblCreditCards.RowHeadersWidth = 62;
            this.tblCreditCards.RowTemplate.Height = 28;
            this.tblCreditCards.Size = new System.Drawing.Size(814, 246);
            this.tblCreditCards.TabIndex = 0;
            // 
            // categoryCard
            // 
            this.categoryCard.HeaderText = "Categoria";
            this.categoryCard.MinimumWidth = 8;
            this.categoryCard.Name = "categoryCard";
            this.categoryCard.Width = 150;
            // 
            // nameCard
            // 
            this.nameCard.HeaderText = "Nombre";
            this.nameCard.MinimumWidth = 8;
            this.nameCard.Name = "nameCard";
            this.nameCard.Width = 150;
            // 
            // typeCard
            // 
            this.typeCard.HeaderText = "Tipo";
            this.typeCard.MinimumWidth = 8;
            this.typeCard.Name = "typeCard";
            this.typeCard.Width = 150;
            // 
            // creditCardNumber
            // 
            this.creditCardNumber.HeaderText = "Tarjeta";
            this.creditCardNumber.MinimumWidth = 8;
            this.creditCardNumber.Name = "creditCardNumber";
            this.creditCardNumber.Width = 150;
            // 
            // expirationDateCard
            // 
            this.expirationDateCard.HeaderText = "Vencimiento";
            this.expirationDateCard.MinimumWidth = 8;
            this.expirationDateCard.Name = "expirationDateCard";
            this.expirationDateCard.Width = 150;
            // 
            // CreditCardList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblCreditCards);
            this.Name = "CreditCardList";
            this.Size = new System.Drawing.Size(1008, 604);
            ((System.ComponentModel.ISupportInitialize)(this.tblCreditCards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblCreditCards;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDateCard;
    }
}
