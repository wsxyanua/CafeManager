using System;
using CafeManager.DAL;

namespace CafeManager.BUS
{
    public class StaffBUS
    {
        private StaffDAL staffDAL;

        public StaffBUS()
        {
            staffDAL = new StaffDAL();
        }

        public bool AddStaff(string name, string position)
        {
            // Logic nghiệp vụ: kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(position))
            {
                return false;
            }
            // Gọi DAL để thêm nhân viên
            return staffDAL.AddStaff(name, position);
        }

        public bool UpdateStaff(int id, string name, string position)
        {
            // Logic nghiệp vụ: kiểm tra dữ liệu đầu vào
            if (id <= 0 || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(position))
            {
                return false;
            }
            // Gọi DAL để cập nhật nhân viên
            return staffDAL.UpdateStaff(id, name, position);
        }

        public bool DeleteStaff(int id)
        {
            // Logic nghiệp vụ: kiểm tra dữ liệu đầu vào
            if (id <= 0)
            {
                return false;
            }
            // Gọi DAL để xóa nhân viên
            return staffDAL.DeleteStaff(id);
        }
    }
} 