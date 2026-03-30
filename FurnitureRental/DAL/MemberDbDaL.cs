using FurnitureRental.Model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FurnitureRental.DAL
{
    public class MemberDbDal
    {
        /// <summary>
        /// Adds a new member
        /// </summary>
        /// <param name="member"></param
        public void AddMember(Member member)
        {
            const string query = @"
                INSERT INTO dbo.Member
                (
                    first_name,
                    last_name,
                    sex,
                    dob,
                    phone,
                    address1,
                    address2,
                    city,
                    state,
                    zip
                )
                VALUES
                (
                    @FirstName,
                    @LastName,
                    @Sex,
                    @Dob,
                    @Phone,
                    @Address1,
                    @Address2,
                    @City,
                    @State,
                    @Zip
                );";

            using SqlConnection connection =
                new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());
            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = member.FirstName;
            command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = member.LastName;
            command.Parameters.Add("@Sex", SqlDbType.VarChar).Value = member.Sex;
            command.Parameters.Add("@Dob", SqlDbType.Date).Value = member.Dob;
            command.Parameters.Add("@Phone", SqlDbType.VarChar).Value = member.Phone;
            command.Parameters.Add("@Address1", SqlDbType.VarChar).Value = member.Address1;
            command.Parameters.Add("@Address2", SqlDbType.VarChar).Value =
                string.IsNullOrWhiteSpace(member.Address2) ? DBNull.Value : member.Address2;
            command.Parameters.Add("@City", SqlDbType.VarChar).Value = member.City;
            command.Parameters.Add("@State", SqlDbType.Char).Value = member.State;
            command.Parameters.Add("@Zip", SqlDbType.VarChar).Value = member.Zip;

            connection.Open();
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Gets the member by id.
        /// </summary>
        /// <param name="memberId">The member identifier.</param>
        /// <returns></returns>
        public Member? GetMemberById(int memberId)
        {
            const string query = @"
                SELECT
                    member_id,
                    first_name,
                    last_name,
                    sex,
                    dob,
                    phone,
                    address1,
                    address2,
                    city,
                    state,
                    zip
                FROM dbo.Member
                WHERE member_id = @MemberId;";

            using SqlConnection connection =
                new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());
            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@MemberId", SqlDbType.Int).Value = memberId;

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                return null;
            }

            return CreateMember(reader);
        }

        /// <summary>
        /// Gets the member by phone.
        /// </summary>
        /// <param name="phone">The phone.</param>
        /// <returns></returns>
        public Member? GetMemberByPhone(string phone)
        {
            const string query = @"
                SELECT
                    member_id,
                    first_name,
                    last_name,
                    sex,
                    dob,
                    phone,
                    address1,
                    address2,
                    city,
                    state,
                    zip
                FROM dbo.Member
                WHERE phone = @Phone;";

            using SqlConnection connection =
                new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());
            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@Phone", SqlDbType.VarChar).Value = phone;

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                return null;
            }

            return CreateMember(reader);
        }

        /// <summary>
        /// Gets the members by full name.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <returns></returns>
        public List<Member> GetMembersByFullName(string firstName, string lastName)
        {
            const string query = @"
                SELECT
                    member_id,
                    first_name,
                    last_name,
                    sex,
                    dob,
                    phone,
                    address1,
                    address2,
                    city,
                    state,
                    zip
                FROM dbo.Member
                WHERE first_name = @FirstName
                  AND last_name = @LastName;";

            List<Member> members = new List<Member>();

            using SqlConnection connection =
                new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());
            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = firstName;
            command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = lastName;

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                members.Add(CreateMember(reader));
            }

            return members;
        }

        public List<Member> GetAllMembers()
        {
            const string query = @"
        SELECT
            member_id,
            first_name,
            last_name,
            sex,
            dob,
            phone,
            address1,
            address2,
            city,
            state,
            zip
        FROM dbo.Member
        ORDER BY last_name, first_name;";

            List<Member> members = new List<Member>();

            using SqlConnection connection =
                new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());
            using SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                members.Add(new Member
                {
                    MemberId = Convert.ToInt32(reader["member_id"]),
                    FirstName = Convert.ToString(reader["first_name"]) ?? string.Empty,
                    LastName = Convert.ToString(reader["last_name"]) ?? string.Empty,
                    Sex = Convert.ToString(reader["sex"]) ?? string.Empty,
                    Dob = Convert.ToDateTime(reader["dob"]),
                    Phone = Convert.ToString(reader["phone"]) ?? string.Empty,
                    Address1 = Convert.ToString(reader["address1"]) ?? string.Empty,
                    Address2 = reader["address2"] == DBNull.Value
                        ? string.Empty
                        : Convert.ToString(reader["address2"]) ?? string.Empty,
                    City = Convert.ToString(reader["city"]) ?? string.Empty,
                    State = Convert.ToString(reader["state"]) ?? string.Empty,
                    Zip = Convert.ToString(reader["zip"]) ?? string.Empty
                });
            }

            return members;
        }

        /// <summary>
        /// Updates the member.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <returns></returns>
        public bool UpdateMember(Member member)
        {
            const string query = @"
                UPDATE dbo.Member
                SET
                    first_name = @FirstName,
                    last_name = @LastName,
                    sex = @Sex,
                    dob = @Dob,
                    phone = @Phone,
                    address1 = @Address1,
                    address2 = @Address2,
                    city = @City,
                    state = @State,
                    zip = @Zip
                WHERE member_id = @MemberId;";

            using SqlConnection connection =
                new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());
            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = member.FirstName;
            command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = member.LastName;
            command.Parameters.Add("@Sex", SqlDbType.VarChar).Value = member.Sex;
            command.Parameters.Add("@Dob", SqlDbType.Date).Value = member.Dob;
            command.Parameters.Add("@Phone", SqlDbType.VarChar).Value = member.Phone;
            command.Parameters.Add("@Address1", SqlDbType.VarChar).Value = member.Address1;
            command.Parameters.Add("@Address2", SqlDbType.VarChar).Value =
                string.IsNullOrWhiteSpace(member.Address2) ? DBNull.Value : member.Address2;
            command.Parameters.Add("@City", SqlDbType.VarChar).Value = member.City;
            command.Parameters.Add("@State", SqlDbType.Char).Value = member.State;
            command.Parameters.Add("@Zip", SqlDbType.VarChar).Value = member.Zip;
            command.Parameters.Add("@MemberId", SqlDbType.Int).Value = member.MemberId;

            connection.Open();
            return command.ExecuteNonQuery() == 1;
        }

        /// <summary>
        /// Creates the member.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns></returns>
        private static Member CreateMember(SqlDataReader reader)
        {
            return new Member
            {
                MemberId = Convert.ToInt32(reader["member_id"]),
                FirstName = Convert.ToString(reader["first_name"]) ?? string.Empty,
                LastName = Convert.ToString(reader["last_name"]) ?? string.Empty,
                Sex = Convert.ToString(reader["sex"]) ?? string.Empty,
                Dob = Convert.ToDateTime(reader["dob"]),
                Phone = Convert.ToString(reader["phone"]) ?? string.Empty,
                Address1 = Convert.ToString(reader["address1"]) ?? string.Empty,
                Address2 = reader["address2"] == DBNull.Value
                    ? string.Empty
                    : Convert.ToString(reader["address2"]) ?? string.Empty,
                City = Convert.ToString(reader["city"]) ?? string.Empty,
                State = Convert.ToString(reader["state"]) ?? string.Empty,
                Zip = Convert.ToString(reader["zip"]) ?? string.Empty
            };
        }
    }
}