using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TempleManagementSystem.Data;
using TempleManagementSystem.Model;

namespace TempleManagementSystem.Services
{
    public class DonorService
    {
        private DatabaseHelper db = new DatabaseHelper();

        // 1. ADD DONOR
        public void AddDonor(Donor donor)
        {
            string query = @"INSERT INTO Donors (FullName, ContactNumber, Email, Address)
                             VALUES (@FullName, @ContactNumber, @Email, @Address)";

            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FullName", donor.Name);
                cmd.Parameters.AddWithValue("@ContactNumber", donor.PhoneNumber);
                cmd.Parameters.AddWithValue("@Email", donor.Email);
                cmd.Parameters.AddWithValue("@Address", donor.Address);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // 2. UPDATE DONOR
        public void UpdateDonor(Donor donor)
        {
            string query = @"UPDATE Donors
                             SET FullName = @FullName,
                                 ContactNumber = @ContactNumber,
                                 Email = @Email,
                                 Address = @Address
                             WHERE DonorID = @DonorID";

            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@DonorID", donor.DonorID);
                cmd.Parameters.AddWithValue("@FullName", donor.Name);
                cmd.Parameters.AddWithValue("@ContactNumber", donor.PhoneNumber);
                cmd.Parameters.AddWithValue("@Email", donor.Email);
                cmd.Parameters.AddWithValue("@Address", donor.Address);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // 3. DELETE DONOR
        public void DeleteDonor(int donorId)
        {
            string query = "DELETE FROM Donors WHERE DonorID = @DonorID";
            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@DonorID", donorId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // 4. SEARCH DONOR
        public List<Donor> SearchDonor(string keyword)
        {
            List<Donor> donors = new List<Donor>();
            string query = @"SELECT DonorID, FullName, ContactNumber, Email, Address
                             FROM Donors
                             WHERE CAST(DonorID AS NVARCHAR(20)) LIKE @Keyword
                             OR FullName LIKE @Keyword
                             ORDER BY FullName;";

            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    donors.Add(MapReaderToDonor(reader));
                }
            }
            return donors;
        }

        // 5. GET ALL DONORS
        public List<Donor> GetAllDonors()
        {
            List<Donor> donors = new List<Donor>();
            string query = "SELECT DonorID, FullName, ContactNumber, Email, Address FROM Donors";

            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    donors.Add(MapReaderToDonor(reader));
                }
            }
            return donors;
        }

        // 6. GET DONOR BY ID
        public Donor GetDonorById(int donorId)
        {
            string query = "SELECT DonorID, FullName, ContactNumber, Email, Address FROM Donors WHERE DonorID = @DonorID";

            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@DonorID", donorId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) return MapReaderToDonor(reader);
            }
            return null;
        }

        // HELPER METHOD TO REDUCE CODE REPETITION
        private Donor MapReaderToDonor(SqlDataReader reader)
        {
            return new Donor
            {
                DonorID = Convert.ToInt32(reader["DonorID"]),
                Name = reader["FullName"].ToString(),
                PhoneNumber = reader["ContactNumber"].ToString(),
                Email = reader["Email"].ToString(),
                Address = reader["Address"].ToString()
            };
        }
    }
}