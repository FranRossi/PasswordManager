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
    public partial class CreditCardList : UserControl
    {
        private PasswordManager _myPasswordManager;
        public CreditCardList(PasswordManager pPasswordManager)
        {
            InitializeComponent();
            _myPasswordManager = pPasswordManager;
            LoadCreditCardList();
        }

        private void LoadCreditCardList()
        {
            var result = _myPasswordManager.GetCreditCards().Select(r => new
            {
                categoryCard = r.Category,
                nameCard = r.Name,
                typeCard = r.Type,
                creditCardNumber = r.Number,
                expirationDateCard = r.ExpirationDate,
            }).ToList();

            tblCreditCards.DataSource = result;

        }
    }
}
