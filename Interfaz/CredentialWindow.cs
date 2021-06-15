using System.Windows.Forms;

namespace Presentation
{
    public partial class CredentialWindow : Form
    {
        private UserControl _credentials;

        public CredentialWindow()
        {
            LoadWindow();
        }

        private void LoadWindow()
        {
            InitializeComponent();
            _credentials = new Credentials();
            pnlCredentials.Controls.Add(_credentials);
        }
    }
}
