using FurnitureRental.Model;

namespace FurnitureRental.View
{
    /// <summary>
    /// Displays the receipt and transaction summary after a rental is submitted.
    /// </summary>
    public class RentalReceiptForm : Form
    {
        private readonly RentalTransaction _transaction;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalReceiptForm"/> class.
        /// </summary>
        /// <param name="transaction">The transaction.</param>
        public RentalReceiptForm(RentalTransaction transaction)
        {
            _transaction = transaction;

            Text = "Rental Receipt";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(850, 500);

            Label lblHeader = new Label
            {
                Text = "Rental Receipt",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 20)
            };

            Label lblRentalId = new Label
            {
                Text = $"Rental Transaction ID: {_transaction.RentalTransactionId}",
                AutoSize = true,
                Location = new Point(20, 70)
            };

            Label lblMemberId = new Label
            {
                Text = $"Member ID: {_transaction.MemberId}",
                AutoSize = true,
                Location = new Point(20, 95)
            };

            Label lblEmployeeId = new Label
            {
                Text = $"Employee ID: {_transaction.EmployeeId}",
                AutoSize = true,
                Location = new Point(20, 120)
            };

            Label lblDueDate = new Label
            {
                Text = $"Due Date: {_transaction.DueDate:d}",
                AutoSize = true,
                Location = new Point(20, 145)
            };

            Label lblTotalCost = new Label
            {
                Text = $"Total Cost: {_transaction.TotalCost:C}",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 170)
            };

            DataGridView dgvReceipt = new DataGridView
            {
                Location = new Point(20, 210),
                Size = new Size(790, 180),
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false
            };

            dgvReceipt.Columns.Add("FurnitureId", "Item ID");
            dgvReceipt.Columns.Add("FurnitureName", "Name");
            dgvReceipt.Columns.Add("DueDate", "Due Date");
            dgvReceipt.Columns.Add("UnitPrice", "Unit Price");
            dgvReceipt.Columns.Add("Quantity", "Quantity");
            dgvReceipt.Columns.Add("LineTotal", "Total Cost");

            foreach (RentalHistoryItem item in _transaction.Items)
            {
                dgvReceipt.Rows.Add(
                    item.FurnitureId,
                    item.FurnitureName,
                    _transaction.DueDate.ToShortDateString(),
                    item.DailyRentalRate.ToString("C"),
                    item.QuantityRented,
                    item.LineTotal.ToString("C"));
            }

            Button btnClose = new Button
            {
                Text = "Close",
                Location = new Point(710, 410),
                Size = new Size(100, 30)
            };
            btnClose.Click += (s, e) => Close();

            Controls.Add(lblHeader);
            Controls.Add(lblRentalId);
            Controls.Add(lblMemberId);
            Controls.Add(lblEmployeeId);
            Controls.Add(lblDueDate);
            Controls.Add(lblTotalCost);
            Controls.Add(dgvReceipt);
            Controls.Add(btnClose);
        }
    }
}