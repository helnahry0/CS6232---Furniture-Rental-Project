using FurnitureRental.Controller;
using FurnitureRental.Model;

namespace FurnitureRental.UserControls
{
    /// <summary>
    /// This user control is responsible for managing the furniture rental cart, 
    /// handling customer selection and processing rental transactions.
    /// </summary>
    public partial class RentalCartUserControl : UserControl
    {
        /// <summary>
        /// controller used to retrieve member/customer data
        /// </summary>
        private MemberController memcontroller = new MemberController();

        /// <summary>
        /// controller used to add rental transactions
        /// </summary>
        private RentalController controller = new RentalController();

        /// <summary>
        /// list representing items currently in the cart
        /// </summary>
        private List<CartItem> cartItems = new List<CartItem>();

        /// <summary>
        /// used to bind cart items to the Datagrid view
        /// </summary>
        private BindingSource cartBindingSource = new BindingSource();

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalCartUserControl"/> class.
        /// It sets up data sources, grid configurations, and initial UI state.
        /// </summary>
        public RentalCartUserControl()
        {
            InitializeComponent();
            SetupCartGrid();

            dgvCart.DataSource = cartBindingSource;
            dgvCart.CellContentClick += DgvCart_CellContentClick;

            // Set a valid range for quantity editing.
            numQty.Minimum = 1;
            numQty.Maximum = 1000;

            RefreshCart();

            if (CurrentUser.Employee != null)
            {
                lblEmployeeName.Text = $"{CurrentUser.Employee.FirstName} {CurrentUser.Employee.LastName}";
            }
            else
            {
                lblEmployeeName.Text = "Not logged in";
            }
            btnSubmitRental.Enabled = false;
        }


        /// <summary>
        /// Configures the DataGridView columns for displaying cart item details 
        /// : ID, Name, Rate, Quantity, and Total Price.
        /// </summary>
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

        /// <summary>
        /// Helper method to retrieve the currently selected <see cref="CartItem"/> from the grid.
        /// </summary>
        /// <returns>The selected CartItem, or null if no valid item is selected.</returns>
        private CartItem? GetSelectedCartItem()
        {
            if (dgvCart.CurrentRow == null ||
                dgvCart.CurrentRow.Index < 0 ||
                dgvCart.CurrentRow.DataBoundItem is not CartItem item)
            {
                return null;
            }

            return item;
        }

        /// <summary>
        /// Gets the number of rental days based on today and the selected due date.
        /// Minimum rental period is 1 day.
        /// </summary>
        /// <returns>The number of rental days.</returns>
        private int GetRentalDays()
        {
            int days = (dtpDueDate.Value.Date - DateTime.Today).Days;
            return days <= 0 ? 1 : days;
        }

        private decimal ClampToNumericRange(int value)
        {
            decimal safeValue = value;

            if (safeValue < numQty.Minimum)
            {
                safeValue = numQty.Minimum;
            }

            if (safeValue > numQty.Maximum)
            {
                safeValue = numQty.Maximum;
            }

            return safeValue;
        }

        /// <summary>
        /// Synchronizes the UI with the current state of the cart, updating totals, 
        /// item counts, and refreshing the data grid binding.
        /// </summary>
        private void RefreshCart()
        {
            dgvCart.Rows.Clear();

            foreach (CartItem item in cartItems)
            {
                dgvCart.Rows.Add(
                    item.FurnitureId,
                    item.Name,
                    item.DailyRate.ToString("C"),
                    item.Quantity,
                    item.LineTotal.ToString("C"));
            }

            lblTotal.Text = $"Cart Total: {cartItems.Sum(x => x.LineTotal):C}";
        }

        /// <summary>
        /// Updates the quantity numeric selector based on the clicked item in the cart grid.
        /// </summary>
        private void DgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvCart.Rows[e.RowIndex].DataBoundItem is not CartItem item)
                return;

