using FurnitureRental.DAL;
using FurnitureRental.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace FurnitureRental.DAL;

/// <summary>
/// Provides database access methods for rental history data.
/// </summary>
public class RentalDbDal
{
    /// <summary>
    /// Gets all rental transactions for a specific member.
    /// </summary>
    /// <param name="memberId">The member ID.</param>
    /// <returns>A list of rental transactions for the member.</returns>
    public List<RentalTransaction> GetRentalTransactionsByMemberId(int memberId)
    {
        const string query = @"
                SELECT
                    rental_id,
                    member_id,
                    employee_id,
                    rental_date,
                    due_date
                FROM dbo.RentalTransaction
                WHERE member_id = @MemberId
                ORDER BY rental_date DESC, rental_id DESC;";

        List<RentalTransaction> rentals = new List<RentalTransaction>();

        using SqlConnection connection =
            new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());
        using SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.Add("@MemberId", SqlDbType.Int).Value = memberId;

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            rentals.Add(CreateRentalTransaction(reader));
        }

        return rentals;
    }

    /// <summary>
    /// Gets all rental detail items for a specific rental transaction.
    /// </summary>
    /// <param name="rentalId">The rental transaction ID.</param>
    /// <returns>A list of rental history items for the rental.</returns>
    public List<RentalHistoryItem> GetRentalItemsByRentalId(int rentalId)
    {
        const string query = @"
                SELECT
                    rd.rental_id,
                    rd.furniture_id,
                    f.furniture_name,
                    rd.quantity_rented,
                    f.daily_rental_rate
                FROM dbo.RentalDetail rd
                JOIN dbo.Furniture f
                    ON rd.furniture_id = f.furniture_id
                WHERE rd.rental_id = @RentalId
                ORDER BY rd.furniture_id;";

        List<RentalHistoryItem> items = new List<RentalHistoryItem>();

        using SqlConnection connection =
            new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());
        using SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.Add("@RentalId", SqlDbType.Int).Value = rentalId;

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            items.Add(CreateRentalHistoryItem(reader));
        }

        return items;
    }

    /// <summary>
    /// Creates a RentalTransaction object from a data reader row.
    /// </summary>
    /// <param name="reader">The active data reader.</param>
    /// <returns>A populated RentalTransaction object.</returns>
    private static RentalTransaction CreateRentalTransaction(SqlDataReader reader)
    {
        return new RentalTransaction
        {
            RentalId = Convert.ToInt32(reader["rental_id"]),
            MemberId = Convert.ToInt32(reader["member_id"]),
            EmployeeId = Convert.ToInt32(reader["employee_id"]),
            RentalDate = Convert.ToDateTime(reader["rental_date"]),
            DueDate = Convert.ToDateTime(reader["due_date"])
        };
    }

    /// <summary>
    /// Creates a RentalHistoryItem object from a data reader row.
    /// </summary>
    /// <param name="reader">The active data reader.</param>
    /// <returns>A populated RentalHistoryItem object.</returns>
    private static RentalHistoryItem CreateRentalHistoryItem(SqlDataReader reader)
    {
        return new RentalHistoryItem
        {
            RentalId = Convert.ToInt32(reader["rental_id"]),
            FurnitureId = Convert.ToInt32(reader["furniture_id"]),
            FurnitureName = Convert.ToString(reader["furniture_name"]) ?? string.Empty,
            QuantityRented = Convert.ToInt32(reader["quantity_rented"]),
            DailyRentalRate = Convert.ToDecimal(reader["daily_rental_rate"])
        };
    }
}