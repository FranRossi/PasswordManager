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
    public partial class MainScreen : UserControl
    {
        private PasswordManager _myPasswordManager;
        public MainScreen(PasswordManager passwordManager)
        {
            InitializeComponent();
            _myPasswordManager = passwordManager;
        }
    }
}
