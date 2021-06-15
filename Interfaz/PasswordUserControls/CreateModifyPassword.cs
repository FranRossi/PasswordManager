using BusinessInterfaces;
using FactoryBusiness;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Utilities;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class CreateModifyPassword : Form
    {

        private ISessionController _mySessionController;
        private IDataBreachController _myDatabreachController;
        private ICategoryController _myCategoryController;
        private IPasswordController _myPasswordController;
        private IPasswordColorReportController _myPasswordColorReportController;
        private Password _myPasswordToModify;
        private Password _myNewPassword;

        public CreateModifyPassword()
        {
            InitializeComponent();
            _mySessionController = FactoryBusinessInterfaces.GetInstanceSessionController();
            _myDatabreachController = FactoryBusinessInterfaces.CreateDataBreachController();
            _myCategoryController = FactoryBusinessInterfaces.CreateCategoryController();
            _myPasswordController = FactoryBusinessInterfaces.CreatePasswordController();
            _myPasswordColorReportController = FactoryBusinessInterfaces.CreatePasswordColorReportController();
            LoadComboBoxCategory();
            ShowHidePassword(false);
        }

        public CreateModifyPassword(Password password)
        {
            InitializeComponent();
            _mySessionController = FactoryBusinessInterfaces.GetInstanceSessionController();
            _myDatabreachController = FactoryBusinessInterfaces.CreateDataBreachController();
            _myCategoryController = FactoryBusinessInterfaces.CreateCategoryController();
            _myPasswordController = FactoryBusinessInterfaces.CreatePasswordController();
            _myPasswordColorReportController = FactoryBusinessInterfaces.CreatePasswordColorReportController();
            _myPasswordToModify = password;
            LoadComboBoxCategory();
            ShowHidePassword(false);
            LoadFromPassword();
        }

        private void LoadFromPassword()
        {
            txtSite.Text = _myPasswordToModify.Site;
            txtUserName.Text = _myPasswordToModify.Username;
            txtPassword.Text = _myPasswordToModify.Pass;
            txtNotes.Text = _myPasswordToModify.Notes;
            cbCategory.SelectedItem = _myPasswordToModify.Category;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cbCategory.SelectedItem != null)
            {
                try
                {
                    if (UserIsCreatingANewPassword())
                    {
                        CreatePasswordObjectFormFields();
                        VerifyNewPassword();
                    }
                    else
                    {
                        ModifyPasswordObjectFormFields();
                        VerifyModifiedPassword();
                    }


                    if (PasswordIsVerified())
                        SuggestionsBeforeUpdatingDataBase();

                }
                catch (ValidationException exception)
                {
                    lblMessage.Text = exception.Message;
                }
            }
            else
                lblMessage.Text = "Debe seleccionar una categoría";
        }


        private bool UserIsCreatingANewPassword()
        {
            if (_myPasswordToModify == null)
                return true;

            return false;
        }

        private void SuggestionsBeforeUpdatingDataBase()
        {
            if (UserIsCreatingANewPassword())
                SuggestionsForPassword(_myNewPassword);
            else
                SuggestionsForPassword(_myPasswordToModify);
        }

        private void VerifyModifiedPassword()
        {
            _myPasswordController.VerifyPassword(_myPasswordToModify);
        }

        private void VerifyNewPassword()
        {
            _myPasswordController.VerifyPassword(_myNewPassword);
        }

        private void SuggestionsForPassword(Password password)
        {
            string historicalSuggestion = HistoricDataBreachSuggestion(password);
            string duplicateSuggestion = DuplicatePasswordSuggestion(password);
            string secureSuggestion = SecurePasswordSuggestion(password);

            bool userConfirmesChanges =
                ManagePopUpSuggestions(historicalSuggestion, duplicateSuggestion, secureSuggestion);

            if (userConfirmesChanges)
            {
                UpdateDataBasePassword(password);
                CloseForm();
            }
        }

        private bool ManagePopUpSuggestions(string historic, string duplicate, string secure)
        {
            string messageToShow = mergeStrings(historic, duplicate, secure);
            DialogResult suggestionResponse;
            suggestionResponse = MessageBox.Show(messageToShow + Environment.NewLine + "¿Está seguro de querer continuar?",
                "Sugerencias contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (suggestionResponse == DialogResult.Yes)
                return true;

            return false;
        }

        private string mergeStrings(string historic, string duplicate, string secure)
        {
            string stringMerged = "";
            stringMerged += historic + duplicate + secure;
            return stringMerged;
        }

        private string HistoricDataBreachSuggestion(Password password)
        {
            string historicSuggestion = "";
            if (_myDatabreachController.VerifyPasswordHasBeenBreached(password))
                historicSuggestion = "- Esta contraseña se encuentra en un data breach" + Environment.NewLine;

            return historicSuggestion;
        }

        private string SecurePasswordSuggestion(Password password)
        {
            string secureSuggestion = "";
            if (_myPasswordColorReportController.PasswordIsNotGreenSecure(password))
                secureSuggestion = "- Esta contraseña no se encuentra en el rango de seguridad verde claro o verde oscuro" + Environment.NewLine;

            return secureSuggestion;
        }

        private string DuplicatePasswordSuggestion(Password password)
        {
            string duplicateSuggestion = "";
            if (_myPasswordController.PasswordTextIsDuplicate(password))
                duplicateSuggestion = "- Esta contraseña ya se encuentra en el sistema" + Environment.NewLine;

            return duplicateSuggestion;
        }


        private void UpdateDataBasePassword(Password password)
        {
            if (UserIsCreatingANewPassword())
                _myPasswordController.CreatePassword(password);
            else
                _myPasswordController.ModifyPasswordOnCurrentUser(password);
        }


        private void CreatePasswordObjectFormFields()
        {
            Password newPassword = new Password
            {
                User = _mySessionController.CurrentUser,
                Category = (Category)cbCategory.SelectedItem,
                Site = txtSite.Text,
                Username = txtUserName.Text,
                Pass = txtPassword.Text,
                Notes = txtNotes.Text,
            };

            _myNewPassword = newPassword;
        }

        private void ModifyPasswordObjectFormFields()
        {
            _myPasswordToModify.User = _mySessionController.CurrentUser;
            _myPasswordToModify.Category = (Category)cbCategory.SelectedItem;
            _myPasswordToModify.Site = txtSite.Text;
            _myPasswordToModify.Username = txtUserName.Text;
            _myPasswordToModify.Pass = txtPassword.Text;
            _myPasswordToModify.Notes = txtNotes.Text;
        }

        private void LoadComboBoxCategory()
        {
            cbCategory.DataSource = _myCategoryController.GetCategoriesFromCurrentUser();
        }

        private void CloseForm()
        {
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int passwordLength = decimal.ToInt32(nudLength.Value);
            bool hasUppercase = cbUppercase.Checked;
            bool hasLowercase = cbLowercase.Checked;
            bool hasDigit = cbDigit.Checked;
            bool hasSymbol = cbSymbol.Checked;
            try
            {
                PasswordGenerationOptions usedOptions = new PasswordGenerationOptions
                {
                    Length = passwordLength,
                    Uppercase = hasUppercase,
                    Lowercase = hasLowercase,
                    Digits = hasDigit,
                    SpecialDigits = hasSymbol
                };
                string newPassword = Password.GenerateRandomPassword(usedOptions);
                txtPassword.Text = Password.GenerateRandomPassword(usedOptions);
            }
            catch (ValidationException exception)
            {
                lblMessage.Text = exception.Message;
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool showPasswordChecked = cbShowPassword.Checked;
            ShowHidePassword(showPasswordChecked);
        }

        private void ShowHidePassword(bool showPassword)
        {
            if (showPassword)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }

        private bool PasswordIsVerified()
        {
            return lblMessage.Text == "";
        }
    }
}
