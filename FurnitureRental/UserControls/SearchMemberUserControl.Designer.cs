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

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSearchContainer = new Panel();
            pnlResults = new Panel();
            dgvMembers = new DataGridView();
            colMemberId = new DataGridViewTextBoxColumn();
            colFirstName = new DataGridViewTextBoxColumn();
            colLastName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            pnlSearchControls = new Panel();
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
            pnlResults.Location = new Point(327, 10);
            pnlResults.Name = "pnlResults";
            pnlResults.Padding = new Padding(10);
            pnlResults.Size = new Size(370, 465);
            pnlResults.TabIndex = 1;
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Columns.AddRange(new DataGridViewColumn[] { colMemberId, colFirstName, colLastName, colPhone });
            dgvMembers.Dock = DockStyle.Fill;
            dgvMembers.Location = new Point(10, 10);
            dgvMembers.MultiSelect = false;
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(350, 445);
            dgvMembers.TabIndex = 0;
            // 
            // colMemberId
            // 
            colMemberId.HeaderText = "Member ID";
            colMemberId.Name = "colMemberId";
            colMemberId.ReadOnly = true;
            // 
            // colFirstName
            // 
            colFirstName.HeaderText = "First Name";
            colFirstName.Name = "colFirstName";
            colFirstName.ReadOnly = true;
            // 
            // colLastName
            // 
            colLastName.HeaderText = "Last Name";
            colLastName.Name = "colLastName";
            colLastName.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Phone Number";
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // pnlSearchControls
            // 
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
            pnlSearchControls.Size = new Size(317, 465);
            pnlSearchControls.TabIndex = 0;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(111, 377);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 1;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(209, 315);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtMemberId
            // 
            txtMemberId.AccessibleRole = AccessibleRole.Text;
            txtMemberId.Enabled = false;
            txtMemberId.Location = new Point(93, 251);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(100, 23);
            txtMemberId.TabIndex = 4;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(111, 315);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lblMemberId
            // 
            lblMemberId.AutoSize = true;
            lblMemberId.Location = new Point(10, 254);
            lblMemberId.Name = "lblMemberId";
            lblMemberId.Size = new Size(69, 15);
            lblMemberId.TabIndex = 4;
            lblMemberId.Text = "Member ID:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(8, 315);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Enabled = false;
            txtPhoneNumber.Location = new Point(93, 199);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(100, 23);
            txtPhoneNumber.TabIndex = 3;
            // 
            // lblSearchCriteria
            // 
            lblSearchCriteria.AutoSize = true;
            lblSearchCriteria.Location = new Point(103, 25);
            lblSearchCriteria.Name = "lblSearchCriteria";
            lblSearchCriteria.Size = new Size(83, 15);
            lblSearchCriteria.TabIndex = 1;
            lblSearchCriteria.Text = "Search Criteria";
            // 
            // txtLastName
            // 
            txtLastName.Enabled = false;
            txtLastName.Location = new Point(93, 148);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 2;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(3, 202);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(91, 15);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Phone Number:";
            // 
            // txtFirstName
            // 
            txtFirstName.Enabled = false;
            txtFirstName.Location = new Point(93, 98);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 1;
            // 
            // radFullName
            // 
            radFullName.AutoSize = true;
            radFullName.Location = new Point(214, 56);
            radFullName.Name = "radFullName";
            radFullName.Size = new Size(79, 19);
            radFullName.TabIndex = 3;
            radFullName.TabStop = true;
            radFullName.Text = "Full Name";
            radFullName.UseVisualStyleBackColor = true;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(13, 148);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // radMemberId
            // 
            radMemberId.AutoSize = true;
            radMemberId.Location = new Point(8, 56);
            radMemberId.Name = "radMemberId";
            radMemberId.Size = new Size(84, 19);
            radMemberId.TabIndex = 1;
            radMemberId.TabStop = true;
            radMemberId.Text = "Member ID";
            radMemberId.UseVisualStyleBackColor = true;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(13, 101);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name:";
            // 
            // radPhone
            // 
            radPhone.AutoSize = true;
            radPhone.Location = new Point(102, 56);
            radPhone.Name = "radPhone";
            radPhone.Size = new Size(106, 19);
            radPhone.TabIndex = 2;
            radPhone.TabStop = true;
            radPhone.Text = "Phone Number";
            radPhone.UseVisualStyleBackColor = true;
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
        private Label lblSearchCriteria;
        private Panel pnlSearchControls;
        private RadioButton radFullName;
        private RadioButton radMemberId;
        private RadioButton radPhone;
        private TextBox txtMemberId;
        private TextBox txtPhoneNumber;
        private TextBox txtLastName;
        private Label lblMemberId;
        private Label lblPhone;
        private TextBox txtFirstName;
        private Label lblLastName;
        private Label lblFirstName;
        private Button btnEdit;
        private Button btnClear;
        private Button btnSearch;
        private Label lblError;
        private Panel pnlResults;
        private DataGridView dgvMembers;
        private DataGridViewTextBoxColumn colMemberId;
        private DataGridViewTextBoxColumn colFirstName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colPhone;
    }
}
