namespace FurnitureRental.Model
{
    /// <summary>
    /// Represents a return transaction row shown in return history.
    /// </summary>
    public class ReturnHistoryTransaction
    {
        /// <summary>
        /// Gets or sets the return transaction ID.
        /// </summary>
        public int ReturnId { get; set; }

        /// <summary>
        /// Gets or sets the return date.
        /// </summary>
        public DateTime ReturnDate { get; set; }

        /// <summary>
        /// Gets or sets the employee full name.
        /// </summary>
        public string EmployeeName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the total fine or refund for the return transaction.
        /// Positive values mean fines. Negative values mean refunds.
        /// </summary>
        public decimal TotalFineOrRefund { get; set; }
    }
}
