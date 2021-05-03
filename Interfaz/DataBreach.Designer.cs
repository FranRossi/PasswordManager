
namespace Presentation
{
    partial class pnlDataBreachResult
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
            this.pnlDataBreachText = new System.Windows.Forms.Panel();
            this.btnVerifyDataBreach = new System.Windows.Forms.Button();
            this.txtDataBreach = new System.Windows.Forms.TextBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDataBreachText.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDataBreachText
            // 
            this.pnlDataBreachText.Controls.Add(this.label1);
            this.pnlDataBreachText.Controls.Add(this.btnVerifyDataBreach);
            this.pnlDataBreachText.Controls.Add(this.txtDataBreach);
            this.pnlDataBreachText.Controls.Add(this.lblSubtitle);
            this.pnlDataBreachText.Controls.Add(this.lblTitle);
            this.pnlDataBreachText.Location = new System.Drawing.Point(3, 3);
            this.pnlDataBreachText.Name = "pnlDataBreachText";
            this.pnlDataBreachText.Size = new System.Drawing.Size(287, 393);
            this.pnlDataBreachText.TabIndex = 0;
            // 
            // btnVerifyDataBreach
            // 
            this.btnVerifyDataBreach.Location = new System.Drawing.Point(209, 348);
            this.btnVerifyDataBreach.Name = "btnVerifyDataBreach";
            this.btnVerifyDataBreach.Size = new System.Drawing.Size(75, 23);
            this.btnVerifyDataBreach.TabIndex = 3;
            this.btnVerifyDataBreach.Text = "Verificar";
            this.btnVerifyDataBreach.UseVisualStyleBackColor = true;
            // 
            // txtDataBreach
            // 
            this.txtDataBreach.Location = new System.Drawing.Point(7, 80);
            this.txtDataBreach.Multiline = true;
            this.txtDataBreach.Name = "txtDataBreach";
            this.txtDataBreach.Size = new System.Drawing.Size(277, 245);
            this.txtDataBreach.TabIndex = 2;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(4, 63);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(80, 13);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Texto expuesto";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(73, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(141, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Data Breaches";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(293, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 393);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data Breaches";
            // 
            // pnlDataBreachResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDataBreachText);
            this.Name = "pnlDataBreachResult";
            this.Size = new System.Drawing.Size(780, 399);
            this.pnlDataBreachText.ResumeLayout(false);
            this.pnlDataBreachText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDataBreachText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVerifyDataBreach;
        private System.Windows.Forms.TextBox txtDataBreach;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
    }
}
