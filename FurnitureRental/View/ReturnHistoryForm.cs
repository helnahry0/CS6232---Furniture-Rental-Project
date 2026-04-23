using FurnitureRental.Controller;
using FurnitureRental.Model;

namespace FurnitureRental.View
{
    /// <summary>
    /// Displays the return history for a selected member.
    /// </summary>
    public class ReturnHistoryForm : Form
    {
        private readonly Member _member;
        private readonly ReturnController _returnController;

        private readonly Label lblMemberInfo;
        private readonly Label lblError;
        private readonly DataGridView dgvReturnTransactions;
        private readonly DataGridView dgvReturnItems;
        private readonly Button btnClose;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnHistoryForm"/> class.
        /// </summary>
        /// <param name="member">The selected member.</param>
        public ReturnHistoryForm(Member member)
        {
            _member = member;
            _returnController = new ReturnController();

            Text = "Return History";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(950, 600);

            lblMemberInfo = new Label
            {
                AutoSize = true,
                Location = new Point(20, 20),
                Font = new Font("Segoe UI", 11, FontStyle.Bold)
            };

            lblError = new Label
            {
                AutoSize = true,
                Location = new Point(20, 50),
                ForeColor = Color.Red
            };

            dgvReturnTransactions = new DataGridView
            {
                Location = new Point(20, 85),
                Size = new Size(890, 200)
            };

            dgvReturnItems = new DataGridView
            {
                Location = new Point(20, 315),
                Size = new Size(890, 200)
            };

            btnClose = new Button
            {
                Text = "Close",
                Location = new Point(810, 530),
                Size = new Size(100, 30)
            };
            btnClose.Click += btnClose_Click;

            Controls.Add(lblMemberInfo);
            Controls.Add(lblError);
            Controls.Add(dgvReturnTransactions);
            Controls.Add(dgvReturnItems);
            Controls.Add(btnClose);

            ConfigureReturnTransactionsGrid();
            ConfigureReturnItemsGrid();
            LoadReturnHistory();

            dgvReturnTransactions.SelectionChanged += dgvReturnTransactions_SelectionChanged;
        }

        /// <summary>
        /// Configures the return transactions grid.
        /// </summary>
        private void ConfigureReturnTransactionsGrid()
        {
            dgvReturnTransactions.AutoGenerateColumns = false;
            dgvReturnTransactions.Columns.Clear();

            dgvReturnTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ReturnId",
                HeaderText = "Return ID",
                DataPropertyName = "ReturnId",
                Width = 90
            });

            dgvReturnTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ReturnDate",
                HeaderText = "Return Date",
                DataPropertyName = "ReturnDate",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "d" }
            });

            dgvReturnTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EmployeeName",
                HeaderText = "Employee",
                DataPropertyName = "EmployeeName"
            });

            dgvReturnTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalFineOrRefund",
                HeaderText = "Total Fine/Refund",
                DataPropertyName = "TotalFineOrRefund",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvReturnTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReturnTransactions.MultiSelect = false;
            dgvReturnTransactions.ReadOnly = true;
            dgvReturnTransactions.AllowUserToAddRows = false;
            dgvReturnTransactions.AllowUserToDeleteRows = false;
            dgvReturnTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Configures the return items grid.
        /// </summary>
        private void ConfigureReturnItemsGrid()
        {
            dgvReturnItems.AutoGenerateColumns = false;
            dgvReturnItems.Columns.Clear();

            dgvReturnItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "RentalId",
                HeaderText = "Rental ID",
                DataPropertyName = "RentalId"
            });

            dgvReturnItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FurnitureId",
                HeaderText = "Furniture ID",
                DataPropertyName = "FurnitureId"
            });

            dgvReturnItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FurnitureName",
                HeaderText = "Furniture Name",
                DataPropertyName = "FurnitureName"
            });

            dgvReturnItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "QuantityReturned",
                HeaderText = "Quantity Returned",
                DataPropertyName = "QuantityReturned"
            });

            dgvReturnItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FineOrRefundAmount",
                HeaderText = "Fine/Refund",
                DataPropertyName = "FineOrRefundAmount",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvReturnItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReturnItems.MultiSelect = false;
            dgvReturnItems.ReadOnly = true;
            dgvReturnItems.AllowUserToAddRows = false;
            dgvReturnItems.AllowUserToDeleteRows = false;
            dgvReturnItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Loads return history for the current member.
        /// </summary>
        private void LoadReturnHistory()
        {
            lblMemberInfo.Text = $"Return History for {_member.FirstName} {_member.LastName} (Member ID: {_member.MemberId})";
            lblError.Text = string.Empty;

            if (_returnController.TryGetReturnHistoryForMember(
                _member.MemberId.ToString(),
                out List<ReturnHistoryTransaction> returns,
                out string errorMessage))
            {
                dgvReturnTransactions.DataSource = returns;

                if (dgvReturnTransactions.Rows.Count > 0)
                {
                    dgvReturnTransactions.Rows[0].Selected = true;
                    LoadSelectedReturnItems();
                }
            }
            else
            {
                dgvReturnTransactions.DataSource = null;
                dgvReturnItems.DataSource = null;
                lblError.Text = errorMessage;
            }
        }

        /// <summary>
        /// Loads the return items for the selected return transaction.
        /// </summary>
        private void LoadSelectedReturnItems()
        {
            if (dgvReturnTransactions.CurrentRow == null ||
                dgvReturnTransactions.CurrentRow.DataBoundItem is not ReturnHistoryTransaction selectedReturn)
            {
                dgvReturnItems.DataSource = null;
                return;
            }

            List<ReturnHistoryItem> items =
                _returnController.GetReturnItemsForTransaction(selectedReturn.ReturnId);

            dgvReturnItems.DataSource = items;
        }

        /// <summary>
        /// Handles selection changes in the return transactions grid.
        /// </summary>
        private void dgvReturnTransactions_SelectionChanged(object? sender, EventArgs e)
        {
            LoadSelectedReturnItems();
        }

        /// <summary>
        /// Closes the form.
        /// </summary>
        private void btnClose_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
