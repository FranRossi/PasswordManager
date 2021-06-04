using BusinessLogic;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Categories : UserControl
    {
        private PasswordManager _myPasswordManager;
        private Category _selectedCategory;
        public Categories(PasswordManager pPasswordManager)
        {
            InitializeComponent();
            _myPasswordManager = pPasswordManager;
            LoadCategoryList();
        }

        private void LoadCategoryList()
        {
            lstCategories.DataSource = null;
            lstCategories.DataSource = _myPasswordManager.GetCategoriesFromCurrentUser();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string categoryName = this.txtNameAdd.Text;
                _myPasswordManager.CreateCategoryOnCurrentUser(categoryName);
                LoadCategoryList();
                lblMessage.Text = "Categoria agregada correctamente";
                txtNameAdd.Text = "";
            }
            catch (ValidationException exception)
            {
                lblMessage.Text = exception.Message;
            }
        }

        private void btnActivateModification_Click(object sender, EventArgs e)
        {
            if (_selectedCategory != null)
            {
                pnlCategoryModification.Visible = true;
                lblMessage.Text = "";
                btnActivateModification.Visible = false;
            }
            else
            {
                lblMessage.Text = "Debe selecionar una categoria para modificar.";
            }
        }

        private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _selectedCategory = (Category)lstCategories.SelectedItem;
                if (_selectedCategory != null)
                    txtNameModify.Text = _selectedCategory.Name;
            }
            catch (InvalidCastException exception)
            {
                lblMessage.Text = "Error al seleccionar la categoria.";
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (_selectedCategory != null)
            {
                try
                {
                    Category modifiedCategory = new Category
                    {
                        Name = txtNameModify.Text
                    };
                    _myPasswordManager.ModifyCategoryOnCurrentUser(_selectedCategory, modifiedCategory);
                    LoadCategoryList();
                    lblMessage.Text = "Categoria modificada correctamente";
                    txtNameModify.Text = "";
                }
                catch (ValidationException exception)
                {
                    lblMessage.Text = exception.Message;
                }
            }
            else
            {
                lblMessage.Text = "Debe selecionar una categoria para modificar.";
            }
        }
    }
}
