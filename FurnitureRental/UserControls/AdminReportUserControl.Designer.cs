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
            lblReportTitle.AutoSize = true;
            lblReportTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportTitle.Location = new Point(274, 11);
            lblReportTitle.Name = "lblReportTitle";
            lblReportTitle.Size = new Size(288, 25);
            lblReportTitle.TabIndex = 0;
            lblReportTitle.Text = "Most Popular Furniture Report";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStartDate.Location = new Point(107, 61);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(95, 15);
            lblStartDate.TabIndex = 1;
            lblStartDate.Text = "Select Start Date:";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEndDate.Location = new Point(351, 62);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(91, 15);
            lblEndDate.TabIndex = 2;
            lblEndDate.Text = "Select End Date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "yyyy-MM-dd";
            dtpStartDate.Font = new Font("Segoe UI", 9F);
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(210, 58);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(114, 23);
            dtpStartDate.TabIndex = 3;
            // 
            // dtpEndDate
            // 
            dtpEndDate.CustomFormat = "yyyy-MM-dd";
            dtpEndDate.Font = new Font("Segoe UI", 9F);
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(452, 58);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(110, 23);
            dtpEndDate.TabIndex = 4;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateReport.Location = new Point(590, 54);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(149, 32);
            btnGenerateReport.TabIndex = 5;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(15, 151);
            dgvReport.Name = "dgvReport";
            dgvReport.Size = new Size(873, 251);
            dgvReport.TabIndex = 6;
            // 
            // btnExportCSV
            // 
            btnExportCSV.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportCSV.Location = new Point(263, 108);
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.Size = new Size(128, 25);
            btnExportCSV.TabIndex = 7;
            btnExportCSV.Text = "Export CSV";
            btnExportCSV.UseVisualStyleBackColor = true;
            btnExportCSV.Click += btnExportCSV_Click;
            // 
            // btnExportPDF
            // 
            btnExportPDF.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportPDF.Location = new Point(438, 108);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(108, 26);
            btnExportPDF.TabIndex = 8;
            btnExportPDF.Text = "Export PDF";
            btnExportPDF.UseVisualStyleBackColor = true;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // AdminReportUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Name = "AdminReportUserControl";
            Size = new Size(898, 423);
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
