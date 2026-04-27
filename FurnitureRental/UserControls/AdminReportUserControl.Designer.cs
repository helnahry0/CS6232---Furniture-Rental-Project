namespace FurnitureRental.UserControls
{
    partial class AdminReportUserControl
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
            lblReportTitle = new Label();
            lblStartDate = new Label();
            lblEndDate = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            btnGenerateReport = new Button();
            dgvReport = new DataGridView();
            btnExportCSV = new Button();
            btnExportPDF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // lblReportTitle
            // 
            lblReportTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblReportTitle.AutoSize = true;
            lblReportTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportTitle.Location = new Point(329, 22);
            lblReportTitle.Name = "lblReportTitle";
            lblReportTitle.Size = new Size(366, 32);
            lblReportTitle.TabIndex = 0;
            lblReportTitle.Text = "Most Popular Furniture Report";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStartDate.Location = new Point(150, 83);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(123, 20);
            lblStartDate.TabIndex = 1;
            lblStartDate.Text = "Select Start Date:";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEndDate.Location = new Point(479, 83);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(117, 20);
            lblEndDate.TabIndex = 2;
            lblEndDate.Text = "Select End Date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "yyyy-MM-dd";
            dtpStartDate.Font = new Font("Segoe UI", 9F);
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(285, 81);
            dtpStartDate.Margin = new Padding(3, 4, 3, 4);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(130, 27);
            dtpStartDate.TabIndex = 3;
            // 
            // dtpEndDate
            // 
            dtpEndDate.CustomFormat = "yyyy-MM-dd";
            dtpEndDate.Font = new Font("Segoe UI", 9F);
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(606, 81);
            dtpEndDate.Margin = new Padding(3, 4, 3, 4);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(125, 27);
            dtpEndDate.TabIndex = 4;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerateReport.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateReport.Location = new Point(782, 74);
            btnGenerateReport.Margin = new Padding(3, 4, 3, 4);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(170, 43);
            btnGenerateReport.TabIndex = 5;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // dgvReport
            // 
            dgvReport.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(17, 201);
            dgvReport.Margin = new Padding(3, 4, 3, 4);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(992, 335);
            dgvReport.TabIndex = 6;
            // 
            // btnExportCSV
            // 
            btnExportCSV.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportCSV.Location = new Point(339, 145);
            btnExportCSV.Margin = new Padding(3, 4, 3, 4);
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.Size = new Size(146, 35);
            btnExportCSV.TabIndex = 7;
            btnExportCSV.Text = "Export CSV";
            btnExportCSV.UseVisualStyleBackColor = true;
            btnExportCSV.Click += btnExportCSV_Click;
            // 
            // btnExportPDF
            // 
            btnExportPDF.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportPDF.Location = new Point(539, 145);
            btnExportPDF.Margin = new Padding(3, 4, 3, 4);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(123, 35);
            btnExportPDF.TabIndex = 8;
            btnExportPDF.Text = "Export PDF";
            btnExportPDF.UseVisualStyleBackColor = true;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // AdminReportUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnExportPDF);
            Controls.Add(btnExportCSV);
            Controls.Add(dgvReport);
            Controls.Add(btnGenerateReport);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(lblReportTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminReportUserControl";
            Size = new Size(1026, 564);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReportTitle;
        private Label lblStartDate;
        private Label lblEndDate;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Button btnGenerateReport;
        private DataGridView dgvReport;
        private Button btnExportCSV;
        private Button btnExportPDF;
    }
}
