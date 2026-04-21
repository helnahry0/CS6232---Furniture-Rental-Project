namespace FurnitureRental.Model
{
    /// <summary>
    /// Represents a rental item that is still eligible to be returned.
    /// </summary>
    public class ReturnableRentalItem
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
        /// Gets or sets the quantity originally rented.
        /// </summary>
        public int QuantityRented { get; set; }

        /// <summary>
        /// Gets or sets the quantity already returned.
        /// </summary>
        public int QuantityAlreadyReturned { get; set; }

        /// <summary>
        /// Gets or sets the quantity still available to return.
        /// </summary>
        public int QuantityRemaining { get; set; }

        /// <summary>
        /// Gets or sets the rental date.
        /// </summary>
        public DateTime RentalDate { get; set; }

        /// <summary>
        /// Gets or sets the due date.
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets or sets the daily rental rate.
        /// </summary>
        public decimal DailyRentalRate { get; set; }
    }
}