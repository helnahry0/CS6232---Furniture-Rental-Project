namespace FurnitureRental.UserControls
{
    partial class CreateMemberUserControl
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
            ClearButton = new Button();
            CreateButton = new Button();
            ZipTextBox = new TextBox();
            ZipLabel = new Label();
            StateLabel = new Label();
            CityTextBox = new TextBox();
            CityLabel = new Label();
            Address2TextBox = new TextBox();
            Address2Label = new Label();
            Address1TextBox = new TextBox();
            Address1Label = new Label();
            SexComboBox = new ComboBox();
            SexLabel = new Label();
            PhoneNumberLabel = new Label();
            DobDateTimePicker = new DateTimePicker();
            DobLabel = new Label();
            LastNameTextBox = new TextBox();
            LastNameLabel = new Label();
            FirstNameTextBox = new TextBox();
            FirstNameLabel = new Label();
            RegMemberLabel = new Label();
            PhoneNumberMaskedTextBox = new MaskedTextBox();
            StateComboBox = new ComboBox();
            SuspendLayout();
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(491, 409);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(112, 39);
            ClearButton.TabIndex = 12;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(239, 409);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(179, 39);
            CreateButton.TabIndex = 11;
            CreateButton.Text = "Create Member";
            CreateButton.UseVisualStyleBackColor = true;
            // 
            // ZipTextBox
            // 
            ZipTextBox.Location = new Point(239, 367);
            ZipTextBox.MaxLength = 5;
            ZipTextBox.Name = "ZipTextBox";
            ZipTextBox.Size = new Size(364, 27);
            ZipTextBox.TabIndex = 10;
            // 
            // ZipLabel
            // 
            ZipLabel.AutoSize = true;
            ZipLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ZipLabel.Location = new Point(170, 370);
            ZipLabel.Name = "ZipLabel";
            ZipLabel.Size = new Size(35, 20);
            ZipLabel.TabIndex = 42;
            ZipLabel.Text = "Zip:";
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            StateLabel.Location = new Point(170, 337);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(49, 20);
            StateLabel.TabIndex = 40;
            StateLabel.Text = "State:";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(239, 301);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(364, 27);
            CityTextBox.TabIndex = 8;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CityLabel.Location = new Point(170, 304);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(40, 20);
            CityLabel.TabIndex = 38;
            CityLabel.Text = "City:";
            // 
            // Address2TextBox
            // 
            Address2TextBox.Location = new Point(239, 268);
            Address2TextBox.Name = "Address2TextBox";
            Address2TextBox.Size = new Size(364, 27);
            Address2TextBox.TabIndex = 7;
            // 
            // Address2Label
            // 
            Address2Label.AutoSize = true;
            Address2Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Address2Label.Location = new Point(130, 271);
            Address2Label.Name = "Address2Label";
            Address2Label.Size = new Size(83, 20);
            Address2Label.TabIndex = 36;
            Address2Label.Text = "Address 2:";
            // 
            // Address1TextBox
            // 
            Address1TextBox.Location = new Point(239, 235);
            Address1TextBox.Name = "Address1TextBox";
            Address1TextBox.Size = new Size(364, 27);
            Address1TextBox.TabIndex = 6;
            // 
            // Address1Label
            // 
            Address1Label.AutoSize = true;
            Address1Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Address1Label.Location = new Point(130, 238);
            Address1Label.Name = "Address1Label";
            Address1Label.Size = new Size(83, 20);
            Address1Label.TabIndex = 34;
            Address1Label.Text = "Address 1:";
            // 
            // SexComboBox
            // 
            SexComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SexComboBox.FormattingEnabled = true;
            SexComboBox.Location = new Point(239, 158);
            SexComboBox.Name = "SexComboBox";
            SexComboBox.Size = new Size(295, 28);
            SexComboBox.TabIndex = 4;
            // 
            // SexLabel
            // 
            SexLabel.AutoSize = true;
            SexLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SexLabel.Location = new Point(172, 161);
            SexLabel.Name = "SexLabel";
            SexLabel.Size = new Size(37, 20);
            SexLabel.TabIndex = 30;
            SexLabel.Text = "Sex:";
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PhoneNumberLabel.Location = new Point(97, 196);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(120, 20);
            PhoneNumberLabel.TabIndex = 32;
            PhoneNumberLabel.Text = "Phone Number:";
            // 
            // DobDateTimePicker
            // 
            DobDateTimePicker.Checked = false;
            DobDateTimePicker.CustomFormat = "yyyy-MM-dd";
            DobDateTimePicker.Format = DateTimePickerFormat.Custom;
            DobDateTimePicker.Location = new Point(239, 125);
            DobDateTimePicker.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            DobDateTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            DobDateTimePicker.Name = "DobDateTimePicker";
            DobDateTimePicker.Size = new Size(364, 27);
            DobDateTimePicker.TabIndex = 3;
            // 
            // DobLabel
            // 
            DobLabel.AutoSize = true;
            DobLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DobLabel.Location = new Point(155, 135);
            DobLabel.Name = "DobLabel";
            DobLabel.Size = new Size(55, 20);
            DobLabel.TabIndex = 28;
            DobLabel.Text = "D.O.B.:";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(239, 89);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(364, 27);
            LastNameTextBox.TabIndex = 2;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LastNameLabel.Location = new Point(125, 93);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(88, 20);
            LastNameLabel.TabIndex = 26;
            LastNameLabel.Text = "Last Name:";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(239, 52);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(364, 27);
            FirstNameTextBox.TabIndex = 1;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FirstNameLabel.Location = new Point(125, 56);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(90, 20);
            FirstNameLabel.TabIndex = 24;
            FirstNameLabel.Text = "First Name:";
            // 
            // RegMemberLabel
            // 
            RegMemberLabel.AutoSize = true;
            RegMemberLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RegMemberLabel.Location = new Point(64, 21);
            RegMemberLabel.Name = "RegMemberLabel";
            RegMemberLabel.Size = new Size(183, 20);
            RegMemberLabel.TabIndex = 23;
            RegMemberLabel.Text = "Register a New Member:";
            // 
            // PhoneNumberMaskedTextBox
            // 
            PhoneNumberMaskedTextBox.Location = new Point(239, 196);
            PhoneNumberMaskedTextBox.Name = "PhoneNumberMaskedTextBox";
            PhoneNumberMaskedTextBox.Size = new Size(364, 27);
            PhoneNumberMaskedTextBox.TabIndex = 5;
            // 
            // StateComboBox
            // 
            StateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StateComboBox.FormattingEnabled = true;
            StateComboBox.Location = new Point(239, 334);
            StateComboBox.Name = "StateComboBox";
            StateComboBox.Size = new Size(364, 28);
            StateComboBox.TabIndex = 9;
            // 
            // CreateMemberUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StateComboBox);
            Controls.Add(PhoneNumberMaskedTextBox);
            Controls.Add(ClearButton);
            Controls.Add(CreateButton);
            Controls.Add(ZipTextBox);
            Controls.Add(ZipLabel);
            Controls.Add(StateLabel);
            Controls.Add(CityTextBox);
            Controls.Add(CityLabel);
            Controls.Add(Address2TextBox);
            Controls.Add(Address2Label);
            Controls.Add(Address1TextBox);
            Controls.Add(Address1Label);
            Controls.Add(SexComboBox);
            Controls.Add(SexLabel);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(DobDateTimePicker);
            Controls.Add(DobLabel);
            Controls.Add(LastNameTextBox);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameTextBox);
            Controls.Add(FirstNameLabel);
            Controls.Add(RegMemberLabel);
            Name = "CreateMemberUserControl";
            Size = new Size(743, 531);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClearButton;
        private Button CreateButton;
        private TextBox ZipTextBox;
        private Label ZipLabel;
        private Label StateLabel;
        private TextBox CityTextBox;
        private Label CityLabel;
        private TextBox Address2TextBox;
        private Label Address2Label;
        private TextBox Address1TextBox;
        private Label Address1Label;
        private ComboBox SexComboBox;
        private Label SexLabel;
        private Label PhoneNumberLabel;
        private DateTimePicker DobDateTimePicker;
        private Label DobLabel;
        private TextBox LastNameTextBox;
        private Label LastNameLabel;
        private TextBox FirstNameTextBox;
        private Label FirstNameLabel;
        private Label RegMemberLabel;
        private MaskedTextBox PhoneNumberMaskedTextBox;
        private ComboBox StateComboBox;
    }
}
