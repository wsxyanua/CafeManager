using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;
using System.Configuration;

namespace CafeManager.Form_management
{
    public partial class Pay : Form
    {
        private int userRole;
        private string connStr = ConfigurationManager.ConnectionStrings["CafeManager2"].ConnectionString;
        public Pay(int role)
        {
            InitializeComponent();
            LoadMenuItems();
            this.userRole = role; 
            ApplyPermissions();
        }
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
        private void LoadMenuItems()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MenuID, TENMON, GIA, HINHANH FROM Menu WHERE HIENTHI = 1";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // Tạo panel hiển thị món ăn
                        Panel menuPanel = new Panel
                        {
                            Size = new Size(200, 250),
                            BorderStyle = BorderStyle.FixedSingle,
                            Tag = reader["MenuID"]
                        };
                        // Hình ảnh
                        PictureBox pbImage = new PictureBox
                        {
                            Size = new Size(180, 150),
                            Location = new Point(10, 10),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Image = Image.FromFile(reader["HINHANH"].ToString())
                        };
                        // Tên món
                        Label lblName = new Label
                        {
                            Text = reader["TENMON"].ToString(),
                            Location = new Point(10, 170),
                            Size = new Size(180, 20),
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        // Giá món
                        Label lblPrice = new Label
                        {
                            Text = $"Giá: {Convert.ToDecimal(reader["GIA"]):N0} đ",
                            Location = new Point(10, 200),
                            Size = new Size(180, 20),
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        menuPanel.Controls.Add(pbImage);
                        menuPanel.Controls.Add(lblName);
                        menuPanel.Controls.Add(lblPrice);

                        // Gán sự kiện click cho panel
                        menuPanel.Click += MenuPanel_Click;
                        flpMenu.Controls.Add(menuPanel);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải danh sách món: {ex.Message}");
                }
            }
        }

