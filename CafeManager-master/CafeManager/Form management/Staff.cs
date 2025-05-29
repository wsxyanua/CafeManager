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
    public partial class Staff : Form
    {
        private int userRole;
        private string connStr = ConfigurationManager.ConnectionStrings["CafeManager2"].ConnectionString;
        public Staff(int role)
        {
            InitializeComponent();
            this.userRole = role;
            ApplyPermissions();
        }
        private void ApplyPermissions()
        {
            if (userRole == 1) // Nếu là Nhân viên
            {
                // ẩn form
                tsMenu.Enabled = false;
                tsRegister.Enabled = false;
                tsStaff.Enabled = false;
                tsStatistical.Enabled = false;
            }
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            LoadStaffData();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            // Thêm nhân viên mới
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO NhanVien (MaNV, TENNV, GIOITINH, SDT, HIENTHI) VALUES (@MaNV, @TENNV, @GIOITINH, @SDT, @HIENTHI)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaNV", txtID.Text);
                    cmd.Parameters.AddWithValue("@TENNV", txtName.Text);
                    cmd.Parameters.AddWithValue("@GIOITINH", rbSex1.Checked);  // Chọn Nam nếu rbSex1 được chọn
                    cmd.Parameters.AddWithValue("@SDT", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@HIENTHI", cbShow.Checked);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhân viên thành công!");
                    LoadStaffData();
                    ClearForm(); // Gọi hàm ClearForm sau khi thêm
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm nhân viên: " + ex.Message);
                }
            }
        }

        private void LoadStaffData()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    string query = "SELECT * FROM NhanVien";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dtNhanVien = new DataTable();
                    adapter.Fill(dtNhanVien);
                    dgvStaf.DataSource = dtNhanVien;
                    // Đặt tên cho các cột trong DataGridView
                    dgvStaf.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
                    dgvStaf.Columns["TENNV"].HeaderText = "Tên Nhân Viên";
                    dgvStaf.Columns["GIOITINH"].HeaderText = "Giới Tính";
                    dgvStaf.Columns["SDT"].HeaderText = "Số Điện Thoại";
                    dgvStaf.Columns["HIENTHI"].HeaderText = "Hiển Thị";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

        private void dgvStaf_SelectionChanged(object sender, EventArgs e)
        {
            // Lấy thông tin nhân viên khi chọn dòng trong DataGridView
            if (dgvStaf.SelectedRows.Count > 0)
            {
                var row = dgvStaf.SelectedRows[0];
                txtID.Text = row.Cells["MaNV"].Value.ToString();
                txtName.Text = row.Cells["TENNV"].Value.ToString();
                bool gioiTinh = (bool)row.Cells["GIOITINH"].Value;
                rbSex1.Checked = gioiTinh;  // Nam
                rbSex2.Checked = !gioiTinh; // Nữ
                txtPhone.Text = row.Cells["SDT"].Value.ToString();
                cbShow.Checked = (bool)row.Cells["HIENTHI"].Value;
            }
        }

        // Hàm xóa thông tin trong form sau khi thêm thành công
        private void ClearForm()
        {
            txtID.Clear();
            txtName.Clear();
            rbSex1.Checked = false;  // Bỏ chọn giới tính Nam
            rbSex2.Checked = false;  // Bỏ chọn giới tính Nữ
            txtPhone.Clear();
            cbShow.Checked = false;
        }

        //Nút Sửa***********
        private void pbRepair_Click(object sender, EventArgs e)
        {
            // Sửa thông tin nhân viên
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE NhanVien SET TENNV = @TENNV, GIOITINH = @GIOITINH, SDT = @SDT, HIENTHI = @HIENTHI WHERE MaNV = @MaNV";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaNV", txtID.Text);
                    cmd.Parameters.AddWithValue("@TENNV", txtName.Text);
                    cmd.Parameters.AddWithValue("@GIOITINH", rbSex1.Checked);  // Chọn Nam nếu rbSex1 được chọn
                    cmd.Parameters.AddWithValue("@SDT", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@HIENTHI", cbShow.Checked);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thông tin nhân viên thành công!");
                    LoadStaffData();
                    ClearForm(); // Gọi hàm ClearForm sau khi sửa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa thông tin nhân viên: " + ex.Message);
                }
            }
        }

        private void dgvStaf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin nhân viên từ hàng đã chọn
                DataGridViewRow row = dgvStaf.Rows[e.RowIndex];
                txtID.Text = row.Cells["MaNV"].Value.ToString();
                txtName.Text = row.Cells["TenNV"].Value.ToString();
                txtPhone.Text = row.Cells["SDT"].Value.ToString();

                string gioiTinh = row.Cells["GioiTinh"].Value.ToString();
                if (gioiTinh == "Nam")
                    rbSex1.Checked = true;
                else
                    rbSex2.Checked = true;

                // Cập nhật trạng thái của checkbox dựa trên giá trị cột HIENTHI
                bool hienThi = row.Cells["HIENTHI"].Value != DBNull.Value && Convert.ToBoolean(row.Cells["HIENTHI"].Value);
                cbShow.Checked = hienThi;
            }
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            // Xóa nhân viên
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaNV", txtID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa nhân viên thành công!");
                    LoadStaffData();
                    ClearForm(); // Gọi hàm ClearForm sau khi xóa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên: " + ex.Message);
                }
            }
        }

        private void tsHome_Click(object sender, EventArgs e)
        {
            Home formHome = new Home(userRole);
            formHome.Show();
            this.Hide();
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

        private void pnR2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}