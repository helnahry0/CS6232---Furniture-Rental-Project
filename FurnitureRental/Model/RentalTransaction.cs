using System.Linq;

namespace FurnitureRental.Model
{
    /// <summary>
    /// Represents a rental transaction header.
    /// </summary>
    public class RentalTransaction
    {
        /// <summary>
        /// Gets or sets the rental transaction ID.
        /// </summary>        
        public int RentalTransactionId { get; set; }

        /// <summary>
        /// Gets or sets the member ID.
        /// </summary>
        public int MemberId { get; set; }

        /// <summary>
        /// Gets or sets the employee ID.
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the rental date.
        /// </summary>
        public DateTime RentalDate { get; set; }

        /// <summary>
        /// Gets or sets the due date.
        /// </summary>
        public DateTime DueDate { get; set; }

        public List<RentalHistoryItem> Items { get; set; } = new List<RentalHistoryItem>();

        /// <summary>
        /// Gets the total cost of the rental transaction.
        /// </summary>
        public decimal TotalCost => Items.Sum(x => x.LineTotal);
    }
}