using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManager.Form_management;

namespace CafeManager
{
    public partial class Home : Form
    {
        private int userRole;// biến lưu trữ quyên
        public Home(int role)
        {
            InitializeComponent();
            this.userRole = role; // Gán giá trị quyền
            ApplyPermissions();   // Áp dụng phân quyền
        }

        // Hàm áp dụng phân quyền
        private void ApplyPermissions()
        {
            if (userRole == 1) // Nếu là Nhân viên
            {
                tsMenu.Enabled = false;  // Vô hiệu hóa Menu
                tsRegister.Enabled = false; 
                tsStaff.Enabled = false;   
                tsStatistical.Enabled = false;
            }
        }

        private void tsMenu_Click(object sender, EventArgs e)
        {
            Menu formMenu = new Menu(userRole);
            formMenu.Show();
            this.Hide();
        }

        private void tsTable_Click(object sender, EventArgs e)
        {
            Table formTable = new Table(userRole);
            formTable.Show();
            this.Hide();
        }

        private void tsStaff_Click(object sender, EventArgs e)
        {
            Staff formStaff = new Staff(userRole);
            formStaff.Show();
            this.Hide();
        }

        private void tsPay_Click(object sender, EventArgs e)
        {
            Pay formPay = new Pay(userRole);
            formPay.Show();
            this.Hide();
        }

        private void tsRegister_Click(object sender, EventArgs e)
        {
            SignUP formSignUp = new SignUP(userRole);
            formSignUp.Show();
            this.Hide();
        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            formLogin.Show();
            this.Hide();
        }

        private void tsStatistical_Click(object sender, EventArgs e)
        {
            Statistical formStatistical = new Statistical(userRole);
            formStatistical.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
