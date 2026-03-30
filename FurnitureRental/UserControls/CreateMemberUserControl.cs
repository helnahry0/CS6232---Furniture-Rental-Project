using FurnitureRental.DBAccess;
using FurnitureRental.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FurnitureRental.UserControls
{
    public partial class CreateMemberUserControl : UserControl
    {
        private readonly MemberDal _memberDal = new MemberDal();

        private Label _firstNameError = new Label();
        private Label _lastNameError = new Label();
        private Label _sexError = new Label();
        private Label _phoneError = new Label();
        private Label _address1Error = new Label();
        private Label _cityError = new Label();
        private Label _stateError = new Label();
        private Label _zipError = new Label();

        public CreateMemberUserControl()
        {
            InitializeComponent();
            SetupSexComboBox();
            SetupErrorLabels();
            WireUpEvents();
        }


        private void SetupSexComboBox()
        {
            SexComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SexComboBox.Items.Clear();
            SexComboBox.Items.Add("");
            SexComboBox.Items.Add("Male");
            SexComboBox.Items.Add("Female");
            SexComboBox.SelectedIndex = 0;
        }

        private void SetupErrorLabels()
        {
            var errorSetup = new (Label errorLabel, Control inputControl)[]
            {
                (_firstNameError, FirstNameTextBox),
                (_lastNameError,  LastNameTextBox),
                (_sexError,       SexComboBox),
                (_phoneError,     PhoneNumberMaskedTextBox),
                (_address1Error,  Address1TextBox),
                (_cityError,      CityTextBox),
                (_stateError,     StateTextBox),
                (_zipError,       ZipTextBox),
            };

            foreach (var (errorLabel, inputControl) in errorSetup)
            {
                errorLabel.ForeColor = Color.Red;
                errorLabel.AutoSize = true;
                errorLabel.Font = new Font("Segoe UI", 8F);
                errorLabel.Visible = false;
                errorLabel.Location = new Point(
                    inputControl.Right + 5,
                    inputControl.Top + 5
                );

                Controls.Add(errorLabel);
            }
        }

        private void WireUpEvents()
        {
            CreateButton.Click += CreateButton_Click;
            ClearButton.Click += ClearButton_Click;

            FirstNameTextBox.KeyPress += LettersOnly_KeyPress;
            LastNameTextBox.KeyPress += LettersOnly_KeyPress;
            CityTextBox.KeyPress += LettersOnly_KeyPress;

            PhoneNumberMaskedTextBox.KeyPress += PhoneNumbersOnly_KeyPress;
            ZipTextBox.KeyPress += NumbersOnly_KeyPress;

            StateTextBox.KeyPress += LettersOnly_KeyPress;
            StateTextBox.MaxLength = 2;
        }

        private void LettersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // lets letters, spaces, hyphens and backspace be pressed
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void NumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // lets only digits and backspace only
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void PhoneNumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // lets only characters found in phone numbers be pressed
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ' && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '(' && e.KeyChar != ')')
            {
                e.Handled = true;
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            try
            {
                Member newMember = new Member
                {
                    FirstName = FirstNameTextBox.Text.Trim(),
                    LastName = LastNameTextBox.Text.Trim(),
                    Sex = SexComboBox.SelectedItem!.ToString()!,
                    Dob = DobDateTimePicker.Value.Date,
                    Phone = PhoneNumberMaskedTextBox.Text.Trim(),
                    Address1 = Address1TextBox.Text.Trim(),
                    Address2 = string.IsNullOrWhiteSpace(Address2TextBox.Text) ? null : Address2TextBox.Text.Trim(),
                    City = CityTextBox.Text.Trim(),
                    State = StateTextBox.Text.Trim().ToUpper(),
                    Zip = ZipTextBox.Text.Trim()
                };

                _memberDal.AddMember(newMember);

                MessageBox.Show(
                    $"Member {newMember.FullName} has been successfully registered.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ClearAllFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while saving the member:\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void ClearAllFields()
        {
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            DobDateTimePicker.Value = DateTime.Today;
            SexComboBox.SelectedIndex = 0;     // back to blank
            PhoneNumberMaskedTextBox.Clear();
            Address1TextBox.Clear();
            Address2TextBox.Clear();
            CityTextBox.Clear();
            StateTextBox.Clear();
            ZipTextBox.Clear();

            HideAllErrors();
        }


        private bool ValidateFields()
        {
            HideAllErrors();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
            {
                ShowError(_firstNameError, "First name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                ShowError(_lastNameError, "Last name is required.");
                isValid = false;
            }

            if (SexComboBox.SelectedIndex == 0 || SexComboBox.SelectedItem == null)
            {
                ShowError(_sexError, "Please select a sex.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(PhoneNumberMaskedTextBox.Text))
            {
                ShowError(_phoneError, "Phone number is required.");
                isValid = false;
            }
            else if (PhoneNumberMaskedTextBox.Text.Trim().Length > 15)
            {
                ShowError(_phoneError, "Phone number is too long.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(Address1TextBox.Text))
            {
                ShowError(_address1Error, "Address is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(CityTextBox.Text))
            {
                ShowError(_cityError, "City is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(StateTextBox.Text))
            {
                ShowError(_stateError, "State is required.");
                isValid = false;
            }
            else if (StateTextBox.Text.Trim().Length != 2)
            {
                ShowError(_stateError, "Use 2-letter state code (e.g. GA).");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(ZipTextBox.Text))
            {
                ShowError(_zipError, "Zip code is required.");
                isValid = false;
            }
            else if (ZipTextBox.Text.Trim().Length > 10)
            {
                ShowError(_zipError, "Zip code is too long.");
                isValid = false;
            }

            return isValid;
        }

        private void ShowError(Label errorLabel, string message)
        {
            errorLabel.Text = message;
            errorLabel.Visible = true;
        }

        private void HideAllErrors()
        {
            _firstNameError.Visible = false;
            _lastNameError.Visible = false;
            _sexError.Visible = false;
            _phoneError.Visible = false;
            _address1Error.Visible = false;
            _cityError.Visible = false;
            _stateError.Visible = false;
            _zipError.Visible = false;
        }
    }
}