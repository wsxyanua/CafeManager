namespace CafeManager.Form_management
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
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
            this.pnRight = new System.Windows.Forms.Panel();
            this.pn8 = new System.Windows.Forms.Panel();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.pbRepair = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pn6 = new System.Windows.Forms.Panel();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.lbShow = new System.Windows.Forms.Label();
            this.pn5 = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.pn4 = new System.Windows.Forms.Panel();
            this.rbSex2 = new System.Windows.Forms.RadioButton();
            this.rbSex1 = new System.Windows.Forms.RadioButton();
            this.lbSex = new System.Windows.Forms.Label();
            this.pn3 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.pnR2 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.pnRTop = new System.Windows.Forms.Panel();
            this.lbText = new System.Windows.Forms.Label();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnL2 = new System.Windows.Forms.Panel();
            this.dgvStaf = new System.Windows.Forms.DataGridView();
            this.pnLTop = new System.Windows.Forms.Panel();
            this.lbStaff = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.pnRight.SuspendLayout();
            this.pn8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRepair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.pn6.SuspendLayout();
            this.pn5.SuspendLayout();
            this.pn4.SuspendLayout();
            this.pn3.SuspendLayout();
            this.pnR2.SuspendLayout();
            this.pnRTop.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.pnL2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaf)).BeginInit();
            this.pnLTop.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1275, 38);
            this.menuStrip1.TabIndex = 2;
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
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.Color.PeachPuff;
            this.pnRight.Controls.Add(this.pn8);
            this.pnRight.Controls.Add(this.pn6);
            this.pnRight.Controls.Add(this.pn5);
            this.pnRight.Controls.Add(this.pn4);
            this.pnRight.Controls.Add(this.pn3);
            this.pnRight.Controls.Add(this.pnR2);
            this.pnRight.Controls.Add(this.pnRTop);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Location = new System.Drawing.Point(985, 38);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(290, 452);
            this.pnRight.TabIndex = 3;
            // 
            // pn8
            // 
            this.pn8.BackColor = System.Drawing.Color.PeachPuff;
            this.pn8.Controls.Add(this.pbDelete);
            this.pn8.Controls.Add(this.pbRepair);
            this.pn8.Controls.Add(this.pbAdd);
            this.pn8.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn8.Location = new System.Drawing.Point(0, 382);
            this.pn8.Name = "pn8";
            this.pn8.Size = new System.Drawing.Size(290, 58);
            this.pn8.TabIndex = 6;
            // 
            // pbDelete
            // 
            this.pbDelete.Image = ((System.Drawing.Image)(resources.GetObject("pbDelete.Image")));
            this.pbDelete.Location = new System.Drawing.Point(212, 4);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(77, 50);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDelete.TabIndex = 5;
            this.pbDelete.TabStop = false;
            this.pbDelete.Click += new System.EventHandler(this.pbDelete_Click);
            // 
            // pbRepair
            // 
            this.pbRepair.Image = ((System.Drawing.Image)(resources.GetObject("pbRepair.Image")));
            this.pbRepair.Location = new System.Drawing.Point(107, 4);
            this.pbRepair.Name = "pbRepair";
            this.pbRepair.Size = new System.Drawing.Size(77, 50);
            this.pbRepair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRepair.TabIndex = 4;
            this.pbRepair.TabStop = false;
            this.pbRepair.Click += new System.EventHandler(this.pbRepair_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbAdd.Image")));
            this.pbAdd.Location = new System.Drawing.Point(2, 4);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(77, 50);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 3;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pn6
            // 
            this.pn6.BackColor = System.Drawing.Color.PeachPuff;
            this.pn6.Controls.Add(this.cbShow);
            this.pn6.Controls.Add(this.lbShow);
            this.pn6.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn6.Location = new System.Drawing.Point(0, 316);
            this.pn6.Name = "pn6";
            this.pn6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pn6.Size = new System.Drawing.Size(290, 66);
            this.pn6.TabIndex = 5;
            // 
            // cbShow
            // 
            this.cbShow.AutoSize = true;
            this.cbShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShow.Location = new System.Drawing.Point(105, 33);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(79, 22);
            this.cbShow.TabIndex = 4;
            this.cbShow.Text = "Hiển thị";
            this.cbShow.UseVisualStyleBackColor = true;
            // 
            // lbShow
            // 
            this.lbShow.AutoSize = true;
            this.lbShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShow.Location = new System.Drawing.Point(10, 0);
            this.lbShow.Name = "lbShow";
            this.lbShow.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.lbShow.Size = new System.Drawing.Size(101, 30);
            this.lbShow.TabIndex = 3;
            this.lbShow.Text = "Trạng thái:";
            // 
            // pn5
            // 
            this.pn5.BackColor = System.Drawing.Color.PeachPuff;
            this.pn5.Controls.Add(this.txtPhone);
            this.pn5.Controls.Add(this.lbPhone);
            this.pn5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn5.Location = new System.Drawing.Point(0, 250);
            this.pn5.Name = "pn5";
            this.pn5.Size = new System.Drawing.Size(290, 66);
            this.pn5.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(18, 33);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(202, 22);
            this.txtPhone.TabIndex = 3;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(0, 0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.lbPhone.Size = new System.Drawing.Size(124, 30);
            this.lbPhone.TabIndex = 2;
            this.lbPhone.Text = "Số điện thoại:";
            // 
            // pn4
            // 
            this.pn4.BackColor = System.Drawing.Color.PeachPuff;
            this.pn4.Controls.Add(this.rbSex2);
            this.pn4.Controls.Add(this.rbSex1);
            this.pn4.Controls.Add(this.lbSex);
            this.pn4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn4.Location = new System.Drawing.Point(0, 184);
            this.pn4.Name = "pn4";
            this.pn4.Size = new System.Drawing.Size(290, 66);
            this.pn4.TabIndex = 3;
            // 
            // rbSex2
            // 
            this.rbSex2.AutoSize = true;
            this.rbSex2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSex2.Location = new System.Drawing.Point(155, 31);
            this.rbSex2.Name = "rbSex2";
            this.rbSex2.Size = new System.Drawing.Size(48, 22);
            this.rbSex2.TabIndex = 3;
            this.rbSex2.TabStop = true;
            this.rbSex2.Text = "Nữ";
            this.rbSex2.UseVisualStyleBackColor = true;
            // 
            // rbSex1
            // 
            this.rbSex1.AutoSize = true;
            this.rbSex1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSex1.Location = new System.Drawing.Point(56, 31);
            this.rbSex1.Name = "rbSex1";
            this.rbSex1.Size = new System.Drawing.Size(61, 22);
            this.rbSex1.TabIndex = 2;
            this.rbSex1.TabStop = true;
            this.rbSex1.Text = "Nam";
            this.rbSex1.UseVisualStyleBackColor = true;
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSex.Location = new System.Drawing.Point(0, 0);
            this.lbSex.Name = "lbSex";
            this.lbSex.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.lbSex.Size = new System.Drawing.Size(85, 30);
            this.lbSex.TabIndex = 1;
            this.lbSex.Text = "Giới tính:";
            // 
            // pn3
            // 
            this.pn3.BackColor = System.Drawing.Color.PeachPuff;
            this.pn3.Controls.Add(this.txtName);
            this.pn3.Controls.Add(this.lbName);
            this.pn3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn3.Location = new System.Drawing.Point(0, 118);
            this.pn3.Name = "pn3";
            this.pn3.Size = new System.Drawing.Size(290, 66);
            this.pn3.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(18, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 22);
            this.txtName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.lbName.Size = new System.Drawing.Size(134, 30);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Tên nhân viên:";
            // 
            // pnR2
            // 
            this.pnR2.BackColor = System.Drawing.Color.PeachPuff;
            this.pnR2.Controls.Add(this.txtID);
            this.pnR2.Controls.Add(this.lbID);
            this.pnR2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnR2.Location = new System.Drawing.Point(0, 52);
            this.pnR2.Name = "pnR2";
            this.pnR2.Size = new System.Drawing.Size(290, 66);
            this.pnR2.TabIndex = 1;
            this.pnR2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnR2_Paint);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(18, 31);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(202, 22);
            this.txtID.TabIndex = 1;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.PeachPuff;
            this.lbID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(0, 0);
            this.lbID.Name = "lbID";
            this.lbID.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.lbID.Size = new System.Drawing.Size(126, 30);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Mã nhân viên:";
            // 
            // pnRTop
            // 
            this.pnRTop.BackColor = System.Drawing.Color.PeachPuff;
            this.pnRTop.Controls.Add(this.lbText);
            this.pnRTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnRTop.Location = new System.Drawing.Point(0, 0);
            this.pnRTop.Name = "pnRTop";
            this.pnRTop.Size = new System.Drawing.Size(290, 52);
            this.pnRTop.TabIndex = 0;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.BackColor = System.Drawing.Color.PeachPuff;
            this.lbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.Location = new System.Drawing.Point(0, 0);
            this.lbText.Name = "lbText";
            this.lbText.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lbText.Size = new System.Drawing.Size(267, 29);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "Đăng Ký Nhân Viên";
            this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnLeft
            // 
            this.pnLeft.Controls.Add(this.pnL2);
            this.pnLeft.Controls.Add(this.pnLTop);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLeft.Location = new System.Drawing.Point(0, 38);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(952, 452);
            this.pnLeft.TabIndex = 5;
            // 
            // pnL2
            // 
            this.pnL2.Controls.Add(this.dgvStaf);
            this.pnL2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnL2.Location = new System.Drawing.Point(0, 40);
            this.pnL2.Name = "pnL2";
            this.pnL2.Size = new System.Drawing.Size(952, 412);
            this.pnL2.TabIndex = 1;
            // 
            // dgvStaf
            // 
            this.dgvStaf.AllowUserToResizeColumns = false;
            this.dgvStaf.AllowUserToResizeRows = false;
            this.dgvStaf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaf.Location = new System.Drawing.Point(0, 0);
            this.dgvStaf.Name = "dgvStaf";
            this.dgvStaf.RowHeadersVisible = false;
            this.dgvStaf.RowHeadersWidth = 51;
            this.dgvStaf.RowTemplate.Height = 24;
            this.dgvStaf.Size = new System.Drawing.Size(952, 412);
            this.dgvStaf.TabIndex = 0;
            this.dgvStaf.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaf_CellClick);
            this.dgvStaf.SelectionChanged += new System.EventHandler(this.dgvStaf_SelectionChanged);
            // 
            // pnLTop
            // 
            this.pnLTop.Controls.Add(this.lbStaff);
            this.pnLTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLTop.Location = new System.Drawing.Point(0, 0);
            this.pnLTop.Name = "pnLTop";
            this.pnLTop.Size = new System.Drawing.Size(952, 40);
            this.pnLTop.TabIndex = 0;
            // 
            // lbStaff
            // 
            this.lbStaff.BackColor = System.Drawing.Color.PeachPuff;
            this.lbStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaff.ForeColor = System.Drawing.Color.Tomato;
            this.lbStaff.Location = new System.Drawing.Point(0, 0);
            this.lbStaff.Name = "lbStaff";
            this.lbStaff.Size = new System.Drawing.Size(952, 40);
            this.lbStaff.TabIndex = 3;
            this.lbStaff.Text = "Quản lý Nhân viên";
            this.lbStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(952, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 452);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 490);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnRight.ResumeLayout(false);
            this.pn8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRepair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.pn6.ResumeLayout(false);
            this.pn6.PerformLayout();
            this.pn5.ResumeLayout(false);
            this.pn5.PerformLayout();
            this.pn4.ResumeLayout(false);
            this.pn4.PerformLayout();
            this.pn3.ResumeLayout(false);
            this.pn3.PerformLayout();
            this.pnR2.ResumeLayout(false);
            this.pnR2.PerformLayout();
            this.pnRTop.ResumeLayout(false);
            this.pnRTop.PerformLayout();
            this.pnLeft.ResumeLayout(false);
            this.pnL2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaf)).EndInit();
            this.pnLTop.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Panel pnRTop;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnR2;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel pn3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel pn4;
        private System.Windows.Forms.RadioButton rbSex2;
        private System.Windows.Forms.RadioButton rbSex1;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Panel pn5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Panel pn6;
        private System.Windows.Forms.Panel pnLTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbStaff;
        private System.Windows.Forms.Panel pnL2;
        private System.Windows.Forms.DataGridView dgvStaf;
        private System.Windows.Forms.Panel pn8;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.PictureBox pbRepair;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.CheckBox cbShow;
        private System.Windows.Forms.Label lbShow;
        private System.Windows.Forms.ToolStripMenuItem tsStatistical;
    }
}