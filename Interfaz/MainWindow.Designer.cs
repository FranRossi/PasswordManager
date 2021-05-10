
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
            this.tsmiSharedWithMe = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlMainScreen.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainScreen
            // 
            this.pnlMainScreen.Controls.Add(this.lblWelcome);
            this.pnlMainScreen.Controls.Add(this.lblMessage);
            this.pnlMainScreen.Location = new System.Drawing.Point(9, 40);
            this.pnlMainScreen.Name = "pnlMainScreen";
            this.pnlMainScreen.Size = new System.Drawing.Size(1170, 614);
            this.pnlMainScreen.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1166, 35);
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
            this.tsmiPasswordStrength,
            this.tsmiSharedWithMe});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tsmiPasswords
            // 
            this.tsmiPasswords.Name = "tsmiPasswords";
            this.tsmiPasswords.Size = new System.Drawing.Size(391, 34);
            this.tsmiPasswords.Text = "Contraseñas";
            this.tsmiPasswords.Click += new System.EventHandler(this.tsmiPasswords_Click);
            // 
            // tsmiCreditCards
            // 
            this.tsmiCreditCards.Name = "tsmiCreditCards";
            this.tsmiCreditCards.Size = new System.Drawing.Size(391, 34);
            this.tsmiCreditCards.Text = "Tarjetas";
            this.tsmiCreditCards.Click += new System.EventHandler(this.tsmiCreditCards_Click);
            // 
            // tsmiCategories
            // 
            this.tsmiCategories.Name = "tsmiCategories";
            this.tsmiCategories.Size = new System.Drawing.Size(391, 34);
            this.tsmiCategories.Text = "Categorias";
            this.tsmiCategories.Click += new System.EventHandler(this.tsmiCategories_Click);
            // 
            // tsmiDataBreaches
            // 
            this.tsmiDataBreaches.Name = "tsmiDataBreaches";
            this.tsmiDataBreaches.Size = new System.Drawing.Size(391, 34);
            this.tsmiDataBreaches.Text = "Data Breach";
            this.tsmiDataBreaches.Click += new System.EventHandler(this.tsmiDataBreaches_Click);
            // 
            // tsmiPasswordStrength
            // 
            this.tsmiPasswordStrength.Name = "tsmiPasswordStrength";
            this.tsmiPasswordStrength.Size = new System.Drawing.Size(391, 34);
            this.tsmiPasswordStrength.Text = "Fortaleza de Contraseñas";
            this.tsmiPasswordStrength.Click += new System.EventHandler(this.tsmiPasswordStrength_Click);
            // 
            // tsmiSharedWithMe
            // 
            this.tsmiSharedWithMe.Name = "tsmiSharedWithMe";
            this.tsmiSharedWithMe.Size = new System.Drawing.Size(391, 34);
            this.tsmiSharedWithMe.Text = "Contraseñas compartidas conmigo";
            this.tsmiSharedWithMe.Click += new System.EventHandler(this.tsmiSharedWithMe_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(948, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(9, 9);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.menuStrip1);
            this.pnlMenu.Location = new System.Drawing.Point(16, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1166, 40);
            this.pnlMenu.TabIndex = 5;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(347, 100);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(490, 217);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Bienvenidos ";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(306, 393);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(545, 29);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Seleccione la opción que desea utilizar del menú.";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 671);
            this.Controls.Add(this.pnlMainScreen);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlMenu);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "PasswordManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.pnlMainScreen.ResumeLayout(false);
            this.pnlMainScreen.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiSharedWithMe;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblMessage;
    }
}