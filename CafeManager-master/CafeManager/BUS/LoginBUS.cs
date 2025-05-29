using System;
using CafeManager.DAL;

namespace CafeManager.BUS
{
    public class LoginBUS
    {
        private LoginDAL loginDAL;

        public LoginBUS()
        {
            loginDAL = new LoginDAL();
        }

        public bool Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return false;
            return loginDAL.Login(username, password);
        }
    }
} 