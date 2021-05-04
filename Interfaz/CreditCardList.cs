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
            FormatTblCreditCard();
        }

        private void FormatTblCreditCard()
        {
            User _user = new User()
            {
                Name = "Gonzalo",
                Pass = "HolaSoyGonzalo123"
            };
            Category _category = new Category()
            {
                Name = "Personal"
            };
            _user.Categories.Add(_category);
            CreditCard _card1 = new CreditCard
            {
                User = _user,
                Category = _category,
                Name = "Visa Gold",
                Type = "Visa",
                Number = "2354678713003498",
                SecureCode = "189",
                ExpirationDate = "10/21",
                Notes = "Límite 400k UYU"
            };

            CreditCard _card2 = new CreditCard
            {
                User = _user,
                Category = _category,
                Name = "Visa Gold",
                Type = "Visa",
                Number = "2354678713003450",
                SecureCode = "189",
                ExpirationDate = "07/24",
                Notes = "Límite 400k UYU"
            };

            _myPasswordManager.CreateCreditCard(_card1);
            _myPasswordManager.CreateCreditCard(_card2);
            List<CreditCard> creditCards = _myPasswordManager.GetCreditCards();
            tblCreditCards.DataSource = creditCards;
            foreach (DataGridViewColumn column in tblCreditCards.Columns)
            {
                switch (column.Name)
                {
                    case "Category":
                        column.HeaderText = "Categoria";
                        break;
                    case "Name":
                        column.HeaderText = "Nombre";
                        break;
                    case "Type":
                        column.HeaderText = "Tipo";
                        break;
                    case "Number":
                        column.HeaderText = "Numero";
                        break;
                    case "ExpirationDate":
                        column.HeaderText = "Vencimiento";
                        break;
                    default:
                        column.Visible = false;
                        break;
                }
            }
        }

        private void btnAddsCreditCard_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCreditCard_Click(object sender, EventArgs e)
        {
            var creditCardRow = tblCreditCards.CurrentRow.DataBoundItem;

        }

    }
}
