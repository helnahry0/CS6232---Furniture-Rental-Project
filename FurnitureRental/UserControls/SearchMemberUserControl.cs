using FurnitureRental.Controller;
using FurnitureRental.Model;
using FurnitureRental.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FurnitureRental.UserControls
{
    public partial class SearchMemberUserControl : UserControl
    {
        private readonly MemberController _memberController;

        public SearchMemberUserControl()
        {
            InitializeComponent();
            _memberController = new MemberController();
        }

        private void SearchMemberUserControl_Load(object sender, EventArgs e)
        {
            radMemberId.Checked = true; 
            UpdateSearchMode();
            ConfigureMemberGrid();
        }

        private void UpdateSearchMode()
        {
            txtMemberId.Enabled = radMemberId.Checked;
            txtPhoneNumber.Enabled = radPhone.Checked;
            txtFirstName.Enabled = radFullName.Checked;
            txtLastName.Enabled = radFullName.Checked;

            if (!txtMemberId.Enabled) txtMemberId.Clear();
            if (!txtPhoneNumber.Enabled) txtPhoneNumber.Clear();
            if (!txtFirstName.Enabled) txtFirstName.Clear();
            if (!txtLastName.Enabled) txtLastName.Clear();

            lblError.Text = string.Empty;
        }

        private void radMemberId_CheckedChanged(object sender, EventArgs e) => UpdateSearchMode();
        private void radPhone_CheckedChanged(object sender, EventArgs e) => UpdateSearchMode();
        private void radFullName_CheckedChanged(object sender, EventArgs e) => UpdateSearchMode();

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
                HeaderText = "Phone",
                DataPropertyName = "Phone"
            });

            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.MultiSelect = false;
            dgvMembers.ReadOnly = true;
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
            dgvMembers.DataSource = null;

            if (radMemberId.Checked)
            {
                if (_memberController.TrySearchByMemberId(txtMemberId.Text.Trim(), out Member? member, out string errorMessage))
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
                if (_memberController.TrySearchByPhone(txtPhoneNumber.Text.Trim(), out Member? member, out string errorMessage))
                {
                    dgvMembers.DataSource = new List<Member> { member! };
                }
                else
                {
                    lblError.Text = errorMessage;
                }
            }
            else if (radFullName.Checked)
            {
                if (_memberController.TrySearchByFullName(txtFirstName.Text.Trim(),
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMemberId.Clear();
            txtPhoneNumber.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            lblError.Text = string.Empty;
            dgvMembers.DataSource = null;
        }

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
    }
}