using FurnitureRental.Model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FurnitureRental.DAL
{
    /// <summary>
    /// Provides database access methods for return processing and returnable item lookup.
    /// </summary>
    public class ReturnDbDal
    {
        /// <summary>
        /// Gets all rental items for a member that still have quantity available to return.
        /// </summary>
        /// <param name="memberId">The member ID.</param>
        /// <returns>A list of returnable rental items.</returns>
        public List<ReturnableRentalItem> GetReturnableItemsByMemberId(int memberId)
        {
            const string query = @"
                SELECT
                    rt.rental_id,
                    rt.employee_id,
                    rd.furniture_id,
                    f.furniture_name,
                    rd.quantity_rented,
                    ISNULL(SUM(rtd.quantity_returned), 0) AS quantity_already_returned,
                    rd.quantity_rented - ISNULL(SUM(rtd.quantity_returned), 0) AS quantity_remaining,
                    rt.rental_date,
                    rt.due_date,
                    f.daily_rental_rate
                FROM dbo.RentalTransaction rt
                JOIN dbo.RentalDetail rd
                    ON rt.rental_id = rd.rental_id
                JOIN dbo.Furniture f
                    ON rd.furniture_id = f.furniture_id
                LEFT JOIN dbo.ReturnDetail rtd
                    ON rd.rental_id = rtd.rental_id
                   AND rd.furniture_id = rtd.furniture_id
                WHERE rt.member_id = @MemberId
                GROUP BY
                    rt.rental_id,
                    rt.employee_id,
                    rd.furniture_id,
                    f.furniture_name,
                    rd.quantity_rented,
                    rt.rental_date,
                    rt.due_date,
                    f.daily_rental_rate
                HAVING rd.quantity_rented - ISNULL(SUM(rtd.quantity_returned), 0) > 0
                ORDER BY rt.rental_date DESC, rt.rental_id DESC, rd.furniture_id;";

            List<ReturnableRentalItem> items = new List<ReturnableRentalItem>();

            using SqlConnection connection =
                new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());
            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@MemberId", SqlDbType.Int).Value = memberId;

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                items.Add(CreateReturnableRentalItem(reader));
            }

            return items;
        }

        /// <summary>
        /// Gets the return history transactions by member identifier.
        /// </summary>
        /// <param name="memberId">The member identifier.</param>
        /// <returns></returns>
        public List<ReturnHistoryTransaction> GetReturnHistoryTransactionsByMemberId(int memberId)
        {
            const string query = @"
        SELECT
            rt.return_id,
            rt.return_date,
            e.first_name + ' ' + e.last_name AS employee_name,
            ISNULL(SUM(rd.fine_or_refund_amount), 0) AS total_fine_or_refund
        FROM dbo.ReturnTransaction rt
        JOIN dbo.Employee e
            ON rt.employee_id = e.employee_id
        LEFT JOIN dbo.ReturnDetail rd
            ON rt.return_id = rd.return_id
        WHERE rt.member_id = @MemberId
        GROUP BY
            rt.return_id,
            rt.return_date,
            e.first_name,
            e.last_name
        ORDER BY rt.return_date DESC, rt.return_id DESC;";

            List<ReturnHistoryTransaction> returns = new List<ReturnHistoryTransaction>();

            using SqlConnection connection =
                new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());
            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@MemberId", SqlDbType.Int).Value = memberId;

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                returns.Add(CreateReturnHistoryTransaction(reader));
            }

            return returns;
        }

        /// <summary>
        /// Gets the return history items by return identifier.
        /// </summary>
        /// <param name="returnId">The return identifier.</param>
        /// <returns></returns>
        public List<ReturnHistoryItem> GetReturnHistoryItemsByReturnId(int returnId)
        {
            const string query = @"
        SELECT
            rd.return_id,
            rd.rental_id,
            rd.furniture_id,
            f.furniture_name,
            rd.quantity_returned,
            rd.fine_or_refund_amount
        FROM dbo.ReturnDetail rd
        JOIN dbo.Furniture f
            ON rd.furniture_id = f.furniture_id
        WHERE rd.return_id = @ReturnId
        ORDER BY rd.rental_id, rd.furniture_id;";

            List<ReturnHistoryItem> items = new List<ReturnHistoryItem>();

            using SqlConnection connection =
                new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());
            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@ReturnId", SqlDbType.Int).Value = returnId;

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                items.Add(CreateReturnHistoryItem(reader));
            }

            return items;
        }


        private static ReturnHistoryTransaction CreateReturnHistoryTransaction(SqlDataReader reader)
        {
            return new ReturnHistoryTransaction
            {
                ReturnId = Convert.ToInt32(reader["return_id"]),
                ReturnDate = Convert.ToDateTime(reader["return_date"]),
                EmployeeName = Convert.ToString(reader["employee_name"]) ?? string.Empty,
                TotalFineOrRefund = Convert.ToDecimal(reader["total_fine_or_refund"])
            };
        }


        private static ReturnHistoryItem CreateReturnHistoryItem(SqlDataReader reader)
        {
            return new ReturnHistoryItem
            {
                ReturnId = Convert.ToInt32(reader["return_id"]),
                RentalId = Convert.ToInt32(reader["rental_id"]),
                FurnitureId = Convert.ToInt32(reader["furniture_id"]),
                FurnitureName = Convert.ToString(reader["furniture_name"]) ?? string.Empty,
                QuantityReturned = Convert.ToInt32(reader["quantity_returned"]),
                FineOrRefundAmount = Convert.ToDecimal(reader["fine_or_refund_amount"])
            };
        }


        /// <summary>
        /// Submits a return transaction and its detail rows.
        /// </summary>
        /// <param name="returnTransaction">The return transaction to save.</param>
        /// <returns>The saved return transaction with its generated return ID.</returns>
        /// <exception cref="ApplicationException">
        /// Thrown when a return item is invalid or exceeds the remaining returnable quantity.
        /// </exception>
        public ReturnTransaction SubmitReturnTransaction(ReturnTransaction returnTransaction)
        {
            using SqlConnection connection =
                new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());

            connection.Open();

            using SqlTransaction dbTransaction = connection.BeginTransaction();

            try
            {
                returnTransaction.ReturnId =
                    InsertReturnTransaction(returnTransaction, connection, dbTransaction);

                foreach (ReturnItem item in returnTransaction.Items)
                {
                    ReturnableItemInfo itemInfo =
                        GetReturnableItemInfo(item.RentalId, item.FurnitureId, connection, dbTransaction);

                    if (itemInfo == null)
                    {
                        throw new ApplicationException(
                            $"Returnable item was not found for rental ID {item.RentalId} and furniture ID {item.FurnitureId}.");
                    }

                    if (item.QuantityToReturn <= 0)
                    {
                        throw new ApplicationException(
                            $"Return quantity must be greater than zero for furniture ID {item.FurnitureId}.");
                    }

                    if (item.QuantityToReturn > itemInfo.QuantityRemaining)
                    {
                        throw new ApplicationException(
                            $"Cannot return more than remaining quantity for furniture ID {item.FurnitureId}. Remaining: {itemInfo.QuantityRemaining}.");
                    }

                    item.ReturnId = returnTransaction.ReturnId;
                    item.FurnitureName = itemInfo.FurnitureName;
                    item.DailyRentalRate = itemInfo.DailyRentalRate;
                    item.QuantityRented = itemInfo.QuantityRented;
                    item.QuantityAlreadyReturned = itemInfo.QuantityAlreadyReturned;
                    item.QuantityRemaining = itemInfo.QuantityRemaining;
                    item.RentalDate = itemInfo.RentalDate;
                    item.DueDate = itemInfo.DueDate;
                    item.ReturnDate = returnTransaction.ReturnDate;

                    InsertReturnDetail(item, connection, dbTransaction);
                    UpdateFurnitureQuantityOnHand(item.FurnitureId, item.QuantityToReturn, connection, dbTransaction);
                }

                dbTransaction.Commit();
                return returnTransaction;
            }
            catch
            {
                dbTransaction.Rollback();
                throw;
            }
        }

        /// <summary>
        /// Inserts a return transaction header row.
        /// </summary>
        /// <param name="returnTransaction">The return transaction.</param>
        /// <param name="connection">The open connection.</param>
        /// <param name="dbTransaction">The active database transaction.</param>
        /// <returns>The generated return ID.</returns>
        private static int InsertReturnTransaction(
            ReturnTransaction returnTransaction,
            SqlConnection connection,
            SqlTransaction dbTransaction)
        {
            const string query = @"
                INSERT INTO dbo.ReturnTransaction
                (
                    member_id,
                    employee_id,
                    return_date
                )
                VALUES
                (
                    @MemberId,
                    @EmployeeId,
                    @ReturnDate
                );

                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using SqlCommand command = new SqlCommand(query, connection, dbTransaction);

            command.Parameters.Add("@MemberId", SqlDbType.Int).Value = returnTransaction.MemberId;
            command.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = returnTransaction.EmployeeId;
            command.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = returnTransaction.ReturnDate;

            return (int)command.ExecuteScalar()!;
        }

        /// <summary>
        /// Inserts a return detail row.
        /// </summary>
        /// <param name="returnItem">The return item.</param>
        /// <param name="connection">The open connection.</param>
        /// <param name="dbTransaction">The active database transaction.</param>
        private static void InsertReturnDetail(
            ReturnItem returnItem,
            SqlConnection connection,
            SqlTransaction dbTransaction)
        {
            const string query = @"
                INSERT INTO dbo.ReturnDetail
                (
                    return_id,
                    rental_id,
                    furniture_id,
                    quantity_returned,
                    fine_or_refund_amount
                )
                VALUES
                (
                    @ReturnId,
                    @RentalId,
                    @FurnitureId,
                    @QuantityReturned,
                    @FineOrRefundAmount
                );";

            using SqlCommand command = new SqlCommand(query, connection, dbTransaction);

            command.Parameters.Add("@ReturnId", SqlDbType.Int).Value = returnItem.ReturnId;
            command.Parameters.Add("@RentalId", SqlDbType.Int).Value = returnItem.RentalId;
            command.Parameters.Add("@FurnitureId", SqlDbType.Int).Value = returnItem.FurnitureId;
            command.Parameters.Add("@QuantityReturned", SqlDbType.Int).Value = returnItem.QuantityToReturn;
            command.Parameters.Add("@FineOrRefundAmount", SqlDbType.Decimal).Value = returnItem.FineOrRefundAmount;

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Increases furniture quantity on hand when an item is returned.
        /// </summary>
        /// <param name="furnitureId">The furniture ID.</param>
        /// <param name="quantityReturned">The quantity returned.</param>
        /// <param name="connection">The open connection.</param>
        /// <param name="dbTransaction">The active database transaction.</param>
        private static void UpdateFurnitureQuantityOnHand(
            int furnitureId,
            int quantityReturned,
            SqlConnection connection,
            SqlTransaction dbTransaction)
        {
            const string query = @"
                UPDATE dbo.Furniture
                SET quantity_on_hand = quantity_on_hand + @QuantityReturned
                WHERE furniture_id = @FurnitureId;";

            using SqlCommand command = new SqlCommand(query, connection, dbTransaction);

            command.Parameters.Add("@FurnitureId", SqlDbType.Int).Value = furnitureId;
            command.Parameters.Add("@QuantityReturned", SqlDbType.Int).Value = quantityReturned;

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Gets the current returnable information for a rental item.
        /// </summary>
        /// <param name="rentalId">The rental transaction ID.</param>
        /// <param name="furnitureId">The furniture ID.</param>
        /// <param name="connection">The open connection.</param>
        /// <param name="dbTransaction">The active database transaction.</param>
        /// <returns>Returnable item information for validation and persistence.</returns>
        private static ReturnableItemInfo GetReturnableItemInfo(
            int rentalId,
            int furnitureId,
            SqlConnection connection,
            SqlTransaction dbTransaction)
        {
            const string query = @"
                SELECT
                    rd.rental_id,
                    rd.furniture_id,
                    f.furniture_name,
                    rd.quantity_rented,
                    ISNULL(SUM(rtd.quantity_returned), 0) AS quantity_already_returned,
                    rd.quantity_rented - ISNULL(SUM(rtd.quantity_returned), 0) AS quantity_remaining,
                    rt.rental_date,
                    rt.due_date,
                    f.daily_rental_rate
                FROM dbo.RentalDetail rd
                JOIN dbo.RentalTransaction rt
                    ON rd.rental_id = rt.rental_id
                JOIN dbo.Furniture f
                    ON rd.furniture_id = f.furniture_id
                LEFT JOIN dbo.ReturnDetail rtd
                    ON rd.rental_id = rtd.rental_id
                   AND rd.furniture_id = rtd.furniture_id
                WHERE rd.rental_id = @RentalId
                  AND rd.furniture_id = @FurnitureId
                GROUP BY
                    rd.rental_id,
                    rd.furniture_id,
                    f.furniture_name,
                    rd.quantity_rented,
                    rt.rental_date,
                    rt.due_date,
                    f.daily_rental_rate;";

            using SqlCommand command = new SqlCommand(query, connection, dbTransaction);
            command.Parameters.Add("@RentalId", SqlDbType.Int).Value = rentalId;
            command.Parameters.Add("@FurnitureId", SqlDbType.Int).Value = furnitureId;

            using SqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                reader.Close();
                return null!;
            }

            ReturnableItemInfo itemInfo = new ReturnableItemInfo
            {
                RentalId = Convert.ToInt32(reader["rental_id"]),
                FurnitureId = Convert.ToInt32(reader["furniture_id"]),
                FurnitureName = Convert.ToString(reader["furniture_name"]) ?? string.Empty,
                QuantityRented = Convert.ToInt32(reader["quantity_rented"]),
                QuantityAlreadyReturned = Convert.ToInt32(reader["quantity_already_returned"]),
                QuantityRemaining = Convert.ToInt32(reader["quantity_remaining"]),
                RentalDate = Convert.ToDateTime(reader["rental_date"]),
                DueDate = Convert.ToDateTime(reader["due_date"]),
                DailyRentalRate = Convert.ToDecimal(reader["daily_rental_rate"])
            };

            reader.Close();
            return itemInfo;
        }

        /// <summary>
        /// Creates a returnable rental item from a data reader row.
        /// </summary>
        /// <param name="reader">The active data reader.</param>
        /// <returns>A populated ReturnableRentalItem object.</returns>
        private static ReturnableRentalItem CreateReturnableRentalItem(SqlDataReader reader)
        {
            return new ReturnableRentalItem
            {
                RentalId = Convert.ToInt32(reader["rental_id"]),
                EmployeeId = Convert.ToInt32(reader["employee_id"]),
                FurnitureId = Convert.ToInt32(reader["furniture_id"]),
                FurnitureName = Convert.ToString(reader["furniture_name"]) ?? string.Empty,
                QuantityRented = Convert.ToInt32(reader["quantity_rented"]),
                QuantityAlreadyReturned = Convert.ToInt32(reader["quantity_already_returned"]),
                QuantityRemaining = Convert.ToInt32(reader["quantity_remaining"]),
                RentalDate = Convert.ToDateTime(reader["rental_date"]),
                DueDate = Convert.ToDateTime(reader["due_date"]),
                DailyRentalRate = Convert.ToDecimal(reader["daily_rental_rate"])
            };
        }

        /// <summary>
        /// Stores returnable item metadata used during return submission.
        /// </summary>
        private class ReturnableItemInfo
        {
            public int RentalId { get; set; }

            public int FurnitureId { get; set; }

            public string FurnitureName { get; set; } = string.Empty;

            public int QuantityRented { get; set; }

            public int QuantityAlreadyReturned { get; set; }

            public int QuantityRemaining { get; set; }

            public DateTime RentalDate { get; set; }

            public DateTime DueDate { get; set; }

            public decimal DailyRentalRate { get; set; }
        }
    }
}