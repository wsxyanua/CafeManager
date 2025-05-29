using System;
using System.Data;
using System.Data.SqlClient;

namespace CafeManager.DAL
{
    public class LoginDAL
    {
        private string connectionString = "Data Source=.;Initial Catalog=CafeManager;Integrated Security=True";

        public bool Login(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
} 