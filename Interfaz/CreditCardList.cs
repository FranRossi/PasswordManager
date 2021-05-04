﻿using Obligatorio1_DA1.Domain;
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

        }

        private void btnDeleteCreditCard_Click(object sender, EventArgs e)
        {
            CreditCard creditCardRow = (CreditCard)tblCreditCards.CurrentRow.DataBoundItem;
            _myPasswordManager.DeleteCreditCard(creditCardRow);
            LoadTblCreditCard();
        }

    }
}
