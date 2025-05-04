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
    public partial class Table : Form
    {
        private int userRole;
        private string connStr = ConfigurationManager.ConnectionStrings["CafeManager2"].ConnectionString;
        public Table(int role)
        {
            InitializeComponent();
            this.userRole = role; // Gán giá trị quyền
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

        private void btAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu TextBox trống hoặc ComboBox không có giá trị được chọn
            if (string.IsNullOrEmpty(tbNumner.Text) || cbStatus.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập số bàn và chọn trạng thái bàn.");
                return;
            }

            // Lấy số bàn và trạng thái
            string tenBan = tbNumner.Text;
            string trangThai = cbStatus.SelectedItem.ToString();

            // Kiểm tra nếu số bàn đã tồn tại trong cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string checkQuery = "SELECT COUNT(*) FROM Ban WHERE SOBAN = @SOBAN";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@SOBAN", tenBan);

                connection.Open();
                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Số bàn này đã tồn tại. Vui lòng chọn số bàn khác.");
                    return;
                }
            }

            // Chọn màu sắc cho Panel dựa trên trạng thái
            Color cellColor;
            switch (trangThai)
            {
                case "Đã sử dụng":
                    cellColor = Color.Red;
                    break;
                case "Đã đặt trước":
                    cellColor = Color.Orange;
                    break;
                case "Dọn dẹp":
                    cellColor = Color.Blue;
                    break;
                default: // Trạng thái mặc định là "Trống"
                    cellColor = Color.Gray;
                    break;
            }

            // Lưu thông tin bàn vào CSDL
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string query = "INSERT INTO Ban (SOBAN, TINHTRANG) VALUES (@SOBAN, @TINHTRANG)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SOBAN", tenBan);
                command.Parameters.AddWithValue("@TINHTRANG", trangThai);

                connection.Open();
                command.ExecuteNonQuery();
            }

            // Tạo một Panel mới cho bàn
            AddTablePanel(tenBan, cellColor);
            // Sắp xếp lại các Panel trong FlowLayoutPanel ngay sau khi thêm bàn mới
            var panels = flbTable.Controls.Cast<Panel>().ToList();
            var sortedPanels = panels.OrderBy(panel => int.Parse(panel.Tag.ToString())).ToList();

            // Xóa các Panel hiện tại trong FlowLayoutPanel
            flbTable.Controls.Clear();

            // Thêm các Panel đã được sắp xếp lại vào FlowLayoutPanel
            foreach (var panel in sortedPanels)
            {
                flbTable.Controls.Add(panel);
            }

            // Xóa thông tin trong TextBox và ComboBox
            tbNumner.Clear();
            cbStatus.SelectedIndex = -1;
        }

        private void TablePanel_Click(object sender, EventArgs e)
        {
            // Lấy thông tin số bàn từ Tag của Panel
            Panel panel = (Panel)sender;
            string tenBan = panel.Tag.ToString();

            // Hiển thị thông tin số bàn được nhấn
            MessageBox.Show($"Bàn {tenBan} được nhấn!");
        }

        private void Table_Load(object sender, EventArgs e)
        {
            // Gọi hàm tải dữ liệu khi mở form
            LoadTableData();
        }

        private void LoadTableData()
        {
            flbTable.Controls.Clear(); // Xóa các bàn cũ trước khi tải lại

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                // Sắp xếp bàn theo số bàn tăng dần
                string query = "SELECT SOBAN, TINHTRANG FROM Ban ORDER BY SOBAN ASC";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string tenBan = reader["SOBAN"].ToString();
                    string trangThai = reader["TINHTRANG"].ToString();

                    // Chọn màu sắc dựa trên trạng thái
                    Color cellColor;
                    switch (trangThai)
                    {
                        case "Đã sử dụng":
                            cellColor = Color.Red;
                            break;
                        case "Đã đặt trước":
                            cellColor = Color.Orange;
                            break;
                        case "Dọn dẹp":
                            cellColor = Color.LimeGreen;
                            break;
                        default: // Trạng thái mặc định là "Trống"
                            cellColor = Color.Gray;
                            break;
                    }

                    // Tạo Panel mới và thêm vào FlowLayoutPanel
                    AddTablePanel(tenBan, cellColor);
                }
            }
        }

        private void AddTablePanel(string tenBan, Color cellColor)
        {
            // Tạo một Panel mới cho bàn
            Panel tablePanel = new Panel
            {
                Width = 100,
                Height = 100,
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = cellColor,
                Tag = tenBan // Lưu số bàn trong Tag của panel
            };

            // Tạo Label để hiển thị số bàn
            Label label = new Label
            {
                Text = tenBan,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.White
            };

            // Thêm Label vào Panel
            tablePanel.Controls.Add(label);

            // Thêm sự kiện click để xử lý khi nhấn vào ô bàn
            tablePanel.Click += TablePanel_Click;

            // Thêm Panel vào FlowLayoutPanel
            flbTable.Controls.Add(tablePanel);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu TextBox trống hoặc ComboBox không có giá trị được chọn
            if (string.IsNullOrEmpty(tbNumner.Text) || cbStatus.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập số bàn và chọn trạng thái bàn.");
                return;
            }

            // Lấy số bàn và trạng thái mới
            string tenBan = tbNumner.Text;
            string trangThai = cbStatus.SelectedItem.ToString();

            // Chọn màu sắc cho Panel dựa trên trạng thái mới
            Color cellColor;
            switch (trangThai)
            {
                case "Đã sử dụng":
                    cellColor = Color.Red;
                    break;
                case "Đã đặt trước":
                    cellColor = Color.Orange;
                    break;
                case "Dọn dẹp":
                    cellColor = Color.LimeGreen;
                    break;
                default: // Trạng thái mặc định là "Trống"
                    cellColor = Color.Gray;
                    break;
            }

            // Cập nhật thông tin bàn trong CSDL
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string query = "UPDATE Ban SET TINHTRANG = @TINHTRANG WHERE SOBAN = @SOBAN";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SOBAN", tenBan);
                command.Parameters.AddWithValue("@TINHTRANG", trangThai);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                // Kiểm tra xem có cập nhật được bản ghi nào không
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Bàn {tenBan} đã được cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bàn để cập nhật.");
                    return;
                }
            }

            // Cập nhật màu sắc của Panel trên form
            foreach (Panel panel in flbTable.Controls)
            {
                if (panel.Tag.ToString() == tenBan)
                {
                    panel.BackColor = cellColor; // Thay đổi màu sắc của Panel
                    break;
                }
            }

            // Xóa thông tin trong TextBox và ComboBox sau khi cập nhật
            tbNumner.Clear();
            cbStatus.SelectedIndex = -1;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu TextBox trống
            if (string.IsNullOrEmpty(tbNumner.Text))
            {
                MessageBox.Show("Vui lòng nhập số bàn cần xoá.");
                return;
            }

            // Lấy số bàn từ TextBox
            string tenBan = tbNumner.Text;

            // Xoá thông tin bàn trong CSDL
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string query = "DELETE FROM Ban WHERE SOBAN = @SOBAN";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SOBAN", tenBan);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                // Kiểm tra nếu xoá thành công
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Bàn {tenBan} đã được xoá thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bàn để xoá.");
                    return;
                }
            }

            // Xoá Panel trên form tương ứng với số bàn
            foreach (Panel panel in flbTable.Controls)
            {
                if (panel.Tag.ToString() == tenBan)
                {
                    flbTable.Controls.Remove(panel); // Xoá Panel khỏi FlowLayoutPanel
                    break;
                }
            }

            // Xóa thông tin trong TextBox sau khi xoá
            tbNumner.Clear();
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
    }
}