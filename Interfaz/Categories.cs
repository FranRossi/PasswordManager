using BusinessInterfaces;
using FactoryBusiness;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Categories : UserControl
    {
        private ICategoryController _myCategoryController;
        private Category _selectedCategory;
        public Categories()
        {
            InitializeComponent();
            _myCategoryController = FactoryBusinessInterfaces.CreateCategoryController();
            LoadCategoryList();
        }

        private void LoadCategoryList()
        {
            lstCategories.DataSource = null;
            lstCategories.DataSource = _myCategoryController.GetCategoriesFromCurrentUser();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string categoryName = this.txtNameAdd.Text;
                _myCategoryController.CreateCategoryOnCurrentUser(categoryName);
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
                    _selectedCategory.Name = txtNameModify.Text;
                    _myCategoryController.ModifyCategoryOnCurrentUser(_selectedCategory);
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
