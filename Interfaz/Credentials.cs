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

namespace Interfaz
{
    public partial class MainScreen : Form
    {
        private PasswordManager _myPasswordManager;
        public MainScreen()
        {
            InitializeComponent();
            _myPasswordManager = new PasswordManager();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserControl loginUser = new UserLogin(_myPasswordManager);
            pnlMainScreen.Controls.Add(loginUser);
            btnLogin.Hide();
        }
    }
}
