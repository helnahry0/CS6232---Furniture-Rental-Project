using FurnitureRental.Model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FurnitureRental.DBAccess
{
    public class MemberDbDal
    {
        public Member? GetMemberById(int memberId)
        {
            const string query = @"
                SELECT *
                FROM dbo.Member
                WHERE member_id = @MemberId";

            using SqlConnection connection = new SqlConnection(DbHelper.ConnectionString);
            using SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@MemberId", SqlDbType.Int).Value = memberId;

            connection.Open();

            using SqlDataReader reader = cmd.ExecuteReader();

            if (!reader.Read())
                return null;

            return new Member
            {
                MemberId = Convert.ToInt32(reader["member_id"]),
                FirstName = Convert.ToString(reader["first_name"]) ?? "",
                LastName = Convert.ToString(reader["last_name"]) ?? "",
                Sex = Convert.ToString(reader["sex"]) ?? "",
                Dob = Convert.ToDateTime(reader["dob"]),
                Phone = Convert.ToString(reader["phone"]) ?? "",
                Address1 = Convert.ToString(reader["address1"]) ?? "",
                Address2 = Convert.ToString(reader["address2"]) ?? "",
                City = Convert.ToString(reader["city"]) ?? "",
                State = Convert.ToString(reader["state"]) ?? "",
                Zip = Convert.ToString(reader["zip"]) ?? ""
            };
        }

        public bool UpdateMember(Member member)
        {
            const string query = @"
                UPDATE dbo.Member
                SET first_name = @FirstName,
                    last_name = @LastName,
                    sex = @Sex,
                    dob = @DOB,
                    phone = @Phone,
                    address1 = @Address1,
                    address2 = @Address2,
                    city = @City,
                    state = @State,
                    zip = @Zip
                WHERE member_id = @MemberId";

            using SqlConnection conn = new SqlConnection(DbHelper.ConnectionString);
            using SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@FirstName", member.FirstName);
            cmd.Parameters.AddWithValue("@LastName", member.LastName);
            cmd.Parameters.AddWithValue("@Sex", member.Sex);
            cmd.Parameters.AddWithValue("@DOB", member.Dob);
            cmd.Parameters.AddWithValue("@Phone", member.Phone);
            cmd.Parameters.AddWithValue("@Address1", member.Address1);
            cmd.Parameters.AddWithValue("@Address2", member.Address2 ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@City", member.City);
            cmd.Parameters.AddWithValue("@State", member.State);
            cmd.Parameters.AddWithValue("@Zip", member.Zip);
            cmd.Parameters.AddWithValue("@MemberId", member.MemberId);

            conn.Open();
            return cmd.ExecuteNonQuery() == 1;
        }

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

            using SqlConnection connection = new SqlConnection(DbHelper.ConnectionString);
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

            using SqlConnection connection = new SqlConnection(DbHelper.ConnectionString);
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