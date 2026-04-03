using FurnitureRental.Controller;
using FurnitureRental.Model;
using System.Text.RegularExpressions;

namespace FurnitureRental.UserControls
{
    public partial class CreateMemberUserControl : UserControl
    {
        private readonly MemberController _memberController = new MemberController();

        private Label _firstNameError = new Label();
        private Label _lastNameError = new Label();
        private Label _sexError = new Label();
        private Label _phoneError = new Label();
        private Label _address1Error = new Label();
        private Label _cityError = new Label();
        private Label _stateError = new Label();
        private Label _zipError = new Label();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMemberUserControl"/> class.
        /// </summary>
        public CreateMemberUserControl()
        {
            InitializeComponent();
            SetupSexComboBox();
            SetupErrorLabels();
            WireUpEvents();
            SetupStateComboBox();
        }

        /// <summary>
        /// Setups the sex ComboBox.
        /// </summary>
        private void SetupSexComboBox()
        {
            SexComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SexComboBox.Items.Clear();
            SexComboBox.Items.Add("");
            SexComboBox.Items.Add("Male");
            SexComboBox.Items.Add("Female");
            SexComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Setups the State ComboBox.
        /// </summary>
        private void SetupStateComboBox()
        {
            StateComboBox.Items.AddRange(new[]
            {
                "  ","AL","AK","AZ","AR","CA","CO","CT","DE","FL","GA",
                "HI","ID","IL","IN","IA","KS","KY","LA","ME","MD",
                "MA","MI","MN","MS","MO","MT","NE","NV","NH","NJ",
                "NM","NY","NC","ND","OH","OK","OR","PA","RI","SC",
                "SD","TN","TX","UT","VT","VA","WA","WV","WI","WY"
            });
        }

        /// <summary>
        /// Setups the error labels.
        /// </summary>
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
                (_stateError,     StateComboBox),
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

        /// <summary>
        /// Wires up events.
        /// </summary>
        private void WireUpEvents()
        {
            CreateButton.Click += CreateButton_Click;
            ClearButton.Click += ClearButton_Click;

            FirstNameTextBox.KeyPress += LettersOnly_KeyPress;
            LastNameTextBox.KeyPress += LettersOnly_KeyPress;
            CityTextBox.KeyPress += LettersOnly_KeyPress;

            PhoneNumberMaskedTextBox.KeyPress += PhoneNumbersOnly_KeyPress;
            ZipTextBox.KeyPress += NumbersOnly_KeyPress;
            ZipTextBox.MaxLength = 5;
        }

        /// <summary>
        /// Handles the KeyPress event of the LettersOnly control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void LettersOnly_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // lets letters, spaces, hyphens and backspace be pressed
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the NumbersOnly control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void NumbersOnly_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // lets only digits and backspace only
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the PhoneNumbersOnly control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void PhoneNumbersOnly_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // lets only characters found in phone numbers be pressed
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ' && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '(' && e.KeyChar != ')')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the Click event of the CreateButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CreateButton_Click(object? sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            try
            {
                string digitsOnlyPhone = Regex.Replace(PhoneNumberMaskedTextBox.Text, @"\D", "");

                Member newMember = new Member
                {
                    FirstName = FirstNameTextBox.Text.Trim(),
                    LastName = LastNameTextBox.Text.Trim(),
                    Sex = SexComboBox.SelectedItem!.ToString()!,
                    Dob = DobDateTimePicker.Value.Date,
                    Phone = digitsOnlyPhone,
                    Address1 = Address1TextBox.Text.Trim(),
                    Address2 = string.IsNullOrWhiteSpace(Address2TextBox.Text)
                        ? string.Empty
                        : Address2TextBox.Text.Trim(),
                    City = CityTextBox.Text.Trim(),
                    State = StateComboBox.SelectedItem!.ToString()!,
                    Zip = ZipTextBox.Text.Trim()
                };

                if (_memberController.TryAddMember(newMember, out string errorMessage))
                {
                    MessageBox.Show(
                        $"Member {newMember.FirstName} {newMember.LastName} has been successfully registered.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    ClearAllFields();
                }
                else
                {
                    MessageBox.Show(
                        errorMessage,
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
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

        /// <summary>
        /// Handles the Click event of the ClearButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ClearButton_Click(object? sender, EventArgs e)
        {
            ClearAllFields();
        }

        /// <summary>
        /// Clears all fields.
        /// </summary>
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
            StateComboBox.SelectedIndex = 0;
            ZipTextBox.Clear();

            HideAllErrors();
        }

        /// <summary>
        /// Validates the fields.
        /// </summary>
        /// <returns></returns>
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

            if (StateComboBox.SelectedIndex == 0 || StateComboBox.SelectedItem == null)
            {
                ShowError(_stateError, "Please select a State.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(ZipTextBox.Text))
            {
                ShowError(_zipError, "Zip code is required.");
                isValid = false;
            }
            else if (ZipTextBox.Text.Trim().Length > 5)
            {
                ShowError(_zipError, "Zip code mst be 5 digits.");
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Shows the error.
        /// </summary>
        /// <param name="errorLabel">The error label.</param>
        /// <param name="message">The message.</param>
        private void ShowError(Label errorLabel, string message)
        {
            errorLabel.Text = message;
            errorLabel.Visible = true;
        }

        /// <summary>
        /// Hides all errors.
        /// </summary>
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