namespace FurnitureRental.View
{
    partial class CreateMemberForm
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
            RegMemberLabel = new Label();
            FirstNameLabel = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            LastNameLabel = new Label();
            DobLabel = new Label();
            DobDateTimePicker = new DateTimePicker();
            PhoneNumberTextBox = new TextBox();
            PhoneNumberLabel = new Label();
            SexLabel = new Label();
            SexComboBox = new ComboBox();
            Address1Label = new Label();
            Address1TextBox = new TextBox();
            Address2TextBox = new TextBox();
            Address2Label = new Label();
            CityTextBox = new TextBox();
            CityLabel = new Label();
            StateTextBox = new TextBox();
            StateLabel = new Label();
            ZipTextBox = new TextBox();
            ZipLabel = new Label();
            CreateButton = new Button();
            ClearButton = new Button();
            SuspendLayout();
            // 
            // RegMemberLabel
            // 
            RegMemberLabel.AutoSize = true;
            RegMemberLabel.Location = new Point(35, 22);
            RegMemberLabel.Name = "RegMemberLabel";
            RegMemberLabel.Size = new Size(172, 20);
            RegMemberLabel.TabIndex = 0;
            RegMemberLabel.Text = "Register a New Member:";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(96, 57);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(83, 20);
            FirstNameLabel.TabIndex = 1;
            FirstNameLabel.Text = "First Name:";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(210, 53);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(250, 27);
            FirstNameTextBox.TabIndex = 2;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(210, 90);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(250, 27);
            LastNameTextBox.TabIndex = 4;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(96, 94);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(82, 20);
            LastNameLabel.TabIndex = 3;
            LastNameLabel.Text = "Last Name:";
            // 
            // DobLabel
            // 
            DobLabel.AutoSize = true;
            DobLabel.Location = new Point(126, 136);
            DobLabel.Name = "DobLabel";
            DobLabel.Size = new Size(52, 20);
            DobLabel.TabIndex = 5;
            DobLabel.Text = "D.O.B.:";
            // 
            // DobDateTimePicker
            // 
            DobDateTimePicker.Checked = false;
            DobDateTimePicker.CustomFormat = "yyyy-MM-dd";
            DobDateTimePicker.Format = DateTimePickerFormat.Custom;
            DobDateTimePicker.Location = new Point(210, 126);
            DobDateTimePicker.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            DobDateTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            DobDateTimePicker.Name = "DobDateTimePicker";
            DobDateTimePicker.Size = new Size(250, 27);
            DobDateTimePicker.TabIndex = 6;
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(210, 193);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(250, 27);
            PhoneNumberTextBox.TabIndex = 10;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(68, 197);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(111, 20);
            PhoneNumberLabel.TabIndex = 9;
            PhoneNumberLabel.Text = "Phone Number:";
            // 
            // SexLabel
            // 
            SexLabel.AutoSize = true;
            SexLabel.Location = new Point(143, 162);
            SexLabel.Name = "SexLabel";
            SexLabel.Size = new Size(35, 20);
            SexLabel.TabIndex = 7;
            SexLabel.Text = "Sex:";
            // 
            // SexComboBox
            // 
            SexComboBox.FormattingEnabled = true;
            SexComboBox.Location = new Point(210, 159);
            SexComboBox.Name = "SexComboBox";
            SexComboBox.Size = new Size(181, 28);
            SexComboBox.TabIndex = 8;
            // 
            // Address1Label
            // 
            Address1Label.AutoSize = true;
            Address1Label.Location = new Point(101, 239);
            Address1Label.Name = "Address1Label";
            Address1Label.Size = new Size(77, 20);
            Address1Label.TabIndex = 11;
            Address1Label.Text = "Address 1:";
            // 
            // Address1TextBox
            // 
            Address1TextBox.Location = new Point(210, 236);
            Address1TextBox.Name = "Address1TextBox";
            Address1TextBox.Size = new Size(250, 27);
            Address1TextBox.TabIndex = 12;
            // 
            // Address2TextBox
            // 
            Address2TextBox.Location = new Point(210, 269);
            Address2TextBox.Name = "Address2TextBox";
            Address2TextBox.Size = new Size(250, 27);
            Address2TextBox.TabIndex = 14;
            // 
            // Address2Label
            // 
            Address2Label.AutoSize = true;
            Address2Label.Location = new Point(101, 272);
            Address2Label.Name = "Address2Label";
            Address2Label.Size = new Size(77, 20);
            Address2Label.TabIndex = 13;
            Address2Label.Text = "Address 2:";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(210, 302);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(250, 27);
            CityTextBox.TabIndex = 16;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(141, 305);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(37, 20);
            CityLabel.TabIndex = 15;
            CityLabel.Text = "City:";
            // 
            // StateTextBox
            // 
            StateTextBox.Location = new Point(210, 335);
            StateTextBox.Name = "StateTextBox";
            StateTextBox.Size = new Size(250, 27);
            StateTextBox.TabIndex = 18;
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Location = new Point(141, 338);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(46, 20);
            StateLabel.TabIndex = 17;
            StateLabel.Text = "State:";
            // 
            // ZipTextBox
            // 
            ZipTextBox.Location = new Point(210, 368);
            ZipTextBox.Name = "ZipTextBox";
            ZipTextBox.Size = new Size(250, 27);
            ZipTextBox.TabIndex = 20;
            // 
            // ZipLabel
            // 
            ZipLabel.AutoSize = true;
            ZipLabel.Location = new Point(141, 371);
            ZipLabel.Name = "ZipLabel";
            ZipLabel.Size = new Size(34, 20);
            ZipLabel.TabIndex = 19;
            ZipLabel.Text = "Zip:";
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(101, 419);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(163, 29);
            CreateButton.TabIndex = 21;
            CreateButton.Text = "Create Member";
            CreateButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(366, 416);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 29);
            ClearButton.TabIndex = 22;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // CreateMemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 469);
            Controls.Add(ClearButton);
            Controls.Add(CreateButton);
            Controls.Add(ZipTextBox);
            Controls.Add(ZipLabel);
            Controls.Add(StateTextBox);
            Controls.Add(StateLabel);
            Controls.Add(CityTextBox);
            Controls.Add(CityLabel);
            Controls.Add(Address2TextBox);
            Controls.Add(Address2Label);
            Controls.Add(Address1TextBox);
            Controls.Add(Address1Label);
            Controls.Add(SexComboBox);
            Controls.Add(SexLabel);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(DobDateTimePicker);
            Controls.Add(DobLabel);
            Controls.Add(LastNameTextBox);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameTextBox);
            Controls.Add(FirstNameLabel);
            Controls.Add(RegMemberLabel);
            Name = "CreateMemberForm";
            Text = "CreateMemberForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RegMemberLabel;
        private Label FirstNameLabel;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private Label LastNameLabel;
        private Label DobLabel;
        private DateTimePicker DobDateTimePicker;
        private TextBox PhoneNumberTextBox;
        private Label PhoneNumberLabel;
        private Label SexLabel;
        private ComboBox SexComboBox;
        private Label Address1Label;
        private TextBox Address1TextBox;
        private TextBox Address2TextBox;
        private Label Address2Label;
        private TextBox CityTextBox;
        private Label CityLabel;
        private TextBox StateTextBox;
        private Label StateLabel;
        private TextBox ZipTextBox;
        private Label ZipLabel;
        private Button CreateButton;
        private Button ClearButton;
    }
}