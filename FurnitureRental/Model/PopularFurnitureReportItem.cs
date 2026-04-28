/// <summary>
/// Model representing an item in the popular furniture report, including details about the furniture, rental transaction counts, and demographic percentages.
/// </summary>
namespace FurnitureRental.Model
{
    public class PopularFurnitureReportItem
    {
        /// <summary>
        /// Gets or sets the furniture identifier.
        /// </summary>
        /// <value>
        /// The furniture identifier.
        /// </value>
        public int FurnitureId { get; set; }
        /// <summary>
        /// Gets or sets the name of the category.
        /// </summary>
        /// <value>
        /// The name of the category.
        /// </value>
        public string CategoryName { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the name of the furniture.
        /// </summary>
        /// <value>
        /// The name of the furniture.
        /// </value>
        public string FurnitureName { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the rental transaction count.
        /// </summary>
        /// <value>
        /// The rental transaction count.
        /// </value>
        public int RentalTransactionCount { get; set; }
        /// <summary>
        /// Gets or sets the total rental transactions.
        /// </summary>
        /// <value>
        /// The total rental transactions.
        /// </value>
        public int TotalRentalTransactions { get; set; }
        /// <summary>
        /// Gets or sets the rental percentage.
        /// </summary>
        /// <value>
        /// The rental percentage.
        /// </value>
        public decimal RentalPercentage { get; set; }
        /// <summary>
        /// Gets or sets the percentage of rentals by customers aged 18 to 29.
        /// </summary>
        /// <value>
        /// The percentage of rentals by customers aged 18 to 29.
        /// </value>
        public decimal Age18To29Percentage { get; set; }
        /// <summary>
        /// Gets or sets the percentage of rentals by customers outside the age range of 18 to 29.
        /// </summary>
        /// <value>
        /// The percentage of rentals by customers outside the age range of 18 to 29.
        /// </value>
        public decimal Outside18To29Percentage { get; set; }
    }
}
