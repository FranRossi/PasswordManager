
namespace Presentation
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.pnlMainScreen = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPasswords = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreditCards = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDataBreaches = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPasswordStrength = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlMainScreen.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainScreen
            // 
            this.pnlMainScreen.Controls.Add(this.menuStrip1);
            this.pnlMainScreen.Location = new System.Drawing.Point(15, 14);
            this.pnlMainScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMainScreen.Name = "pnlMainScreen";
            this.pnlMainScreen.Size = new System.Drawing.Size(1040, 491);
            this.pnlMainScreen.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1040, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPasswords,
            this.tsmiCreditCards,
            this.tsmiCategories,
            this.tsmiDataBreaches,
            this.tsmiPasswordStrength});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tsmiPasswords
            // 
            this.tsmiPasswords.Name = "tsmiPasswords";
            this.tsmiPasswords.Size = new System.Drawing.Size(258, 26);
            this.tsmiPasswords.Text = "Contraseñas";
            this.tsmiPasswords.Click += new System.EventHandler(this.tsmiPasswords_Click);
            // 
            // tsmiCreditCards
            // 
            this.tsmiCreditCards.Name = "tsmiCreditCards";
            this.tsmiCreditCards.Size = new System.Drawing.Size(258, 26);
            this.tsmiCreditCards.Text = "Tarjetas";
            this.tsmiCreditCards.Click += new System.EventHandler(this.tsmiCreditCards_Click);
            // 
            // tsmiCategories
            // 
            this.tsmiCategories.Name = "tsmiCategories";
            this.tsmiCategories.Size = new System.Drawing.Size(258, 26);
            this.tsmiCategories.Text = "Categorias";
            this.tsmiCategories.Click += new System.EventHandler(this.tsmiCategories_Click);
            // 
            // tsmiDataBreaches
            // 
            this.tsmiDataBreaches.Name = "tsmiDataBreaches";
            this.tsmiDataBreaches.Size = new System.Drawing.Size(258, 26);
            this.tsmiDataBreaches.Text = "Data Breach";
            this.tsmiDataBreaches.Click += new System.EventHandler(this.tsmiDataBreaches_Click);
            // 
            // tsmiPasswordStrength
            // 
            this.tsmiPasswordStrength.Name = "tsmiPasswordStrength";
            this.tsmiPasswordStrength.Size = new System.Drawing.Size(258, 26);
            this.tsmiPasswordStrength.Text = "Fortaleza de Contraseñas";
            this.tsmiPasswordStrength.Click += new System.EventHandler(this.tsmiPasswordStrength_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(842, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1069, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 518);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlMainScreen);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "PasswordManager";
            this.pnlMainScreen.ResumeLayout(false);
            this.pnlMainScreen.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlMainScreen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiPasswords;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreditCards;
        private System.Windows.Forms.ToolStripMenuItem tsmiCategories;
        private System.Windows.Forms.ToolStripMenuItem tsmiDataBreaches;
        private System.Windows.Forms.ToolStripMenuItem tsmiPasswordStrength;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}