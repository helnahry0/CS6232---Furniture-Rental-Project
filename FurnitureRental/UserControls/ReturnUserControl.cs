using FurnitureRental.Controller;
using FurnitureRental.Model;
using System.Data;
using System.Text;

namespace FurnitureRental.UserControls
{
    /// <summary>
    /// User control that manages the full furniture return workflow:
    /// member lookup to rental selection to order selection to cart staging to return submission.
    /// </summary>
    public partial class ReturnUserControl : UserControl
    {
        private readonly ReturnController _returnController = new ReturnController();
        private readonly MemberController _memberController = new MemberController();

        private int _currentMemberId;
        private List<ReturnableRentalItem> _allReturnableItems = new List<ReturnableRentalItem>();
        private ReturnableRentalItem? _activeOrderItem;
        private bool _isShowingItemLevel;

        private readonly List<ReturnItem> _cartItems = new List<ReturnItem>();
        private ReturnItem? _selectedCartItem;
        private bool _suppressEvents;

        private readonly BindingSource _mainGridSource = new BindingSource();
        private readonly BindingSource _cartGridSource = new BindingSource();



        private sealed class RentalSummaryRow
        {
            public int RentalId { get; set; }
            public DateTime RentalDate { get; set; }
            public DateTime DueDate { get; set; }
            public string Status { get; set; } = string.Empty;
            public decimal TotalPrice { get; set; }
        }

        private sealed class OrderItemRow
        {
            public int OrderId { get; set; }
            public string ItemName { get; set; } = string.Empty;
            public int Qty { get; set; }
            public decimal Price { get; set; }
            public string Status { get; set; } = string.Empty;
        }

        private sealed class CartDisplayRow
        {
            public int RentalId { get; set; }
            public int OrderId { get; set; }
            public string Name { get; set; } = string.Empty;
            public int Qty { get; set; }
            public decimal TotalPrice { get; set; }
        }


        /// <summary>
        /// Initializes a new instance of <see cref="ReturnUserControl"/>.
        /// </summary>
        public ReturnUserControl()
        {
            InitializeComponent();
        }

        private void ReturnUserControl_Load(object sender, EventArgs e)
        {
            ConfigureMainGrid();
            ConfigureCartGrid();
            WireEventHandlers();
            ResetToInitialState();
        }

        private void ConfigureMainGrid()
        {
            ReturnDataGridView.AutoGenerateColumns = false;
            ReturnDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ReturnDataGridView.MultiSelect = false;
            ReturnDataGridView.ReadOnly = true;
            ReturnDataGridView.AllowUserToAddRows = false;
            ReturnDataGridView.DataSource = _mainGridSource;
        }

