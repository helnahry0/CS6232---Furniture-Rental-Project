namespace FurnitureRental.Model
{
    /// <summary>
    /// Represents a return transaction.
    /// </summary>
    public class ReturnTransaction
    {
        /// <summary>
        /// Gets or sets the return transaction ID.
        /// </summary>
        public int ReturnId { get; set; }

        /// <summary>
        /// Gets or sets the member ID for the return transaction.
        /// </summary>
        public int MemberId { get; set; }

        /// <summary>
        /// Gets or sets the employee ID for the return transaction.
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the date the return transaction is processed.
        /// </summary>
        public DateTime ReturnDate { get; set; }

        /// <summary>
        /// Gets or sets the items included in the return transaction.
        /// </summary>
        public List<ReturnItem> Items { get; set; } = new List<ReturnItem>();

        /// <summary>
        /// Gets the total fine or refund amount for the return transaction.
        /// </summary>
        public decimal TotalFineOrRefund => Items.Sum(item => item.FineOrRefundAmount);
    }
}