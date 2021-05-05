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
            pruebasParaBorrar();
            LoadTblCreditCard();
        }

        private void LoadTblCreditCard()
        {
            List<CreditCard> creditCards = _myPasswordManager.GetCreditCards();
            tblCreditCards.DataSource = null;
            tblCreditCards.Rows.Clear();
            tblCreditCards.DataSource = creditCards;
            FormatCreditCardListOnTable();
        }

        private void pruebasParaBorrar()
        {
            Category _category = new Category()
            {
                Name = "Personal"
            };
            Category _category2 = new Category()
            {
                Name = "Work"
            };
            _myPasswordManager.CurrentUser.Categories.Add(_category);
            _myPasswordManager.CurrentUser.Categories.Add(_category2);
            CreditCard _card = new CreditCard
            {
                User = _myPasswordManager.CurrentUser,
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
                User = _myPasswordManager.CurrentUser,
                Category = _category2,
                Name = "MasterCard Black",
                Type = "Master",
                Number = "2354678713001111",
                SecureCode = "111",
                ExpirationDate = "02/30",
                Notes = "Límite 400 shenn UYU"
            };

            _myPasswordManager.CreateCreditCard(_card);
            _myPasswordManager.CreateCreditCard(_card2);
        }

        private void FormatCreditCardListOnTable()
        {
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
                    case "SecretNumber":
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
            Form createCreditCard = new CreateCreditCard(_myPasswordManager);
            createCreditCard.FormClosing += new FormClosingEventHandler(RefreshForm);
            createCreditCard.ShowDialog();
        }

        private void RefreshForm(object sender, FormClosingEventArgs e)
        {
            LoadTblCreditCard();
        }

        private void btnDeleteCreditCard_Click(object sender, EventArgs e)
        {
            CreditCard creditCardRow = (CreditCard)tblCreditCards.CurrentRow.DataBoundItem;
            _myPasswordManager.DeleteCreditCard(creditCardRow);
            LoadTblCreditCard();
        }

    }
}
