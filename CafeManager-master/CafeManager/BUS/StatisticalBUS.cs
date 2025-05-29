using System;
using CafeManager.DAL;

namespace CafeManager.BUS
{
    public class StatisticalBUS
    {
        private StatisticalDAL statisticalDAL;

        public StatisticalBUS()
        {
            statisticalDAL = new StatisticalDAL();
        }

        public decimal GetRevenueByDate(DateTime date)
        {
            return statisticalDAL.GetRevenueByDate(date);
        }
    }
} 