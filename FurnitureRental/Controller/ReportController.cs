using FurnitureRental.DBL;
using FurnitureRental.Model;

namespace FurnitureRental.Controller
{    
    public class ReportController
    {
        private readonly ReportDbDal _reportDbDal;

        public ReportController()
        {
            _reportDbDal = new ReportDbDal();
        }

        public List<PopularFurnitureReportItem> GetMostPopularFurnitureDuringDates(
        DateTime startDate,
        DateTime endDate)
        { 
            try
            {
                return _reportDbDal.GetMostPopularFurnitureDuringDates(startDate, endDate);
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex); 
                return new List<PopularFurnitureReportItem>();
            }
        }
    }
}
