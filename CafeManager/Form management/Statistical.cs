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
    public partial class Statistical : Form
    {
        private string connStr = ConfigurationManager.ConnectionStrings["CafeManager2"].ConnectionString; private int userRole;
        public Statistical(int role)
        {
            InitializeComponent();
            ApplyPermissions();
            this.userRole = role;
        }

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

        private void Statistical_Load(object sender, EventArgs e)
        {
            // Loại thống kê
            cbStatistical.Items.AddRange(new string[] { "Ngày", "Tuần", "Tháng" });
            cbStatistical.SelectedIndex = 0; // Mặc định là "Ngày"
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string statisticType = cbStatistical.SelectedItem.ToString();
            DateTime selectedDate = dtpStatistical.Value;

            string query = GetStatisticType(statisticType, selectedDate);

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvStatistical.DataSource = table;

                    if (table.Columns.Contains("NGAYDAT")) dgvStatistical.Columns["NGAYDAT"].HeaderText = "Ngày đặt";
                    if (table.Columns.Contains("Tuan")) dgvStatistical.Columns["Tuan"].HeaderText = "Tuần";
                    if (table.Columns.Contains("Nam")) dgvStatistical.Columns["Nam"].HeaderText = "Năm";
                    if (table.Columns.Contains("DoanhThu")) dgvStatistical.Columns["DoanhThu"].HeaderText = "Doanh thu (VNĐ)";
                    if (table.Columns.Contains("SoHoaDon")) dgvStatistical.Columns["SoHoaDon"].HeaderText = "Số hóa đơn";

                    // Tính tổng doanh thu và số hóa đơn
                    Calculate(table);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetStatisticType(string statisticType, DateTime selectedDate)
        {
            string query = "";

            switch (statisticType)
            {
                case "Ngày":
                    query = $"SELECT NGAYDAT, SUM(TONGTIEN) AS DoanhThu, COUNT(SOHOADON) AS SoHoaDon " +
                            $"FROM HoaDon " +
                            $"WHERE CAST(NGAYDAT AS DATE) = '{selectedDate:yyyy-MM-dd}' " +
                            $"GROUP BY NGAYDAT";
                    break;

                case "Tuần":
                    query = $"SELECT DATEPART(WEEK, NGAYDAT) AS Tuan, YEAR(NGAYDAT) AS Nam, SUM(TONGTIEN) AS DoanhThu, COUNT(SOHOADON) AS SoHoaDon " +
                            $"FROM HoaDon " +
                            $"WHERE DATEPART(WEEK, NGAYDAT) = DATEPART(WEEK, '{selectedDate:yyyy-MM-dd}') AND YEAR(NGAYDAT) = {selectedDate.Year} " +
                            $"GROUP BY DATEPART(WEEK, NGAYDAT), YEAR(NGAYDAT)";
                    break;

                case "Tháng":
                    query = $"SELECT MONTH(NGAYDAT) AS Thang, YEAR(NGAYDAT) AS Nam, SUM(TONGTIEN) AS DoanhThu, COUNT(SOHOADON) AS SoHoaDon " +
                            $"FROM HoaDon " +
                            $"WHERE MONTH(NGAYDAT) = {selectedDate.Month} AND YEAR(NGAYDAT) = {selectedDate.Year} " +
                            $"GROUP BY MONTH(NGAYDAT), YEAR(NGAYDAT)";
                    break;
            }

            return query;
        }

        private void Calculate(DataTable table)
        {
            decimal totalRevenue = 0;
            int totalBills = 0;

            foreach (DataRow row in table.Rows)
            {
                totalRevenue += Convert.ToDecimal(row["DoanhThu"]);
                totalBills += Convert.ToInt32(row["SoHoaDon"]);
            }

            // Định dạng và hiển thị tổng doanh thu mà không có phần thập phân và thêm "VND"
            lbSum.Text = $"Tổng doanh thu: {totalRevenue.ToString("#,0", new System.Globalization.CultureInfo("vi-VN"))} VND";
            lbNumber.Text = $"Số hóa đơn: {totalBills}";

            // Điều chỉnh kích thước dòng và cột cho DataGridView
            dgvStatistical.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvStatistical.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void tsStaff_Click(object sender, EventArgs e)
        {
            Staff formStaff = new Staff(userRole);
            formStaff.Show();
            this.Hide();
        }
    }
}
