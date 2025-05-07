namespace CafeManager
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
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
            this.gbInfMenu = new System.Windows.Forms.GroupBox();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btFixMenu = new System.Windows.Forms.Button();
            this.btDeleteMenu = new System.Windows.Forms.Button();
            this.btAddMenu = new System.Windows.Forms.Button();
            this.btChoosePhoto = new System.Windows.Forms.Button();
            this.pbMenuImg = new System.Windows.Forms.PictureBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtNamedish = new System.Windows.Forms.TextBox();
            this.pnMenu1 = new System.Windows.Forms.Panel();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.pnMenu2 = new System.Windows.Forms.Panel();
            this.lbMenu = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbInfMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.pnMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.pnMenu2.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1276, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsHome
            // 
            this.tsHome.Image = ((System.Drawing.Image)(resources.GetObject("tsHome.Image")));
            this.tsHome.Name = "tsHome";
            this.tsHome.Size = new System.Drawing.Size(133, 34);
            this.tsHome.Text = "Trang Chủ";
            this.tsHome.Click += new System.EventHandler(this.tsHome_Click);
            // 
            // tsMenu
            // 
            this.tsMenu.Image = global::CafeManager.Properties.Resources.images;
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(96, 34);
            this.tsMenu.Text = "Menu";
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
            // gbInfMenu
            // 
            this.gbInfMenu.BackColor = System.Drawing.Color.PeachPuff;
            this.gbInfMenu.Controls.Add(this.cbShow);
            this.gbInfMenu.Controls.Add(this.lbName);
            this.gbInfMenu.Controls.Add(this.btFixMenu);
            this.gbInfMenu.Controls.Add(this.btDeleteMenu);
            this.gbInfMenu.Controls.Add(this.btAddMenu);
            this.gbInfMenu.Controls.Add(this.btChoosePhoto);
            this.gbInfMenu.Controls.Add(this.pbMenuImg);
            this.gbInfMenu.Controls.Add(this.cbType);
            this.gbInfMenu.Controls.Add(this.nudPrice);
            this.gbInfMenu.Controls.Add(this.lbPrice);
            this.gbInfMenu.Controls.Add(this.txtNamedish);
            this.gbInfMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbInfMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfMenu.Location = new System.Drawing.Point(0, 38);
            this.gbInfMenu.Name = "gbInfMenu";
            this.gbInfMenu.Size = new System.Drawing.Size(223, 435);
            this.gbInfMenu.TabIndex = 3;
            this.gbInfMenu.TabStop = false;
            this.gbInfMenu.Text = "Thông tin đồ uống";
            // 
            // cbShow
            // 
            this.cbShow.AutoSize = true;
            this.cbShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShow.Location = new System.Drawing.Point(71, 308);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(89, 24);
            this.cbShow.TabIndex = 10;
            this.cbShow.Text = "Hiển thị";
            this.cbShow.UseVisualStyleBackColor = true;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(3, 23);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(127, 22);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "Nhập tên món:";
            // 
            // btFixMenu
            // 
            this.btFixMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFixMenu.Location = new System.Drawing.Point(83, 387);
            this.btFixMenu.Name = "btFixMenu";
            this.btFixMenu.Size = new System.Drawing.Size(56, 36);
            this.btFixMenu.TabIndex = 8;
            this.btFixMenu.Text = "Sửa";
            this.btFixMenu.UseVisualStyleBackColor = true;
            this.btFixMenu.Click += new System.EventHandler(this.btFixMenu_Click);
            // 
            // btDeleteMenu
            // 
            this.btDeleteMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteMenu.Location = new System.Drawing.Point(161, 387);
            this.btDeleteMenu.Name = "btDeleteMenu";
            this.btDeleteMenu.Size = new System.Drawing.Size(56, 36);
            this.btDeleteMenu.TabIndex = 7;
            this.btDeleteMenu.Text = "Xoá";
            this.btDeleteMenu.UseVisualStyleBackColor = true;
            this.btDeleteMenu.Click += new System.EventHandler(this.btDeleteMenu_Click);
            // 
            // btAddMenu
            // 
            this.btAddMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddMenu.Location = new System.Drawing.Point(7, 387);
            this.btAddMenu.Name = "btAddMenu";
            this.btAddMenu.Size = new System.Drawing.Size(56, 36);
            this.btAddMenu.TabIndex = 6;
            this.btAddMenu.Text = "Thêm";
            this.btAddMenu.UseVisualStyleBackColor = true;
            this.btAddMenu.Click += new System.EventHandler(this.btAddMenu_Click);
            // 
            // btChoosePhoto
            // 
            this.btChoosePhoto.Location = new System.Drawing.Point(56, 338);
            this.btChoosePhoto.Name = "btChoosePhoto";
            this.btChoosePhoto.Size = new System.Drawing.Size(104, 37);
            this.btChoosePhoto.TabIndex = 5;
            this.btChoosePhoto.Text = "Chọn ảnh";
            this.btChoosePhoto.UseVisualStyleBackColor = true;
            this.btChoosePhoto.Click += new System.EventHandler(this.btChoosePhoto_Click);
            // 
            // pbMenuImg
            // 
            this.pbMenuImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMenuImg.Location = new System.Drawing.Point(35, 152);
            this.pbMenuImg.Name = "pbMenuImg";
            this.pbMenuImg.Size = new System.Drawing.Size(150, 150);
            this.pbMenuImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenuImg.TabIndex = 4;
            this.pbMenuImg.TabStop = false;
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Trà Sữa",
            "Trà",
            "Yaourt",
            "Cafe",
            "Đá Xay"});
            this.cbType.Location = new System.Drawing.Point(6, 118);
            this.cbType.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(211, 28);
            this.cbType.TabIndex = 3;
            this.cbType.Text = "Loại món";
            // 
            // nudPrice
            // 
            this.nudPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrice.Location = new System.Drawing.Point(56, 86);
            this.nudPrice.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.nudPrice.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(161, 27);
            this.nudPrice.TabIndex = 2;
            this.nudPrice.ThousandsSeparator = true;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(7, 86);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(43, 22);
            this.lbPrice.TabIndex = 1;
            this.lbPrice.Text = "Giá:";
            // 
            // txtNamedish
            // 
            this.txtNamedish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamedish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNamedish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamedish.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNamedish.Location = new System.Drawing.Point(6, 51);
            this.txtNamedish.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtNamedish.Name = "txtNamedish";
            this.txtNamedish.Size = new System.Drawing.Size(211, 27);
            this.txtNamedish.TabIndex = 0;
            // 
            // pnMenu1
            // 
            this.pnMenu1.Controls.Add(this.dgvMenu);
            this.pnMenu1.Controls.Add(this.pnMenu2);
            this.pnMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMenu1.Location = new System.Drawing.Point(223, 38);
            this.pnMenu1.Name = "pnMenu1";
            this.pnMenu1.Size = new System.Drawing.Size(1053, 435);
            this.pnMenu1.TabIndex = 4;
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenu.Location = new System.Drawing.Point(0, 30);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.Size = new System.Drawing.Size(1053, 405);
            this.dgvMenu.TabIndex = 3;
            this.dgvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellContentClick);
            this.dgvMenu.SelectionChanged += new System.EventHandler(this.dgvMenu_SelectionChanged);
            // 
            // pnMenu2
            // 
            this.pnMenu2.Controls.Add(this.lbMenu);
            this.pnMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu2.Location = new System.Drawing.Point(0, 0);
            this.pnMenu2.Name = "pnMenu2";
            this.pnMenu2.Size = new System.Drawing.Size(1053, 30);
            this.pnMenu2.TabIndex = 2;
            // 
            // lbMenu
            // 
            this.lbMenu.BackColor = System.Drawing.Color.PeachPuff;
            this.lbMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.ForeColor = System.Drawing.Color.Tomato;
            this.lbMenu.Location = new System.Drawing.Point(0, 0);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(1053, 30);
            this.lbMenu.TabIndex = 1;
            this.lbMenu.Text = "Quản lý Menu";
            this.lbMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 473);
            this.Controls.Add(this.pnMenu1);
            this.Controls.Add(this.gbInfMenu);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Shown += new System.EventHandler(this.Menu_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbInfMenu.ResumeLayout(false);
            this.gbInfMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.pnMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.pnMenu2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsTable;
        private System.Windows.Forms.ToolStripMenuItem tsSet;
        private System.Windows.Forms.ToolStripMenuItem tsExit;
        private System.Windows.Forms.ToolStripMenuItem tsStaff;
        private System.Windows.Forms.ToolStripMenuItem tsRegister;
        private System.Windows.Forms.ToolStripMenuItem tsPay;
        private System.Windows.Forms.GroupBox gbInfMenu;
        private System.Windows.Forms.TextBox txtNamedish;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.PictureBox pbMenuImg;
        private System.Windows.Forms.Button btChoosePhoto;
        private System.Windows.Forms.Button btFixMenu;
        private System.Windows.Forms.Button btDeleteMenu;
        private System.Windows.Forms.Button btAddMenu;
        private System.Windows.Forms.Panel pnMenu1;
        private System.Windows.Forms.ToolStripTextBox tsName;
        private System.Windows.Forms.Panel pnMenu2;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ToolStripMenuItem tsHome;
        private System.Windows.Forms.CheckBox cbShow;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.ToolStripMenuItem tsStatistical;
    }
}