namespace FurnitureRental.UserControls
{
    partial class SearchMemberUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            pnlSearchContainer = new Panel();
            pnlResults = new Panel();
            dgvMembers = new DataGridView();
            pnlSearchControls = new Panel();
            btnViewReturnHistory = new Button();
            btnViewRentalHistory = new Button();
            lblError = new Label();
            btnEdit = new Button();
            txtMemberId = new TextBox();
            btnClear = new Button();
            lblMemberId = new Label();
            btnSearch = new Button();
            txtPhoneNumber = new TextBox();
            lblSearchCriteria = new Label();
            txtLastName = new TextBox();
            lblPhone = new Label();
            txtFirstName = new TextBox();
            radFullName = new RadioButton();
            lblLastName = new Label();
            radMemberId = new RadioButton();
            lblFirstName = new Label();
            radPhone = new RadioButton();
            pnlSearchContainer.SuspendLayout();
            pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            pnlSearchControls.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSearchContainer
            // 
            pnlSearchContainer.Controls.Add(pnlResults);
            pnlSearchContainer.Controls.Add(pnlSearchControls);
            pnlSearchContainer.Dock = DockStyle.Fill;
            pnlSearchContainer.Location = new Point(0, 0);
            pnlSearchContainer.Margin = new Padding(3, 4, 3, 4);
            pnlSearchContainer.Name = "pnlSearchContainer";
            pnlSearchContainer.Padding = new Padding(11, 13, 11, 13);
            pnlSearchContainer.Size = new Size(808, 647);
            pnlSearchContainer.TabIndex = 0;
            // 
            // pnlResults
            // 
            pnlResults.Controls.Add(dgvMembers);
            pnlResults.Dock = DockStyle.Fill;
            pnlResults.Location = new Point(400, 13);
            pnlResults.Margin = new Padding(3, 4, 3, 4);
            pnlResults.Name = "pnlResults";
            pnlResults.Padding = new Padding(11, 13, 11, 13);
            pnlResults.Size = new Size(397, 621);
            pnlResults.TabIndex = 1;
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Dock = DockStyle.Fill;
            dgvMembers.Location = new Point(11, 13);
            dgvMembers.Margin = new Padding(3, 4, 3, 4);
            dgvMembers.MultiSelect = false;
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(375, 595);
            dgvMembers.TabIndex = 0;
            dgvMembers.SelectionChanged += dgvMembers_SelectionChanged;
            // 
            // pnlSearchControls
            // 
            pnlSearchControls.Controls.Add(btnViewReturnHistory);
            pnlSearchControls.Controls.Add(btnViewRentalHistory);
            pnlSearchControls.Controls.Add(lblError);
            pnlSearchControls.Controls.Add(btnEdit);
            pnlSearchControls.Controls.Add(txtMemberId);
            pnlSearchControls.Controls.Add(btnClear);
            pnlSearchControls.Controls.Add(lblMemberId);
            pnlSearchControls.Controls.Add(btnSearch);
            pnlSearchControls.Controls.Add(txtPhoneNumber);
            pnlSearchControls.Controls.Add(lblSearchCriteria);
            pnlSearchControls.Controls.Add(txtLastName);
            pnlSearchControls.Controls.Add(lblPhone);
            pnlSearchControls.Controls.Add(txtFirstName);
            pnlSearchControls.Controls.Add(radFullName);
            pnlSearchControls.Controls.Add(lblLastName);
            pnlSearchControls.Controls.Add(radMemberId);
            pnlSearchControls.Controls.Add(lblFirstName);
            pnlSearchControls.Controls.Add(radPhone);
            pnlSearchControls.Dock = DockStyle.Left;
            pnlSearchControls.Location = new Point(11, 13);
            pnlSearchControls.Margin = new Padding(3, 4, 3, 4);
            pnlSearchControls.Name = "pnlSearchControls";
            pnlSearchControls.Padding = new Padding(11, 13, 11, 13);
            pnlSearchControls.Size = new Size(389, 621);
            pnlSearchControls.TabIndex = 0;
            // 
            // btnViewReturnHistory
            // 
            btnViewReturnHistory.Enabled = false;
            btnViewReturnHistory.Location = new Point(15, 527);
            btnViewReturnHistory.Margin = new Padding(3, 4, 3, 4);
            btnViewReturnHistory.Name = "btnViewReturnHistory";
            btnViewReturnHistory.Size = new Size(327, 40);
            btnViewReturnHistory.TabIndex = 17;
            btnViewReturnHistory.Text = "View Return History";
            btnViewReturnHistory.UseVisualStyleBackColor = true;
            btnViewReturnHistory.Click += btnViewReturnHistory_Click;
            // 
            // btnViewRentalHistory
            // 
            btnViewRentalHistory.Enabled = false;
            btnViewRentalHistory.Location = new Point(15, 473);
            btnViewRentalHistory.Margin = new Padding(3, 4, 3, 4);
            btnViewRentalHistory.Name = "btnViewRentalHistory";
            btnViewRentalHistory.Size = new Size(327, 40);
            btnViewRentalHistory.TabIndex = 16;
            btnViewRentalHistory.Text = "View Rental History";
            btnViewRentalHistory.UseVisualStyleBackColor = true;
            btnViewRentalHistory.Click += btnViewRentalHistory_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(17, 580);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 15;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(239, 420);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(103, 37);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(126, 335);
            txtMemberId.Margin = new Padding(3, 4, 3, 4);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(171, 27);
            txtMemberId.TabIndex = 7;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(127, 420);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 37);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblMemberId
            // 
            lblMemberId.AutoSize = true;
            lblMemberId.Location = new Point(17, 339);
            lblMemberId.Name = "lblMemberId";
            lblMemberId.Size = new Size(87, 20);
            lblMemberId.TabIndex = 11;
            lblMemberId.Text = "Member ID:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(15, 420);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 37);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(126, 265);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(171, 27);
            txtPhoneNumber.TabIndex = 6;
            // 
            // lblSearchCriteria
            // 
            lblSearchCriteria.AutoSize = true;
            lblSearchCriteria.Location = new Point(118, 33);
            lblSearchCriteria.Name = "lblSearchCriteria";
            lblSearchCriteria.Size = new Size(105, 20);
            lblSearchCriteria.TabIndex = 0;
            lblSearchCriteria.Text = "Search Criteria";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(126, 193);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(171, 27);
            txtLastName.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(17, 269);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(66, 20);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Phone #:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(126, 131);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(171, 27);
            txtFirstName.TabIndex = 4;
            // 
            // radFullName
            // 
            radFullName.AutoSize = true;
            radFullName.Location = new Point(260, 73);
            radFullName.Margin = new Padding(3, 4, 3, 4);
            radFullName.Name = "radFullName";
            radFullName.Size = new Size(97, 24);
            radFullName.TabIndex = 3;
            radFullName.TabStop = true;
            radFullName.Text = "Full Name";
            radFullName.UseVisualStyleBackColor = true;
            radFullName.CheckedChanged += radFullName_CheckedChanged;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(17, 197);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(82, 20);
            lblLastName.TabIndex = 9;
            lblLastName.Text = "Last Name:";
            // 
            // radMemberId
            // 
            radMemberId.AutoSize = true;
            radMemberId.Location = new Point(17, 73);
            radMemberId.Margin = new Padding(3, 4, 3, 4);
            radMemberId.Name = "radMemberId";
            radMemberId.Size = new Size(105, 24);
            radMemberId.TabIndex = 1;
            radMemberId.TabStop = true;
            radMemberId.Text = "Member ID";
            radMemberId.UseVisualStyleBackColor = true;
            radMemberId.CheckedChanged += radMemberId_CheckedChanged;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(17, 135);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(83, 20);
            lblFirstName.TabIndex = 8;
            lblFirstName.Text = "First Name:";
            // 
            // radPhone
            // 
            radPhone.AutoSize = true;
            radPhone.Location = new Point(151, 73);
            radPhone.Margin = new Padding(4, 4, 3, 4);
            radPhone.Name = "radPhone";
            radPhone.Size = new Size(84, 24);
            radPhone.TabIndex = 2;
            radPhone.TabStop = true;
            radPhone.Text = "Phone #";
            radPhone.UseVisualStyleBackColor = true;
            radPhone.CheckedChanged += radPhone_CheckedChanged;
            // 
            // SearchMemberUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlSearchContainer);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SearchMemberUserControl";
            Size = new Size(808, 647);
            pnlSearchContainer.ResumeLayout(false);
            pnlResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            pnlSearchControls.ResumeLayout(false);
            pnlSearchControls.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSearchContainer;
        private Panel pnlResults;
        private DataGridView dgvMembers;
        private Panel pnlSearchControls;
        private Label lblError;
        private Button btnEdit;
        private TextBox txtMemberId;
        private Button btnClear;
        private Label lblMemberId;
        private Button btnSearch;
        private TextBox txtPhoneNumber;
        private Label lblSearchCriteria;
        private TextBox txtLastName;
        private Label lblPhone;
        private TextBox txtFirstName;
        private RadioButton radFullName;
        private Label lblLastName;
        private RadioButton radMemberId;
        private Label lblFirstName;
        private RadioButton radPhone;
        private Button btnViewRentalHistory;
        private Button btnViewReturnHistory;
    }
}