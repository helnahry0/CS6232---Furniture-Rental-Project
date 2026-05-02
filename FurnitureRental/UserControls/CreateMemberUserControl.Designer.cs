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
            ClearButton.Location = new Point(430, 361);
            ClearButton.Margin = new Padding(3, 2, 3, 2);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(98, 29);
            ClearButton.TabIndex = 12;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(209, 361);
            CreateButton.Margin = new Padding(3, 2, 3, 2);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(157, 29);
            CreateButton.TabIndex = 11;
            CreateButton.Text = "Create Member";
            CreateButton.UseVisualStyleBackColor = true;
            // 
            // ZipTextBox
            // 
            ZipTextBox.Location = new Point(209, 323);
            ZipTextBox.Margin = new Padding(3, 2, 3, 2);
            ZipTextBox.MaxLength = 5;
            ZipTextBox.Name = "ZipTextBox";
            ZipTextBox.Size = new Size(319, 23);
            ZipTextBox.TabIndex = 10;
            // 
            // ZipLabel
            // 
            ZipLabel.AutoSize = true;
            ZipLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ZipLabel.Location = new Point(149, 326);
            ZipLabel.Name = "ZipLabel";
            ZipLabel.Size = new Size(27, 15);
            ZipLabel.TabIndex = 42;
            ZipLabel.Text = "Zip:";
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            StateLabel.Location = new Point(149, 295);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(40, 15);
            StateLabel.TabIndex = 40;
            StateLabel.Text = "State:";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(209, 262);
            CityTextBox.Margin = new Padding(3, 2, 3, 2);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(319, 23);
            CityTextBox.TabIndex = 8;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CityLabel.Location = new Point(149, 264);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(31, 15);
            CityLabel.TabIndex = 38;
            CityLabel.Text = "City:";
            // 
            // Address2TextBox
            // 
            Address2TextBox.Location = new Point(209, 231);
            Address2TextBox.Margin = new Padding(3, 2, 3, 2);
            Address2TextBox.Name = "Address2TextBox";
            Address2TextBox.Size = new Size(319, 23);
            Address2TextBox.TabIndex = 7;
            // 
            // Address2Label
            // 
            Address2Label.AutoSize = true;
            Address2Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Address2Label.Location = new Point(114, 233);
            Address2Label.Name = "Address2Label";
            Address2Label.Size = new Size(64, 15);
            Address2Label.TabIndex = 36;
            Address2Label.Text = "Address 2:";
            // 
            // Address1TextBox
            // 
            Address1TextBox.Location = new Point(209, 199);
            Address1TextBox.Margin = new Padding(3, 2, 3, 2);
            Address1TextBox.Name = "Address1TextBox";
            Address1TextBox.Size = new Size(319, 23);
            Address1TextBox.TabIndex = 6;
            // 
            // Address1Label
            // 
            Address1Label.AutoSize = true;
            Address1Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Address1Label.Location = new Point(114, 201);
            Address1Label.Name = "Address1Label";
            Address1Label.Size = new Size(64, 15);
            Address1Label.TabIndex = 34;
            Address1Label.Text = "Address 1:";
            // 
            // SexComboBox
            // 
            SexComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SexComboBox.FormattingEnabled = true;
            SexComboBox.Location = new Point(209, 136);
            SexComboBox.Margin = new Padding(3, 2, 3, 2);
            SexComboBox.Name = "SexComboBox";
            SexComboBox.Size = new Size(259, 23);
            SexComboBox.TabIndex = 4;
            // 
            // SexLabel
            // 
            SexLabel.AutoSize = true;
            SexLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SexLabel.Location = new Point(150, 139);
            SexLabel.Name = "SexLabel";
            SexLabel.Size = new Size(31, 15);
            SexLabel.TabIndex = 30;
            SexLabel.Text = "Sex:";
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PhoneNumberLabel.Location = new Point(85, 167);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(94, 15);
            PhoneNumberLabel.TabIndex = 32;
            PhoneNumberLabel.Text = "Phone Number:";
            // 
            // DobDateTimePicker
            // 
            DobDateTimePicker.Checked = false;
            DobDateTimePicker.CustomFormat = "yyyy-MM-dd";
            DobDateTimePicker.Format = DateTimePickerFormat.Custom;
            DobDateTimePicker.Location = new Point(209, 106);
            DobDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            DobDateTimePicker.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            DobDateTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            DobDateTimePicker.Name = "DobDateTimePicker";
            DobDateTimePicker.Size = new Size(319, 23);
            DobDateTimePicker.TabIndex = 3;
            // 
            // DobLabel
            // 
            DobLabel.AutoSize = true;
            DobLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DobLabel.Location = new Point(136, 113);
            DobLabel.Name = "DobLabel";
            DobLabel.Size = new Size(44, 15);
            DobLabel.TabIndex = 28;
            DobLabel.Text = "D.O.B.:";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(209, 73);
            LastNameTextBox.Margin = new Padding(3, 2, 3, 2);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(319, 23);
            LastNameTextBox.TabIndex = 2;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LastNameLabel.Location = new Point(109, 76);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(68, 15);
            LastNameLabel.TabIndex = 26;
            LastNameLabel.Text = "Last Name:";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(209, 39);
            FirstNameTextBox.Margin = new Padding(3, 2, 3, 2);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(319, 23);
            FirstNameTextBox.TabIndex = 1;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FirstNameLabel.Location = new Point(109, 42);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(70, 15);
            FirstNameLabel.TabIndex = 24;
            FirstNameLabel.Text = "First Name:";
            // 
            // RegMemberLabel
            // 
            RegMemberLabel.AutoSize = true;
            RegMemberLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RegMemberLabel.Location = new Point(56, 16);
            RegMemberLabel.Name = "RegMemberLabel";
            RegMemberLabel.Size = new Size(146, 15);
            RegMemberLabel.TabIndex = 23;
            RegMemberLabel.Text = "Register a New Member:";
            // 
            // PhoneNumberMaskedTextBox
            // 
            PhoneNumberMaskedTextBox.Location = new Point(209, 167);
            PhoneNumberMaskedTextBox.Margin = new Padding(3, 2, 3, 2);
            PhoneNumberMaskedTextBox.Name = "PhoneNumberMaskedTextBox";
            PhoneNumberMaskedTextBox.Size = new Size(319, 23);
            PhoneNumberMaskedTextBox.TabIndex = 5;
            // 
            // StateComboBox
            // 
            StateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StateComboBox.FormattingEnabled = true;
            StateComboBox.Location = new Point(209, 292);
            StateComboBox.Margin = new Padding(3, 2, 3, 2);
            StateComboBox.Name = "StateComboBox";
            StateComboBox.Size = new Size(319, 23);
            StateComboBox.TabIndex = 9;
            // 
            // CreateMemberUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "CreateMemberUserControl";
            Size = new Size(650, 451);
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
