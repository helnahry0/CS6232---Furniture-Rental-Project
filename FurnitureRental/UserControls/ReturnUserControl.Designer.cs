namespace FurnitureRental.UserControls
{
    partial class ReturnUserControl
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
            ReturnCartLabel = new Label();
            ReturnDataGridView = new DataGridView();
            SummaryTitleLabel = new Label();
            panel1 = new Panel();
            SearchOrderIdButton = new Button();
            textBox1 = new TextBox();
            SearchRentalIdButton = new Button();
            RentalIdTextBox = new TextBox();
            SearchMemberButton = new Button();
            MemberIDTextBox = new TextBox();
            OrderIDLabel = new Label();
            RentalIDLabel = new Label();
            MemberIdLabel = new Label();
            panel2 = new Panel();
            DayFeesCalculatedLabel = new Label();
            ActiveFinesLabel = new Label();
            EarlyReturnRefundLabel = new Label();
            ActiveBaseCostLabel = new Label();
            BaseCostLabel = new Label();
            FinesLabel = new Label();
            EarlyReturnLabel = new Label();
            BreakdownLabel = new Label();
            AmtDueLabel = new Label();
            ActiveRefundLabel = new Label();
            RefundLabel = new Label();
            DueDateTimePicker = new DateTimePicker();
            ActiveStatusLabel = new Label();
            ActiveOrderIdLabel = new Label();
            ReturnDateLabel = new Label();
            StatusLabel = new Label();
            OrderLabel = new Label();
            OrderSummaryLabel = new Label();
            panel3 = new Panel();
            EmployeeIDLabel = new Label();
            DueDateLabel = new Label();
            RentalDateLabel = new Label();
            RentalInfoLabel = new Label();
            ProcessReturnButton = new Button();
            ClearButton = new Button();
            ActiveRentalDateLabel = new Label();
            ActiveDueDateLabel = new Label();
            ActiveEmployeeIdLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ReturnDataGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // ReturnCartLabel
            // 
            ReturnCartLabel.AutoSize = true;
            ReturnCartLabel.Location = new Point(27, 31);
            ReturnCartLabel.Name = "ReturnCartLabel";
            ReturnCartLabel.Size = new Size(81, 20);
            ReturnCartLabel.TabIndex = 0;
            ReturnCartLabel.Text = "Return cart";
            // 
            // ReturnDataGridView
            // 
            ReturnDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReturnDataGridView.Location = new Point(535, 43);
            ReturnDataGridView.Name = "ReturnDataGridView";
            ReturnDataGridView.RowHeadersWidth = 51;
            ReturnDataGridView.Size = new Size(633, 442);
            ReturnDataGridView.TabIndex = 1;
            // 
            // SummaryTitleLabel
            // 
            SummaryTitleLabel.AutoSize = true;
            SummaryTitleLabel.Location = new Point(535, 20);
            SummaryTitleLabel.Name = "SummaryTitleLabel";
            SummaryTitleLabel.Size = new Size(171, 20);
            SummaryTitleLabel.TabIndex = 2;
            SummaryTitleLabel.Text = "RENTAL ID. X SUMMARY";
            // 
            // panel1
            // 
            panel1.Controls.Add(SearchOrderIdButton);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(SearchRentalIdButton);
            panel1.Controls.Add(RentalIdTextBox);
            panel1.Controls.Add(SearchMemberButton);
            panel1.Controls.Add(MemberIDTextBox);
            panel1.Controls.Add(OrderIDLabel);
            panel1.Controls.Add(RentalIDLabel);
            panel1.Controls.Add(MemberIdLabel);
            panel1.Location = new Point(27, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 202);
            panel1.TabIndex = 3;
            // 
            // SearchOrderIdButton
            // 
            SearchOrderIdButton.Location = new Point(278, 130);
            SearchOrderIdButton.Name = "SearchOrderIdButton";
            SearchOrderIdButton.Size = new Size(146, 29);
            SearchOrderIdButton.TabIndex = 8;
            SearchOrderIdButton.Text = "Search Order";
            SearchOrderIdButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 27);
            textBox1.TabIndex = 7;
            // 
            // SearchRentalIdButton
            // 
            SearchRentalIdButton.Location = new Point(278, 82);
            SearchRentalIdButton.Name = "SearchRentalIdButton";
            SearchRentalIdButton.Size = new Size(146, 29);
            SearchRentalIdButton.TabIndex = 6;
            SearchRentalIdButton.Text = "Search Rental";
            SearchRentalIdButton.UseVisualStyleBackColor = true;
            // 
            // RentalIdTextBox
            // 
            RentalIdTextBox.Location = new Point(97, 83);
            RentalIdTextBox.Name = "RentalIdTextBox";
            RentalIdTextBox.Size = new Size(155, 27);
            RentalIdTextBox.TabIndex = 5;
            // 
            // SearchMemberButton
            // 
            SearchMemberButton.Location = new Point(278, 36);
            SearchMemberButton.Name = "SearchMemberButton";
            SearchMemberButton.Size = new Size(146, 29);
            SearchMemberButton.TabIndex = 4;
            SearchMemberButton.Text = "SEARCH MEMBER";
            SearchMemberButton.UseVisualStyleBackColor = true;
            // 
            // MemberIDTextBox
            // 
            MemberIDTextBox.Location = new Point(97, 36);
            MemberIDTextBox.Name = "MemberIDTextBox";
            MemberIDTextBox.Size = new Size(155, 27);
            MemberIDTextBox.TabIndex = 3;
            // 
            // OrderIDLabel
            // 
            OrderIDLabel.AutoSize = true;
            OrderIDLabel.Location = new Point(22, 133);
            OrderIDLabel.Name = "OrderIDLabel";
            OrderIDLabel.Size = new Size(69, 20);
            OrderIDLabel.TabIndex = 2;
            OrderIDLabel.Text = "Order ID:";
            // 
            // RentalIDLabel
            // 
            RentalIDLabel.AutoSize = true;
            RentalIDLabel.Location = new Point(18, 86);
            RentalIDLabel.Name = "RentalIDLabel";
            RentalIDLabel.Size = new Size(73, 20);
            RentalIDLabel.TabIndex = 1;
            RentalIDLabel.Text = "Rental ID:";
            // 
            // MemberIdLabel
            // 
            MemberIdLabel.AutoSize = true;
            MemberIdLabel.Location = new Point(4, 39);
            MemberIdLabel.Name = "MemberIdLabel";
            MemberIdLabel.Size = new Size(87, 20);
            MemberIdLabel.TabIndex = 0;
            MemberIdLabel.Text = "Member ID:";
            // 
            // panel2
            // 
            panel2.Controls.Add(DayFeesCalculatedLabel);
            panel2.Controls.Add(ActiveFinesLabel);
            panel2.Controls.Add(EarlyReturnRefundLabel);
            panel2.Controls.Add(ActiveBaseCostLabel);
            panel2.Controls.Add(BaseCostLabel);
            panel2.Controls.Add(FinesLabel);
            panel2.Controls.Add(EarlyReturnLabel);
            panel2.Controls.Add(BreakdownLabel);
            panel2.Controls.Add(AmtDueLabel);
            panel2.Controls.Add(ActiveRefundLabel);
            panel2.Controls.Add(RefundLabel);
            panel2.Controls.Add(DueDateTimePicker);
            panel2.Controls.Add(ActiveStatusLabel);
            panel2.Controls.Add(ActiveOrderIdLabel);
            panel2.Controls.Add(ReturnDateLabel);
            panel2.Controls.Add(StatusLabel);
            panel2.Controls.Add(OrderLabel);
            panel2.Location = new Point(27, 303);
            panel2.Name = "panel2";
            panel2.Size = new Size(468, 327);
            panel2.TabIndex = 4;
            // 
            // DayFeesCalculatedLabel
            // 
            DayFeesCalculatedLabel.AutoSize = true;
            DayFeesCalculatedLabel.ForeColor = Color.IndianRed;
            DayFeesCalculatedLabel.Location = new Point(43, 135);
            DayFeesCalculatedLabel.Name = "DayFeesCalculatedLabel";
            DayFeesCalculatedLabel.Size = new Size(261, 20);
            DayFeesCalculatedLabel.TabIndex = 16;
            DayFeesCalculatedLabel.Text = "On Time ||  X Days Early ||  X days Late";
            // 
            // ActiveFinesLabel
            // 
            ActiveFinesLabel.AutoSize = true;
            ActiveFinesLabel.Location = new Point(114, 293);
            ActiveFinesLabel.Name = "ActiveFinesLabel";
            ActiveFinesLabel.Size = new Size(199, 20);
            ActiveFinesLabel.TabIndex = 15;
            ActiveFinesLabel.Text = "+(Days Late By * Price(Rate))";
            // 
            // EarlyReturnRefundLabel
            // 
            EarlyReturnRefundLabel.AutoSize = true;
            EarlyReturnRefundLabel.Location = new Point(114, 261);
            EarlyReturnRefundLabel.Name = "EarlyReturnRefundLabel";
            EarlyReturnRefundLabel.Size = new Size(199, 20);
            EarlyReturnRefundLabel.TabIndex = 14;
            EarlyReturnRefundLabel.Text = "-(Days Early By * Price(Rate))";
            // 
            // ActiveBaseCostLabel
            // 
            ActiveBaseCostLabel.AutoSize = true;
            ActiveBaseCostLabel.Location = new Point(114, 226);
            ActiveBaseCostLabel.Name = "ActiveBaseCostLabel";
            ActiveBaseCostLabel.Size = new Size(186, 20);
            ActiveBaseCostLabel.TabIndex = 13;
            ActiveBaseCostLabel.Text = "Price (Rate) * Days booked";
            // 
            // BaseCostLabel
            // 
            BaseCostLabel.AutoSize = true;
            BaseCostLabel.Location = new Point(27, 225);
            BaseCostLabel.Name = "BaseCostLabel";
            BaseCostLabel.Size = new Size(80, 20);
            BaseCostLabel.TabIndex = 12;
            BaseCostLabel.Text = "Base Cost :";
            // 
            // FinesLabel
            // 
            FinesLabel.AutoSize = true;
            FinesLabel.ForeColor = Color.Red;
            FinesLabel.Location = new Point(58, 292);
            FinesLabel.Name = "FinesLabel";
            FinesLabel.Size = new Size(49, 20);
            FinesLabel.TabIndex = 11;
            FinesLabel.Text = "Fines :";
            // 
            // EarlyReturnLabel
            // 
            EarlyReturnLabel.AutoSize = true;
            EarlyReturnLabel.Location = new Point(12, 259);
            EarlyReturnLabel.Name = "EarlyReturnLabel";
            EarlyReturnLabel.Size = new Size(95, 20);
            EarlyReturnLabel.TabIndex = 10;
            EarlyReturnLabel.Text = "Early Return :";
            // 
            // BreakdownLabel
            // 
            BreakdownLabel.AutoSize = true;
            BreakdownLabel.Location = new Point(17, 196);
            BreakdownLabel.Name = "BreakdownLabel";
            BreakdownLabel.Size = new Size(90, 20);
            BreakdownLabel.TabIndex = 9;
            BreakdownLabel.Text = "Breakdown :";
            // 
            // AmtDueLabel
            // 
            AmtDueLabel.AutoSize = true;
            AmtDueLabel.ForeColor = Color.Red;
            AmtDueLabel.Location = new Point(346, 168);
            AmtDueLabel.Name = "AmtDueLabel";
            AmtDueLabel.Size = new Size(105, 20);
            AmtDueLabel.TabIndex = 8;
            AmtDueLabel.Text = "AMOUNT DUE";
            // 
            // ActiveRefundLabel
            // 
            ActiveRefundLabel.AutoSize = true;
            ActiveRefundLabel.Location = new Point(159, 168);
            ActiveRefundLabel.Name = "ActiveRefundLabel";
            ActiveRefundLabel.Size = new Size(64, 20);
            ActiveRefundLabel.TabIndex = 7;
            ActiveRefundLabel.Text = "$ refund";
            // 
            // RefundLabel
            // 
            RefundLabel.AutoSize = true;
            RefundLabel.Location = new Point(18, 168);
            RefundLabel.Name = "RefundLabel";
            RefundLabel.Size = new Size(120, 20);
            RefundLabel.TabIndex = 6;
            RefundLabel.Text = "Refund Amount :";
            // 
            // DueDateTimePicker
            // 
            DueDateTimePicker.Format = DateTimePickerFormat.Short;
            DueDateTimePicker.Location = new Point(159, 102);
            DueDateTimePicker.Name = "DueDateTimePicker";
            DueDateTimePicker.Size = new Size(250, 27);
            DueDateTimePicker.TabIndex = 5;
            // 
            // ActiveStatusLabel
            // 
            ActiveStatusLabel.AutoSize = true;
            ActiveStatusLabel.Location = new Point(159, 68);
            ActiveStatusLabel.Name = "ActiveStatusLabel";
            ActiveStatusLabel.Size = new Size(117, 20);
            ActiveStatusLabel.TabIndex = 4;
            ActiveStatusLabel.Text = "Out, Out-Late, In";
            // 
            // ActiveOrderIdLabel
            // 
            ActiveOrderIdLabel.AutoSize = true;
            ActiveOrderIdLabel.Location = new Point(159, 31);
            ActiveOrderIdLabel.Name = "ActiveOrderIdLabel";
            ActiveOrderIdLabel.Size = new Size(135, 20);
            ActiveOrderIdLabel.TabIndex = 3;
            ActiveOrderIdLabel.Text = "Order number here";
            // 
            // ReturnDateLabel
            // 
            ReturnDateLabel.AutoSize = true;
            ReturnDateLabel.Location = new Point(43, 106);
            ReturnDateLabel.Name = "ReturnDateLabel";
            ReturnDateLabel.Size = new Size(95, 20);
            ReturnDateLabel.TabIndex = 2;
            ReturnDateLabel.Text = "Return Date :";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(82, 68);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(56, 20);
            StatusLabel.TabIndex = 1;
            StatusLabel.Text = "Status :";
            // 
            // OrderLabel
            // 
            OrderLabel.AutoSize = true;
            OrderLabel.Location = new Point(65, 31);
            OrderLabel.Name = "OrderLabel";
            OrderLabel.Size = new Size(73, 20);
            OrderLabel.TabIndex = 0;
            OrderLabel.Text = "Order ID :";
            // 
            // OrderSummaryLabel
            // 
            OrderSummaryLabel.AutoSize = true;
            OrderSummaryLabel.Location = new Point(31, 277);
            OrderSummaryLabel.Name = "OrderSummaryLabel";
            OrderSummaryLabel.Size = new Size(113, 20);
            OrderSummaryLabel.TabIndex = 0;
            OrderSummaryLabel.Text = "Order Summary";
            // 
            // panel3
            // 
            panel3.Controls.Add(ActiveEmployeeIdLabel);
            panel3.Controls.Add(ActiveDueDateLabel);
            panel3.Controls.Add(ActiveRentalDateLabel);
            panel3.Controls.Add(EmployeeIDLabel);
            panel3.Controls.Add(DueDateLabel);
            panel3.Controls.Add(RentalDateLabel);
            panel3.Controls.Add(RentalInfoLabel);
            panel3.Location = new Point(535, 495);
            panel3.Name = "panel3";
            panel3.Size = new Size(633, 125);
            panel3.TabIndex = 5;
            // 
            // EmployeeIDLabel
            // 
            EmployeeIDLabel.AutoSize = true;
            EmployeeIDLabel.Location = new Point(7, 84);
            EmployeeIDLabel.Name = "EmployeeIDLabel";
            EmployeeIDLabel.Size = new Size(101, 20);
            EmployeeIDLabel.TabIndex = 3;
            EmployeeIDLabel.Text = "Employee ID :";
            // 
            // DueDateLabel
            // 
            DueDateLabel.AutoSize = true;
            DueDateLabel.Location = new Point(29, 59);
            DueDateLabel.Name = "DueDateLabel";
            DueDateLabel.Size = new Size(79, 20);
            DueDateLabel.TabIndex = 2;
            DueDateLabel.Text = "Due Date :";
            // 
            // RentalDateLabel
            // 
            RentalDateLabel.AutoSize = true;
            RentalDateLabel.Location = new Point(14, 34);
            RentalDateLabel.Name = "RentalDateLabel";
            RentalDateLabel.Size = new Size(94, 20);
            RentalDateLabel.TabIndex = 1;
            RentalDateLabel.Text = "Rental Date :";
            // 
            // RentalInfoLabel
            // 
            RentalInfoLabel.AutoSize = true;
            RentalInfoLabel.Location = new Point(8, 7);
            RentalInfoLabel.Name = "RentalInfoLabel";
            RentalInfoLabel.Size = new Size(81, 20);
            RentalInfoLabel.TabIndex = 0;
            RentalInfoLabel.Text = "Rental Info";
            // 
            // ProcessReturnButton
            // 
            ProcessReturnButton.Location = new Point(322, 648);
            ProcessReturnButton.Name = "ProcessReturnButton";
            ProcessReturnButton.Size = new Size(173, 29);
            ProcessReturnButton.TabIndex = 17;
            ProcessReturnButton.Text = "Process Return";
            ProcessReturnButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(401, 22);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 29);
            ClearButton.TabIndex = 18;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // ActiveRentalDateLabel
            // 
            ActiveRentalDateLabel.AutoSize = true;
            ActiveRentalDateLabel.Location = new Point(118, 33);
            ActiveRentalDateLabel.Name = "ActiveRentalDateLabel";
            ActiveRentalDateLabel.Size = new Size(50, 20);
            ActiveRentalDateLabel.TabIndex = 4;
            ActiveRentalDateLabel.Text = "label1";
            // 
            // ActiveDueDateLabel
            // 
            ActiveDueDateLabel.AutoSize = true;
            ActiveDueDateLabel.Location = new Point(118, 61);
            ActiveDueDateLabel.Name = "ActiveDueDateLabel";
            ActiveDueDateLabel.Size = new Size(50, 20);
            ActiveDueDateLabel.TabIndex = 5;
            ActiveDueDateLabel.Text = "label2";
            // 
            // ActiveEmployeeIdLabel
            // 
            ActiveEmployeeIdLabel.AutoSize = true;
            ActiveEmployeeIdLabel.Location = new Point(118, 84);
            ActiveEmployeeIdLabel.Name = "ActiveEmployeeIdLabel";
            ActiveEmployeeIdLabel.Size = new Size(292, 20);
            ActiveEmployeeIdLabel.TabIndex = 6;
            ActiveEmployeeIdLabel.Text = "ID of employee responsible for transaction";
            // 
            // ReturnUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ClearButton);
            Controls.Add(ProcessReturnButton);
            Controls.Add(panel3);
            Controls.Add(OrderSummaryLabel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(SummaryTitleLabel);
            Controls.Add(ReturnDataGridView);
            Controls.Add(ReturnCartLabel);
            Name = "ReturnUserControl";
            Size = new Size(1200, 707);
            Load += ReturnUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)ReturnDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ReturnCartLabel;
        private DataGridView ReturnDataGridView;
        private Label SummaryTitleLabel;
        private Panel panel1;
        private Label OrderIDLabel;
        private Label RentalIDLabel;
        private Label MemberIdLabel;
        private Button SearchMemberButton;
        private TextBox MemberIDTextBox;
        private TextBox RentalIdTextBox;
        private Button SearchOrderIdButton;
        private TextBox textBox1;
        private Button SearchRentalIdButton;
        private Panel panel2;
        private Label OrderSummaryLabel;
        private Label StatusLabel;
        private Label OrderLabel;
        private Label ReturnDateLabel;
        private Label ActiveStatusLabel;
        private Label ActiveOrderIdLabel;
        private DateTimePicker DueDateTimePicker;
        private Label RefundLabel;
        private Label BaseCostLabel;
        private Label FinesLabel;
        private Label EarlyReturnLabel;
        private Label BreakdownLabel;
        private Label AmtDueLabel;
        private Label ActiveRefundLabel;
        private Label ActiveFinesLabel;
        private Label EarlyReturnRefundLabel;
        private Label ActiveBaseCostLabel;
        private Panel panel3;
        private Label EmployeeIDLabel;
        private Label DueDateLabel;
        private Label RentalDateLabel;
        private Label RentalInfoLabel;
        private Label DayFeesCalculatedLabel;
        private Button ProcessReturnButton;
        private Button ClearButton;
        private Label ActiveEmployeeIdLabel;
        private Label ActiveDueDateLabel;
        private Label ActiveRentalDateLabel;
    }
}
