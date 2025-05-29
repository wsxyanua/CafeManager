using System;
using System.Data;
using System.Data.SqlClient;

namespace CafeManager.DAL
{
    public class PayDAL
    {
        private string connectionString = "Data Source=.;Initial Catalog=CafeManager;Integrated Security=True";

        public bool AddPayment(int orderId, decimal amount)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Payment (OrderID, Amount) VALUES (@OrderID, @Amount)", conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdatePayment(int id, int orderId, decimal amount)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE Payment SET OrderID = @OrderID, Amount = @Amount WHERE ID = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeletePayment(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Payment WHERE ID = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
} 