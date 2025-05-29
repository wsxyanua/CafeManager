using System;
using System.Data;
using System.Data.SqlClient;

namespace CafeManager.DAL
{
    public class StatisticalDAL
    {
        private string connectionString = "Data Source=.;Initial Catalog=CafeManager;Integrated Security=True";

        public decimal GetRevenueByDate(DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(SUM(Amount),0) FROM Payment WHERE CAST(PaymentDate AS DATE) = @Date", conn))
                {
                    cmd.Parameters.AddWithValue("@Date", date.Date);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToDecimal(result) : 0;
                }
            }
        }
    }
} 