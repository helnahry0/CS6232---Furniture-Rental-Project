namespace FurnitureRental.Model
{
    /// <summary>
    /// Represents an item being returned in a return transaction.
    /// </summary>
    public class ReturnItem
    {
        /// <summary>
        /// Gets or sets the return transaction ID.
        /// </summary>
        public int ReturnId { get; set; }

        /// <summary>
        /// Gets or sets the original rental transaction ID.
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
        /// Gets or sets the quantity already returned across prior return transactions.
        /// </summary>
        public int QuantityAlreadyReturned { get; set; }

        /// <summary>
        /// Gets or sets the quantity still available to return.
        /// </summary>
        public int QuantityRemaining { get; set; }

        /// <summary>
        /// Gets or sets the quantity being returned in the current return transaction.
        /// </summary>
        public int QuantityToReturn { get; set; }

        /// <summary>
        /// Gets or sets the original rental date.
        /// </summary>
        public DateTime RentalDate { get; set; }

        /// <summary>
        /// Gets or sets the original due date.
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets or sets the current return date.
        /// </summary>
        public DateTime ReturnDate { get; set; }

        /// <summary>
        /// Gets or sets the daily rental rate.
        /// </summary>
        public decimal DailyRentalRate { get; set; }

        /// <summary>
        /// Gets or sets the fine or refund amount for this return item.
        /// Positive values represent fines. Negative values represent refunds.
        /// </summary>
        public decimal FineOrRefundAmount { get; set; }

        /// <summary>
        /// Gets the number of planned rental days.
        /// </summary>
        public int PlannedRentalDays => (DueDate.Date - RentalDate.Date).Days + 1;

        /// <summary>
        /// Gets the number of actual rental days used through the return date.
        /// </summary>
        public int ActualRentalDays => (ReturnDate.Date - RentalDate.Date).Days + 1;
    }
}