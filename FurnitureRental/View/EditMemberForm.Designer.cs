
namespace FurnitureRental.View
{
    partial class EditMemberForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMemberID = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblGender = new Label();
            lblDOB = new Label();
            lblAddress = new Label();
            lblCity = new Label();
            lblState = new Label();
            lblPhone = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtMemberId = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAddress1 = new TextBox();
            txtCity = new TextBox();
            txtPhone = new TextBox();
            cboGender = new ComboBox();
            cboState = new ComboBox();
            lblAddress2 = new Label();
            txtAddress2 = new TextBox();
            dtpDOB = new DateTimePicker();
            txtZip = new TextBox();
            lblZip = new Label();
            SuspendLayout();
            // 
            // lblMemberID
            // 
            lblMemberID.AutoSize = true;
            lblMemberID.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblMemberID.Location = new Point(52, 20);
            lblMemberID.Name = "lblMemberID";
            lblMemberID.Size = new Size(79, 17);
            lblMemberID.TabIndex = 41;
            lblMemberID.Text = "Member ID:";
            lblMemberID.Click += label1_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblFirstName.Location = new Point(52, 56);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(77, 17);
            lblFirstName.TabIndex = 31;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblLastName.Location = new Point(52, 93);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(75, 17);
            lblLastName.TabIndex = 32;
            lblLastName.Text = "Last Name:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblGender.Location = new Point(52, 125);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(56, 17);
            lblGender.TabIndex = 33;
            lblGender.Text = "Gender:";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblDOB.Location = new Point(52, 160);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(38, 17);
            lblDOB.TabIndex = 34;
            lblDOB.Text = "DOB:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblAddress.Location = new Point(51, 228);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(65, 17);
            lblAddress.TabIndex = 36;
            lblAddress.Text = "Address1:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblCity.Location = new Point(51, 300);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(34, 17);
            lblCity.TabIndex = 38;
            lblCity.Text = "City:";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblState.Location = new Point(51, 331);
            lblState.Name = "lblState";
            lblState.Size = new Size(42, 17);
            lblState.TabIndex = 39;
            lblState.Text = "State:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblPhone.Location = new Point(51, 191);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 17);
            lblPhone.TabIndex = 35;
            lblPhone.Text = "Phone:";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveBorder;
            btnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(100, 404);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(83, 38);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveBorder;
            btnCancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Location = new Point(232, 404);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 38);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtMemberId
            // 
            txtMemberId.BorderStyle = BorderStyle.FixedSingle;
            txtMemberId.Font = new Font("Segoe UI", 12F);
            txtMemberId.Location = new Point(159, 15);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.ReadOnly = true;
            txtMemberId.Size = new Size(152, 29);
            txtMemberId.TabIndex = 41;
            txtMemberId.TabStop = false;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 12F);
            txtFirstName.Location = new Point(158, 51);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(266, 29);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 12F);
            txtLastName.Location = new Point(159, 88);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(265, 29);
            txtLastName.TabIndex = 2;
            // 
            // txtAddress1
            // 
            txtAddress1.BorderStyle = BorderStyle.FixedSingle;
            txtAddress1.Font = new Font("Segoe UI", 12F);
            txtAddress1.Location = new Point(160, 228);
            txtAddress1.Name = "txtAddress1";
            txtAddress1.Size = new Size(264, 29);
            txtAddress1.TabIndex = 6;
            // 
            // txtCity
            // 
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Font = new Font("Segoe UI", 12F);
            txtCity.Location = new Point(159, 297);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(184, 29);
            txtCity.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 12F);
            txtPhone.Location = new Point(160, 191);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(132, 29);
            txtPhone.TabIndex = 5;
            // 
            // cboGender
            // 
            cboGender.Font = new Font("Segoe UI", 12F);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cboGender.Location = new Point(159, 125);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(153, 29);
            cboGender.TabIndex = 3;
            // 
            // cboState
            // 
            cboState.Font = new Font("Segoe UI", 12F);
            cboState.FormattingEnabled = true;
            cboState.Location = new Point(159, 331);
            cboState.Name = "cboState";
            cboState.Size = new Size(133, 29);
            cboState.TabIndex = 9;
            // 
            // lblAddress2
            // 
            lblAddress2.AutoSize = true;
            lblAddress2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress2.Location = new Point(49, 266);
            lblAddress2.Name = "lblAddress2";
            lblAddress2.Size = new Size(67, 17);
            lblAddress2.TabIndex = 37;
            lblAddress2.Text = "Address2:";
            // 
            // txtAddress2
            // 
            txtAddress2.BorderStyle = BorderStyle.FixedSingle;
            txtAddress2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress2.Location = new Point(159, 264);
            txtAddress2.Name = "txtAddress2";
            txtAddress2.Size = new Size(265, 29);
            txtAddress2.TabIndex = 7;
            // 
            // dtpDOB
            // 
            dtpDOB.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDOB.Checked = false;
            dtpDOB.CustomFormat = "MM-dd-yyyy";
            dtpDOB.Format = DateTimePickerFormat.Custom;
            dtpDOB.Location = new Point(159, 161);
            dtpDOB.Margin = new Padding(3, 2, 3, 2);
            dtpDOB.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            dtpDOB.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(153, 25);
            dtpDOB.TabIndex = 4;
            // 
            // txtZip
            // 
            txtZip.BorderStyle = BorderStyle.FixedSingle;
            txtZip.Font = new Font("Segoe UI", 12F);
            txtZip.Location = new Point(160, 368);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(132, 29);
            txtZip.TabIndex = 10;
            // 
            // lblZip
            // 
            lblZip.AutoSize = true;
            lblZip.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblZip.Location = new Point(51, 368);
            lblZip.Name = "lblZip";
            lblZip.Size = new Size(62, 17);
            lblZip.TabIndex = 40;
            lblZip.Text = "Zip Code";
            // 
            // EditMemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 452);
            Controls.Add(txtZip);
            Controls.Add(lblZip);
            Controls.Add(dtpDOB);
            Controls.Add(txtAddress2);
            Controls.Add(lblAddress2);
            Controls.Add(cboState);
            Controls.Add(cboGender);
            Controls.Add(txtPhone);
            Controls.Add(txtCity);
            Controls.Add(txtAddress1);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtMemberId);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblPhone);
            Controls.Add(lblState);
            Controls.Add(lblCity);
            Controls.Add(lblAddress);
            Controls.Add(lblDOB);
            Controls.Add(lblGender);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblMemberID);
            Font = new Font("Segoe UI", 9.75F);
            Name = "EditMemberForm";
            Text = "EditMemberForm";
            Load += EditMemberForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblMemberID;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblGender;
        private Label lblDOB;
        private Label lblAddress;
        private Label lblCity;
        private Label lblState;
        private Label lblPhone;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtMemberId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAddress1;
        private TextBox txtCity;
        private TextBox txtPhone;
        private ComboBox cboGender;
        private ComboBox cboState;
        private Label lblAddress2;
        private TextBox txtAddress2;
        private DateTimePicker dtpDOB;
        private TextBox txtZip;
        private Label lblZip;
    }
}