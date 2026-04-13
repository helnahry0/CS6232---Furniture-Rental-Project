namespace FurnitureRental.Model
{
   public class CartItem
    {
        public int FurnitureId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal DailyRate { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => DailyRate * Quantity;
    }
}

