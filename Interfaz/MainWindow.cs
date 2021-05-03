using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class MainWindow : Form
    {
        private PasswordManager _myPasswordManager;
        private UserControl _menu;
        public MainWindow(PasswordManager pPasswordManager)
        {
            InitializeComponent();
            _myPasswordManager = pPasswordManager;
        }

        private void tsmiPasswords_Click(object sender, EventArgs e)
        {

        }

        private void tsmiCreditCards_Click(object sender, EventArgs e)
        {
            UserControl creditCardList = new CreditCardList(_myPasswordManager);
            pnlMainScreen.Controls.Clear();
            pnlMainScreen.Controls.Add(creditCardList);
        }

        private void tsmiCategories_Click(object sender, EventArgs e)
        {

        }

        private void tsmiDataBreaches_Click(object sender, EventArgs e)
        {

        }

        private void tsmiPasswordStrength_Click(object sender, EventArgs e)
        {

        }
    }
}
