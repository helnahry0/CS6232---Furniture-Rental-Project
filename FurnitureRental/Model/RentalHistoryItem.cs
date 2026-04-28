namespace FurnitureRental.Model
{
    /// <summary>
    /// Represents an item shown in rental history detail.
    /// </summary>
    public class RentalHistoryItem
    {
        /// <summary>
        /// Gets or sets the rental transaction ID.
        /// </summary>
        public int RentalId { get; set; }

        /// <summary>
        /// Gets or sets the furniture ID.
        /// </summary>
        public int FurnitureId { get; set; }

        /// <summary>
        /// Gets or sets the furniture name.
        /// </summary>
        public string FurnitureName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the quantity rented.
        /// </summary>
        public int QuantityRented { get; set; }

        /// <summary>
        /// Gets or sets the daily rental rate.
        /// </summary>
        public decimal DailyRentalRate { get; set; }

        /// <summary>
        /// Gets or sets the rental date.
        /// </summary>
        /// <value>
        /// The rental date.
        /// </value>
        public DateTime RentalDate { get; set; }

        /// <summary>
        /// Gets or sets the due date.
        /// </summary>
        /// <value>
        /// The due date.
        /// </value>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets the rental days.
        /// </summary>
        /// <value>
        /// The rental days.
        /// </value>
        public int RentalDays => (DueDate.Date - RentalDate.Date).Days + 1;

        /// <summary>
        /// Gets the line total for the rental item.
        /// </summary>
        public decimal LineTotal => QuantityRented * DailyRentalRate * RentalDays;
    }
}