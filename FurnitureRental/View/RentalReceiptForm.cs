using FurnitureRental.Model;
using System.Drawing;
using System.Windows.Forms;

namespace FurnitureRental.View
{
    public class RentalReceiptForm : Form
    {
        private readonly RentalTransaction _transaction;

        public RentalReceiptForm(RentalTransaction transaction)
        {
            _transaction = transaction;

            Text = "Rental Receipt";
            StartPosition = FormStartPosition.CenterParent;
            MinimumSize = new Size(850, 550);
            Size = new Size(950, 600);

            InitializeLayout();
        }

        private void InitializeLayout()
        {
            TableLayoutPanel mainLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4,
                Padding = new Padding(15)
            };

            mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            Label lblHeader = new Label
            {
                Text = "Rental Receipt",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                AutoSize = true,
                Dock = DockStyle.Fill,
                Margin = new Padding(3, 3, 3, 12)
            };

            TableLayoutPanel detailsLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                ColumnCount = 1,
                RowCount = 6,
                Margin = new Padding(0, 0, 0, 12)
            };

            Label lblRentalId = new Label
            {
                Text = $"Rental Transaction ID: {_transaction.RentalTransactionId}",
                AutoSize = true,
                Margin = new Padding(3, 3, 3, 6)
            };

            Label lblMemberId = new Label
            {
                Text = $"Member ID: {_transaction.MemberId}",
                AutoSize = true,
                Margin = new Padding(3, 3, 3, 6)
            };

            Label lblEmployeeId = new Label
            {
                Text = $"Employee ID: {_transaction.EmployeeId}",
                AutoSize = true,
                Margin = new Padding(3, 3, 3, 6)
            };

            Label lblRentalDate = new Label
            {
                Text = $"Rental Date: {_transaction.RentalDate:d}",
                AutoSize = true,
                Margin = new Padding(3, 3, 3, 6)
            };

            Label lblDueDate = new Label
            {
                Text = $"Due Date: {_transaction.DueDate:d}",
                AutoSize = true,
                Margin = new Padding(3, 3, 3, 6)
            };

            Label lblTotalCost = new Label
            {
                Text = $"Total Cost: {_transaction.TotalCost:C}",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                AutoSize = true,
                Margin = new Padding(3, 3, 3, 6)
            };

            detailsLayout.Controls.Add(lblRentalId, 0, 0);
            detailsLayout.Controls.Add(lblMemberId, 0, 1);
            detailsLayout.Controls.Add(lblEmployeeId, 0, 2);
            detailsLayout.Controls.Add(lblRentalDate, 0, 3);
            detailsLayout.Controls.Add(lblDueDate, 0, 4);
            detailsLayout.Controls.Add(lblTotalCost, 0, 5);

            DataGridView dgvReceipt = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false,
                Margin = new Padding(0, 0, 0, 12)
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

            FlowLayoutPanel buttonPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.RightToLeft,
                AutoSize = true,
                WrapContents = false
            };

            Button btnClose = new Button
            {
                Text = "Close",
                AutoSize = true,
                Padding = new Padding(12, 4, 12, 4)
            };
            btnClose.Click += (s, e) => Close();

            buttonPanel.Controls.Add(btnClose);

            mainLayout.Controls.Add(lblHeader, 0, 0);
            mainLayout.Controls.Add(detailsLayout, 0, 1);
            mainLayout.Controls.Add(dgvReceipt, 0, 2);
            mainLayout.Controls.Add(buttonPanel, 0, 3);

            Controls.Add(mainLayout);
        }
    }
}