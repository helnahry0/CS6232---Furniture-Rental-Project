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
            pnlSearchContainer.Name = "pnlSearchContainer";
            pnlSearchContainer.Padding = new Padding(10);
            pnlSearchContainer.Size = new Size(707, 485);
            pnlSearchContainer.TabIndex = 0;
            // 
            // pnlResults
            // 
            pnlResults.Controls.Add(dgvMembers);
            pnlResults.Dock = DockStyle.Fill;
            pnlResults.Location = new Point(350, 10);
            pnlResults.Name = "pnlResults";
            pnlResults.Padding = new Padding(10);
            pnlResults.Size = new Size(347, 465);
            pnlResults.TabIndex = 1;
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Dock = DockStyle.Fill;
            dgvMembers.Location = new Point(10, 10);
            dgvMembers.MultiSelect = false;
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(327, 445);
            dgvMembers.TabIndex = 0;
            dgvMembers.SelectionChanged += dgvMembers_SelectionChanged;
            // 
            // pnlSearchControls
            // 
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
            pnlSearchControls.Location = new Point(10, 10);
            pnlSearchControls.Name = "pnlSearchControls";
            pnlSearchControls.Padding = new Padding(10);
            pnlSearchControls.Size = new Size(340, 465);
            pnlSearchControls.TabIndex = 0;
            // 
            // btnViewRentalHistory
            // 
            btnViewRentalHistory.Enabled = false;
            btnViewRentalHistory.Location = new Point(13, 355);
            btnViewRentalHistory.Name = "btnViewRentalHistory";
            btnViewRentalHistory.Size = new Size(286, 30);
            btnViewRentalHistory.TabIndex = 16;
            btnViewRentalHistory.Text = "View Rental History";
            btnViewRentalHistory.UseVisualStyleBackColor = true;
            btnViewRentalHistory.Click += btnViewRentalHistory_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(15, 360);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 15;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(209, 315);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 28);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(110, 251);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(150, 23);
            txtMemberId.TabIndex = 7;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(111, 315);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 28);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblMemberId
            // 
            lblMemberId.AutoSize = true;
            lblMemberId.Location = new Point(15, 254);
            lblMemberId.Name = "lblMemberId";
            lblMemberId.Size = new Size(69, 15);
            lblMemberId.TabIndex = 11;
            lblMemberId.Text = "Member ID:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(13, 315);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 28);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(110, 199);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(150, 23);
            txtPhoneNumber.TabIndex = 6;
            // 
            // lblSearchCriteria
            // 
            lblSearchCriteria.AutoSize = true;
            lblSearchCriteria.Location = new Point(103, 25);
            lblSearchCriteria.Name = "lblSearchCriteria";
            lblSearchCriteria.Size = new Size(83, 15);
            lblSearchCriteria.TabIndex = 0;
            lblSearchCriteria.Text = "Search Criteria";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(110, 145);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 23);
            txtLastName.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(15, 202);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(54, 15);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Phone #:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(110, 98);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 23);
            txtFirstName.TabIndex = 4;
            // 
            // radFullName
            // 
            radFullName.AutoSize = true;
            radFullName.Location = new Point(209, 55);
            radFullName.Name = "radFullName";
            radFullName.Size = new Size(79, 19);
            radFullName.TabIndex = 3;
            radFullName.TabStop = true;
            radFullName.Text = "Full Name";
            radFullName.UseVisualStyleBackColor = true;
            radFullName.CheckedChanged += radFullName_CheckedChanged;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(15, 148);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 9;
            lblLastName.Text = "Last Name:";
            // 
            // radMemberId
            // 
            radMemberId.AutoSize = true;
            radMemberId.Location = new Point(15, 55);
            radMemberId.Name = "radMemberId";
            radMemberId.Size = new Size(84, 19);
            radMemberId.TabIndex = 1;
            radMemberId.TabStop = true;
            radMemberId.Text = "Member ID";
            radMemberId.UseVisualStyleBackColor = true;
            radMemberId.CheckedChanged += radMemberId_CheckedChanged;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(15, 101);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 8;
            lblFirstName.Text = "First Name:";
            // 
            // radPhone
            // 
            radPhone.AutoSize = true;
            radPhone.Location = new Point(120, 55);
            radPhone.Name = "radPhone";
            radPhone.Size = new Size(69, 19);
            radPhone.TabIndex = 2;
            radPhone.TabStop = true;
            radPhone.Text = "Phone #";
            radPhone.UseVisualStyleBackColor = true;
            radPhone.CheckedChanged += radPhone_CheckedChanged;
            // 
            // SearchMemberUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlSearchContainer);
            Name = "SearchMemberUserControl";
            Size = new Size(707, 485);
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
    }
}