
namespace Presentation
{
    partial class DeleteConfirmation
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
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.chPopUp = new System.Windows.Forms.CheckBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblConfirmationMessage = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlButtons.Controls.Add(this.chPopUp);
            this.pnlButtons.Controls.Add(this.btnAccept);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Location = new System.Drawing.Point(1, 107);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(410, 47);
            this.pnlButtons.TabIndex = 2;
            // 
            // chPopUp
            // 
            this.chPopUp.AutoSize = true;
            this.chPopUp.Location = new System.Drawing.Point(7, 19);
            this.chPopUp.Margin = new System.Windows.Forms.Padding(2);
            this.chPopUp.Name = "chPopUp";
            this.chPopUp.Size = new System.Drawing.Size(183, 17);
            this.chPopUp.TabIndex = 2;
            this.chPopUp.Text = "No volver a mostrar este mensaje";
            this.chPopUp.UseVisualStyleBackColor = true;
            this.chPopUp.CheckedChanged += new System.EventHandler(this.chPopUp_CheckedChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAccept.Location = new System.Drawing.Point(203, 12);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(81, 25);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCancel.Location = new System.Drawing.Point(296, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 25);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblConfirmationMessage
            // 
            this.lblConfirmationMessage.AutoSize = true;
            this.lblConfirmationMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblConfirmationMessage.Location = new System.Drawing.Point(19, 47);
            this.lblConfirmationMessage.Name = "lblConfirmationMessage";
            this.lblConfirmationMessage.Size = new System.Drawing.Size(258, 18);
            this.lblConfirmationMessage.TabIndex = 3;
            this.lblConfirmationMessage.Text = "¿Estás seguro que quieres eliminar la ";
            // 
            // DeleteConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(412, 153);
            this.Controls.Add(this.lblConfirmationMessage);
            this.Controls.Add(this.pnlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "DeleteConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmación";
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblConfirmationMessage;
        private System.Windows.Forms.CheckBox chPopUp;
    }
}