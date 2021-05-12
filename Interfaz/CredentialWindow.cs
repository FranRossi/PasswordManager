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
    public partial class CredentialWindow : Form
    {
        private PasswordManager _myPasswordManager;
        private UserControl _credentials;

        public CredentialWindow()
        {
            _myPasswordManager = new PasswordManager();
            LoadWindow();
        }

        private void LoadWindow()
        {
            InitializeComponent();
            _credentials = new Credentials(_myPasswordManager);
            pnlCredentials.Controls.Add(_credentials);
        }
    }
}