            numQty.Value = ClampToNumericRange(item.Quantity);
        }

        /// <summary>
        /// Updates the quantity of the selected item in the cart.
        /// </summary>
        private void btnUpdateQty_Click(object sender, EventArgs e)
        {
            CartItem? item = GetSelectedCartItem();

            if (item == null)
            {
                MessageBox.Show("Select an item in cart.");
                return;
            }

            int newQty = (int)numQty.Value;

            TryUpdateCartItemQuantity(item, newQty, item.QuantityOnHand);
        }

        /// <summary>
        /// Removes the currently selected item from the cart.
        /// </summary>
        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            var item = GetSelectedCartItem();
            if (item == null)
            {
                MessageBox.Show("Select an item in cart.");
                return;
            }

            cartItems.Remove(item);

            RefreshCart();
        }

        /// <summary>
        /// Removes all items from the current cart.
        /// </summary>
        private void btnEmptyCart_Click(object sender, EventArgs e)
        {
            cartItems.Clear();
            RefreshCart();
        }

        /// <summary>
        /// Adds the item to cart.
        /// </summary>
        /// <param name="furnitureId">The furniture identifier.</param>
        /// <param name="furnitureName">Name of the furniture.</param>
        /// <param name="dailyRentalRate">The daily rental rate.</param>
        /// <param name="quantityToAdd">The quantity to add.</param>
        /// <param name="quantityOnHand">The quantity on hand.</param>
        private void AddItemToCart(int furnitureId, string furnitureName, decimal dailyRentalRate, int quantityToAdd, int quantityOnHand)
        {
            CartItem? existingItem = cartItems.FirstOrDefault(x => x.FurnitureId == furnitureId);

            int quantityAlreadyInCart = existingItem?.Quantity ?? 0;
            int newTotalQuantity = quantityAlreadyInCart + quantityToAdd;

            if (newTotalQuantity > quantityOnHand)
            {
                MessageBox.Show(
                    $"Cannot add that quantity.\n\nAvailable: {quantityOnHand}\nAlready in cart: {quantityAlreadyInCart}\nRequested to add: {quantityToAdd}",
                    "Quantity Exceeds Available Stock",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (existingItem != null)
            {
                existingItem.Quantity = newTotalQuantity;
            }
            else
            {
                cartItems.Add(new CartItem
                {
                    FurnitureId = furnitureId,
                    Name = furnitureName,
                    DailyRate = dailyRentalRate,
                    Quantity = quantityToAdd
                });
            }

            RefreshCart();
        }

        /// <summary>
        /// Validates requirements and submits the rental transaction to the database. 
        /// Displays a receipt upon success.
        /// </summary>
        private void btnSubmitRental_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMemID.Text.Trim(), out int memberId))
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

            if (dtpDueDate.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Due date cannot be in the past.");
                return;
            }

            decimal cartTotal = cartItems.Sum(x => x.TotalPrice) * GetRentalDays();

            DialogResult confirmResult = MessageBox.Show(
                $"Submit this rental?\n\nMember ID: {memberId}\nItems: {cartItems.Count}\nRental Days: {GetRentalDays()}\nTotal: {cartTotal:C}",
                "Confirm Rental Submission",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult != DialogResult.Yes)
            {
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
                    FurnitureName = x.Name,
                    QuantityRented = x.Quantity,
                    DailyRentalRate = x.DailyRate
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

        /// <summary>
        /// Cancels the current rental process and empties the cart.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            cartItems.Clear();
            RefreshCart();
        }

        private void dtpDueDate_ValueChanged(object sender, EventArgs e)
        {
            RefreshCart();
        }

        /// <summary>
        /// Search member registered in the system.
        /// </summary>
        private void btnMemberSearch_Click(object sender, EventArgs e)
        {
            if (memcontroller.TrySearchByMemberId(txtMemID.Text.Trim(),
                out Member? member, out string errorMessage))
            {
                // Concatenate First and Last name
                txtMemberName.Text = $"{member?.FirstName} {member?.LastName}";

                btnSubmitRental.Enabled = true;
            }
            else
            {
                // Clear the field or show the error in the textbox
                txtMemID.Text = string.Empty;
                txtMemberName.Text = string.Empty;

                // Disable Submit Rental button
                btnSubmitRental.Enabled = false;

                // Display a pop-up message to the user
                MessageBox.Show(errorMessage, "Member Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMemID_TextChanged(object sender, EventArgs e)
        {
            // Disable Submit Rental button
            btnSubmitRental.Enabled = false;
        }

        private bool TryUpdateCartItemQuantity(CartItem item, int newQuantity, int quantityOnHand)
        {
            if (newQuantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.");
                return false;
            }

            if (newQuantity > quantityOnHand)
            {
                MessageBox.Show(
                    $"Quantity cannot exceed available stock ({quantityOnHand}).",
                    "Quantity Exceeds Stock",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            item.Quantity = newQuantity;
            RefreshCart();
            return true;
        }
    }
}
