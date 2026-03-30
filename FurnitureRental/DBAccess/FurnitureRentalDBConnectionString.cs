namespace FurnitureRental.DBAccess
{
    /// <summary>
    /// This will provide a centralized location for database connection settings.
    /// </summary>
    public static class FurnitureRentalDBConnectionString
    {
        public static string GetConnectionString()
        {
            return @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FurnitureRental;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
        }
    }
}
