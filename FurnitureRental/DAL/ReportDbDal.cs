using FurnitureRental.DAL;
using FurnitureRental.Model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FurnitureRental.DBL
{
    public class ReportDbDal
    {
        public List<PopularFurnitureReportItem> GetMostPopularFurnitureDuringDates(
            DateTime startDate,
            DateTime endDate)
        {
            List<PopularFurnitureReportItem> results = new();           


            using SqlConnection connection = new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());
            using SqlCommand command = new SqlCommand("dbo.getMostPopularFurnitureDuringDates", connection);
            
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@StartDate", SqlDbType.Date).Value = startDate.Date;
            command.Parameters.Add("@EndDate", SqlDbType.Date).Value = endDate.Date;

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                results.Add(new PopularFurnitureReportItem
                {
                    FurnitureId = Convert.ToInt32(reader["furniture_id"]),
                    CategoryName = Convert.ToString(reader["category_name"]) ?? string.Empty,
                    FurnitureName = Convert.ToString(reader["furniture_name"]) ?? string.Empty,
                    RentalTransactionCount = Convert.ToInt32(reader["rental_transaction_count"]),
                    TotalRentalTransactions = Convert.ToInt32(reader["total_rental_transactions"]),
                    RentalPercentage = Convert.ToDecimal(reader["rental_percentage"]),
                    Age18To29Percentage = Convert.ToDecimal(reader["age18to29_percentage"]),
                    Outside18To29Percentage = Convert.ToDecimal(reader["outside18to29_percentage"])
                });
            }

            return results;
        }
    }
}