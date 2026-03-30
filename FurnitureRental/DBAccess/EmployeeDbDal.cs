using FurnitureRental.Model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FurnitureRental.DBAccess
{
    public class EmployeeDbDal
    {
        public Employee? AuthenticateEmployee(string username, string password)
        {
            const string query = @"
                SELECT
                    employee_id,
                    role,
                    first_name,
                    last_name,
                    username,
                    password
                FROM dbo.Employee
                WHERE username = @Username
                  AND password = @Password;";

            using SqlConnection connection =
    new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());
            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                return null;
            }

            return new Employee
            {
                EmployeeId = Convert.ToInt32(reader["employee_id"]),
                Role = Convert.ToString(reader["role"]) ?? string.Empty,
                FirstName = Convert.ToString(reader["first_name"]) ?? string.Empty,
                LastName = Convert.ToString(reader["last_name"]) ?? string.Empty,
                Username = Convert.ToString(reader["username"]) ?? string.Empty,
                Password = Convert.ToString(reader["password"]) ?? string.Empty
            };
        }
    }
}