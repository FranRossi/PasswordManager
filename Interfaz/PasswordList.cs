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
    public partial class PasswordList : UserControl
    {
        private PasswordManager _myPasswordManager;
        public PasswordList()
        {
            InitializeComponent();
        }

        private void LoadTblCreditCard()
        {
            List<Password> passwords = _myPasswordManager.GetPasswords();
            tblPassword.DataSource = null;
            tblPassword.Rows.Clear();
            tblPassword.DataSource = passwords;
            //FormatCreditCardListOnTable();
        }

    }
}
