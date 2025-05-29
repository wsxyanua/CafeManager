using System;
using CafeManager.DAL;

namespace CafeManager.BUS
{
    public class TableBUS
    {
        private TableDAL tableDAL;

        public TableBUS()
        {
            tableDAL = new TableDAL();
        }

        public bool AddTable(string name, int seats)
        {
            if (string.IsNullOrEmpty(name) || seats <= 0)
                return false;
            return tableDAL.AddTable(name, seats);
        }

        public bool UpdateTable(int id, string name, int seats)
        {
            if (id <= 0 || string.IsNullOrEmpty(name) || seats <= 0)
                return false;
            return tableDAL.UpdateTable(id, name, seats);
        }

        public bool DeleteTable(int id)
        {
            if (id <= 0)
                return false;
            return tableDAL.DeleteTable(id);
        }
    }
} 