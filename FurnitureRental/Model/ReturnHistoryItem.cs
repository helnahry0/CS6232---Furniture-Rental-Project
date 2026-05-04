namespace FurnitureRental.Model
{
    /// <summary>
    /// Represents an item shown in return history detail.
    /// </summary>
    public class ReturnHistoryItem
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
        /// Gets or sets the quantity returned in this return transaction.
        /// </summary>
        public int QuantityReturned { get; set; }

        /// <summary>
        /// Gets or sets the fine or refund amount for this item.
        /// Positive values mean fines. Negative values mean refunds.
        /// </summary>
        public decimal FineOrRefundAmount { get; set; }
        /// <summary>
        /// Gets the line total.
        /// </summary>
        /// <value>
        /// The line total.
        /// </value>
        public decimal LineTotal => QuantityReturned * FineOrRefundAmount;
    }
}
