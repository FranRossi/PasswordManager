
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
            this.pnlCategoryList = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnActivateModification = new System.Windows.Forms.Button();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.lblList = new System.Windows.Forms.Label();
            this.pnlCategoryModification = new System.Windows.Forms.Panel();
            this.btnModify = new System.Windows.Forms.Button();
            this.txtNameModify = new System.Windows.Forms.TextBox();
            this.lblNameModifyPassword = new System.Windows.Forms.Label();
            this.lblModifyCategory = new System.Windows.Forms.Label();
            this.pnlCategoryInsertion.SuspendLayout();
            this.pnlCategoryList.SuspendLayout();
            this.pnlCategoryModification.SuspendLayout();
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
            this.btnAdd.Location = new System.Drawing.Point(134, 156);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNameAdd
            // 
            this.txtNameAdd.Location = new System.Drawing.Point(8, 120);
            this.txtNameAdd.Name = "txtNameAdd";
            this.txtNameAdd.Size = new System.Drawing.Size(201, 20);
            this.txtNameAdd.TabIndex = 0;
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
            // pnlCategoryList
            // 
            this.pnlCategoryList.Controls.Add(this.lblMessage);
            this.pnlCategoryList.Controls.Add(this.btnActivateModification);
            this.pnlCategoryList.Controls.Add(this.lstCategories);
            this.pnlCategoryList.Controls.Add(this.lblList);
            this.pnlCategoryList.Location = new System.Drawing.Point(318, 3);
            this.pnlCategoryList.Name = "pnlCategoryList";
            this.pnlCategoryList.Size = new System.Drawing.Size(459, 392);
            this.pnlCategoryList.TabIndex = 2;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(8, 373);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 7;
            // 
            // btnActivateModification
            // 
            this.btnActivateModification.Location = new System.Drawing.Point(381, 278);
            this.btnActivateModification.Name = "btnActivateModification";
            this.btnActivateModification.Size = new System.Drawing.Size(75, 23);
            this.btnActivateModification.TabIndex = 5;
            this.btnActivateModification.Text = "Modificar";
            this.btnActivateModification.UseVisualStyleBackColor = true;
            this.btnActivateModification.Click += new System.EventHandler(this.btnActivateModification_Click);
            // 
            // lstCategories
            // 
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.Location = new System.Drawing.Point(3, 73);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(453, 199);
            this.lstCategories.TabIndex = 4;
            this.lstCategories.SelectedIndexChanged += new System.EventHandler(this.lstCategories_SelectedIndexChanged);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Enabled = false;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblList.Location = new System.Drawing.Point(3, 18);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(197, 25);
            this.lblList.TabIndex = 4;
            this.lblList.Text = "Listado de categorias";
            // 
            // pnlCategoryModification
            // 
            this.pnlCategoryModification.Controls.Add(this.btnModify);
            this.pnlCategoryModification.Controls.Add(this.txtNameModify);
            this.pnlCategoryModification.Controls.Add(this.lblNameModifyPassword);
            this.pnlCategoryModification.Controls.Add(this.lblModifyCategory);
            this.pnlCategoryModification.Location = new System.Drawing.Point(4, 201);
            this.pnlCategoryModification.Name = "pnlCategoryModification";
            this.pnlCategoryModification.Size = new System.Drawing.Size(311, 193);
            this.pnlCategoryModification.TabIndex = 3;
            this.pnlCategoryModification.Visible = false;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(133, 115);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtNameModify
            // 
            this.txtNameModify.Location = new System.Drawing.Point(7, 77);
            this.txtNameModify.Name = "txtNameModify";
            this.txtNameModify.Size = new System.Drawing.Size(201, 20);
            this.txtNameModify.TabIndex = 2;
            // 
            // lblNameModifyPassword
            // 
            this.lblNameModifyPassword.AutoSize = true;
            this.lblNameModifyPassword.Location = new System.Drawing.Point(6, 60);
            this.lblNameModifyPassword.Name = "lblNameModifyPassword";
            this.lblNameModifyPassword.Size = new System.Drawing.Size(44, 13);
            this.lblNameModifyPassword.TabIndex = 5;
            this.lblNameModifyPassword.Text = "Nombre";
            // 
            // lblModifyCategory
            // 
            this.lblModifyCategory.AutoSize = true;
            this.lblModifyCategory.Enabled = false;
            this.lblModifyCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblModifyCategory.Location = new System.Drawing.Point(6, 10);
            this.lblModifyCategory.Name = "lblModifyCategory";
            this.lblModifyCategory.Size = new System.Drawing.Size(134, 18);
            this.lblModifyCategory.TabIndex = 5;
            this.lblModifyCategory.Text = "Modificar categoria";
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCategoryModification);
            this.Controls.Add(this.pnlCategoryList);
            this.Controls.Add(this.pnlCategoryInsertion);
            this.Name = "Categories";
            this.Size = new System.Drawing.Size(780, 399);
            this.pnlCategoryInsertion.ResumeLayout(false);
            this.pnlCategoryInsertion.PerformLayout();
            this.pnlCategoryList.ResumeLayout(false);
            this.pnlCategoryList.PerformLayout();
            this.pnlCategoryModification.ResumeLayout(false);
            this.pnlCategoryModification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCategoryInsertion;
        private System.Windows.Forms.Label lblCreateCategory;
        private System.Windows.Forms.Label lblNameAddPassword;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNameAdd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlCategoryList;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnActivateModification;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Panel pnlCategoryModification;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox txtNameModify;
        private System.Windows.Forms.Label lblNameModifyPassword;
        private System.Windows.Forms.Label lblModifyCategory;
    }
}