        private void MenuPanel_Click(object sender, EventArgs e)
        {
            if (sender is Panel panel)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT TENMON, GIA FROM Menu WHERE MenuID = @MenuID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MenuID", panel.Tag);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtOName.Text = reader["TENMON"].ToString();
                            txtOPrice.Text = reader["GIA"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi lấy thông tin món: {ex.Message}");
                    }
                }
            }
        }

        private void btOPut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtONumber.Text) || string.IsNullOrEmpty(txtOName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đơn hàng!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // Lấy mã nhân viên từ đăng nhập
                    string MaNV = Login.CurrentStaffID; // Lấy mã nhân viên từ form đăng nhập

                    // Kiểm tra xem hóa đơn đã tồn tại chưa
                    string checkHoaDonQuery = "SELECT COUNT(*) FROM HoaDon WHERE SOHOADON = @SOHOADON";
                    SqlCommand checkHoaDonCmd = new SqlCommand(checkHoaDonQuery, conn);
                    checkHoaDonCmd.Parameters.AddWithValue("@SOHOADON", txtONumber.Text);
                    int countHD = (int)checkHoaDonCmd.ExecuteScalar();

                    // Nếu hóa đơn chưa tồn tại, thêm hóa đơn mới
                    if (countHD == 0)
                    {
                        string insertHoaDonQuery = @"
                        INSERT INTO HoaDon (SOHOADON, MaNV)
                        VALUES (@SOHOADON, @MaNV)";
                        SqlCommand insertHoaDonCmd = new SqlCommand(insertHoaDonQuery, conn);
                        insertHoaDonCmd.Parameters.AddWithValue("@SOHOADON", txtONumber.Text);
                        insertHoaDonCmd.Parameters.AddWithValue("@MaNV", MaNV);
                        insertHoaDonCmd.ExecuteNonQuery();
                    }

                    // Lấy giá và số lượng món đặt
                    decimal gia = Convert.ToDecimal(txtOPrice.Text);
                    int soLuong = (int)nudOQuantity.Value;

                    // Thêm chi tiết hóa đơn
                    string insertChiTietHoaDonQuery = @"
        INSERT INTO ChiTietHoaDon (SOHOADON, MenuID, SOLUONG)
        VALUES (@SOHOADON, (SELECT MenuID FROM Menu WHERE TENMON = @TENMON), @SOLUONG)";
                    SqlCommand insertChiTietHoaDonCmd = new SqlCommand(insertChiTietHoaDonQuery, conn);
                    insertChiTietHoaDonCmd.Parameters.AddWithValue("@SOHOADON", txtONumber.Text);
                    insertChiTietHoaDonCmd.Parameters.AddWithValue("@TENMON", txtOName.Text);
                    insertChiTietHoaDonCmd.Parameters.AddWithValue("@SOLUONG", soLuong);
                    insertChiTietHoaDonCmd.ExecuteNonQuery();
                    LoadOrderDetails(txtONumber.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi đặt món: {ex.Message}");
                }
            }
        }

        private void LoadOrderDetails(string soHoaDon)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = @"
                    SELECT c.SOHOADON, 
                        m.TENMON, 
                        CAST(m.GIA AS DECIMAL(18, 0)) AS GIA,  
                        c.SOLUONG, 
                        CAST(m.GIA * c.SOLUONG AS DECIMAL(18, 0)) AS ThanhTien  
                    FROM ChiTietHoaDon c
                    JOIN Menu m ON c.MenuID = m.MenuID
                    WHERE c.SOHOADON = @SOHOADON";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@SOHOADON", soHoaDon);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPList.DataSource = dt;

                    // Định dạng lại cột "GIA" và "ThanhTien" sau khi tải dữ liệu
                    dgvPList.Columns["GIA"].DefaultCellStyle.Format = "0";  
                    dgvPList.Columns["ThanhTien"].DefaultCellStyle.Format = "0";
                    dgvPList.Columns["SOHOADON"].HeaderText = "Số hoá đơn";
                    dgvPList.Columns["TENMON"].HeaderText = "Tên món";
                    dgvPList.Columns["GIA"].HeaderText = "Giá";
                    dgvPList.Columns["SOLUONG"].HeaderText = "Số lượng";
                    dgvPList.Columns["ThanhTien"].HeaderText = "Thành tiền";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải danh sách đặt món: {ex.Message}");
                }
            }
        }

        private void btPSearch_Click(object sender, EventArgs e)
        {
            string soHoaDon = txtPNumber.Text;
            if (string.IsNullOrEmpty(soHoaDon))
            {
                MessageBox.Show("Vui lòng nhập số hóa đơn!");
                return;
            }
            LoadOrderDetails(soHoaDon);
            // Tính tổng tiền
            decimal total = dgvPList.Rows.Cast<DataGridViewRow>()
                .Sum(row => Convert.ToDecimal(row.Cells["ThanhTien"].Value));

            txtPSum.Text = total.ToString("N0");
        }

        private void btPPay_Click(object sender, EventArgs e)
        {
            string soHoaDon = txtPNumber.Text.Trim(); // Lấy số hóa đơn từ TextBox
            decimal tongTien;

            // Kiểm tra các điều kiện đầu vào
            if (string.IsNullOrEmpty(soHoaDon))
            {
                MessageBox.Show("Vui lòng nhập số hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPSum.Text, out tongTien))
            {
                MessageBox.Show("Tổng tiền không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật tổng tiền vào cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string updateQuery = "UPDATE HoaDon SET TONGTIEN = @TongTien WHERE SOHOADON = @SoHoaDon";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@TongTien", tongTien);
                        cmd.Parameters.AddWithValue("@SoHoaDon", soHoaDon);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            SaveBillToFile(soHoaDon); // Ghi hóa đơn ra tệp
                            MessageBox.Show("Thanh toán thành công và hóa đơn đã được in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Số hóa đơn không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật tổng tiền: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveBillToFile(string soHoaDon)
        {
            string filePath = $"HoaDon_{soHoaDon}.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("HÓA ĐƠN THANH TOÁN");
                writer.WriteLine($"Số hóa đơn: {soHoaDon}");
                writer.WriteLine($"Ngày lập: {DateTime.Now}");

                // In tên nhân viên đã đăng nhập
                writer.WriteLine($"Nhân viên lập: {Login.CurrentStaffName}"); // Truy xuất tên nhân viên từ biến static trong Login

                writer.WriteLine(new string('-', 30));

                foreach (DataGridViewRow row in dgvPList.Rows)
                {
                    writer.WriteLine($"{row.Cells["TENMON"].Value} - SL: {row.Cells["SOLUONG"].Value} - Giá: {row.Cells["ThanhTien"].Value} đ");
                }

                writer.WriteLine(new string('-', 30));
                writer.WriteLine($"Tổng tiền: {txtPSum.Text} đ");
            }

            System.Diagnostics.Process.Start("notepad.exe", filePath);
        }

        private void tsHome_Click(object sender, EventArgs e)
        {
            Home formHome = new Home(userRole);
            formHome.Show(); //Show Home
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

        private void tsStaff_Click(object sender, EventArgs e)
        {
            Staff formStaff = new Staff(userRole);
            formStaff.Show();
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

        private void flpMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsName_Click(object sender, EventArgs e)
        {

        }
    }
}