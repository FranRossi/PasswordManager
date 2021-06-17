
namespace Presentation
{
    partial class DataBreach
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnVerifyDataBreach = new System.Windows.Forms.Button();
            this.txtDataBreach = new System.Windows.Forms.TextBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDataBreachResult = new System.Windows.Forms.Label();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.tblDataBreachCreditCard = new System.Windows.Forms.DataGridView();
            this.tblDataBreachPassword = new System.Windows.Forms.DataGridView();
            this.btnModifyPass = new System.Windows.Forms.Button();
            this.lblCard = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnOpenTextFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlDataBreachText.SuspendLayout();
            this.pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDataBreachCreditCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDataBreachPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDataBreachText
            // 
            this.pnlDataBreachText.Controls.Add(this.btnCancel);
            this.pnlDataBreachText.Controls.Add(this.btnOpenTextFile);
            this.pnlDataBreachText.Controls.Add(this.lblMessage);
            this.pnlDataBreachText.Controls.Add(this.btnVerifyDataBreach);
            this.pnlDataBreachText.Controls.Add(this.txtDataBreach);
            this.pnlDataBreachText.Controls.Add(this.lblSubtitle);
            this.pnlDataBreachText.Controls.Add(this.lblTitle);
            this.pnlDataBreachText.Location = new System.Drawing.Point(3, 3);
            this.pnlDataBreachText.Name = "pnlDataBreachText";
            this.pnlDataBreachText.Size = new System.Drawing.Size(287, 393);
            this.pnlDataBreachText.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(7, 377);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 4;
            // 
            // btnVerifyDataBreach
            // 
            this.btnVerifyDataBreach.Location = new System.Drawing.Point(209, 342);
            this.btnVerifyDataBreach.Name = "btnVerifyDataBreach";
            this.btnVerifyDataBreach.Size = new System.Drawing.Size(75, 23);
            this.btnVerifyDataBreach.TabIndex = 1;
            this.btnVerifyDataBreach.Text = "Verificar";
            this.btnVerifyDataBreach.UseVisualStyleBackColor = true;
            this.btnVerifyDataBreach.Click += new System.EventHandler(this.btnVerifyDataBreach_Click);
            // 
            // txtDataBreach
            // 
            this.txtDataBreach.Location = new System.Drawing.Point(7, 53);
            this.txtDataBreach.Multiline = true;
            this.txtDataBreach.Name = "txtDataBreach";
            this.txtDataBreach.Size = new System.Drawing.Size(277, 256);
            this.txtDataBreach.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(4, 37);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(80, 13);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Texto expuesto";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(73, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(141, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Data Breaches";
            // 
            // lblDataBreachResult
            // 
            this.lblDataBreachResult.AutoSize = true;
            this.lblDataBreachResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataBreachResult.Location = new System.Drawing.Point(7, 2);
            this.lblDataBreachResult.Name = "lblDataBreachResult";
            this.lblDataBreachResult.Size = new System.Drawing.Size(109, 25);
            this.lblDataBreachResult.TabIndex = 4;
            this.lblDataBreachResult.Text = "Resultados";
            // 
            // pnlResults
            // 
            this.pnlResults.Controls.Add(this.tblDataBreachCreditCard);
            this.pnlResults.Controls.Add(this.tblDataBreachPassword);
            this.pnlResults.Controls.Add(this.btnModifyPass);
            this.pnlResults.Controls.Add(this.lblCard);
            this.pnlResults.Controls.Add(this.lblPass);
            this.pnlResults.Controls.Add(this.lblDataBreachResult);
            this.pnlResults.Location = new System.Drawing.Point(293, 3);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(484, 393);
            this.pnlResults.TabIndex = 1;
            // 
            // tblDataBreachCreditCard
            // 
            this.tblDataBreachCreditCard.AllowUserToAddRows = false;
            this.tblDataBreachCreditCard.AllowUserToDeleteRows = false;
            this.tblDataBreachCreditCard.AllowUserToResizeRows = false;
            this.tblDataBreachCreditCard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblDataBreachCreditCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDataBreachCreditCard.Location = new System.Drawing.Point(12, 229);
            this.tblDataBreachCreditCard.MultiSelect = false;
            this.tblDataBreachCreditCard.Name = "tblDataBreachCreditCard";
            this.tblDataBreachCreditCard.ReadOnly = true;
            this.tblDataBreachCreditCard.RowHeadersVisible = false;
            this.tblDataBreachCreditCard.RowHeadersWidth = 62;
            this.tblDataBreachCreditCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblDataBreachCreditCard.Size = new System.Drawing.Size(469, 136);
            this.tblDataBreachCreditCard.TabIndex = 4;
            // 
            // tblDataBreachPassword
            // 
            this.tblDataBreachPassword.AllowUserToAddRows = false;
            this.tblDataBreachPassword.AllowUserToDeleteRows = false;
            this.tblDataBreachPassword.AllowUserToResizeRows = false;
            this.tblDataBreachPassword.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblDataBreachPassword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDataBreachPassword.Location = new System.Drawing.Point(12, 53);
            this.tblDataBreachPassword.MultiSelect = false;
            this.tblDataBreachPassword.Name = "tblDataBreachPassword";
            this.tblDataBreachPassword.ReadOnly = true;
            this.tblDataBreachPassword.RowHeadersVisible = false;
            this.tblDataBreachPassword.RowHeadersWidth = 62;
            this.tblDataBreachPassword.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblDataBreachPassword.Size = new System.Drawing.Size(469, 128);
            this.tblDataBreachPassword.TabIndex = 2;
            // 
            // btnModifyPass
            // 
            this.btnModifyPass.Location = new System.Drawing.Point(406, 190);
            this.btnModifyPass.Name = "btnModifyPass";
            this.btnModifyPass.Size = new System.Drawing.Size(75, 23);
            this.btnModifyPass.TabIndex = 3;
            this.btnModifyPass.Text = "Modificar";
            this.btnModifyPass.UseVisualStyleBackColor = true;
            this.btnModifyPass.Click += new System.EventHandler(this.btnModifyPass_Click);
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Location = new System.Drawing.Point(9, 213);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(99, 13);
            this.lblCard.TabIndex = 6;
            this.lblCard.Text = "Tarjetas expuestas:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(9, 37);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(120, 13);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Contraseñas expuestas:";
            // 
            // btnOpenTextFile
            // 
            this.btnOpenTextFile.Location = new System.Drawing.Point(7, 342);
            this.btnOpenTextFile.Name = "btnOpenTextFile";
            this.btnOpenTextFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenTextFile.TabIndex = 5;
            this.btnOpenTextFile.Text = "Abrir archivo";
            this.btnOpenTextFile.UseVisualStyleBackColor = true;
            this.btnOpenTextFile.Click += new System.EventHandler(this.btnOpenTextFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(161, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Agregar manualmente";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DataBreach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.pnlDataBreachText);
            this.Name = "DataBreach";
            this.Size = new System.Drawing.Size(780, 399);
            this.pnlDataBreachText.ResumeLayout(false);
            this.pnlDataBreachText.PerformLayout();
            this.pnlResults.ResumeLayout(false);
            this.pnlResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDataBreachCreditCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDataBreachPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDataBreachText;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Button btnVerifyDataBreach;
        private System.Windows.Forms.TextBox txtDataBreach;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDataBreachResult;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnModifyPass;
        private System.Windows.Forms.DataGridView tblDataBreachCreditCard;
        private System.Windows.Forms.DataGridView tblDataBreachPassword;
        private System.Windows.Forms.Button btnOpenTextFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnCancel;
    }
}
