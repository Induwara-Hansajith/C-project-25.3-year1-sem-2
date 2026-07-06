using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempleManagementSystem.Data;
using TempleManagementSystem.Model;

namespace TempleManagementSystem.Services
{
    public class DanaRequestService
    {
        private readonly string _connectionString = @"Data Source=HANSAJITH\SQLEXPRESS;
              Initial Catalog=TempleManagementDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        private DatabaseHelper db = new DatabaseHelper();

        public void SubmitRequest(DanaRequest request)
        {
            string query = @"INSERT INTO DanaRequests
                    (DonorID, DanaDate, DanaType, MealType, Status, RequestDate)
                    VALUES
                    (@DonorID, @DanaDate, @DanaType, @MealType, @Status, @RequestDate)";

            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@DonorID", request.DonorID);
                cmd.Parameters.AddWithValue("@DanaDate", request.DanaDate);
                cmd.Parameters.AddWithValue("@DanaType", request.DanaType);
                cmd.Parameters.AddWithValue("@MealType", request.MealType);
                cmd.Parameters.AddWithValue("@Status", request.Status);
                cmd.Parameters.AddWithValue("@RequestDate", request.RequestDate);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void UpdateRequestStatus(int requestId, string newStatus)
        {
            string query = "UPDATE DanaRequests SET Status = @Status WHERE RequestID = @RequestID";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    cmd.Parameters.AddWithValue("@RequestID", requestId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 2. The public methods your Form will call
        public void ApproveRequest(int requestId)
        {
            UpdateRequestStatus(requestId, "Approved");
        }

        public void RejectRequest(int requestId)
        {
            UpdateRequestStatus(requestId, "Rejected");
        }

        public void HoldRequest(int requestId)
        {
            UpdateRequestStatus(requestId, "Hold");
        }
        public List<DanaRequest> GetAllRequests()
        {
            List<DanaRequest> requests = new List<DanaRequest>();

            string query = "SELECT * FROM DanaRequests";

            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);

                
                con.Open();   

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DanaRequest request = new DanaRequest();

                    request.RequestID = Convert.ToInt32(reader["RequestID"]);
                    request.DonorID = Convert.ToInt32(reader["DonorID"]);
                    request.DanaDate = Convert.ToDateTime(reader["DanaDate"]);
                    request.DanaType = reader["DanaType"].ToString();
                    request.MealType = reader["MealType"].ToString();
                    request.Status = reader["Status"].ToString();
                    request.RequestDate = Convert.ToDateTime(reader["RequestDate"]);

                    requests.Add(request);
                }
            }

            return requests;
        }

        public List<DanaRequest> GetRequestsByDonor(int donorId)
        {
            List<DanaRequest> requests = new List<DanaRequest>();

            string query = "SELECT * FROM DanaRequests WHERE DonorID = @DonorID";

            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@DonorID", donorId);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DanaRequest request = new DanaRequest();

                    request.RequestID = Convert.ToInt32(reader["RequestID"]);
                    request.DonorID = Convert.ToInt32(reader["DonorID"]);
                    request.DanaDate = Convert.ToDateTime(reader["DanaDate"]);
                    request.DanaType = reader["DanaType"].ToString();
                    request.MealType = reader["MealType"].ToString();
                    request.Status = reader["Status"].ToString();
                    request.RequestDate = Convert.ToDateTime(reader["RequestDate"]);

                    requests.Add(request);
                }
            }

            return requests;
        }

        public void ApproveAndCreateOffering(int requestId)
        {
            // We use a transaction so if one part fails, the whole thing cancels safely
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // 1. Update the Request Status to 'Approved'
                        string updateQuery = "UPDATE DanaRequests SET Status = 'Approved' WHERE RequestID = @RequestID";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, con, transaction))
                        {
                            updateCmd.Parameters.AddWithValue("@RequestID", requestId);
                            updateCmd.ExecuteNonQuery();
                        }

                        // 2. Fetch the details of the approved request so we can copy them
                        int donorId = 0;
                        DateTime danaDate = DateTime.Now;
                        string mealType = "Other";

                        string selectQuery = "SELECT DonorID, DanaDate, MealType FROM DanaRequests WHERE RequestID = @RequestID";
                        using (SqlCommand selectCmd = new SqlCommand(selectQuery, con, transaction))
                        {
                            selectCmd.Parameters.AddWithValue("@RequestID", requestId);
                            using (SqlDataReader reader = selectCmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    donorId = Convert.ToInt32(reader["DonorID"]);
                                    danaDate = Convert.ToDateTime(reader["DanaDate"]);
                                    mealType = reader["MealType"].ToString();
                                }
                            }
                        }

                        // 3. Insert the new Upcoming Offering into the DanaOfferings table
                        string insertQuery = @"INSERT INTO DanaOfferings (DonorID, DanaDate, MealType, Status, NumberOfPeople) 
                                       VALUES (@DonorID, @DanaDate, @MealType, 'Upcoming', 0)";
                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, con, transaction))
                        {
                            insertCmd.Parameters.AddWithValue("@DonorID", donorId);
                            insertCmd.Parameters.AddWithValue("@DanaDate", danaDate);
                            insertCmd.Parameters.AddWithValue("@MealType", mealType);
                            insertCmd.ExecuteNonQuery();
                        }

                        // If everything worked perfectly, commit the changes to the database
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        // If anything went wrong, roll back the changes to prevent broken data
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}