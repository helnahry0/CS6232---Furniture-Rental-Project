using FurnitureRental.Controller;
using FurnitureRental.Model;

/// <summary>
///  View for the Edit Member form, allowing users to update member information. 
///  It loads the member data on form load and provides validation before saving changes.
/// </summary>
namespace FurnitureRental.View
{
    /// <summary>
    /// Edit Member form that allows users to update member information. 
    /// It loads the member data on form load and provides validation before saving changes.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class EditMemberForm : Form
    {
        private readonly int _memberId;
        private readonly MemberController _memberController = new MemberController();
        private Label _firstNameError = new Label();
        private Label _lastNameError = new Label();
        private Label _genderError = new Label();
        private Label _phoneError = new Label();
        private Label _stateError = new Label();
        private Label _zipError = new Label();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditMemberForm"/> class.
        /// </summary>
        /// <param name="memberId">The member identifier.</param>
        public EditMemberForm(int memberId)
        {
            InitializeComponent();
            _memberId = memberId;

            this.Load += EditMemberForm_Load;
        }

        private void EditMemberForm_Load(object? sender, EventArgs e)
        {
            LoadStates();
            SetupErrorLabels();

            Member? member = _memberController.GetMemberById(_memberId);

            if (member == null)
            {
                MessageBox.Show(
                    "Unable to load member data. Please try again.",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                txtMemberId.Text = member.MemberId.ToString();
                txtFirstName.Text = member.FirstName;
                txtLastName.Text = member.LastName;
                cboGender.SelectedItem = member.Sex;
                dtpDOB.Value = member.Dob;
                txtPhone.Text = member.Phone;
                txtAddress1.Text = member.Address1;
                txtAddress2.Text = member.Address2;
                txtCity.Text = member.City;
                cboState.SelectedItem = member.State;
                txtZip.Text = member.Zip;
            }
        }

        private void LoadStates()
        {
            cboState.Items.AddRange(new[]
            {
                "AL","AK","AZ","AR","CA","CO","CT","DE","FL","GA",
                "HI","ID","IL","IN","IA","KS","KY","LA","ME","MD",
                "MA","MI","MN","MS","MO","MT","NE","NV","NH","NJ",
                "NM","NY","NC","ND","OH","OK","OR","PA","RI","SC",
                "SD","TN","TX","UT","VT","VA","WA","WV","WI","WY"
            });
        }


        /// <summary>
        /// Sets up inline error labels positioned to the right of their associated input controls.
        /// </summary>
        private void SetupErrorLabels()
        {
            var errorSetup = new (Label errorLabel, Control inputControl)[]
            {
                (_firstNameError, txtFirstName),
                (_lastNameError,  txtLastName),
                (_genderError,    cboGender),
                (_phoneError,     txtPhone),
                (_stateError,     cboState),
                (_zipError,       txtZip),
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
        /// Shows an error label with the given message.
        /// </summary>
        private void ShowError(Label errorLabel, string message)
        {
            errorLabel.Text = message;
            errorLabel.Visible = true;
        }

        /// <summary>
        /// Hides all inline validation error labels.
        /// </summary>
        private void HideAllErrors()
        {
            _firstNameError.Visible = false;
            _lastNameError.Visible = false;
            _genderError.Visible = false;
            _phoneError.Visible = false;
            _stateError.Visible = false;
            _zipError.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            Member member = new Member
            {
                MemberId = _memberId,
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Sex = cboGender?.SelectedItem?.ToString()!,
                Dob = dtpDOB.Value.Date,
                Phone = txtPhone.Text.Trim(),
                Address1 = txtAddress1.Text.Trim(),
                Address2 = txtAddress2.Text.Trim(),
                City = txtCity.Text.Trim(),
                State = cboState?.SelectedItem?.ToString()!,
                Zip = txtZip.Text.Trim()
            };

            bool success = _memberController.UpdateMember(member);

            if (success)
            {
                MessageBox.Show("Member updated successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Update failed.");
            }
        }

        private bool ValidateForm()
        {
            HideAllErrors();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                ShowError(_firstNameError, "First name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                ShowError(_lastNameError, "Last name is required.");
                isValid = false;
            }

            if (cboGender.SelectedItem == null)
            {
                ShowError(_genderError, "Please select a gender.");
                isValid = false;
            }

            if (txtPhone.Text.Length != 10 || !txtPhone.Text.All(char.IsDigit))
            {
                ShowError(_phoneError, "Must be exactly 10 digits.");
                isValid = false;
            }

            if (cboState.SelectedItem == null)
            {
                ShowError(_stateError, "Please select a state.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtZip.Text))
            {
                ShowError(_zipError, "Zip code is required.");
                isValid = false;
            }

            return isValid;
        }

    }
}
