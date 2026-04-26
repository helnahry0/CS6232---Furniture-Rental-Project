using FurnitureRental.DBL;
using FurnitureRental.Model;

namespace FurnitureRental.Controller
{    
    public class ReportController
    {
        private readonly ReportDbDal _reportDbDal;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportController"/> class.
        /// </summary>
        public ReportController()
        {
            _reportDbDal = new ReportDbDal();
        }

        /// <summary>
        /// Attempts to get most popular furniter report for given dates.
        /// </summary>
        /// <param name="startDate">The entered member ID.</param>
        /// <param name="endDate">The resulting return transactions.</param>
        /// <param name="errorMessage">The error message if lookup fails.</param>
        /// <returns>List of Most Popular furniture data if found; otherwise None.</returns>
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
