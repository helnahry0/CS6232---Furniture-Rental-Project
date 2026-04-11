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
            pnlBottom = new Panel();
            grpTransactions = new GroupBox();
            dgvRentalTransactions = new DataGridView();
            grpItems = new GroupBox();
            dgvRentalItems = new DataGridView();
            btnClose = new Button();
            pnlTop.SuspendLayout();
            pnlBottom.SuspendLayout();
            grpTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRentalTransactions).BeginInit();
            grpItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRentalItems).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(155, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Rental History";
            // 
            // lblMemberInfo
            // 
            lblMemberInfo.AutoSize = true;
            lblMemberInfo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMemberInfo.Location = new Point(22, 55);
            lblMemberInfo.Name = "lblMemberInfo";
            lblMemberInfo.Size = new Size(182, 19);
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
            pnlTop.Size = new Size(900, 110);
            pnlTop.TabIndex = 3;
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(grpItems);
            pnlBottom.Controls.Add(grpTransactions);
            pnlBottom.Controls.Add(btnClose);
            pnlBottom.Dock = DockStyle.Fill;
            pnlBottom.Location = new Point(0, 110);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(15);
            pnlBottom.Size = new Size(900, 490);
            pnlBottom.TabIndex = 4;
            // 
            // grpTransactions
            // 
            grpTransactions.Controls.Add(dgvRentalTransactions);
            grpTransactions.Location = new Point(18, 18);
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
            grpItems.Location = new Point(18, 215);
            grpItems.Name = "grpItems";
            grpItems.Size = new Size(864, 210);
            grpItems.TabIndex = 1;
            grpItems.TabStop = false;
            grpItems.Text = "Items in Selected Rental";
            // 
            // dgvRentalItems
            // 
            dgvRentalItems.AllowUserToAddRows = false;
            dgvRentalItems.AllowUserToDeleteRows = false;
            dgvRentalItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalItems.Dock = DockStyle.Fill;
            dgvRentalItems.Location = new Point(3, 19);
            dgvRentalItems.MultiSelect = false;
            dgvRentalItems.Name = "dgvRentalItems";
            dgvRentalItems.ReadOnly = true;
            dgvRentalItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRentalItems.Size = new Size(858, 188);
            dgvRentalItems.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(787, 440);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(95, 30);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // RentalHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(pnlBottom);
            Controls.Add(pnlTop);
            Name = "RentalHistoryForm";
            Text = "Rental History";
            StartPosition = FormStartPosition.CenterParent;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlBottom.ResumeLayout(false);
            grpTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRentalTransactions).EndInit();
            grpItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRentalItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblMemberInfo;
        private Label lblError;
        private Panel pnlTop;
        private Panel pnlBottom;
        private GroupBox grpTransactions;
        private DataGridView dgvRentalTransactions;
        private GroupBox grpItems;
        private DataGridView dgvRentalItems;
        private Button btnClose;
    }
}