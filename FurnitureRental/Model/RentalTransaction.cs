namespace FurnitureRental.Model
{
    public class RentalTransaction
    {
        public int RentalTransactionId { get; set; }

        public int MemberId { get; set; }

        public int EmployeeId { get; set; }

        public DateTime RentalDate { get; set; }

        public DateTime DueDate { get; set; }

        public int RentalDays { get; set; }

        public List<RentalHistoryItem> Items { get; set; } = new List<RentalHistoryItem>();

        public decimal DailySubtotal => Items.Sum(x => x.LineTotal);

        public decimal TotalCost => DailySubtotal * RentalDays;
    }
}