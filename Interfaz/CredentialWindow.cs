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
    public partial class CredentialWindow : Form
    {
        private PasswordManager _myPasswordManager;
        private UserControl _credentials;

        public CredentialWindow()
        {
            InitializeComponent();
            _myPasswordManager = new PasswordManager();
            _credentials = new Credentials(_myPasswordManager);
            this.pnlCredentials.Controls.Add(_credentials);
        }
    }
}
