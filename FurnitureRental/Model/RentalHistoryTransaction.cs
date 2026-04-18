namespace FurnitureRental.Model
{
    /// <summary>
    /// Represents a rental transaction row shown in rental history.
    /// </summary>
    public class RentalHistoryTransaction
    {
        /// <summary>
        /// Gets or sets the rental transaction ID.
        /// </summary>
        public int RentalTransactionId { get; set; }

        /// <summary>
        /// Gets or sets the rental date.
        /// </summary>
        public DateTime RentalDate { get; set; }

        /// <summary>
        /// Gets or sets the due date.
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets or sets the employee full name.
        /// </summary>
        public string EmployeeName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the return dates summary.
        /// </summary>
        public string ReturnDates { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the total cost of the rental transaction.
        /// </summary>
        public decimal TotalCost { get; set; }
    }
}