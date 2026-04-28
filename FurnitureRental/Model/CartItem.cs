namespace FurnitureRental.Model
{
    /// <summary>
    /// Model representing an item in the shopping cart, including details about the furniture, quantity, and pricing.
    /// </summary>
    public class CartItem
    {
        /// <summary>
        /// Gets or sets the furniture identifier.
        /// </summary>
        /// <value>
        /// The furniture identifier.
        /// </value>
/        public int FurnitureId { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the daily rate.
        /// </summary>
        /// <value>
        /// The daily rate.
        /// </value>
        public decimal DailyRate { get; set; }
        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>
        /// The quantity.
        /// </value>
        public int Quantity { get; set; }
        /// <summary>
        /// Gets or sets the quantity on hand.
        /// </summary>
        /// <value>
        /// The quantity on hand.
        /// </value>
        public int QuantityOnHand { get; set; }
        /// <summary>
        /// Gets the total price.
        /// </summary>
        /// <value>
        /// The total price.
        /// </value>
        public decimal TotalPrice => DailyRate * Quantity;
    }
}

