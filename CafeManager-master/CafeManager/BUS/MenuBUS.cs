using System;
using CafeManager.DAL;

namespace CafeManager.BUS
{
    public class MenuBUS
    {
        private MenuDAL menuDAL;

        public MenuBUS()
        {
            menuDAL = new MenuDAL();
        }

        public bool AddMenuItem(string name, decimal price)
        {
            // Logic nghiệp vụ: kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(name) || price <= 0)
            {
                return false;
            }
            // Gọi DAL để thêm món ăn
            return menuDAL.AddMenuItem(name, price);
        }

        public bool UpdateMenuItem(int id, string name, decimal price)
        {
            // Logic nghiệp vụ: kiểm tra dữ liệu đầu vào
            if (id <= 0 || string.IsNullOrEmpty(name) || price <= 0)
            {
                return false;
            }
            // Gọi DAL để cập nhật món ăn
            return menuDAL.UpdateMenuItem(id, name, price);
        }

        public bool DeleteMenuItem(int id)
        {
            // Logic nghiệp vụ: kiểm tra dữ liệu đầu vào
            if (id <= 0)
            {
                return false;
            }
            // Gọi DAL để xóa món ăn
            return menuDAL.DeleteMenuItem(id);
        }
    }
} 