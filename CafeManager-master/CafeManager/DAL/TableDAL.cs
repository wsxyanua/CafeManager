using System;
using System.Data;
using System.Data.SqlClient;

namespace CafeManager.DAL
{
    public class TableDAL
    {
        private string connectionString = "Data Source=.;Initial Catalog=CafeManager;Integrated Security=True";

        public bool AddTable(string name, int seats)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO [Table] (Name, Seats) VALUES (@Name, @Seats)", conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Seats", seats);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateTable(int id, string name, int seats)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE [Table] SET Name = @Name, Seats = @Seats WHERE ID = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Seats", seats);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteTable(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM [Table] WHERE ID = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
} 