using FurnitureRental.Model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FurnitureRental.DAL
{
    public class FurnitureDbDal
    {
        /// <summary>
        /// Gets all furniture items from the database.
        /// </summary>
        /// <returns>A list of Furniture objects.</returns>
        public List<Furniture> GetAllFurniture()
        {
            const string query = @"
                SELECT 
                    f.furniture_id, 
                    f.furniture_name, 
                    f.category_id, 
                    c.category_name, 
                    f.style_id, 
                    s.style_name, 
                    f.description, 
                    f.daily_rental_rate, 
                    f.quantity_on_hand
                FROM dbo.Furniture f
                INNER JOIN dbo.FurnitureCategory c ON f.category_id = c.category_id
                INNER JOIN dbo.FurnitureStyle s ON f.style_id = s.style_id;";

            List<Furniture> furnitureList = new List<Furniture>();

            using SqlConnection connection = new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());
            using SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                furnitureList.Add(CreateFurnitureFromReader(reader));
            }

            return furnitureList;
        }


        public DataTable GetCategories()
        {
            DataTable dt = new DataTable();
            using SqlConnection connection = new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());
            using SqlCommand command = new SqlCommand("SELECT category_id, category_name FROM FurnitureCategory", connection);
            connection.Open();
            dt.Load(command.ExecuteReader());
            return dt;
        }

        public DataTable GetStyles()
        {
            DataTable dt = new DataTable();
            using SqlConnection connection = new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());
            using SqlCommand command = new SqlCommand("SELECT style_id, style_name FROM FurnitureStyle", connection);
            connection.Open();
            dt.Load(command.ExecuteReader());
            return dt;
        }




        /// <summary>
        /// Gets a specific furniture item by its ID.
        /// </summary>
        public Furniture? GetFurnitureById(int furnitureId)
        {
            const string query = @"
                SELECT 
                    f.furniture_id, 
                    f.furniture_name, 
                    f.category_id, 
                    c.category_name, 
                    f.style_id, 
                    s.style_name, 
                    f.description, 
                    f.daily_rental_rate, 
                    f.quantity_on_hand
                FROM dbo.Furniture f
                INNER JOIN dbo.FurnitureCategory c ON f.category_id = c.category_id
                INNER JOIN dbo.FurnitureStyle s ON f.style_id = s.style_id
                WHERE f.furniture_id = @FurnitureId; ";

            using SqlConnection connection = new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@FurnitureId", SqlDbType.Int).Value = furnitureId;

            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                return CreateFurnitureFromReader(reader);
            }

            return null;
        }

        /// <summary>
        /// Searches for furniture by category and style.
        /// </summary>
        public List<Furniture> GetFurnitureByCategoryAndStyle(int? categoryId, int? styleId)
        {
            const string query = @"
                SELECT 
                    f.furniture_id, 
                    f.furniture_name, 
                    f.category_id, 
                    c.category_name, 
                    f.style_id, 
                    s.style_name, 
                    f.description, 
                    f.daily_rental_rate, 
                    f.quantity_on_hand
                FROM dbo.Furniture f
                INNER JOIN dbo.FurnitureCategory c ON f.category_id = c.category_id
                INNER JOIN dbo.FurnitureStyle s ON f.style_id = s.style_id
                WHERE (@CategoryId IS NULL OR f.category_id = @CategoryId) AND 
                (@StyleId IS NULL OR f.style_id = @StyleId);";

            List<Furniture> furnitureList = new List<Furniture>();

            using SqlConnection connection = new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@CategoryId", SqlDbType.Int).Value = (object)categoryId ?? DBNull.Value;
            command.Parameters.Add("@StyleId", SqlDbType.Int).Value = (object)styleId ?? DBNull.Value;

            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                furnitureList.Add(CreateFurnitureFromReader(reader));
            }

            return furnitureList;
        }

        
        /// <summary>
        /// Helper method to map a database row to a Furniture object.
        /// </summary>
        private static Furniture CreateFurnitureFromReader(SqlDataReader reader)
        {
            return new Furniture
            {
                FurnitureId = Convert.ToInt32(reader["furniture_id"]),
                FurnitureName = Convert.ToString(reader["furniture_name"]) ?? string.Empty,

                CategoryId = Convert.ToInt32(reader["category_id"]),
                CategoryName = Convert.ToString(reader["category_name"]) ?? string.Empty,


                StyleId = Convert.ToInt32(reader["style_id"]),
                StyleName = Convert.ToString(reader["style_name"]) ?? string.Empty,


                Description = reader["description"] == DBNull.Value
                    ? string.Empty
                    : Convert.ToString(reader["description"]) ?? string.Empty,
                DailyRentalRate = Convert.ToDecimal(reader["daily_rental_rate"]),
                QuantityOnHand = Convert.ToInt32(reader["quantity_on_hand"])
            };
        }


    }
}