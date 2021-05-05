using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
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
    public partial class Categories : UserControl
    {
        private PasswordManager _myPasswordManager;
        public Categories(PasswordManager pPasswordManager)
        {
            InitializeComponent();
            _myPasswordManager = pPasswordManager;
            LoadCategoryList();
        }

        private void LoadCategoryList()
        {
            this.lstCategories.DataSource = null;
            this.lstCategories.DataSource = _myPasswordManager.GetCategoriesFromCurrentUser();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Category newCategory = new Category
                {
                    Name = this.txtNameAdd.Text
                };
                _myPasswordManager.CreateCategoryOnCurrentUser(newCategory);
                LoadCategoryList();
                this.lblMessage.Text = "Categoria agregada correctamente";
            }
            catch (ValidationException exception)
            {
                this.lblMessage.Text = exception.Message;
            }
        }
    }
}
