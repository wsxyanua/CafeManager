namespace CafeManager
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsHome = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsName = new System.Windows.Forms.ToolStripTextBox();
            this.tsStatistical = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.PeachPuff;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHome,
            this.tsMenu,
            this.tsTable,
            this.tsPay,
            this.tsName,
            this.tsStatistical,
            this.tsRegister,
            this.tsStaff,
            this.tsSet});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1283, 38);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsHome
            // 
            this.tsHome.Image = ((System.Drawing.Image)(resources.GetObject("tsHome.Image")));
            this.tsHome.Name = "tsHome";
            this.tsHome.Size = new System.Drawing.Size(133, 34);
            this.tsHome.Text = "Trang Chủ";
            // 
            // tsMenu
            // 
            this.tsMenu.Image = global::CafeManager.Properties.Resources.images;
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(96, 34);
            this.tsMenu.Text = "Menu";
            this.tsMenu.Click += new System.EventHandler(this.tsMenu_Click);
            // 
            // tsTable
            // 
            this.tsTable.Image = ((System.Drawing.Image)(resources.GetObject("tsTable.Image")));
            this.tsTable.Name = "tsTable";
            this.tsTable.Size = new System.Drawing.Size(83, 34);
            this.tsTable.Text = "Bàn ";
            this.tsTable.Click += new System.EventHandler(this.tsTable_Click);
            // 
            // tsPay
            // 
            this.tsPay.Image = ((System.Drawing.Image)(resources.GetObject("tsPay.Image")));
            this.tsPay.Name = "tsPay";
            this.tsPay.Size = new System.Drawing.Size(144, 34);
            this.tsPay.Text = "Thanh toán";
            this.tsPay.Click += new System.EventHandler(this.tsPay_Click);
            // 
            // tsName
            // 
            this.tsName.BackColor = System.Drawing.Color.PeachPuff;
            this.tsName.CausesValidation = false;
            this.tsName.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsName.ForeColor = System.Drawing.Color.Red;
            this.tsName.Name = "tsName";
            this.tsName.ReadOnly = true;
            this.tsName.Size = new System.Drawing.Size(310, 34);
            this.tsName.Text = "CAFE Ngũ Hổ Tướng";
            this.tsName.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tsStatistical
            // 
            this.tsStatistical.Image = ((System.Drawing.Image)(resources.GetObject("tsStatistical.Image")));
            this.tsStatistical.Name = "tsStatistical";
            this.tsStatistical.Size = new System.Drawing.Size(138, 34);
            this.tsStatistical.Text = "Doanh thu";
            this.tsStatistical.Click += new System.EventHandler(this.tsStatistical_Click);
            // 
            // tsRegister
            // 
            this.tsRegister.Image = ((System.Drawing.Image)(resources.GetObject("tsRegister.Image")));
            this.tsRegister.Name = "tsRegister";
            this.tsRegister.Size = new System.Drawing.Size(118, 34);
            this.tsRegister.Text = "Đăng ký";
            this.tsRegister.Click += new System.EventHandler(this.tsRegister_Click);
            // 
            // tsStaff
            // 
            this.tsStaff.Image = ((System.Drawing.Image)(resources.GetObject("tsStaff.Image")));
            this.tsStaff.Name = "tsStaff";
            this.tsStaff.Size = new System.Drawing.Size(134, 34);
            this.tsStaff.Text = "Nhân viên";
            this.tsStaff.Click += new System.EventHandler(this.tsStaff_Click);
            // 
            // tsSet
            // 
            this.tsSet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsExit});
            this.tsSet.Image = ((System.Drawing.Image)(resources.GetObject("tsSet.Image")));
            this.tsSet.Name = "tsSet";
            this.tsSet.Size = new System.Drawing.Size(107, 34);
            this.tsSet.Text = "Cài đặt";
            // 
            // tsExit
            // 
            this.tsExit.Image = ((System.Drawing.Image)(resources.GetObject("tsExit.Image")));
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(187, 32);
            this.tsExit.Text = "Đăng xuất";
            this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1283, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsHome;
        private System.Windows.Forms.ToolStripMenuItem tsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsTable;
        private System.Windows.Forms.ToolStripMenuItem tsPay;
        private System.Windows.Forms.ToolStripTextBox tsName;
        private System.Windows.Forms.ToolStripMenuItem tsRegister;
        private System.Windows.Forms.ToolStripMenuItem tsStaff;
        private System.Windows.Forms.ToolStripMenuItem tsSet;
        private System.Windows.Forms.ToolStripMenuItem tsExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tsStatistical;
    }
}