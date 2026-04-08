namespace FurnitureRental.Model
{
    public class FurnitureCategory
    {
        /// <summary>
        /// Gets or sets the Category identifier.
        /// </summary>
        /// <value> The Category identifier. </value>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the Category Name.
        /// </summary>
        /// <value> The Category Name. </value>
        public string CategoryName { get; set; } = string.Empty;
    }
}
