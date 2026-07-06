using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TempleManagementSystem.Data;
using TempleManagementSystem.Model;

namespace TempleManagementSystem.Services
{
    public class DanaOfferingService
    {
        private readonly string _connectionString = @"Data Source=HANSAJITH\SQLEXPRESS;
              Initial Catalog=TempleManagementDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        private DatabaseHelper db = new DatabaseHelper();

        public void AddDanaOffering(DanaOffering offering)
        {
            string query = @"INSERT INTO DanaOfferings
                    (DonorID, EventID, DanaDate, MealType,
                     NumberOfPeople, Description, Status)
                    VALUES
                    (@DonorID, @EventID, @DanaDate, @MealType,
                     @NumberOfPeople, @Description, @Status)";

            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@DonorID", offering.DonorID);
                cmd.Parameters.AddWithValue("@EventID", offering.EventID);
                cmd.Parameters.AddWithValue("@DanaDate", offering.DanaDate);
                cmd.Parameters.AddWithValue("@MealType", offering.MealType);
                cmd.Parameters.AddWithValue("@NumberOfPeople", offering.NumberOfPeople);
                cmd.Parameters.AddWithValue("@Description", offering.Description);
                cmd.Parameters.AddWithValue("@Status", offering.Status);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateDanaOffering(DanaOffering offering)
        {
            string query = @"UPDATE DanaOfferings
                     SET DonorID = @DonorID,
                         EventID = @EventID,
                         DanaDate = @DanaDate,
                         MealType = @MealType,
                         NumberOfPeople = @NumberOfPeople,
                         Description = @Description,
                         Status = @Status
                     WHERE DanaID = @DanaID";

            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@DanaID", offering.DanaID);
                cmd.Parameters.AddWithValue("@DonorID", offering.DonorID);
                cmd.Parameters.AddWithValue("@EventID", offering.EventID);
                cmd.Parameters.AddWithValue("@DanaDate", offering.DanaDate);
                cmd.Parameters.AddWithValue("@MealType", offering.MealType);
                cmd.Parameters.AddWithValue("@NumberOfPeople", offering.NumberOfPeople);
                cmd.Parameters.AddWithValue("@Description", offering.Description);
                cmd.Parameters.AddWithValue("@Status", offering.Status);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void CancelDanaOffering(int danaID)
        {
            string query = @"UPDATE DanaOfferings
                     SET Status = 'Cancelled'
                     WHERE DanaID = @DanaID";

            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@DanaID", danaID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<DanaOffering> GetUpcomingDanaOfferings()
        {
            List<DanaOffering> offerings = new List<DanaOffering>();

            string query = "SELECT * FROM DanaOfferings WHERE Status = 'Upcoming'";

            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DanaOffering offering = new DanaOffering();

                    offering.DanaID = Convert.ToInt32(reader["DanaID"]);
                    offering.DonorID = Convert.ToInt32(reader["DonorID"]);
                    offering.EventID = reader["EventID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["EventID"]);
                    offering.DanaDate = Convert.ToDateTime(reader["DanaDate"]);
                    offering.MealType = reader["MealType"].ToString();
                    offering.NumberOfPeople = Convert.ToInt32(reader["NumberOfPeople"]);
                    offering.Description = reader["Description"].ToString();
                    offering.Status = reader["Status"].ToString();
                    offering.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);

                    offerings.Add(offering);
                }
            }

            return offerings;
        }

        public List<DanaOffering> GetCompletedDanaOfferings()
        {
            List<DanaOffering> offerings = new List<DanaOffering>();

            string query = "SELECT * FROM DanaOfferings WHERE Status = 'Completed'";

            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DanaOffering offering = new DanaOffering();

                    offering.DanaID = Convert.ToInt32(reader["DanaID"]);
                    offering.DonorID = Convert.ToInt32(reader["DonorID"]);
                    offering.EventID = reader["EventID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["EventID"]);
                    offering.DanaDate = Convert.ToDateTime(reader["DanaDate"]);
                    offering.MealType = reader["MealType"].ToString();
                    offering.NumberOfPeople = Convert.ToInt32(reader["NumberOfPeople"]);
                    offering.Description = reader["Description"].ToString();
                    offering.Status = reader["Status"].ToString();
                    offering.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);

                    offerings.Add(offering);
                }
            }

            return offerings;
        }

        public List<DanaOffering> GetUpcomingDanaOfferingsByDonor(int donorId)
        {
            List<DanaOffering> offerings = new List<DanaOffering>();

            string query = @"SELECT * FROM DanaOfferings
                     WHERE DonorID = @DonorID
                     AND Status = 'Upcoming'";

            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@DonorID", donorId);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DanaOffering offering = new DanaOffering();

                    offering.DanaID = Convert.ToInt32(reader["DanaID"]);
                    offering.DonorID = Convert.ToInt32(reader["DonorID"]);
                    offering.EventID = reader["EventID"] == DBNull.Value
                                        ? 0
                                        : Convert.ToInt32(reader["EventID"]);
                    offering.DanaDate = Convert.ToDateTime(reader["DanaDate"]);
                    offering.MealType = reader["MealType"].ToString();
                    offering.NumberOfPeople = Convert.ToInt32(reader["NumberOfPeople"]);
                    offering.Description = reader["Description"].ToString();
                    offering.Status = reader["Status"].ToString();
                    offering.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);

                    offerings.Add(offering);
                }
            }

            return offerings;
        }

        public List<DanaOffering> GetAllDanaOfferings()
        {
            List<DanaOffering> offerings = new List<DanaOffering>();

            string query = "SELECT * FROM DanaOfferings";

            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DanaOffering offering = new DanaOffering();

                    offering.DanaID = Convert.ToInt32(reader["DanaID"]);
                    offering.DonorID = Convert.ToInt32(reader["DonorID"]);
                    offering.EventID = reader["EventID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["EventID"]);
                    offering.DanaDate = Convert.ToDateTime(reader["DanaDate"]);
                    offering.MealType = reader["MealType"].ToString();
                    offering.NumberOfPeople = Convert.ToInt32(reader["NumberOfPeople"]);
                    offering.Description = reader["Description"].ToString();
                    offering.Status = reader["Status"].ToString();
                    offering.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);

                    offerings.Add(offering);
                }
            }

            return offerings;
        }

        public void MarkOfferingAsCompleted(int danaID)
        {
            string query = "UPDATE DanaOfferings SET Status = 'Completed' WHERE DanaID = @DanaID";

            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@DanaID", danaID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}