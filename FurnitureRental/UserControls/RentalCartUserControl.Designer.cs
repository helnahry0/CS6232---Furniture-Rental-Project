namespace FurnitureRental.UserControls
{
    partial class RentalCartUserControl
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
            lblRentalCart = new Label();
            lblDueDate = new Label();
            lblCustomer = new Label();
            lblEmployee = new Label();
            txtMemberName = new TextBox();
            dtpDueDate = new DateTimePicker();
            lblEmployeeName = new Label();
            grpShoppingCart = new GroupBox();
            btnEmptyCart = new Button();
            btnRemoveSelected = new Button();
            btnUpdateQty = new Button();
            numQty = new NumericUpDown();
            lblSelectedQty = new Label();
            dgvCart = new DataGridView();
            grpOrderSummary = new GroupBox();
            lblDays = new Label();
            lblRentalDays = new Label();
            TotalItemCountLabel = new Label();
            TotalQtyLabel = new Label();
            btnCancel = new Button();
            btnSubmitRental = new Button();
            lblTotal = new Label();
            lblSubtotal = new Label();
            lblItemCount = new Label();
            lblTotalTitle = new Label();
            lblSubttotalTitle = new Label();
            lblItemCountTitle = new Label();
            lblReturnDate = new Label();
            dtpRentalDate = new DateTimePicker();
            txtMemID = new TextBox();
            btnMemberSearch = new Button();
            grpShoppingCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            grpOrderSummary.SuspendLayout();
            SuspendLayout();
            // 
            // lblRentalCart
            // 
            lblRentalCart.AutoSize = true;
            lblRentalCart.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalCart.Location = new Point(23, 10);
            lblRentalCart.Name = "lblRentalCart";
            lblRentalCart.Size = new Size(137, 32);
            lblRentalCart.TabIndex = 1;
            lblRentalCart.Text = "Rental Cart";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(31, 99);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(70, 15);
            lblDueDate.TabIndex = 3;
            lblDueDate.Text = "Rental Date:";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomer.Location = new Point(314, 56);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(107, 17);
            lblCustomer.TabIndex = 4;
            lblCustomer.Text = "Customer Name";
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(443, 99);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(62, 15);
            lblEmployee.TabIndex = 5;
            lblEmployee.Text = "Employee:";
            // 
            // txtMemberName
            // 
            txtMemberName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMemberName.Location = new Point(427, 52);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.ReadOnly = true;
            txtMemberName.Size = new Size(185, 25);
            txtMemberName.TabIndex = 6;
            // 
            // dtpDueDate
            // 
            dtpDueDate.CustomFormat = "yyyy-MM-dd";
            dtpDueDate.Format = DateTimePickerFormat.Custom;
            dtpDueDate.Location = new Point(318, 94);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(105, 23);
            dtpDueDate.TabIndex = 9;
            dtpDueDate.ValueChanged += dtpDueDate_ValueChanged;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Location = new Point(527, 99);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(59, 15);
            lblEmployeeName.TabIndex = 11;
            lblEmployeeName.Text = "employee";
            // 
            // grpShoppingCart
            // 
            grpShoppingCart.Controls.Add(btnEmptyCart);
            grpShoppingCart.Controls.Add(btnRemoveSelected);
            grpShoppingCart.Controls.Add(btnUpdateQty);
            grpShoppingCart.Controls.Add(numQty);
            grpShoppingCart.Controls.Add(lblSelectedQty);
            grpShoppingCart.Controls.Add(dgvCart);
            grpShoppingCart.Location = new Point(23, 129);
            grpShoppingCart.Name = "grpShoppingCart";
            grpShoppingCart.Size = new Size(598, 265);
            grpShoppingCart.TabIndex = 16;
            grpShoppingCart.TabStop = false;
            grpShoppingCart.Text = "Shopping Cart";
            // 
            // btnEmptyCart
            // 
            btnEmptyCart.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEmptyCart.Location = new Point(394, 236);
            btnEmptyCart.Name = "btnEmptyCart";
            btnEmptyCart.Size = new Size(75, 23);
            btnEmptyCart.TabIndex = 5;
            btnEmptyCart.Text = "Empty Cart";
            btnEmptyCart.UseVisualStyleBackColor = true;
            btnEmptyCart.Click += btnEmptyCart_Click;
            // 
            // btnRemoveSelected
            // 
            btnRemoveSelected.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnRemoveSelected.Location = new Point(230, 236);
            btnRemoveSelected.Name = "btnRemoveSelected";
            btnRemoveSelected.Size = new Size(120, 23);
            btnRemoveSelected.TabIndex = 4;
            btnRemoveSelected.Text = "Remove Selected";
            btnRemoveSelected.UseVisualStyleBackColor = true;
            btnRemoveSelected.Click += btnRemoveSelected_Click;
            // 
            // btnUpdateQty
            // 
            btnUpdateQty.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUpdateQty.Location = new Point(66, 236);
            btnUpdateQty.Name = "btnUpdateQty";
            btnUpdateQty.Size = new Size(108, 23);
            btnUpdateQty.TabIndex = 3;
            btnUpdateQty.Text = "Update Quantity";
            btnUpdateQty.UseVisualStyleBackColor = true;
            btnUpdateQty.Click += btnUpdateQty_Click;
            // 
            // numQty
            // 
            numQty.Location = new Point(229, 200);
            numQty.Name = "numQty";
            numQty.Size = new Size(66, 23);
            numQty.TabIndex = 2;
            // 
            // lblSelectedQty
            // 
            lblSelectedQty.AutoSize = true;
            lblSelectedQty.Location = new Point(66, 202);
            lblSelectedQty.Name = "lblSelectedQty";
            lblSelectedQty.Size = new Size(130, 15);
            lblSelectedQty.TabIndex = 1;
            lblSelectedQty.Text = "Selected Item Quantity:";
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(15, 22);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(564, 166);
            dgvCart.TabIndex = 0;
            // 
            // grpOrderSummary
            // 
            grpOrderSummary.Controls.Add(lblDays);
            grpOrderSummary.Controls.Add(lblRentalDays);
            grpOrderSummary.Controls.Add(TotalItemCountLabel);
            grpOrderSummary.Controls.Add(TotalQtyLabel);
            grpOrderSummary.Controls.Add(btnCancel);
            grpOrderSummary.Controls.Add(btnSubmitRental);
            grpOrderSummary.Controls.Add(lblTotal);
            grpOrderSummary.Controls.Add(lblSubtotal);
            grpOrderSummary.Controls.Add(lblItemCount);
            grpOrderSummary.Controls.Add(lblTotalTitle);
            grpOrderSummary.Controls.Add(lblSubttotalTitle);
            grpOrderSummary.Controls.Add(lblItemCountTitle);
            grpOrderSummary.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpOrderSummary.Location = new Point(23, 400);
            grpOrderSummary.Name = "grpOrderSummary";
            grpOrderSummary.Size = new Size(598, 136);
            grpOrderSummary.TabIndex = 18;
            grpOrderSummary.TabStop = false;
            grpOrderSummary.Text = "Order Summary";
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Location = new Point(182, 73);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(14, 15);
            lblDays.TabIndex = 11;
            lblDays.Text = "0";
            // 
            // lblRentalDays
            // 
            lblRentalDays.AutoSize = true;
            lblRentalDays.Location = new Point(31, 73);
            lblRentalDays.Name = "lblRentalDays";
            lblRentalDays.Size = new Size(105, 15);
            lblRentalDays.TabIndex = 10;
            lblRentalDays.Text = "No. of Rental Days";
            // 
            // TotalItemCountLabel
            // 
            TotalItemCountLabel.AutoSize = true;
            TotalItemCountLabel.Location = new Point(418, 26);
            TotalItemCountLabel.Name = "TotalItemCountLabel";
            TotalItemCountLabel.Size = new Size(118, 15);
            TotalItemCountLabel.TabIndex = 9;
            TotalItemCountLabel.Text = "TotalItemCountLabel";
            // 
            // TotalQtyLabel
            // 
            TotalQtyLabel.AutoSize = true;
            TotalQtyLabel.Location = new Point(278, 26);
            TotalQtyLabel.Name = "TotalQtyLabel";
            TotalQtyLabel.Size = new Size(104, 15);
            TotalQtyLabel.TabIndex = 8;
            TotalQtyLabel.Text = "Total Qty of items:";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCancel.Location = new Point(504, 72);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmitRental
            // 
            btnSubmitRental.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSubmitRental.Location = new Point(325, 72);
            btnSubmitRental.Name = "btnSubmitRental";
            btnSubmitRental.Size = new Size(161, 23);
            btnSubmitRental.TabIndex = 6;
            btnSubmitRental.Text = "Submit Rental Transaction";
            btnSubmitRental.UseVisualStyleBackColor = true;
            btnSubmitRental.Click += btnSubmitRental_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(182, 96);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "$0.00";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(182, 51);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(38, 15);
            lblSubtotal.TabIndex = 4;
            lblSubtotal.Text = "$0.00";
            // 
            // lblItemCount
            // 
            lblItemCount.AutoSize = true;
            lblItemCount.Location = new Point(182, 26);
            lblItemCount.Name = "lblItemCount";
            lblItemCount.Size = new Size(14, 15);
            lblItemCount.TabIndex = 3;
            lblItemCount.Text = "0";
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Location = new Point(31, 96);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(36, 15);
            lblTotalTitle.TabIndex = 2;
            lblTotalTitle.Text = "Total:";
            // 
            // lblSubttotalTitle
            // 
            lblSubttotalTitle.AutoSize = true;
            lblSubttotalTitle.Location = new Point(31, 51);
            lblSubttotalTitle.Name = "lblSubttotalTitle";
            lblSubttotalTitle.Size = new Size(55, 15);
            lblSubttotalTitle.TabIndex = 1;
            lblSubttotalTitle.Text = "Subtotal:";
            // 
            // lblItemCountTitle
            // 
            lblItemCountTitle.AutoSize = true;
            lblItemCountTitle.Location = new Point(31, 26);
            lblItemCountTitle.Name = "lblItemCountTitle";
            lblItemCountTitle.Size = new Size(77, 15);
            lblItemCountTitle.TabIndex = 0;
            lblItemCountTitle.Text = "Items in Cart:";
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Location = new Point(230, 98);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(72, 15);
            lblReturnDate.TabIndex = 20;
            lblReturnDate.Text = "Return Date:";
            // 
            // dtpRentalDate
            // 
            dtpRentalDate.CustomFormat = "yyyy-MM-dd";
            dtpRentalDate.Format = DateTimePickerFormat.Custom;
            dtpRentalDate.Location = new Point(117, 94);
            dtpRentalDate.Name = "dtpRentalDate";
            dtpRentalDate.Size = new Size(101, 23);
            dtpRentalDate.TabIndex = 21;
            // 
            // txtMemID
            // 
            txtMemID.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMemID.Location = new Point(163, 53);
            txtMemID.Name = "txtMemID";
            txtMemID.PlaceholderText = "Enter Member ID";
            txtMemID.Size = new Size(129, 25);
            txtMemID.TabIndex = 22;
            txtMemID.TextChanged += txtMemID_TextChanged;
            // 
            // btnMemberSearch
            // 
            btnMemberSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMemberSearch.Location = new Point(31, 52);
            btnMemberSearch.Name = "btnMemberSearch";
            btnMemberSearch.Size = new Size(119, 30);
            btnMemberSearch.TabIndex = 23;
            btnMemberSearch.Text = "Search Member";
            btnMemberSearch.UseVisualStyleBackColor = true;
            btnMemberSearch.Click += btnMemberSearch_Click;
            // 
            // RentalCartUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtMemID);
            Controls.Add(btnMemberSearch);
            Controls.Add(dtpRentalDate);
            Controls.Add(lblReturnDate);
            Controls.Add(grpOrderSummary);
            Controls.Add(grpShoppingCart);
            Controls.Add(lblEmployeeName);
            Controls.Add(dtpDueDate);
            Controls.Add(txtMemberName);
            Controls.Add(lblEmployee);
            Controls.Add(lblCustomer);
            Controls.Add(lblDueDate);
            Controls.Add(lblRentalCart);
            Name = "RentalCartUserControl";
            Size = new Size(639, 539);
            grpShoppingCart.ResumeLayout(false);
            grpShoppingCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            grpOrderSummary.ResumeLayout(false);
            grpOrderSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblRentalCart;
        private Label lblDueDate;
        private Label lblCustomer;
        private Label lblEmployee;
        private TextBox txtMemberName;
        private DateTimePicker dtpDueDate;
        private Label lblEmployeeName;
        private GroupBox grpShoppingCart;
        private DataGridView dgvCart;
        private Button btnEmptyCart;
        private Button btnRemoveSelected;
        private Button btnUpdateQty;
        private NumericUpDown numQty;
        private Label lblSelectedQty;
        private GroupBox grpOrderSummary;
        private Label lblTotal;
        private Label lblSubtotal;
        private Label lblItemCount;
        private Label lblTotalTitle;
        private Label lblSubttotalTitle;
        private Label lblItemCountTitle;
        private Button btnCancel;
        private Button btnSubmitRental;
        private Label TotalQtyLabel;
        private Label TotalItemCountLabel;
        private Label lblReturnDate;
        private DateTimePicker dtpRentalDate;
        private Label lblDays;
        private Label lblRentalDays;
        private TextBox txtMemID;
        private Button btnMemberSearch;
    }
}
