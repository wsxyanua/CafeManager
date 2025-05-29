using System;
using System.Data;
using System.Data.SqlClient;

namespace CafeManager.DAL
{
    public class MenuDAL
    {
        private string connectionString = "Data Source=.;Initial Catalog=CafeManager;Integrated Security=True";

        public bool AddMenuItem(string name, decimal price)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Menu (Name, Price) VALUES (@Name, @Price)", conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Price", price);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateMenuItem(int id, string name, decimal price)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE Menu SET Name = @Name, Price = @Price WHERE ID = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Price", price);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteMenuItem(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Menu WHERE ID = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
} 