        private void ConfigureCartGrid()
        {
            ReturnCartDataGridView.AutoGenerateColumns = false;
            ReturnCartDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ReturnCartDataGridView.MultiSelect = false;
            ReturnCartDataGridView.ReadOnly = true;
            ReturnCartDataGridView.AllowUserToAddRows = false;
            ReturnCartDataGridView.DataSource = _cartGridSource;

            ReturnCartDataGridView.Columns.Clear();
            ReturnCartDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Rental ID", DataPropertyName = nameof(CartDisplayRow.RentalId) });
            ReturnCartDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Order ID", DataPropertyName = nameof(CartDisplayRow.OrderId) });
            ReturnCartDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = nameof(CartDisplayRow.Name) });
            ReturnCartDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Qty", DataPropertyName = nameof(CartDisplayRow.Qty) });
            ReturnCartDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Total Price", DataPropertyName = nameof(CartDisplayRow.TotalPrice), DefaultCellStyle = new DataGridViewCellStyle { Format = "C" } });
        }

        private void WireEventHandlers()
        {
            SearchMemberButton.Click += SearchMemberButton_Click;
            SearchRentalIdButton.Click += SearchRentalIdButton_Click;
            SearchOrderIdButton.Click += SearchOrderIdButton_Click;
            AddToCartButton.Click += AddToCartButton_Click;
            ClearButton.Click += ClearButton_Click;
            ProcessReturnButton.Click += ProcessReturnButton_Click;
            RemoveButton.Click += RemoveButton_Click;
            UpdateButton.Click += UpdateButton_Click;

            ReturnDataGridView.SelectionChanged += ReturnDataGridView_SelectionChanged;
            ReturnCartDataGridView.SelectionChanged += ReturnCartDataGridView_SelectionChanged;

            DueDateTimePicker.ValueChanged += DueDateTimePicker_ValueChanged;
            ItemQtyNumericUpDown.ValueChanged += ItemQtyNumericUpDown_ValueChanged;
            ItemQtyNumericUpDown2.ValueChanged += ItemQtyNumericUpDown2_ValueChanged;
        }



        private void ResetToInitialState()
        {
            _suppressEvents = true;

            _currentMemberId = 0;
            _allReturnableItems.Clear();
            _activeOrderItem = null;
            _isShowingItemLevel = false;
            _selectedCartItem = null;

            MemberIDTextBox.Clear();
            MemberIDTextBox.ReadOnly = false;
            RentalIdTextBox.Clear();
            RentalIdTextBox.ReadOnly = true;
            OrderIdTextBox.Clear();
            OrderIdTextBox.ReadOnly = true;

            _mainGridSource.DataSource = null;
            SummaryTitleLabel.Text = "Rental History";

            ActiveRentalDateLabel.Text = "--/--/----";
            ActiveDueDateLabel.Text = "--/--/----";
            ActiveEmployeeIdLabel.Text = "---";

            ActiveOrderIdLabel.Text = "---";
            ActiveFurnitureNameLabel.Text = "---";
            ActiveStatusLabel.Text = "---";
            DueDateTimePicker.Value = DateTime.Today;
            DayFeesCalculatedLabel.Text = "---";

            ItemQtyNumericUpDown.Minimum = 1;
            ItemQtyNumericUpDown.Maximum = 1;
            ItemQtyNumericUpDown.Value = 1;

            ActiveBaseCostLabel.Text = "$0.00";
            EarlyReturnRefundLabel.Text = "$0.00";
            ActiveLateFinesLabel.Text = "$0.00";
            ActiveAmountDueLabel.Text = "$0.00";

            EarlyReturnLabel.Visible = false;
            EarlyReturnRefundLabel.Visible = false;
            FinesLabel.Visible = false;
            ActiveLateFinesLabel.Visible = false;

            ActiveRentalIdLabel.Text = "---";
            ActiveOrderIdLabel2.Text = "---";
            ActiveFurnitureNameLabel2.Text = "---";

            ItemQtyNumericUpDown2.Minimum = 1;
            ItemQtyNumericUpDown2.Maximum = 1;
            ItemQtyNumericUpDown2.Value = 1;

            ActiveBaseCostLabel2.Text = "$0.00";
            EarlyReturnRefundLabel2.Text = "$0.00";
            ActiveLateFinesLabel2.Text = "$0.00";
            AmountDueLabel2.Text = "$0.00";

            SearchRentalIdButton.Enabled = false;
            SearchOrderIdButton.Enabled = false;
            AddToCartButton.Enabled = false;

            _suppressEvents = false;
        }

        private void ResetCartTabPageState()
        {
            _suppressEvents = true;
            _selectedCartItem = null;

            ActiveRentalIdLabel.Text = "---";
            ActiveOrderIdLabel2.Text = "---";
            ActiveFurnitureNameLabel2.Text = "---";

            ItemQtyNumericUpDown2.Minimum = 1;
            ItemQtyNumericUpDown2.Maximum = 1;
            ItemQtyNumericUpDown2.Value = 1;

            ActiveBaseCostLabel2.Text = "$0.00";
            EarlyReturnRefundLabel2.Text = "$0.00";
            ActiveLateFinesLabel2.Text = "$0.00";
            AmountDueLabel2.Text = "$0.00";
            AmountDueLabel2.ForeColor = Color.Black;
            ReturnCartDataGridView.ClearSelection();

            _suppressEvents = false;
        }

        private void LoadRentalSummaryGrid()
        {
            ReturnDataGridView.Columns.Clear();
            ReturnDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Rental ID", DataPropertyName = nameof(RentalSummaryRow.RentalId) });
            ReturnDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Rental Date", DataPropertyName = nameof(RentalSummaryRow.RentalDate), DefaultCellStyle = new DataGridViewCellStyle { Format = "MM/dd/yyyy" } });
            ReturnDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Due Date", DataPropertyName = nameof(RentalSummaryRow.DueDate), DefaultCellStyle = new DataGridViewCellStyle { Format = "MM/dd/yyyy" } });
            ReturnDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = nameof(RentalSummaryRow.Status) });
            ReturnDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Total Price", DataPropertyName = nameof(RentalSummaryRow.TotalPrice), DefaultCellStyle = new DataGridViewCellStyle { Format = "C" } });

            _mainGridSource.DataSource = _allReturnableItems
                .GroupBy(i => i.RentalId)
                .Select(g => new RentalSummaryRow
                {
                    RentalId = g.Key,
                    RentalDate = g.First().RentalDate,
                    DueDate = g.First().DueDate,
                    Status = g.First().Status,
                    TotalPrice = g.Sum(i => i.QuantityRemaining * i.DailyRentalRate * i.PlannedDays)
                }).ToList();
        }

        private void LoadOrderItemGrid(List<ReturnableRentalItem> items)
        {
            ReturnDataGridView.Columns.Clear();
            ReturnDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Order ID", DataPropertyName = nameof(OrderItemRow.OrderId), Width = 80 });
            ReturnDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Item Name", DataPropertyName = nameof(OrderItemRow.ItemName), Width = 160 });
            ReturnDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Qty", DataPropertyName = nameof(OrderItemRow.Qty), Width = 60 });
            ReturnDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Price / Day", DataPropertyName = nameof(OrderItemRow.Price), Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "C" } });
            ReturnDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = nameof(OrderItemRow.Status), Width = 90 });

            _mainGridSource.DataSource = items.Select(i => new OrderItemRow
            {
                OrderId = i.FurnitureId,
                ItemName = i.FurnitureName,
                Qty = i.QuantityRemaining,
                Price = i.DailyRentalRate,
                Status = i.Status
            }).ToList();
        }

        private void RefreshCartGrid()
        {
            _cartGridSource.DataSource = _cartItems.Select(item => new CartDisplayRow
            {
                RentalId = item.RentalId,
                OrderId = item.FurnitureId,
                Name = item.FurnitureName,
                Qty = item.QuantityToReturn,
                TotalPrice = item.FineOrRefundAmount
            }).ToList();
        }

        private static decimal CalculateFineOrRefund(DateTime rentalDate, DateTime dueDate, DateTime returnDate, decimal dailyRate, int qty)
        {
            int plannedDays = Math.Max(1, (dueDate.Date - rentalDate.Date).Days + 1);
            int actualDays = Math.Max(1, (returnDate.Date - rentalDate.Date).Days + 1);
            return (actualDays - plannedDays) * dailyRate * qty;
        }



        private void SearchMemberButton_Click(object sender, EventArgs e)
        {
            if (!_returnController.TryGetReturnableItemsForMember(MemberIDTextBox.Text.Trim(), out List<ReturnableRentalItem> items, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Member Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int.TryParse(MemberIDTextBox.Text.Trim(), out _currentMemberId);
            _allReturnableItems = items;
            _isShowingItemLevel = false;

            Member? member = _memberController.GetMemberById(_currentMemberId);
            SummaryTitleLabel.Text = member != null
                ? $"Rental Record for Member ID:{_currentMemberId} {member.FirstName} {member.LastName[0]}."
                : $"Rental History for Member Not Found.";

            RentalIdTextBox.Clear();
            OrderIdTextBox.Clear();
            SearchRentalIdButton.Enabled = true;
            SearchOrderIdButton.Enabled = false;

            LoadRentalSummaryGrid();
        }

        private void SearchRentalIdButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(RentalIdTextBox.Text.Trim(), out int rentalId) || rentalId <= 0) return;

            List<ReturnableRentalItem> rentalItems = _allReturnableItems.Where(i => i.RentalId == rentalId).ToList();
            if (rentalItems.Count == 0) return;

            _isShowingItemLevel = true;
            SummaryTitleLabel.Text = $"RENTAL ID. {rentalId} SUMMARY";

            ActiveRentalDateLabel.Text = rentalItems[0].RentalDate.ToString("MM/dd/yyyy");
            ActiveDueDateLabel.Text = rentalItems[0].DueDate.ToString("MM/dd/yyyy");
            ActiveEmployeeIdLabel.Text = rentalItems[0].EmployeeId.ToString();

            OrderIdTextBox.Clear();
            SearchOrderIdButton.Enabled = true;
            LoadOrderItemGrid(rentalItems);
        }

        private void SearchOrderIdButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(OrderIdTextBox.Text.Trim(), out int furnitureId) || !int.TryParse(RentalIdTextBox.Text.Trim(), out int rentalId)) return;

            _activeOrderItem = _allReturnableItems.FirstOrDefault(i => i.RentalId == rentalId && i.FurnitureId == furnitureId);
            if (_activeOrderItem == null) return;

            _suppressEvents = true;
            ActiveOrderIdLabel.Text = _activeOrderItem.FurnitureId.ToString();
            ActiveFurnitureNameLabel.Text = _activeOrderItem.FurnitureName;
            ActiveStatusLabel.Text = _activeOrderItem.Status;
            DueDateTimePicker.Value = _activeOrderItem.DueDate.Date;

            ItemQtyNumericUpDown.Maximum = _activeOrderItem.QuantityRemaining;
            ItemQtyNumericUpDown.Value = _activeOrderItem.QuantityRemaining;
            _suppressEvents = false;

            UpdateOrderPanelBreakdown();
            AddToCartButton.Enabled = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResetToInitialState();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (_activeOrderItem == null) return;

            if (_cartItems.Any(c => c.RentalId == _activeOrderItem.RentalId && c.FurnitureId == _activeOrderItem.FurnitureId))
            {
                MessageBox.Show("This item is already in the return cart.", "Already in Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int qtyToReturn = (int)ItemQtyNumericUpDown.Value;
            decimal fineOrRefund = CalculateFineOrRefund(_activeOrderItem.RentalDate, _activeOrderItem.DueDate, DueDateTimePicker.Value.Date, _activeOrderItem.DailyRentalRate, qtyToReturn);

            _cartItems.Add(new ReturnItem
            {
                RentalId = _activeOrderItem.RentalId,
                FurnitureId = _activeOrderItem.FurnitureId,
                FurnitureName = _activeOrderItem.FurnitureName,
                QuantityRented = _activeOrderItem.QuantityRented,
                QuantityAlreadyReturned = _activeOrderItem.QuantityAlreadyReturned,
                QuantityRemaining = _activeOrderItem.QuantityRemaining,
                QuantityToReturn = qtyToReturn,
                RentalDate = _activeOrderItem.RentalDate,
                DueDate = _activeOrderItem.DueDate,
                ReturnDate = DueDateTimePicker.Value.Date,
                DailyRentalRate = _activeOrderItem.DailyRentalRate,
                FineOrRefundAmount = fineOrRefund
            });

            RefreshCartGrid();
            MessageBox.Show($"'{_activeOrderItem.FurnitureName}' added to cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearButton2_Click(object sender, EventArgs e)
        {
            ResetCartTabPageState();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (_selectedCartItem == null) return;
            _cartItems.Remove(_selectedCartItem);

            RefreshCartGrid();
            ResetCartTabPageState();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (_selectedCartItem == null) return;

            _selectedCartItem.QuantityToReturn = (int)ItemQtyNumericUpDown2.Value;
            _selectedCartItem.FineOrRefundAmount = CalculateFineOrRefund(_selectedCartItem.RentalDate, _selectedCartItem.DueDate,
                                                    _selectedCartItem.ReturnDate, _selectedCartItem.DailyRentalRate, _selectedCartItem.QuantityToReturn);
            RefreshCartGrid();
        }

        private void ProcessReturnButton_Click(object sender, EventArgs e)
        {
            if (_cartItems.Count == 0) return;

            if (MessageBox.Show("Please confirm items listed are present. \n  Proceed with return?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            if (CurrentUser.Employee == null)
            {
                MessageBox.Show("No employee is logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ReturnTransaction transaction = new ReturnTransaction
            {
                MemberId = _currentMemberId,
                EmployeeId = CurrentUser.Employee.EmployeeId,
                ReturnDate = DateTime.Now,
                Items = new List<ReturnItem>(_cartItems)
            };

            if (!_returnController.TrySubmitReturn(transaction, out ReturnTransaction? savedTransaction, out string errorMessage))
            {
                MessageBox.Show($"Return could not be processed:\n{errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StringBuilder receipt = new StringBuilder();
            receipt.AppendLine($"Return Receipt ID: {savedTransaction!.ReturnId}\nDate: {savedTransaction.ReturnDate:MM/dd/yyyy}\n");

            foreach (ReturnItem item in savedTransaction.Items)
            {
                receipt.AppendLine($"Item: {item.FurnitureName} (Qty: {item.QuantityToReturn})");
                receipt.AppendLine($"Fine/Refund: {item.FineOrRefundAmount:C}\n");
            }
            receipt.AppendLine($"Total Net Fine/Refund: {savedTransaction.TotalFineOrRefund:C}");

            MessageBox.Show(receipt.ToString(), "Return Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _cartItems.Clear();
            RefreshCartGrid();
            ResetCartTabPageState();

            if (_returnController.TryGetReturnableItemsForMember(_currentMemberId.ToString(), out List<ReturnableRentalItem> refreshedItems, out _))
            {
                _allReturnableItems = refreshedItems;
            }
            else
            {
                _allReturnableItems.Clear();
            }

            _isShowingItemLevel = false;
            RentalIdTextBox.Clear();
            OrderIdTextBox.Clear();
            LoadRentalSummaryGrid();
        }



        private void ReturnDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (_suppressEvents || ReturnDataGridView.CurrentRow == null) return;
            object? boundItem = ReturnDataGridView.CurrentRow.DataBoundItem;

            _suppressEvents = true;
            if (!_isShowingItemLevel && boundItem is RentalSummaryRow rentalSummaryRow)
            {
                RentalIdTextBox.Text = rentalSummaryRow.RentalId.ToString();
            }
            else if (_isShowingItemLevel && boundItem is OrderItemRow orderItemRow)
            {
                OrderIdTextBox.Text = orderItemRow.OrderId.ToString();
            }
            _suppressEvents = false;
        }

        private void ReturnCartDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (_suppressEvents || ReturnCartDataGridView.CurrentRow == null) return;
            if (ReturnCartDataGridView.CurrentRow.DataBoundItem is not CartDisplayRow cartRow) return;

            _selectedCartItem = _cartItems.FirstOrDefault(c => c.RentalId == cartRow.RentalId && c.FurnitureId == cartRow.OrderId);
            if (_selectedCartItem == null) return;

            _suppressEvents = true;
            ActiveRentalIdLabel.Text = _selectedCartItem.RentalId.ToString();
            ActiveOrderIdLabel2.Text = _selectedCartItem.FurnitureId.ToString();
            ActiveFurnitureNameLabel2.Text = _selectedCartItem.FurnitureName;

            ItemQtyNumericUpDown2.Maximum = _selectedCartItem.QuantityRemaining;
            ItemQtyNumericUpDown2.Value = _selectedCartItem.QuantityToReturn;
            _suppressEvents = false;

            UpdateCartDetailsBreakdown();
        }



        private void DueDateTimePicker_ValueChanged(object sender, EventArgs e) => UpdateOrderPanelBreakdown();
        private void ItemQtyNumericUpDown_ValueChanged(object sender, EventArgs e) => UpdateOrderPanelBreakdown();
        private void ItemQtyNumericUpDown2_ValueChanged(object sender, EventArgs e) => UpdateCartDetailsBreakdown();

        private void UpdateOrderPanelBreakdown()
        {
            if (_suppressEvents || _activeOrderItem == null) return;

            int quantity = (int)ItemQtyNumericUpDown.Value;

            decimal fineOrRefund = CalculateFineOrRefund(_activeOrderItem.RentalDate, _activeOrderItem.DueDate,
                DueDateTimePicker.Value.Date, _activeOrderItem.DailyRentalRate, quantity);

            int plannedDays = Math.Max(1, (_activeOrderItem.DueDate.Date - _activeOrderItem.RentalDate.Date).Days + 1);

            int actualDays = Math.Max(1, (DueDateTimePicker.Value.Date - _activeOrderItem.RentalDate.Date).Days + 1);
            int daysDifference = actualDays - plannedDays;

            if (daysDifference == 0)
            {
                DayFeesCalculatedLabel.Text = "On Time";
                DayFeesCalculatedLabel.ForeColor = Color.Green;
            }
            else
            {
                DayFeesCalculatedLabel.Text = daysDifference < 0 ? $"{Math.Abs(daysDifference)} Days Early" : $"{daysDifference} Days Late";
                DayFeesCalculatedLabel.ForeColor = daysDifference < 0 ? Color.DodgerBlue : Color.Red;
            }

            decimal baseCost = quantity * _activeOrderItem.DailyRentalRate * plannedDays;
            ActiveBaseCostLabel.Text = baseCost.ToString("C");

            EarlyReturnLabel.Visible = fineOrRefund < 0;
            EarlyReturnRefundLabel.Visible = fineOrRefund < 0;
            EarlyReturnRefundLabel.Text = fineOrRefund < 0 ? $"({Math.Abs(fineOrRefund):C})" : "$0.00";

            FinesLabel.Visible = fineOrRefund > 0;
            ActiveLateFinesLabel.Visible = fineOrRefund > 0;
            ActiveLateFinesLabel.Text = fineOrRefund > 0 ? $"+{fineOrRefund:C}" : "$0.00";

            decimal totalAmountDue = baseCost + fineOrRefund;
            ActiveAmountDueLabel.Text = totalAmountDue.ToString("C");
            ActiveAmountDueLabel.ForeColor = Color.Black;
        }

        private void UpdateCartDetailsBreakdown()
        {
            if (_suppressEvents || _selectedCartItem == null) return;

            int quantity = (int)ItemQtyNumericUpDown2.Value;

            decimal fineOrRefund = CalculateFineOrRefund(_selectedCartItem.RentalDate, _selectedCartItem.DueDate,
                _selectedCartItem.ReturnDate, _selectedCartItem.DailyRentalRate, quantity);

            int plannedDays = Math.Max(1, (_selectedCartItem.DueDate.Date - _selectedCartItem.RentalDate.Date).Days + 1);

            decimal baseCost = quantity * _selectedCartItem.DailyRentalRate * plannedDays;
            ActiveBaseCostLabel2.Text = baseCost.ToString("C");

            EarlyReturnRefundLabel2.Text = fineOrRefund < 0 ? $"({Math.Abs(fineOrRefund):C})" : "$0.00";
            ActiveLateFinesLabel2.Text = fineOrRefund > 0 ? $"+{fineOrRefund:C}" : "$0.00";

            decimal totalAmountDue = baseCost + fineOrRefund;
            AmountDueLabel2.Text = totalAmountDue.ToString("C");
            AmountDueLabel2.ForeColor = Color.Black;
        }


    }
}