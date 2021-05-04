
namespace Presentation
{
    partial class Categories
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
            this.pnlCategoryInsertion = new System.Windows.Forms.Panel();
            this.lblCreateCategory = new System.Windows.Forms.Label();
            this.lblNameAddPassword = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNameAdd = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCategoryInsertion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCategoryInsertion
            // 
            this.pnlCategoryInsertion.Controls.Add(this.lblCreateCategory);
            this.pnlCategoryInsertion.Controls.Add(this.lblNameAddPassword);
            this.pnlCategoryInsertion.Controls.Add(this.btnAdd);
            this.pnlCategoryInsertion.Controls.Add(this.txtNameAdd);
            this.pnlCategoryInsertion.Controls.Add(this.lblTitle);
            this.pnlCategoryInsertion.Location = new System.Drawing.Point(3, 3);
            this.pnlCategoryInsertion.Name = "pnlCategoryInsertion";
            this.pnlCategoryInsertion.Size = new System.Drawing.Size(312, 192);
            this.pnlCategoryInsertion.TabIndex = 1;
            // 
            // lblCreateCategory
            // 
            this.lblCreateCategory.AutoSize = true;
            this.lblCreateCategory.Enabled = false;
            this.lblCreateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCreateCategory.Location = new System.Drawing.Point(7, 74);
            this.lblCreateCategory.Name = "lblCreateCategory";
            this.lblCreateCategory.Size = new System.Drawing.Size(110, 18);
            this.lblCreateCategory.TabIndex = 4;
            this.lblCreateCategory.Text = "Crear categoria";
            // 
            // lblNameAddPassword
            // 
            this.lblNameAddPassword.AutoSize = true;
            this.lblNameAddPassword.Location = new System.Drawing.Point(7, 104);
            this.lblNameAddPassword.Name = "lblNameAddPassword";
            this.lblNameAddPassword.Size = new System.Drawing.Size(44, 13);
            this.lblNameAddPassword.TabIndex = 3;
            this.lblNameAddPassword.Text = "Nombre";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(206, 158);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtNameAdd
            // 
            this.txtNameAdd.Location = new System.Drawing.Point(8, 120);
            this.txtNameAdd.Name = "txtNameAdd";
            this.txtNameAdd.Size = new System.Drawing.Size(201, 20);
            this.txtNameAdd.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Enabled = false;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitle.Location = new System.Drawing.Point(3, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(107, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Categorias";
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCategoryInsertion);
            this.Name = "Categories";
            this.Size = new System.Drawing.Size(780, 399);
            this.pnlCategoryInsertion.ResumeLayout(false);
            this.pnlCategoryInsertion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCategoryInsertion;
        private System.Windows.Forms.Label lblCreateCategory;
        private System.Windows.Forms.Label lblNameAddPassword;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNameAdd;
        private System.Windows.Forms.Label lblTitle;
    }
}
