using FurnitureRental.Controller;
using FurnitureRental.Model;
using System.Data;

namespace FurnitureRental.UserControls
{
    /// <summary>
    /// User control responsible for searching, filtering, and viewing furniture items
    /// within the furniture rental system.
    /// </summary>
    public partial class FurnitureSearchUiUserControl : UserControl
    {
        private readonly FurnitureController _furnitureController;
        public RentalCartUserControl? RentalCart { get; set; }
        private Label _errorLabel;

        /// <summary>
        /// Initializes a new instance of the <see cref="FurnitureSearchUiUserControl"/> class.
        /// </summary>
        public FurnitureSearchUiUserControl()
        {
            InitializeComponent();
            _furnitureController = new FurnitureController();

            SetupErrorLabel();
            SetupDataGridView();
            LoadComboBoxData();
            RefreshFurnitureList();
            AttachEvents();
        }

        /// <summary>
        /// Configures and adds the error reporting label to the UI panel.
        /// </summary>
        private void SetupErrorLabel()
        {
            _errorLabel = new Label
            {
                ForeColor = Color.Red,
                Location = new Point(FurnitureIdTextBox.Location.X - 130, FurnitureIdTextBox.Location.Y + 30),
                AutoSize = true,
                Text = "",
                Visible = false
            };
            this.splitContainer1.Panel1.Controls.Add(_errorLabel);
        }

        /// <summary>
        /// Configures the Furniture DataGridView columns, selection modes, and data mapping.
        /// </summary>
        private void SetupDataGridView()
        {
            FurnitureDataGridView.AutoGenerateColumns = false;
            FurnitureDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FurnitureDataGridView.MultiSelect = false;

            FurnitureDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FurnitureId", HeaderText = "Furniture ID" });
            FurnitureDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FurnitureName", HeaderText = "Name" });
            FurnitureDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CategoryName", HeaderText = "Category" });
            FurnitureDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StyleName", HeaderText = "Style" });
            FurnitureDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DailyRentalRate", HeaderText = "Rate" });
            FurnitureDataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "QuantityOnHand", DataPropertyName = "QuantityOnHand", HeaderText = "Qty" });
        }

        /// <summary>
        /// Populates the Category and Style ComboBoxes with data from the database 
        /// and inserts default "Select" prompts.
        /// </summary>
        private void LoadComboBoxData()
        {

            DataTable categoryTable = _furnitureController.GetCategories();
            categoryTable.Columns["category_id"].AllowDBNull = true;

            DataRow categoryRow = categoryTable.NewRow();
            categoryRow["category_id"] = DBNull.Value;
            categoryRow["category_name"] = "-- Select Category --";
            categoryTable.Rows.InsertAt(categoryRow, 0);

            CategoryComboBox.DataSource = categoryTable;
            CategoryComboBox.DisplayMember = "category_name";
            CategoryComboBox.ValueMember = "category_id";



            DataTable styleTable = _furnitureController.GetStyles();
            styleTable.Columns["style_id"].AllowDBNull = true;

            DataRow styleRow = styleTable.NewRow();
            styleRow["style_id"] = DBNull.Value;
            styleRow["style_name"] = "-- Select Style --";
            styleTable.Rows.InsertAt(styleRow, 0);

            StyleComboBox.DataSource = styleTable;
            StyleComboBox.DisplayMember = "style_name";
            StyleComboBox.ValueMember = "style_id";
        }

        /// <summary>
        /// Subscribes UI controls to their respective event handlers.
        /// </summary>
        private void AttachEvents()
        {
            SearchButton.Click += SearchButton_Click;
            FurnitureIdTextBox.KeyPress += FurnitureIdTextBox_KeyPress;
            FurnitureDataGridView.SelectionChanged += FurnitureDataGridView_SelectionChanged;
            CategoryComboBox.SelectedIndexChanged += FilterComboBox_SelectedIndexChanged;
            StyleComboBox.SelectedIndexChanged += FilterComboBox_SelectedIndexChanged;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event for both Category and Style ComboBoxes 
        /// to filter the furniture list dynamically.
        /// </summary>
        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FurnitureIdTextBox.Clear();
            _errorLabel.Visible = false;

            int? categoryId = CategoryComboBox.SelectedValue as int?;
            int? styleId = StyleComboBox.SelectedValue as int?;

            var results = _furnitureController.GetFurnitureByCategoryAndStyle(categoryId, styleId);
            FurnitureDataGridView.DataSource = results;
        }

        /// <summary>
        /// Restricts the Furniture ID text box to only allow numeric input and control characters.
        /// </summary>
        private void FurnitureIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Retrieves all furniture items from the database and updates the DataGridView.
        /// </summary>
        private void RefreshFurnitureList()
        {
            FurnitureDataGridView.DataSource = null;
            FurnitureDataGridView.DataSource = _furnitureController.GetAllFurniture();
        }

        /// <summary>
        /// Handles the Search button click event to find a specific furniture item by ID.
        /// </summary>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            _errorLabel.Visible = false;
            List<Furniture> results = new List<Furniture>();

            if (!string.IsNullOrWhiteSpace(FurnitureIdTextBox.Text))
            {
                if (int.TryParse(FurnitureIdTextBox.Text, out int id))
                {
                    var item = _furnitureController.GetFurnitureById(id);
                    if (item != null) results.Add(item);
                    else
                    {
                        _errorLabel.Text = "No furniture found with this ID.";
                        _errorLabel.Visible = true;
                    }
                }
            }

            FurnitureDataGridView.DataSource = results;
        }

        /// <summary>
        /// Resets the search filters, text boxes and refreshes the list to default values.
        /// </summary>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            FurnitureIdTextBox.Clear();
            FurnitureNameTextBox.Clear();

            _errorLabel.Visible = false;

            if (CategoryComboBox.Items.Count > 0)
            {
                CategoryComboBox.SelectedIndex = 0;
            }

            if (StyleComboBox.Items.Count > 0)
            {
                StyleComboBox.SelectedIndex = 0;
            }

            int? categoryId = CategoryComboBox.SelectedValue as int?;
            int? styleId = StyleComboBox.SelectedValue as int?;

            var allFurniture = _furnitureController.GetFurnitureByCategoryAndStyle(categoryId, styleId);
            FurnitureDataGridView.DataSource = allFurniture;

        }

        /// <summary>
        /// Updates the description and name labels when a different row is selected in the DataGridView.
        /// </summary>
        private void FurnitureDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (FurnitureDataGridView.SelectedRows.Count > 0)
            {
                var selectedFurniture = (Furniture)FurnitureDataGridView.SelectedRows[0].DataBoundItem;

                FurnitureNameTextBox.Text = selectedFurniture.FurnitureName;
                AddDescriptionLabel.Text = string.IsNullOrWhiteSpace(selectedFurniture.Description)
                    ? "No description available."
                    : selectedFurniture.Description;
            }
        }

        /// <summary>
        /// Validates inventory and adds the selected furniture item to the rental cart.
        /// </summary>
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (FurnitureDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Select a furniture item.");
                return;
            }

            var row = FurnitureDataGridView.CurrentRow;

            var furniture = (Furniture)row.DataBoundItem;

            object cellValue = row.Cells["QuantityOnHand"].Value;

            if (cellValue == null || !int.TryParse(cellValue.ToString(), out int qty))
            {
                MessageBox.Show("Invalid quantity value.");
                return;
            }

            if (qty <= 0)
            {
                MessageBox.Show("Selected Item Not in Stock.");
                return;
            }

            RentalCart?.AddToCart(furniture, qty);
            MessageBox.Show("Item Added to Cart.");
        }
    }
}
