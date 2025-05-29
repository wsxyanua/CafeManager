using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CafeManager.Form_management
{
    public partial class SignUP : Form
    {
        private int userRole;
        private string connStr = ConfigurationManager.ConnectionStrings["CafeManager2"].ConnectionString;
        public SignUP(int role)
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
                // Vô hiệu hóa các mục menu không được phép
                tsMenu.Enabled = false;
                tsRegister.Enabled = false;
                tsStaff.Enabled = false;
                tsStatistical.Enabled = false;
            }
        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            string maNV = txtCode.Text.Trim();
            string tenDK = txtName.Text.Trim();
            string matKhau = txtPassword.Text.Trim();
            int chucVu = rbPosition1.Checked ? 0 : 1; // 0 = Admin, 1 = Nhân Viên

            // Kiểm tra các trường dữ liệu
            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(tenDK) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // Kiểm tra trạng thái HIENTHI của nhân viên trong bảng NhanVien
                    string checkQuery = "SELECT HIENTHI FROM NhanVien WHERE MaNV = @MaNV";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, conn);
                    checkCommand.Parameters.AddWithValue("@MaNV", maNV);

                    object result = checkCommand.ExecuteScalar();

                    // Nếu không tìm thấy mã nhân viên hoặc HIENTHI không phải true
                    if (result == null || result == DBNull.Value || !Convert.ToBoolean(result))
                    {
                        MessageBox.Show("Mã nhân viên không hợp lệ hoặc chưa được kích hoạt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Thêm dữ liệu vào bảng DangKy
                    string insertQuery = "INSERT INTO DangKy (TenDK, MatKhau, ChucVu, MaNV) VALUES (@TenDK, @MatKhau, @ChucVu, @MaNV)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, conn);
                    insertCommand.Parameters.AddWithValue("@TenDK", tenDK);
                    insertCommand.Parameters.AddWithValue("@MatKhau", matKhau);
                    insertCommand.Parameters.AddWithValue("@ChucVu", chucVu);
                    insertCommand.Parameters.AddWithValue("@MaNV", maNV);

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reset form sau khi đăng ký thành công
                        txtCode.Clear();
                        txtName.Clear();
                        txtPassword.Clear();
                        rbPosition1.Checked = false;
                        rbPosition2.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsHome_Click(object sender, EventArgs e)
        {
            Home formHome = new Home(userRole);
            formHome.Show();
            this.Hide();
        }

        private void tsTable_Click(object sender, EventArgs e)
        {
            Table formTable = new Table(userRole);
            formTable.Show();
            this.Hide();
        }

        private void tsPay_Click(object sender, EventArgs e)
        {
            Pay formPay = new Pay(userRole);
            formPay.Show();
            this.Hide();
        }

        private void tsStaff_Click(object sender, EventArgs e)
        {
            Staff formStaff = new Staff(userRole);
            formStaff.Show();
            this.Hide();
        }

        private void tsMenu_Click(object sender, EventArgs e)
        {
            Menu formMenu = new Menu(userRole);
            formMenu.Show();
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

        private void pnFill_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}