using System.Configuration;

namespace FurnitureRental.DBAccess
{
    public static class DbHelper
    {
        public static string ConnectionString =>
            ConfigurationManager.ConnectionStrings["FurnitureRentalDB"].ConnectionString;
    }
}