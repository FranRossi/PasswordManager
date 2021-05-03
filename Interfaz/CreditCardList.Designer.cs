
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
            ((System.ComponentModel.ISupportInitialize)(this.tblCreditCards)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCreditCards
            // 
            this.tblCreditCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCreditCards.Location = new System.Drawing.Point(81, 99);
            this.tblCreditCards.Name = "tblCreditCards";
            this.tblCreditCards.RowHeadersWidth = 62;
            this.tblCreditCards.RowTemplate.Height = 28;
            this.tblCreditCards.Size = new System.Drawing.Size(814, 246);
            this.tblCreditCards.TabIndex = 0;
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
    }
}
