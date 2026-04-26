namespace FurnitureRental.Model
{
    /// <summary>
    /// Represents a rental line item that still has quantity available to be returned.
    /// Returned by the DAL when loading returnable items for a given member.
    /// </summary>
    public class ReturnableRentalItem
    {
        /// <summary>
        /// Gets or sets the rental transaction ID this item belongs to.
        /// </summary>
        public int RentalId { get; set; }

        /// <summary>
        /// Gets or sets the furniture ID (Order ID).
        /// </summary>
        public int FurnitureId { get; set; }

        /// <summary>
        /// Gets or sets the furniture name.
        /// </summary>
        public string FurnitureName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the total quantity originally rented in this order line.
        /// </summary>
        public int QuantityRented { get; set; }

        /// <summary>
        /// Gets or sets the quantity already returned across all prior return transactions.
        /// </summary>
        public int QuantityAlreadyReturned { get; set; }

        /// <summary>
        /// Gets or sets the quantity still available to return (QuantityRented minus QuantityAlreadyReturned).
        /// </summary>
        public int QuantityRemaining { get; set; }

        /// <summary>
        /// Gets or sets the date the rental transaction was created.
        /// </summary>
        public DateTime RentalDate { get; set; }

        /// <summary>
        /// Gets or sets the scheduled due date for the rental.
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets or sets the daily rental rate for this furniture item.
        /// </summary>
        public decimal DailyRentalRate { get; set; }

        /// <summary>
        /// Gets or sets the employee ID responsible for checking out the rental.
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets the number of planned rental days (inclusive of both rental date and due date).
        /// </summary>
        public int PlannedDays => (DueDate.Date - RentalDate.Date).Days + 1;

        /// <summary>
        /// Gets the current status based on whether the due date has passed.
        /// Returns "Out-Late" if overdue, otherwise "Out".
        /// </summary>
        public string Status => DueDate.Date < DateTime.Today ? "Out-Late" : "Out";

        /// <summary>
        /// Gets the total base cost for the remaining quantity over the planned rental period.
        /// </summary>
        public decimal BaseCost => QuantityRemaining * DailyRentalRate * PlannedDays;
    }
}
