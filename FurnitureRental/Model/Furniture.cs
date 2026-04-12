namespace FurnitureRental.Model
{
    /// <summary>
    ///  Furniture class represents a piece of furniture in the furniture rental service.  
    /// </summary>
    public class Furniture
    {
        /// <summary>
        /// Gets or sets the Furniture identifier.
        /// </summary>
        /// <value> The Furniture identifier. </value>
        public int FurnitureId { get; set; }

        /// <summary>
        /// Gets or sets the Category identifier.
        /// </summary>
        /// <value> The Category identifier. </value>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the Category Name.
        /// </summary>
        /// <value> The Category Name. </value>
        public string CategoryName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Style identifier.
        /// </summary>
        /// <value> The Style identifier. </value>
        public int StyleId { get; set; }

        /// <summary>
        /// Gets or sets the Style Name.
        /// </summary>
        /// <value> The Style Name. </value>
        public string StyleName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Furniture Name.
        /// </summary>
        /// <value> The Furniture Name. </value>
        public string FurnitureName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Furniture Description.
        /// </summary>
        /// <value> The Furniture Description. </value>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Daily Rental Rate.
        /// </summary>
        /// <value> The Daily Rental Rate. </value>
        public decimal DailyRentalRate { get; set; }

        /// <summary>
        /// Gets or sets the Quantity On Hand.
        /// </summary>
        /// <value> The Quantity On Hand. </value>
        public int QuantityOnHand { get; set; }

    }
}
