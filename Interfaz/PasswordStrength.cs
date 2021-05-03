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
    public partial class PasswordStrength : UserControl
    {
        private PasswordManager _passwordManager;
        public PasswordStrength(PasswordManager passwordManager)
        {
            this._passwordManager = passwordManager;
            InitializeComponent();

            /*            tbgroup.width = tbgroup.parent.width;
                        tbgroup.height = 300;
                        tbgroup.location = new point(0, tbgroup.location.y);
                        tbgroup.anchor = anchorstyles.left | anchorstyles.right;*/
        }


        private void tbGroup_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
