using System.Configuration;

namespace FurnitureRental.DBAcess
{
    public static class DbHelper
    {
        public static string ConnectionString =>
            ConfigurationManager.ConnectionStrings["FurnitureRentalDb"].ConnectionString;
    }
}