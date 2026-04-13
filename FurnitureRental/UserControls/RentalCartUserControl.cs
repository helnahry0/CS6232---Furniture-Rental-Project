using FurnitureRental.Controller;
using FurnitureRental.Model;

namespace FurnitureRental.UserControls
{
    public partial class RentalCartUserControl : UserControl
    {
        private MemberController memcontroller = new MemberController();
        private RentalController controller = new RentalController();
        private List<CartItem> cartItems = new List<CartItem>();
        private BindingSource cartBindingSource = new BindingSource();

        public RentalCartUserControl()
        {
            InitializeComponent();
            LoadCustomers();
            SetupCartGrid();

            dgvCart.DataSource = cartBindingSource;
            dgvCart.CellContentClick += DgvCart_CellContentClick;

            RefreshCart();

            if (CurrentUser.Employee != null)
            {
                lblEmployeeName.Text = $"{CurrentUser.Employee.FirstName} {CurrentUser.Employee.LastName}";
            }
            else
            {
                lblEmployeeName.Text = "Not logged in";
            }
        }
        public void LoadCustomers()
        {
            var customers = memcontroller.GetAllMembers();

            cboCustomer.DataSource = customers;
            cboCustomer.DisplayMember = "FullName";
            cboCustomer.ValueMember = "MemberId";
            cboCustomer.SelectedIndex = -1;
        }


        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCustomer.SelectedIndex == -1)
            {
                txtMemberId.Clear();
                return;
            }

            if (cboCustomer.SelectedValue != null &&
                int.TryParse(cboCustomer.SelectedValue.ToString(), out int memberId))
            {
                txtMemberId.Text = memberId.ToString();
            }
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

        private void RefreshCart()
        {
            cartBindingSource.DataSource = null;
            cartBindingSource.DataSource = cartItems;

            lblItemCount.Text = cartItems.Count.ToString();
            TotalItemCountLabel.Text = cartItems.Sum(x => x.Quantity).ToString();

            decimal subtotal = cartItems.Sum(x => x.TotalPrice);
            lblSubtotal.Text = subtotal.ToString("C");
            lblTotal.Text = subtotal.ToString("C");

            // To prevent invalid row state
            dgvCart.ClearSelection();
            dgvCart.CurrentCell = null;

            numQty.Value = cartItems.Count > 0
                ? cartItems[0].Quantity
                : 1;
        }

        private void DgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvCart.Rows[e.RowIndex].DataBoundItem is not CartItem item)
                return;

            numQty.Value = item.Quantity;
        }

        private void btnUpdateQty_Click(object sender, EventArgs e)
        {
            var item = GetSelectedCartItem();

            if (item == null)
            {
                MessageBox.Show("Select an item in cart.");
                return;
            }

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
            var item = GetSelectedCartItem();
            if (item == null)
            {
                MessageBox.Show("Select an item in cart.");
                return;
            }

            cartItems.Remove(item);

            RefreshCart();
        }

        private void btnEmptyCart_Click(object sender, EventArgs e)
        {
            cartItems.Clear();
            RefreshCart();
        }

        public void AddToCart(Furniture furniture, int quantity)
        {
            if (furniture == null) return;

            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.");
                return;
            }

            var existing = cartItems.FirstOrDefault(x => x.FurnitureId == furniture.FurnitureId);

            if (existing != null)
            {
                existing.Quantity += quantity;
            }
            else
            {
                cartItems.Add(new CartItem
                {
                    FurnitureId = furniture.FurnitureId,
                    Name = furniture.FurnitureName,
                    DailyRate = furniture.DailyRentalRate,
                    Quantity = quantity
                });
            }

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
            RefreshCart();
        }

    }
}
