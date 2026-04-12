using FurnitureRental.Controller;
using FurnitureRental.Model;

namespace FurnitureRental.UserControls
{
    public partial class FurnitureSearchUiUserControl : UserControl
    {
        private readonly FurnitureController _furnitureController;

        public RentalCartUserControl? RentalCart { get; set; }

        public FurnitureSearchUiUserControl()
        {
            InitializeComponent();
            _furnitureController = new FurnitureController();
        }

        /*
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (dgvFurniture.CurrentRow == null)
            {
                MessageBox.Show("Select a furniture item.");
                return;
            }

            var furniture = (Furniture)dgvFurniture.CurrentRow.DataBoundItem;

            int qty = (int)numQty.Value;

            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.");
                return;
            }

            RentalCart?.AddToCart(furniture, qty);
        }
        */
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            Furniture furniture = new Furniture
            {
                FurnitureId = 10,
                FurnitureName = "Bed",
                DailyRentalRate = 20
            };

            int qty = 1;

            RentalCart?.AddToCart(furniture, qty);

            furniture.FurnitureId = 11;
            furniture.FurnitureName = "Dining Table";
            furniture.DailyRentalRate = 10;
            qty = 1;
            RentalCart?.AddToCart(furniture, qty);

            MessageBox.Show("TEST :: Added a furniture item.");
        }
    }
}
