using FurnitureRental.Controller;
using FurnitureRental.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FurnitureRental.UserControls
{
    public partial class RentalCartUserControl : UserControl
    {
        private RentalController controller = new RentalController();
        private List<CartItem> cartItems = new List<CartItem>();

        public RentalCartUserControl()
        {
            InitializeComponent();
            SetupCartGrid();


        }

        private void SetupCartGrid()
        {
            dgvCart.AutoGenerateColumns = false;
            dgvCart.Columns.Clear();

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Furniture ID",
                DataPropertyName = "FurnitureId"
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                DataPropertyName = "Name"
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Daily Rate",
                DataPropertyName = "DailyRate",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C" }
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantity",
                DataPropertyName = "Quantity"
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total",
                DataPropertyName = "TotalPrice",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C" }
            });
        }

        private void RefreshCart()
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = cartItems;

            lblItemCount.Text = cartItems.Count.ToString();

            decimal subtotal = cartItems.Sum(x => x.TotalPrice);

            lblSubtotal.Text = subtotal.ToString("C");
            lblTotal.Text = subtotal.ToString("C");
        }
        private void DgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateQty_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow == null)
            {
                MessageBox.Show("Select an item in cart.");
                return;
            }

            var item = (CartItem)dgvCart.CurrentRow.DataBoundItem;

            int newQty = (int)numQty.Value;

            if (newQty <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.");
                return;
            }

            item.Quantity = newQty;

            RefreshCart();
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow == null) return;

            var item = (CartItem)dgvCart.CurrentRow.DataBoundItem;
            cartItems.Remove(item);

            RefreshCart();
        }

        private void btnEmptyCart_Click(object sender, EventArgs e)
        {
            cartItems.Clear();
            RefreshCart();
        }

        private void btnSubmitRental_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMemberId.Text.Trim(), out int memberId))
            {
                MessageBox.Show("Enter a valid member ID.");
                return;
            }

            if (CurrentUser.Employee == null)
            {
                MessageBox.Show("No employee is currently logged in.");
                return;
            }

            if (cartItems.Count == 0)
            {
                MessageBox.Show("The cart is empty.");
                return;
            }

            RentalTransaction rentalTransaction = new RentalTransaction
            {
                MemberId = memberId,
                EmployeeId = CurrentUser.Employee.EmployeeId,
                RentalDate = DateTime.Now,
                DueDate = dtpDueDate.Value,
                Items = cartItems.Select(x => new RentalHistoryItem
                {
                    FurnitureId = x.FurnitureId,
                    QuantityRented = x.Quantity
                }).ToList()
            };

            bool success = controller.TrySubmitRentalTransaction(
                rentalTransaction,
                out RentalTransaction? savedTransaction,
                out string errorMessage);

            if (!success || savedTransaction == null)
            {
                MessageBox.Show(errorMessage);
                return;
            }

            MessageBox.Show(
                $"Rental submitted successfully.\n\nRental ID: {savedTransaction.RentalTransactionId}\nTotal Cost: {savedTransaction.TotalCost:C}",
                "Transaction Summary",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            using FurnitureRental.View.RentalReceiptForm receiptForm =
                new FurnitureRental.View.RentalReceiptForm(savedTransaction);

            receiptForm.ShowDialog();

            cartItems.Clear();
            RefreshCart();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cartItems.Clear();
        }
    }
}
