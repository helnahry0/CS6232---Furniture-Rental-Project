using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRental.Model
{
    public class PopularFurnitureReportItem
    {
        public int FurnitureId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string FurnitureName { get; set; } = string.Empty;
        public int RentalTransactionCount { get; set; }
        public int TotalRentalTransactions { get; set; }
        public decimal RentalPercentage { get; set; }
        public decimal Age18To29Percentage { get; set; }
        public decimal Outside18To29Percentage { get; set; }
    }
}
