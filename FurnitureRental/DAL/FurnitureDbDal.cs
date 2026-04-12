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
                    furniture_id, 
                    furniture_name, 
                    category_id,
                    category_name,
                    style_id, 
                    style_name,
                    description, 
                    daily_rental_rate, 
                    quantity_on_hand
                FROM dbo.Furniture;";

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

        /// <summary>
        /// Gets a specific furniture item by its ID.
        /// </summary>
        public Furniture? GetFurnitureById(int furnitureId)
        {
            const string query = @"
                SELECT 
                    furniture_id, 
                    furniture_name, 
                    category_id,
                    category_name,
                    style_id, 
                    style_name,
                    description, 
                    daily_rental_rate, 
                    quantity_on_hand
                FROM dbo.Furniture
                WHERE furniture_id = @FurnitureId;";

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
        public List<Furniture> GetFurnitureByCategoryAndStyle(int categoryId, int styleId)
        {
            const string query = @"
                SELECT 
                    furniture_id, 
                    furniture_name, 
                    category_id,
                    category_name,
                    style_id, 
                    style_name,
                    description, 
                    daily_rental_rate, 
                    quantity_on_hand
                FROM dbo.Furniture
                WHERE category_id = @CategoryId AND style_id = @StyleId;";

            List<Furniture> furnitureList = new List<Furniture>();

            using SqlConnection connection = new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@CategoryId", SqlDbType.Int).Value = categoryId;
            command.Parameters.Add("@StyleId", SqlDbType.Int).Value = styleId;

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