using FurnitureRental.Controller;
using FurnitureRental.Model;

namespace FurnitureRental.View
{
    /// <summary>
    /// Displays the rental history for a selected member.
    /// </summary>
    public partial class RentalHistoryForm : Form
    {
        private readonly Member _member;
        private readonly RentalController _rentalController;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalHistoryForm"/> class.
        /// </summary>
        /// <param name="member">The selected member.</param>
        public RentalHistoryForm(Member member)
        {
            InitializeComponent();
            _member = member;
            _rentalController = new RentalController();

            StartPosition = FormStartPosition.CenterParent;

            ConfigureRentalTransactionsGrid();
            ConfigureRentalItemsGrid();
            LoadRentalHistory();
        }

        /// <summary>
        /// Configures the rental transactions grid.
        /// </summary>
        private void ConfigureRentalTransactionsGrid()
        {
            dgvRentalTransactions.AutoGenerateColumns = false;
            dgvRentalTransactions.Columns.Clear();

            dgvRentalTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "RentalTransactionId",
                HeaderText = "Rental ID",
                DataPropertyName = "RentalTransactionId",
                Width = 80,
                MinimumWidth = 60
            });

            dgvRentalTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "RentalDate",
                HeaderText = "Rental Date",
                DataPropertyName = "RentalDate",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "d" }
            });

            dgvRentalTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DueDate",
                HeaderText = "Due Date",
                DataPropertyName = "DueDate",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "d" }
            });

            dgvRentalTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EmployeeName",
                HeaderText = "Employee",
                DataPropertyName = "EmployeeName"
            });

            dgvRentalTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ReturnDates",
                HeaderText = "Return Date(s)",
                DataPropertyName = "ReturnDates"
            });

            dgvRentalTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalCost",
                HeaderText = "Total Cost",
                DataPropertyName = "TotalCost",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvRentalTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRentalTransactions.MultiSelect = false;
            dgvRentalTransactions.ReadOnly = true;
            dgvRentalTransactions.AllowUserToAddRows = false;
            dgvRentalTransactions.AllowUserToDeleteRows = false;
            dgvRentalTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Configures the rental items grid.
        /// </summary>
        private void ConfigureRentalItemsGrid()
        {
            dgvRentalItems.AutoGenerateColumns = false;
            dgvRentalItems.Columns.Clear();

            dgvRentalItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FurnitureId",
                HeaderText = "Furniture ID",
                DataPropertyName = "FurnitureId"
            });

            dgvRentalItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FurnitureName",
                HeaderText = "Furniture Name",
                DataPropertyName = "FurnitureName"
            });

            dgvRentalItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "QuantityRented",
                HeaderText = "Quantity",
                DataPropertyName = "QuantityRented"
            });

            dgvRentalItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DailyRentalRate",
                HeaderText = "Daily Rate",
                DataPropertyName = "DailyRentalRate",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvRentalItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LineTotal",
                HeaderText = "Line Total",
                DataPropertyName = "LineTotal",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvRentalItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRentalItems.MultiSelect = false;
            dgvRentalItems.ReadOnly = true;
            dgvRentalItems.AllowUserToAddRows = false;
            dgvRentalItems.AllowUserToDeleteRows = false;
            dgvRentalItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Loads rental history for the current member.
        /// </summary>
        private void LoadRentalHistory()
        {
            lblMemberInfo.Text = $"Rental History for {_member.FirstName} {_member.LastName} (Member ID: {_member.MemberId})";
            lblError.Text = string.Empty;

            if (_rentalController.TryGetRentalHistoryForMember(
                _member.MemberId.ToString(),
                out List<RentalHistoryTransaction> rentals,
                out string errorMessage))
            {
                dgvRentalTransactions.DataSource = rentals;

                if (dgvRentalTransactions.Rows.Count > 0)
                {
                    dgvRentalTransactions.Rows[0].Selected = true;
                    LoadSelectedRentalItems();
                }
            }
            else
            {
                dgvRentalTransactions.DataSource = null;
                dgvRentalItems.DataSource = null;
                lblError.Text = errorMessage;
            }
        }

        /// <summary>
        /// Loads the rental items for the selected rental transaction.
        /// </summary>
        private void LoadSelectedRentalItems()
        {
            if (dgvRentalTransactions.CurrentRow == null ||
                dgvRentalTransactions.CurrentRow.DataBoundItem is not RentalHistoryTransaction selectedRental)
            {
                dgvRentalItems.DataSource = null;
                return;
            }

            List<RentalHistoryItem> items =
                _rentalController.GetRentalItemsForTransaction(selectedRental.RentalTransactionId);

            dgvRentalItems.DataSource = items;
        }

        /// <summary>
        /// Handles selection changes in the rental transactions grid.
        /// </summary>
        private void dgvRentalTransactions_SelectionChanged(object sender, EventArgs e)
        {
            LoadSelectedRentalItems();
        }

        /// <summary>
        /// Closes the rental history form.
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}