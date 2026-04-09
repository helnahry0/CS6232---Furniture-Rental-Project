namespace FurnitureRental.Model
{
    public class FurnitureItemSummary
    {
        public int FurnitureId { get; set; }
        public string FurnitureName { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public string StyleName { get; set; } = string.Empty;
        public decimal DailyRentalRate { get; set; }
        public int QuantityOnHand { get; set; }
    }
}