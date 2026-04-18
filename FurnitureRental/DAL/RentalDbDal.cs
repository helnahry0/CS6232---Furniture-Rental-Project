using FurnitureRental.Model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FurnitureRental.DAL
{
    /// <summary>
    /// Provides database access methods for rental history data and rental submission.
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
        /// Gets the rental history transactions for a specific member, including employee name,
        /// return dates, and total cost.
        /// </summary>
        /// <param name="memberId">The member ID.</param>
        /// <returns>A list of rental history transaction rows.</returns>
        public List<RentalHistoryTransaction> GetRentalHistoryTransactionsByMemberId(int memberId)
        {
            const string query = @"
                SELECT
                    rt.rental_id,
                    rt.rental_date,
                    rt.due_date,
                    e.first_name + ' ' + e.last_name AS employee_name,
                    SUM(
                        rd.quantity_rented
                        * f.daily_rental_rate
                        * (DATEDIFF(DAY, rt.rental_date, rt.due_date) + 1)
                    ) AS total_cost,
                    ISNULL(
                        STRING_AGG(CONVERT(VARCHAR(10), rtt.return_date, 101), ', '),
                        'Not Returned'
                    ) AS return_dates
                FROM dbo.RentalTransaction rt
                JOIN dbo.Employee e
                    ON rt.employee_id = e.employee_id
                JOIN dbo.RentalDetail rd
                    ON rt.rental_id = rd.rental_id
                JOIN dbo.Furniture f
                    ON rd.furniture_id = f.furniture_id
                LEFT JOIN dbo.ReturnDetail rtd
                    ON rd.rental_id = rtd.rental_id
                   AND rd.furniture_id = rtd.furniture_id
                LEFT JOIN dbo.ReturnTransaction rtt
                    ON rtd.return_id = rtt.return_id
                WHERE rt.member_id = @MemberId
                GROUP BY
                    rt.rental_id,
                    rt.rental_date,
                    rt.due_date,
                    e.first_name,
                    e.last_name
                ORDER BY rt.rental_date DESC, rt.rental_id DESC;";

            List<RentalHistoryTransaction> rentals = new List<RentalHistoryTransaction>();

            using SqlConnection connection =
                new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());
            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@MemberId", SqlDbType.Int).Value = memberId;

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                rentals.Add(CreateRentalHistoryTransaction(reader));
            }

            return rentals;
        }

        /// <summary>
        /// Submits the rental transaction.
        /// </summary>
        /// <param name="rentalTransaction">The rental transaction.</param>
        /// <returns>The saved rental transaction with its generated ID.</returns>
        /// <exception cref="ApplicationException">
        /// Thrown when a furniture item does not exist or there is not enough quantity on hand.
        /// </exception>
        public RentalTransaction SubmitRentalTransaction(RentalTransaction rentalTransaction)
        {
            using SqlConnection connection =
                new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());

            connection.Open();

            using SqlTransaction dbTransaction = connection.BeginTransaction();

            try
            {
                rentalTransaction.RentalTransactionId =
                    InsertRentalTransaction(rentalTransaction, connection, dbTransaction);

                foreach (RentalHistoryItem item in rentalTransaction.Items)
                {
                    FurnitureRentalItemInfo itemInfo =
                        GetFurnitureRentalItemInfo(item.FurnitureId, connection, dbTransaction);

                    if (itemInfo == null)
                    {
                        throw new ApplicationException($"Furniture ID {item.FurnitureId} was not found.");
                    }

                    if (item.QuantityRented > itemInfo.QuantityOnHand)
                    {
                        throw new ApplicationException(
                            $"Not enough quantity on hand for furniture ID {item.FurnitureId}. Available: {itemInfo.QuantityOnHand}.");
                    }

                    item.RentalId = rentalTransaction.RentalTransactionId;
                    item.FurnitureName = itemInfo.FurnitureName;
                    item.DailyRentalRate = itemInfo.DailyRentalRate;
                    item.RentalDate = rentalTransaction.RentalDate;
                    item.DueDate = rentalTransaction.DueDate;

                    InsertRentalDetail(item, connection, dbTransaction);
                    UpdateFurnitureQuantityOnHand(item.FurnitureId, item.QuantityRented, connection, dbTransaction);
                }

                dbTransaction.Commit();
                return rentalTransaction;
            }
            catch
            {
                dbTransaction.Rollback();
                throw;
            }
        }

        /// <summary>
        /// Inserts the rental transaction.
        /// </summary>
        /// <param name="rentalTransaction">The rental transaction.</param>
        /// <param name="connection">The connection.</param>
        /// <param name="dbTransaction">The database transaction.</param>
        /// <returns>The generated rental transaction ID.</returns>
        private static int InsertRentalTransaction(
            RentalTransaction rentalTransaction,
            SqlConnection connection,
            SqlTransaction dbTransaction)
        {
            const string query = @"
                INSERT INTO dbo.RentalTransaction
                (
                    member_id,
                    employee_id,
                    rental_date,
                    due_date
                )
                VALUES
                (
                    @MemberId,
                    @EmployeeId,
                    @RentalDate,
                    @DueDate
                );

                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using SqlCommand command = new SqlCommand(query, connection, dbTransaction);

            command.Parameters.Add("@MemberId", SqlDbType.Int).Value = rentalTransaction.MemberId;
            command.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = rentalTransaction.EmployeeId;
            command.Parameters.Add("@RentalDate", SqlDbType.DateTime).Value = rentalTransaction.RentalDate;
            command.Parameters.Add("@DueDate", SqlDbType.DateTime).Value = rentalTransaction.DueDate;

            return (int)command.ExecuteScalar()!;
        }

        /// <summary>
        /// Inserts the rental detail row.
        /// </summary>
        /// <param name="rentalItem">The rental item.</param>
        /// <param name="connection">The connection.</param>
        /// <param name="dbTransaction">The database transaction.</param>
        private static void InsertRentalDetail(
            RentalHistoryItem rentalItem,
            SqlConnection connection,
            SqlTransaction dbTransaction)
        {
            const string query = @"
                INSERT INTO dbo.RentalDetail
                (
                    rental_id,
                    furniture_id,
                    quantity_rented
                )
                VALUES
                (
                    @RentalId,
                    @FurnitureId,
                    @QuantityRented
                );";

            using SqlCommand command = new SqlCommand(query, connection, dbTransaction);

            command.Parameters.Add("@RentalId", SqlDbType.Int).Value = rentalItem.RentalId;
            command.Parameters.Add("@FurnitureId", SqlDbType.Int).Value = rentalItem.FurnitureId;
            command.Parameters.Add("@QuantityRented", SqlDbType.Int).Value = rentalItem.QuantityRented;

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Updates the furniture quantity on hand.
        /// </summary>
        /// <param name="furnitureId">The furniture ID.</param>
        /// <param name="quantityRented">The quantity rented.</param>
        /// <param name="connection">The connection.</param>
        /// <param name="dbTransaction">The database transaction.</param>
        private static void UpdateFurnitureQuantityOnHand(
            int furnitureId,
            int quantityRented,
            SqlConnection connection,
            SqlTransaction dbTransaction)
        {
            const string query = @"
                UPDATE dbo.Furniture
                SET quantity_on_hand = quantity_on_hand - @QuantityRented
                WHERE furniture_id = @FurnitureId;";

            using SqlCommand command = new SqlCommand(query, connection, dbTransaction);

            command.Parameters.Add("@FurnitureId", SqlDbType.Int).Value = furnitureId;
            command.Parameters.Add("@QuantityRented", SqlDbType.Int).Value = quantityRented;

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Gets the rental item information for a furniture item.
        /// </summary>
        /// <param name="furnitureId">The furniture ID.</param>
        /// <param name="connection">The connection.</param>
        /// <param name="dbTransaction">The database transaction.</param>
        /// <returns>The rental item information.</returns>
        private static FurnitureRentalItemInfo GetFurnitureRentalItemInfo(
            int furnitureId,
            SqlConnection connection,
            SqlTransaction dbTransaction)
        {
            const string query = @"
                SELECT
                    furniture_id,
                    furniture_name,
                    daily_rental_rate,
                    quantity_on_hand
                FROM dbo.Furniture
                WHERE furniture_id = @FurnitureId;";

            using SqlCommand command = new SqlCommand(query, connection, dbTransaction);
            command.Parameters.Add("@FurnitureId", SqlDbType.Int).Value = furnitureId;

            using SqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                reader.Close();
                return null!;
            }

            FurnitureRentalItemInfo itemInfo = new FurnitureRentalItemInfo
            {
                FurnitureId = Convert.ToInt32(reader["furniture_id"]),
                FurnitureName = Convert.ToString(reader["furniture_name"]) ?? string.Empty,
                DailyRentalRate = Convert.ToDecimal(reader["daily_rental_rate"]),
                QuantityOnHand = Convert.ToInt32(reader["quantity_on_hand"])
            };

            reader.Close();
            return itemInfo;
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
                    f.daily_rental_rate,
                    rt.rental_date,
                    rt.due_date
                FROM dbo.RentalDetail rd
                JOIN dbo.Furniture f
                    ON rd.furniture_id = f.furniture_id
                JOIN dbo.RentalTransaction rt
                    ON rd.rental_id = rt.rental_id
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
                RentalTransactionId = Convert.ToInt32(reader["rental_id"]),
                MemberId = Convert.ToInt32(reader["member_id"]),
                EmployeeId = Convert.ToInt32(reader["employee_id"]),
                RentalDate = Convert.ToDateTime(reader["rental_date"]),
                DueDate = Convert.ToDateTime(reader["due_date"])
            };
        }

        /// <summary>
        /// Creates a RentalHistoryTransaction object from a data reader row.
        /// </summary>
        /// <param name="reader">The active data reader.</param>
        /// <returns>A populated RentalHistoryTransaction object.</returns>
        private static RentalHistoryTransaction CreateRentalHistoryTransaction(SqlDataReader reader)
        {
            return new RentalHistoryTransaction
            {
                RentalTransactionId = Convert.ToInt32(reader["rental_id"]),
                RentalDate = Convert.ToDateTime(reader["rental_date"]),
                DueDate = Convert.ToDateTime(reader["due_date"]),
                EmployeeName = Convert.ToString(reader["employee_name"]) ?? string.Empty,
                ReturnDates = Convert.ToString(reader["return_dates"]) ?? "Not Returned",
                TotalCost = Convert.ToDecimal(reader["total_cost"])
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
                DailyRentalRate = Convert.ToDecimal(reader["daily_rental_rate"]),
                RentalDate = Convert.ToDateTime(reader["rental_date"]),
                DueDate = Convert.ToDateTime(reader["due_date"])
            };
        }

        /// <summary>
        /// Gets the cart items for a member.
        /// </summary>
        /// <param name="memberId">The member ID.</param>
        /// <returns>A list of cart items.</returns>
        public List<CartItem> GetCartItems(int memberId)
        {
            List<CartItem> list = new List<CartItem>();

            string query = @"
                SELECT 
                    f.furniture_id,
                    f.furniture_name,
                    f.daily_rental_rate,
                    rd.quantity_rented
                FROM dbo.RentalTransaction rt
                JOIN dbo.RentalDetail rd ON rt.rental_id = rd.rental_id
                JOIN dbo.Furniture f ON rd.furniture_id = f.furniture_id
                WHERE rt.member_id = @MemberId
                ORDER BY rt.rental_id DESC;";

            using SqlConnection connection =
                new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());
            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MemberId", memberId);

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int qty = Convert.ToInt32(reader["quantity_rented"]);
                decimal rate = Convert.ToDecimal(reader["daily_rental_rate"]);

                list.Add(new CartItem
                {
                    FurnitureId = Convert.ToInt32(reader["furniture_id"]),
                    Name = reader["furniture_name"].ToString()!,
                    DailyRate = rate,
                    Quantity = qty
                });
            }

            return list;
        }

        /// <summary>
        /// Stores furniture rental item metadata used during rental submission.
        /// </summary>
        private class FurnitureRentalItemInfo
        {
            public int FurnitureId { get; set; }

            public string FurnitureName { get; set; } = string.Empty;

            public decimal DailyRentalRate { get; set; }

            public int QuantityOnHand { get; set; }
        }
    }
}