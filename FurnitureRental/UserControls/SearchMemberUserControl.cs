using FurnitureRental.Controller;
using FurnitureRental.Model;
using FurnitureRental.View;

/// <summary>
/// FurnitureRental.UserControls namespace contains user controls for the Furniture Rental application, including the SearchMemberUserControl which allows users to search for members by various criteria and view their rental and return history.
/// </summary>
namespace FurnitureRental.UserControls
{
    /// <summary>
    /// class SearchMemberUserControl is a user control that provides a form for searching members in the furniture rental application. It includes fields for member ID, phone number, and full name, and allows viewing rental and return history.
    /// </summary>
    public partial class SearchMemberUserControl : UserControl
    {
        private readonly MemberController _memberController;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMemberUserControl"/> class.
        /// </summary>
        public SearchMemberUserControl()
        {
            InitializeComponent();
            _memberController = new MemberController();

            radMemberId.Checked = true;
            UpdateSearchMode();
            ConfigureMemberGrid();
            btnEdit.Enabled = false;
            btnViewRentalHistory.Enabled = false;
            LoadAllMembers();
        }

        /// <summary>
        /// Updates the search mode.
        /// </summary>
        private void UpdateSearchMode()
        {
            txtMemberId.Enabled = radMemberId.Checked;
            txtPhoneNumber.Enabled = radPhone.Checked;
            txtFirstName.Enabled = radFullName.Checked;
            txtLastName.Enabled = radFullName.Checked;

            if (!txtMemberId.Enabled)
            {
                txtMemberId.Clear();
            }

            if (!txtPhoneNumber.Enabled)
            {
                txtPhoneNumber.Clear();
            }

            if (!txtFirstName.Enabled)
            {
                txtFirstName.Clear();
            }

            if (!txtLastName.Enabled)
            {
                txtLastName.Clear();
            }

            lblError.Text = string.Empty;
        }

        /// <summary>
        /// Handles the CheckedChanged event of the radMemberId control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void radMemberId_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSearchMode();
        }

        private void btnViewReturnHistory_Click(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow == null || dgvMembers.CurrentRow.DataBoundItem is not Member selectedMember)
            {
                lblError.Text = "Please select a member to view return history.";
                return;
            }
            lblError.Text = string.Empty;

            ReturnHistoryForm form = new ReturnHistoryForm(selectedMember);
            form.ShowDialog();
        }

        /// <summary>
        /// Handles the CheckedChanged event of the radPhone control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void radPhone_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSearchMode();
        }

        /// <summary>
        /// Handles the CheckedChanged event of the radFullName control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void radFullName_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSearchMode();
        }

        /// <summary>
        /// Configures the member grid.
        /// </summary>
        private void ConfigureMemberGrid()
        {
            dgvMembers.AutoGenerateColumns = false;
            dgvMembers.Columns.Clear();

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MemberId",
                HeaderText = "Member ID",
                DataPropertyName = "MemberId"
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FirstName",
                HeaderText = "First Name",
                DataPropertyName = "FirstName"
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LastName",
                HeaderText = "Last Name",
                DataPropertyName = "LastName"
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Phone",
                HeaderText = "Phone Number",
                DataPropertyName = "Phone"
            });

            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.MultiSelect = false;
            dgvMembers.ReadOnly = true;
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
        }

        /// <summary>
        /// Handles the Click event of the btnSearch control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
            dgvMembers.DataSource = null;

            if (radMemberId.Checked)
            {
                if (_memberController.TrySearchByMemberId(
                    txtMemberId.Text.Trim(),
                    out Member? member,
                    out string errorMessage))
                {
                    dgvMembers.DataSource = new List<Member> { member! };
                }
                else
                {
                    lblError.Text = errorMessage;
                }
            }
            else if (radPhone.Checked)
            {
                if (_memberController.TrySearchByPhone(
                    txtPhoneNumber.Text.Trim(),
                    out List<Member> members,
                    out string errorMessage))
                {
                    dgvMembers.DataSource = members;
                }
                else
                {
                    lblError.Text = errorMessage;
                }
            }
            else if (radFullName.Checked)
            {
                if (_memberController.TrySearchByFullName(
                    txtFirstName.Text.Trim(),
                    txtLastName.Text.Trim(),
                    out List<Member> members,
                    out string errorMessage))
                {
                    dgvMembers.DataSource = members;
                }
                else
                {
                    lblError.Text = errorMessage;
                }
            }

            btnEdit.Enabled = true;
            btnViewRentalHistory.Enabled = true;
        }

        /// <summary>
        /// Handles the Click event of the btnClear control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMemberId.Clear();
            txtPhoneNumber.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            lblError.Text = string.Empty;

            radMemberId.Checked = true;
            UpdateSearchMode();
            LoadAllMembers();
        }

        /// <summary>
        /// Handles the Click event of the btnEdit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow == null || dgvMembers.CurrentRow.DataBoundItem is not Member selectedMember)
            {
                lblError.Text = "Please select a member to edit.";
                return;
            }

            EditMemberForm form = new EditMemberForm(selectedMember.MemberId);
            form.ShowDialog();

            btnSearch.PerformClick();
        }

        /// <summary>
        /// Loads all members.
        /// </summary>
        public void LoadAllMembers()
        {
            dgvMembers.DataSource = null;
            dgvMembers.DataSource = _memberController.GetAllMembers();

            if (dgvMembers.Rows.Count > 0)
            {
                dgvMembers.ClearSelection();
                dgvMembers.Rows[0].Selected = true;
                dgvMembers.CurrentCell = dgvMembers.Rows[0].Cells[0];

                btnEdit.Enabled = true;
                btnViewRentalHistory.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnViewRentalHistory.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnViewRentalHistory control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnViewRentalHistory_Click(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow == null || dgvMembers.CurrentRow.DataBoundItem is not Member selectedMember)
            {
                lblError.Text = "Please select a member to view rental history.";
                return;
            }

            RentalHistoryForm form = new RentalHistoryForm(selectedMember);
            form.ShowDialog();
        }

        /// <summary>
        /// Enables or disables buttons based on selected member
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void dgvMembers_SelectionChanged(object sender, EventArgs e)
        {
            bool hasSelection = dgvMembers.CurrentRow != null &&
                                dgvMembers.CurrentRow.DataBoundItem is Member;

            btnEdit.Enabled = hasSelection;
            btnViewRentalHistory.Enabled = hasSelection;
            btnViewReturnHistory.Enabled = hasSelection;
        }
    }
}