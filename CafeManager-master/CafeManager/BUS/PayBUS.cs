using System;
using CafeManager.DAL;

namespace CafeManager.BUS
{
    public class PayBUS
    {
        private PayDAL payDAL;

        public PayBUS()
        {
            payDAL = new PayDAL();
        }

        public bool AddPayment(int orderId, decimal amount)
        {
            // Logic nghiệp vụ: kiểm tra dữ liệu đầu vào
            if (orderId <= 0 || amount <= 0)
            {
                return false;
            }
            // Gọi DAL để thêm thanh toán
            return payDAL.AddPayment(orderId, amount);
        }

        public bool UpdatePayment(int id, int orderId, decimal amount)
        {
            // Logic nghiệp vụ: kiểm tra dữ liệu đầu vào
            if (id <= 0 || orderId <= 0 || amount <= 0)
            {
                return false;
            }
            // Gọi DAL để cập nhật thanh toán
            return payDAL.UpdatePayment(id, orderId, amount);
        }

        public bool DeletePayment(int id)
        {
            // Logic nghiệp vụ: kiểm tra dữ liệu đầu vào
            if (id <= 0)
            {
                return false;
            }
            // Gọi DAL để xóa thanh toán
            return payDAL.DeletePayment(id);
        }
    }
} 