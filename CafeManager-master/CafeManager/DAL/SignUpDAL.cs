using System;
using System.Data;
using System.Data.SqlClient;

namespace CafeManager.DAL
{
    public class SignUpDAL
    {
        private string connectionString = "Data Source=.;Initial Catalog=CafeManager;Integrated Security=True";

        public bool Register(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username, Password) VALUES (@Username, @Password)", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
} 