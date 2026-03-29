using FurnitureRental.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace FurnitureRental.DBAcess
{
    public class MemberDal
    {

        public void AddMember(Member member)
        {
            const string query = @"
                INSERT INTO dbo.Member (
                            first_name, last_name, sex, dob, 
                            phone, address1, address2, city, state, zip )
                VALUES(
                        @FirstName, @LastName, @Sex, @Dob, @Phone, 
                        @Address1, @Address2, @City, @State, @Zip );";

            using SqlConnection connection = new SqlConnection(FurnitureRentalDBConnectionString.GetConnectionString());
            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = member.FirstName;
            command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = member.LastName;
            command.Parameters.Add("@Sex", SqlDbType.VarChar).Value = member.Sex;
            command.Parameters.Add("@Dob", SqlDbType.Date).Value = member.Dob;
            command.Parameters.Add("@Phone", SqlDbType.VarChar).Value = member.Phone;
            command.Parameters.Add("@Address1", SqlDbType.VarChar).Value = member.Address1;
            command.Parameters.Add("@Address2", SqlDbType.VarChar).Value = (object?)member.Address2 ?? DBNull.Value;
            command.Parameters.Add("@City", SqlDbType.VarChar).Value = member.City;
            command.Parameters.Add("@State", SqlDbType.Char).Value = member.State;
            command.Parameters.Add("@Zip", SqlDbType.VarChar).Value = member.Zip;

            connection.Open();
            command.ExecuteNonQuery();
        }

    }
}