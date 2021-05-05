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
        private Category _selectedCategory;
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
                this.txtNameAdd.Text = "";
            }
            catch (ValidationException exception)
            {
                this.lblMessage.Text = exception.Message;
            }
        }

        private void btnActivateModification_Click(object sender, EventArgs e)
        {
            if (this._selectedCategory != null)
            {
                this.pnlCategoryModification.Visible = true;
                this.lblMessage.Text = "";
                this.btnActivateModification.Visible = false;
            }
            else
            {
                this.lblMessage.Text = "Debe selecionar una categoria para modificar.";
            }
        }

        private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _selectedCategory = (Category)lstCategories.SelectedItem;
                if (this._selectedCategory != null)
                    this.txtNameModify.Text = _selectedCategory.Name;
            }
            catch (FormatException exception)
            {
                this.lblMessage.Text = "Error al seleccionar la categoria.";
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
                        Name = this.txtNameModify.Text
                    };
                    _myPasswordManager.ModifyCategoryOnCurrentUser(this._selectedCategory, modifiedCategory);
                    this.LoadCategoryList();
                    this.lblMessage.Text = "Categoria modificada correctamente";
                    this.txtNameModify.Text = "";
                }
                catch (ValidationException exception)
                {
                    this.lblMessage.Text = exception.Message;
                }
            }
            else
            {
                this.lblMessage.Text = "Debe selecionar una categoria para modificar.";
            }
        }
    }
}
