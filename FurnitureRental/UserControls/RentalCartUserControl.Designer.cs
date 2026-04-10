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
            lblMemberId = new Label();
            lblDueDate = new Label();
            lblCustomer = new Label();
            lblEmployee = new Label();
            txtMemberId = new TextBox();
            dtpDueDate = new DateTimePicker();
            lblCustomerName = new Label();
            lblEmployeeName = new Label();
            grpShoppingCart = new GroupBox();
            btnEmptyCart = new Button();
            btnRemoveSelected = new Button();
            btnUpdateQty = new Button();
            numQty = new NumericUpDown();
            lblSelectedQty = new Label();
            dgvCart = new DataGridView();
            grpOrderSummary = new GroupBox();
            btnCancel = new Button();
            btnSubmitRental = new Button();
            lblTotal = new Label();
            lblSubtotal = new Label();
            lblItemCount = new Label();
            lblTotalTitle = new Label();
            lblSubttotalTitle = new Label();
            lblItemCountTitle = new Label();
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
            // lblMemberId
            // 
            lblMemberId.AutoSize = true;
            lblMemberId.Location = new Point(23, 64);
            lblMemberId.Name = "lblMemberId";
            lblMemberId.Size = new Size(69, 15);
            lblMemberId.TabIndex = 2;
            lblMemberId.Text = "Member ID:";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(23, 96);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(58, 15);
            lblDueDate.TabIndex = 3;
            lblDueDate.Text = "Due Date:";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(399, 64);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(62, 15);
            lblCustomer.TabIndex = 4;
            lblCustomer.Text = "Customer:";
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(399, 98);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(62, 15);
            lblEmployee.TabIndex = 5;
            lblEmployee.Text = "Employee:";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(143, 56);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(100, 23);
            txtMemberId.TabIndex = 6;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(143, 90);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(200, 23);
            dtpDueDate.TabIndex = 9;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(536, 64);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(38, 15);
            lblCustomerName.TabIndex = 10;
            lblCustomerName.Text = "label1";
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Location = new Point(536, 98);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(38, 15);
            lblEmployeeName.TabIndex = 11;
            lblEmployeeName.Text = "label1";
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
            numQty.Location = new Point(219, 200);
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
            dgvCart.Size = new Size(564, 166);
            dgvCart.TabIndex = 0;

            // 
            // grpOrderSummary
            // 
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
            grpOrderSummary.Size = new Size(598, 115);
            grpOrderSummary.TabIndex = 18;
            grpOrderSummary.TabStop = false;
            grpOrderSummary.Text = "Order Summary";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCancel.Location = new Point(424, 43);
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
            btnSubmitRental.Location = new Point(245, 43);
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
            lblTotal.Location = new Point(182, 72);
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
            lblTotalTitle.Location = new Point(31, 72);
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
            // RentalCartUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpOrderSummary);
            Controls.Add(grpShoppingCart);
            Controls.Add(lblEmployeeName);
            Controls.Add(lblCustomerName);
            Controls.Add(dtpDueDate);
            Controls.Add(txtMemberId);
            Controls.Add(lblEmployee);
            Controls.Add(lblCustomer);
            Controls.Add(lblDueDate);
            Controls.Add(lblMemberId);
            Controls.Add(lblRentalCart);
            Name = "RentalCartUserControl";
            Size = new Size(639, 528);
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
        private Label lblMemberId;
        private Label lblDueDate;
        private Label lblCustomer;
        private Label lblEmployee;
        private TextBox txtMemberId;
        private DateTimePicker dtpDueDate;
        private Label lblCustomerName;
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
    }
}
