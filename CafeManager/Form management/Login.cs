using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CafeManager.Form_management
{
    public partial class Login : Form
    {
        private string connStr = ConfigurationManager.ConnectionStrings["CafeManager2"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }
        public static string CurrentStaffID; // Biến toàn cục để lưu mã nhân viên
        public static string CurrentStaffName; // Biến toàn cục để lưu tên nhân viên

        private void btSignUp_Click(object sender, EventArgs e)
        {
            // Lấy thông tin người dùng nhập vào
            string tenDangNhap = txtName.Text.Trim();
            string matKhau = txtPassword.Text.Trim();

            // Kiểm tra RadioButton được chọn và xác định quyền
            int? chucVu = null; // Giá trị ban đầu null
            if (rbPosition1.Checked)
            {
                chucVu = 0; // 0 = Admin
            }
            else if (rbPosition2.Checked)
            {
                chucVu = 1; // 1 = Nhân viên
            }

            // Nếu không chọn RadioButton nào thì báo lỗi
            if (chucVu == null)
            {
                MessageBox.Show("Vui lòng chọn quyền Admin hoặc Nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kết nối với cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // Kiểm tra trạng thái HIENTHI trong bảng NhanVien
                    string checkQuery = @"
            SELECT nv.MaNV, nv.HIENTHI, nv.TenNV
            FROM DangKy dk
            INNER JOIN NhanVien nv ON dk.MaNV = nv.MaNV
            WHERE dk.TenDK = @TenDK AND dk.MatKhau = @MatKhau AND dk.ChucVu = @ChucVu";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@TenDK", tenDangNhap);
                        checkCmd.Parameters.AddWithValue("@MatKhau", matKhau);
                        checkCmd.Parameters.AddWithValue("@ChucVu", chucVu);

                        using (SqlDataReader reader = checkCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bool isActive = reader.GetBoolean(reader.GetOrdinal("HIENTHI"));
                                if (!isActive)
                                {
                                    MessageBox.Show("Nhân viên chưa được kích hoạt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                // Lưu mã nhân viên và tên nhân viên vào biến toàn cục
                                CurrentStaffID = reader["MaNV"].ToString();
                                CurrentStaffName = reader["TenNV"].ToString(); // Lưu tên nhân viên

                                // Đăng nhập thành công
                                Home trangChuForm = new Home(chucVu.Value); // Cấp quyền theo 0 1
                                trangChuForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Tài khoản không hợp lệ hoặc nhân viên chưa được kích hoạt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pnTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbNameShop_Click(object sender, EventArgs e)
        {

        }
    }
}
