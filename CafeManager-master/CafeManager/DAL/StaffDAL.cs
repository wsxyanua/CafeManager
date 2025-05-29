using System;
using System.Data;
using System.Data.SqlClient;

namespace CafeManager.DAL
{
    public class StaffDAL
    {
        private string connectionString = "Data Source=.;Initial Catalog=CafeManager;Integrated Security=True";

        public bool AddStaff(string name, string position)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Staff (Name, Position) VALUES (@Name, @Position)", conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Position", position);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateStaff(int id, string name, string position)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE Staff SET Name = @Name, Position = @Position WHERE ID = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Position", position);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteStaff(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Staff WHERE ID = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
} 