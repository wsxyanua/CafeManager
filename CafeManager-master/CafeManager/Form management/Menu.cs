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
using System.Drawing.Text;
using CafeManager.Form_management;
using System.IO;
using System.Configuration;

namespace CafeManager
{
    public partial class Menu : Form
    {
        private int userRole;
        private string connStr = ConfigurationManager.ConnectionStrings["CafeManager2"].ConnectionString;

        public Menu(int role)
        {
            InitializeComponent();
            this.userRole = role;
            ApplyPermissions();
            this.Shown += new EventHandler(Menu_Shown);
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

        private void Menu_Load(object sender, EventArgs e)
        {
            LoadMenuData();
        }

        private void LoadMenuData()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT menuID, TENMON, CAST(GIA AS INT) AS GIA, LOAIMON, HINHANH, HIENTHI FROM Menu", conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvMenu.DataSource = table;

                // Thiết lập tên cho các cột
                dgvMenu.Columns["menuID"].HeaderText = "Mã món";
                dgvMenu.Columns["TENMON"].HeaderText = "Tên món";
                dgvMenu.Columns["GIA"].HeaderText = "Giá";
                dgvMenu.Columns["LOAIMON"].HeaderText = "Loại món";
                dgvMenu.Columns["HINHANH"].HeaderText = "Hình ảnh";
                dgvMenu.Columns["HIENTHI"].HeaderText = "Hiển thị";

                // Thiết lập một số thuộc tính của các cột nếu cần
                dgvMenu.Columns["menuID"].Visible = false; // Ẩn cột menuID nếu không cần thiết hiển thị
            }
        }

        private void btAddMenu_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Menu (TENMON, GIA, LOAIMON, HINHANH, HIENTHI) VALUES (@TENMON, @GIA, @LOAIMON, @HINHANH, @HIENTHI)", conn);
                cmd.Parameters.AddWithValue("@TENMON", txtNamedish.Text);
                cmd.Parameters.AddWithValue("@GIA", nudPrice.Value);
                cmd.Parameters.AddWithValue("@LOAIMON", cbType.Text);

                if (!string.IsNullOrEmpty(pbMenuImg.Tag?.ToString()))
                {
                    cmd.Parameters.AddWithValue("@HINHANH", pbMenuImg.Tag.ToString()); // Lưu đường dẫn hình ảnh
                }
                else
                {
                    cmd.Parameters.AddWithValue("@HINHANH", DBNull.Value);
                }

                cmd.Parameters.AddWithValue("@HIENTHI", cbShow.Checked);
                cmd.ExecuteNonQuery();
            }
            LoadMenuData();
            ClearInputs();
        }

        private void btFixMenu_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count > 0)
            {
                int menuID = Convert.ToInt32(dgvMenu.SelectedRows[0].Cells["menuID"].Value);

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Menu SET TENMON = @TENMON, GIA = @GIA, LOAIMON = @LOAIMON, HINHANH = @HINHANH, HIENTHI = @HIENTHI WHERE menuID = @menuID", conn);
                    cmd.Parameters.AddWithValue("@TENMON", txtNamedish.Text);
                    cmd.Parameters.AddWithValue("@GIA", nudPrice.Value);
                    cmd.Parameters.AddWithValue("@LOAIMON", cbType.Text);

                    if (!string.IsNullOrEmpty(pbMenuImg.Tag?.ToString()))
                    {
                        cmd.Parameters.AddWithValue("@HINHANH", pbMenuImg.Tag.ToString()); // Lưu đường dẫn hình ảnh
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@HINHANH", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@HIENTHI", cbShow.Checked);
                    cmd.Parameters.AddWithValue("@menuID", menuID);
                    cmd.ExecuteNonQuery();
                }
                LoadMenuData();
                ClearInputs();
            }
        }

        private void btDeleteMenu_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count > 0)
            {
                int menuID = Convert.ToInt32(dgvMenu.SelectedRows[0].Cells["menuID"].Value);

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Menu WHERE menuID = @menuID", conn);
                    cmd.Parameters.Add(new SqlParameter("@menuID", menuID));
                    cmd.ExecuteNonQuery();
                }
                LoadMenuData();
                ClearInputs();
            }
        }

        private void btChoosePhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbMenuImg.Image = Image.FromFile(openFileDialog.FileName);
                    pbMenuImg.Tag = openFileDialog.FileName; // Lưu đường dẫn hình ảnh
                }
            }
        }

        private void dgvMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvMenu.SelectedRows[0];

                // Lấy giá trị từ dòng đã chọn và điền vào các điều khiển
                txtNamedish.Text = row.Cells["TENMON"].Value.ToString();
                nudPrice.Value = Convert.ToDecimal(row.Cells["GIA"].Value);
                cbType.Text = row.Cells["LOAIMON"].Value.ToString();

                // Hiển thị hình ảnh nếu có
                if (row.Cells["HINHANH"].Value != DBNull.Value)
                {
                    string filePath = row.Cells["HINHANH"].Value.ToString();
                    if (File.Exists(filePath))
                    {
                        pbMenuImg.Image = Image.FromFile(filePath);
                        pbMenuImg.Tag = filePath; // Lưu lại đường dẫn hình ảnh
                    }
                    else
                    {
                        pbMenuImg.Image = null;
                        MessageBox.Show("Hình ảnh không tồn tại tại đường dẫn: " + filePath);
                    }
                }
                else
                {
                    pbMenuImg.Image = null;
                }

                // Cập nhật trạng thái checkbox
                cbShow.Checked = Convert.ToBoolean(row.Cells["HIENTHI"].Value);
            }
        }

        private void ClearInputs()
        {
            txtNamedish.Clear();
            nudPrice.Value = 0;
            cbType.SelectedIndex = -1;
            pbMenuImg.Image = null;
            pbMenuImg.Tag = null;
            cbShow.Checked = false;
        }

        //Xử lý các nút của thanh Taskbar

        private void tsHome_Click(object sender, EventArgs e)
        {
            Home formHome = Application.OpenForms["Home"] as Home;
            if (formHome != null)
            {
                formHome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Không tìm thấy trang chủ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void Menu_Shown(object sender, EventArgs e)
        {
            LoadMenuData();
        }

        private void tsStatistical_Click(object sender, EventArgs e)
        {
            Statistical formStatistical = new Statistical(userRole);
            formStatistical.Show();
            this.Hide();
        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
