using System;
using CafeManager.DAL;

namespace CafeManager.BUS
{
    public class SignUpBUS
    {
        private SignUpDAL signUpDAL;

        public SignUpBUS()
        {
            signUpDAL = new SignUpDAL();
        }

        public bool Register(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return false;
            return signUpDAL.Register(username, password);
        }
    }
} 