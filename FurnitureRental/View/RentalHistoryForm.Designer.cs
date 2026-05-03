namespace FurnitureRental.View
{
    partial class RentalHistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Cleans up any resources being used.
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

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblMemberInfo = new Label();
            lblError = new Label();
            pnlTop = new Panel();
            tblMain = new TableLayoutPanel();
            grpTransactions = new GroupBox();
            dgvRentalTransactions = new DataGridView();
            grpItems = new GroupBox();
            dgvRentalItems = new DataGridView();
            pnlFooter = new Panel();
            btnClose = new Button();
            pnlTop.SuspendLayout();
            tblMain.SuspendLayout();
            grpTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRentalTransactions).BeginInit();
            grpItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRentalItems).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(161, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Rental History";
            // 
            // lblMemberInfo
            // 
            lblMemberInfo.AutoSize = true;
            lblMemberInfo.Font = new Font("Segoe UI", 10F);
            lblMemberInfo.Location = new Point(22, 55);
            lblMemberInfo.Name = "lblMemberInfo";
            lblMemberInfo.Size = new Size(181, 19);
            lblMemberInfo.TabIndex = 1;
            lblMemberInfo.Text = "Rental History for Member...";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(22, 82);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 2;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Controls.Add(lblMemberInfo);
            pnlTop.Controls.Add(lblError);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Padding = new Padding(15);
            pnlTop.Size = new Size(900, 110);
            pnlTop.TabIndex = 0;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(grpTransactions, 0, 0);
            tblMain.Controls.Add(grpItems, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 110);
            tblMain.Name = "tblMain";
            tblMain.Padding = new Padding(15, 10, 15, 10);
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tblMain.Size = new Size(900, 435);
            tblMain.TabIndex = 1;
            // 
            // grpTransactions
            // 
            grpTransactions.Controls.Add(dgvRentalTransactions);
            grpTransactions.Dock = DockStyle.Fill;
            grpTransactions.Location = new Point(18, 13);
            grpTransactions.Name = "grpTransactions";
            grpTransactions.Size = new Size(864, 180);
            grpTransactions.TabIndex = 0;
            grpTransactions.TabStop = false;
            grpTransactions.Text = "Rental Transactions";
            // 
            // dgvRentalTransactions
            // 
            dgvRentalTransactions.AllowUserToAddRows = false;
            dgvRentalTransactions.AllowUserToDeleteRows = false;
            dgvRentalTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRentalTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalTransactions.Dock = DockStyle.Fill;
            dgvRentalTransactions.Location = new Point(3, 19);
            dgvRentalTransactions.MultiSelect = false;
            dgvRentalTransactions.Name = "dgvRentalTransactions";
            dgvRentalTransactions.ReadOnly = true;
            dgvRentalTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRentalTransactions.Size = new Size(858, 158);
            dgvRentalTransactions.TabIndex = 0;
            dgvRentalTransactions.SelectionChanged += dgvRentalTransactions_SelectionChanged;
            // 
            // grpItems
            // 
            grpItems.Controls.Add(dgvRentalItems);
            grpItems.Dock = DockStyle.Fill;
            grpItems.Location = new Point(18, 199);
            grpItems.Name = "grpItems";
            grpItems.Size = new Size(864, 223);
            grpItems.TabIndex = 1;
            grpItems.TabStop = false;
            grpItems.Text = "Items in Selected Rental";
            // 
            // dgvRentalItems
            // 
            dgvRentalItems.AllowUserToAddRows = false;
            dgvRentalItems.AllowUserToDeleteRows = false;
            dgvRentalItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRentalItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalItems.Dock = DockStyle.Fill;
            dgvRentalItems.Location = new Point(3, 19);
            dgvRentalItems.MultiSelect = false;
            dgvRentalItems.Name = "dgvRentalItems";
            dgvRentalItems.ReadOnly = true;
            dgvRentalItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRentalItems.Size = new Size(858, 201);
            dgvRentalItems.TabIndex = 0;
            // 
            // pnlFooter
            // 
            pnlFooter.Controls.Add(btnClose);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 545);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Padding = new Padding(15, 10, 15, 10);
            pnlFooter.Size = new Size(900, 55);
            pnlFooter.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(790, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(95, 30);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // RentalHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(tblMain);
            Controls.Add(pnlFooter);
            Controls.Add(pnlTop);
            MinimumSize = new Size(800, 550);
            Name = "RentalHistoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Rental History";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            tblMain.ResumeLayout(false);
            grpTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRentalTransactions).EndInit();
            grpItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRentalItems).EndInit();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblMemberInfo;
        private Label lblError;
        private Panel pnlTop;
        private TableLayoutPanel tblMain;
        private GroupBox grpTransactions;
        private DataGridView dgvRentalTransactions;
        private GroupBox grpItems;
        private DataGridView dgvRentalItems;
        private Panel pnlFooter;
        private Button btnClose;
    }
}