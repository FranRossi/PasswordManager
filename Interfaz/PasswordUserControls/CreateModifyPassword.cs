using BusinessLogic;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Utilities;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class CreateModifyPassword : Form
    {
        private PasswordManager _myPasswordManager;
        private Password _myPasswordToModify;
        private Password _myNewPassword;

        public CreateModifyPassword(PasswordManager passwordManager)
        {
            InitializeComponent();
            _myPasswordManager = passwordManager;
            LoadComboBoxCategory();
            ShowHidePassword(false);
        }

        public CreateModifyPassword(PasswordManager passwordManager, Password password)
        {
            InitializeComponent();
            _myPasswordManager = passwordManager;
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
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cbCategory.SelectedItem != null)
            {
                try
                {
                    VerifyPassword();

                    if(lblMessage.Text == "")
                        ApplySuggestions();

                }
                catch (ValidationException exception)
                {
                    lblMessage.Text = exception.Message;
                }
            }
            else
                lblMessage.Text = "Debe seleccionar una categoría";
        }

        private void VerifyPassword()
        {
            if (UserIsCreatingANewPassword())
                VerifiesNewPassword();
            else
                VerifiesModifyPassword();
        }

        private bool UserIsCreatingANewPassword()
        {
            if (_myPasswordToModify == null)
                return true;

            return false;
        }

        private void ApplySuggestions()
        {
            if (UserIsCreatingANewPassword())
            {
                SuggestionsForPassword(_myNewPassword);
            }
            else
                SuggestionsForPassword(_myPasswordToModify);
        }

        private void VerifiesModifyPassword()
        {
            ModifyPasswordObjectFormFields();
            _myPasswordManager.VerifiesPassword(_myPasswordToModify);
        }

        private void VerifiesNewPassword()
        {
            Password newPassword = CreatePasswordObjectFormFields();
            _myNewPassword = newPassword;
            _myPasswordManager.VerifiesPassword(_myNewPassword);
        }

        private void SuggestionsForPassword(Password password)
        {
            bool userDontWantToChangePassword = true;
            //HistoricDataBreachSuggestion();
            //userDontWantToChangePassword = DuplicatePasswordSuggestion(password);
            userDontWantToChangePassword = SecurePasswordSuggestion(password);

            if (userDontWantToChangePassword) { 
                UpdateDataBasePassword(password); 
                CloseForm();
            }
        }

        private bool ManagePopUpSuggestions(string message)
        {
            DialogResult duplicateSuggestion;
            duplicateSuggestion = MessageBox.Show("Esta pass ya se encuentre en el sistema, ¿le gustaría cambiarla?",
                "Pass Duplicate", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (duplicateSuggestion == DialogResult.Yes)
                 return true;

            return false;
        }

        private bool SecurePasswordSuggestion(Password password)
        {
            bool userDontWantToChangePassword = true;
            if (_myPasswordManager.PasswordIsNotGreenSecure(password))
            {
                string message = "Esta pass no se encuentra en el rango de seguridad verde claro" +
                    " o verde oscuro, ¿le gustaría cambiarla?";
                userDontWantToChangePassword = !ManagePopUpSuggestions(message);
            }

            return userDontWantToChangePassword;
        }


        private void UpdateDataBasePassword(Password password)
        {
            if (UserIsCreatingANewPassword())
                _myPasswordManager.CreatePassword(password);
            else
                _myPasswordManager.ModifyPasswordOnCurrentUser(password);
        }

        private bool DuplicatePasswordSuggestion(Password password)
        {
            bool userDontWantToChangePassword = true;
            if (_myPasswordManager.PasswordTextIsDuplicate(password))
            {
                DialogResult duplicateSuggestion;
                duplicateSuggestion = MessageBox.Show("Esta pass ya se encuentre en el sistema, ¿le gustaría cambiarla?", 
                    "Pass Duplicate", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (duplicateSuggestion == DialogResult.Yes)
                     userDontWantToChangePassword = false;
            }
            return userDontWantToChangePassword;
        }




        private Password CreatePasswordObjectFormFields()
        {
            Password newPassword = new Password
            {
                User = _myPasswordManager.CurrentUser,
                Category = (Category)cbCategory.SelectedItem,
                Site = txtSite.Text,
                Username = txtUserName.Text,
                Pass = txtPassword.Text,
                Notes = txtNotes.Text,
            };

            return newPassword;
        }

        private void ModifyPasswordObjectFormFields()
        {
            _myPasswordToModify.User = _myPasswordManager.CurrentUser;
            _myPasswordToModify.Category = (Category)cbCategory.SelectedItem;
            _myPasswordToModify.Site = txtSite.Text;
            _myPasswordToModify.Username = txtUserName.Text;
            _myPasswordToModify.Pass = txtPassword.Text;
            _myPasswordToModify.Notes = txtNotes.Text;
        }

        private void LoadComboBoxCategory()
        {
            cbCategory.DataSource = _myPasswordManager.GetCategoriesFromCurrentUser();
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
    }
}
