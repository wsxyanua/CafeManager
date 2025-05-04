namespace CafeManager.Form_management
{
    partial class Pay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay));
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
            this.pnPay = new System.Windows.Forms.Panel();
            this.pnP1 = new System.Windows.Forms.Panel();
            this.dgvPList = new System.Windows.Forms.DataGridView();
            this.pnP2 = new System.Windows.Forms.Panel();
            this.btPSearch = new System.Windows.Forms.Button();
            this.btPPay = new System.Windows.Forms.Button();
            this.txtPSum = new System.Windows.Forms.TextBox();
            this.lbPSum = new System.Windows.Forms.Label();
            this.lbPNumber = new System.Windows.Forms.Label();
            this.txtPNumber = new System.Windows.Forms.TextBox();
            this.pnPTop = new System.Windows.Forms.Panel();
            this.lbPay = new System.Windows.Forms.Label();
            this.pnOrder = new System.Windows.Forms.Panel();
            this.pnO4 = new System.Windows.Forms.Panel();
            this.txtONumber = new System.Windows.Forms.TextBox();
            this.lbONumber = new System.Windows.Forms.Label();
            this.btOPut = new System.Windows.Forms.Button();
            this.pnO3 = new System.Windows.Forms.Panel();
            this.nudOQuantity = new System.Windows.Forms.NumericUpDown();
            this.lbOQuantity = new System.Windows.Forms.Label();
            this.pnO2 = new System.Windows.Forms.Panel();
            this.txtOPrice = new System.Windows.Forms.TextBox();
            this.lbOPrice = new System.Windows.Forms.Label();
            this.pnO1 = new System.Windows.Forms.Panel();
            this.txtOName = new System.Windows.Forms.TextBox();
            this.lbOName = new System.Windows.Forms.Label();
            this.pOTop = new System.Windows.Forms.Panel();
            this.lbOrder = new System.Windows.Forms.Label();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.pnPay.SuspendLayout();
            this.pnP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPList)).BeginInit();
            this.pnP2.SuspendLayout();
            this.pnPTop.SuspendLayout();
            this.pnOrder.SuspendLayout();
            this.pnO4.SuspendLayout();
            this.pnO3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOQuantity)).BeginInit();
            this.pnO2.SuspendLayout();
            this.pnO1.SuspendLayout();
            this.pOTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(1285, 38);
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
            // 
            // tsName
            // 
            this.tsName.CausesValidation = false;
            this.tsName.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsName.ForeColor = System.Drawing.Color.Red;
            this.tsName.Name = "tsName";
            this.tsName.ReadOnly = true;
            this.tsName.Size = new System.Drawing.Size(310, 34);
            this.tsName.Text = "CAFE Ngũ Hổ Tướng";
            this.tsName.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tsName.Click += new System.EventHandler(this.tsName_Click);
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
            // pnPay
            // 
            this.pnPay.Controls.Add(this.pnP1);
            this.pnPay.Controls.Add(this.pnP2);
            this.pnPay.Controls.Add(this.pnPTop);
            this.pnPay.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnPay.Location = new System.Drawing.Point(832, 38);
            this.pnPay.Name = "pnPay";
            this.pnPay.Size = new System.Drawing.Size(453, 509);
            this.pnPay.TabIndex = 3;
            // 
            // pnP1
            // 
            this.pnP1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnP1.Controls.Add(this.dgvPList);
            this.pnP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnP1.Location = new System.Drawing.Point(0, 37);
            this.pnP1.Name = "pnP1";
            this.pnP1.Size = new System.Drawing.Size(453, 345);
            this.pnP1.TabIndex = 2;
            // 
            // dgvPList
            // 
            this.dgvPList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPList.Location = new System.Drawing.Point(0, 0);
            this.dgvPList.Name = "dgvPList";
            this.dgvPList.RowHeadersWidth = 51;
            this.dgvPList.RowTemplate.Height = 24;
            this.dgvPList.Size = new System.Drawing.Size(449, 341);
            this.dgvPList.TabIndex = 0;
            // 
            // pnP2
            // 
            this.pnP2.Controls.Add(this.btPSearch);
            this.pnP2.Controls.Add(this.btPPay);
            this.pnP2.Controls.Add(this.txtPSum);
            this.pnP2.Controls.Add(this.lbPSum);
            this.pnP2.Controls.Add(this.lbPNumber);
            this.pnP2.Controls.Add(this.txtPNumber);
            this.pnP2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnP2.Location = new System.Drawing.Point(0, 382);
            this.pnP2.Name = "pnP2";
            this.pnP2.Size = new System.Drawing.Size(453, 127);
            this.pnP2.TabIndex = 1;
            // 
            // btPSearch
            // 
            this.btPSearch.Location = new System.Drawing.Point(306, 13);
            this.btPSearch.Name = "btPSearch";
            this.btPSearch.Size = new System.Drawing.Size(75, 30);
            this.btPSearch.TabIndex = 13;
            this.btPSearch.Text = "Tìm kiếm";
            this.btPSearch.UseVisualStyleBackColor = true;
            this.btPSearch.Click += new System.EventHandler(this.btPSearch_Click);
            // 
            // btPPay
            // 
            this.btPPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPPay.Location = new System.Drawing.Point(144, 72);
            this.btPPay.Name = "btPPay";
            this.btPPay.Size = new System.Drawing.Size(121, 41);
            this.btPPay.TabIndex = 12;
            this.btPPay.Text = "Thanh Toán";
            this.btPPay.UseVisualStyleBackColor = true;
            this.btPPay.Click += new System.EventHandler(this.btPPay_Click);
            // 
            // txtPSum
            // 
            this.txtPSum.Location = new System.Drawing.Point(131, 44);
            this.txtPSum.Name = "txtPSum";
            this.txtPSum.ReadOnly = true;
            this.txtPSum.Size = new System.Drawing.Size(154, 22);
            this.txtPSum.TabIndex = 11;
            // 
            // lbPSum
            // 
            this.lbPSum.AutoSize = true;
            this.lbPSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPSum.ForeColor = System.Drawing.Color.Red;
            this.lbPSum.Location = new System.Drawing.Point(8, 44);
            this.lbPSum.Name = "lbPSum";
            this.lbPSum.Size = new System.Drawing.Size(88, 20);
            this.lbPSum.TabIndex = 10;
            this.lbPSum.Text = "Tổng Tiền:";
            // 
            // lbPNumber
            // 
            this.lbPNumber.AutoSize = true;
            this.lbPNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPNumber.Location = new System.Drawing.Point(8, 13);
            this.lbPNumber.Name = "lbPNumber";
            this.lbPNumber.Size = new System.Drawing.Size(105, 20);
            this.lbPNumber.TabIndex = 9;
            this.lbPNumber.Text = "Số Hoá Đơn:";
            // 
            // txtPNumber
            // 
            this.txtPNumber.Location = new System.Drawing.Point(131, 13);
            this.txtPNumber.Name = "txtPNumber";
            this.txtPNumber.Size = new System.Drawing.Size(154, 22);
            this.txtPNumber.TabIndex = 8;
            // 
            // pnPTop
            // 
            this.pnPTop.Controls.Add(this.lbPay);
            this.pnPTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPTop.Location = new System.Drawing.Point(0, 0);
            this.pnPTop.Name = "pnPTop";
            this.pnPTop.Size = new System.Drawing.Size(453, 37);
            this.pnPTop.TabIndex = 0;
            // 
            // lbPay
            // 
            this.lbPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPay.ForeColor = System.Drawing.Color.Tomato;
            this.lbPay.Location = new System.Drawing.Point(0, 0);
            this.lbPay.Name = "lbPay";
            this.lbPay.Size = new System.Drawing.Size(453, 37);
            this.lbPay.TabIndex = 3;
            this.lbPay.Text = "Thanh Toán";
            this.lbPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnOrder
            // 
            this.pnOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnOrder.Controls.Add(this.pnO4);
            this.pnOrder.Controls.Add(this.pnO3);
            this.pnOrder.Controls.Add(this.pnO2);
            this.pnOrder.Controls.Add(this.pnO1);
            this.pnOrder.Controls.Add(this.pOTop);
            this.pnOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnOrder.Location = new System.Drawing.Point(627, 38);
            this.pnOrder.Name = "pnOrder";
            this.pnOrder.Size = new System.Drawing.Size(205, 509);
            this.pnOrder.TabIndex = 4;
            // 
            // pnO4
            // 
            this.pnO4.Controls.Add(this.txtONumber);
            this.pnO4.Controls.Add(this.lbONumber);
            this.pnO4.Controls.Add(this.btOPut);
            this.pnO4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnO4.Location = new System.Drawing.Point(0, 205);
            this.pnO4.Name = "pnO4";
            this.pnO4.Size = new System.Drawing.Size(201, 158);
            this.pnO4.TabIndex = 4;
            // 
            // txtONumber
            // 
            this.txtONumber.Location = new System.Drawing.Point(28, 59);
            this.txtONumber.Name = "txtONumber";
            this.txtONumber.Size = new System.Drawing.Size(154, 22);
            this.txtONumber.TabIndex = 7;
            // 
            // lbONumber
            // 
            this.lbONumber.AutoSize = true;
            this.lbONumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbONumber.Location = new System.Drawing.Point(52, 23);
            this.lbONumber.Name = "lbONumber";
            this.lbONumber.Size = new System.Drawing.Size(100, 20);
            this.lbONumber.TabIndex = 6;
            this.lbONumber.Text = "Số Hoá Đơn";
            // 
            // btOPut
            // 
            this.btOPut.Location = new System.Drawing.Point(68, 113);
            this.btOPut.Name = "btOPut";
            this.btOPut.Size = new System.Drawing.Size(69, 31);
            this.btOPut.TabIndex = 5;
            this.btOPut.Text = "Đặt Món";
            this.btOPut.UseVisualStyleBackColor = true;
            this.btOPut.Click += new System.EventHandler(this.btOPut_Click);
            // 
            // pnO3
            // 
            this.pnO3.Controls.Add(this.nudOQuantity);
            this.pnO3.Controls.Add(this.lbOQuantity);
            this.pnO3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnO3.Location = new System.Drawing.Point(0, 149);
            this.pnO3.Name = "pnO3";
            this.pnO3.Size = new System.Drawing.Size(201, 56);
            this.pnO3.TabIndex = 3;
            // 
            // nudOQuantity
            // 
            this.nudOQuantity.Location = new System.Drawing.Point(43, 31);
            this.nudOQuantity.Name = "nudOQuantity";
            this.nudOQuantity.Size = new System.Drawing.Size(154, 22);
            this.nudOQuantity.TabIndex = 1;
            // 
            // lbOQuantity
            // 
            this.lbOQuantity.AutoSize = true;
            this.lbOQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOQuantity.Location = new System.Drawing.Point(6, 3);
            this.lbOQuantity.Name = "lbOQuantity";
            this.lbOQuantity.Size = new System.Drawing.Size(85, 20);
            this.lbOQuantity.TabIndex = 0;
            this.lbOQuantity.Text = "Số Lượng:";
            // 
            // pnO2
            // 
            this.pnO2.Controls.Add(this.txtOPrice);
            this.pnO2.Controls.Add(this.lbOPrice);
            this.pnO2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnO2.Location = new System.Drawing.Point(0, 93);
            this.pnO2.Name = "pnO2";
            this.pnO2.Size = new System.Drawing.Size(201, 56);
            this.pnO2.TabIndex = 2;
            // 
            // txtOPrice
            // 
            this.txtOPrice.Location = new System.Drawing.Point(43, 29);
            this.txtOPrice.Name = "txtOPrice";
            this.txtOPrice.ReadOnly = true;
            this.txtOPrice.Size = new System.Drawing.Size(154, 22);
            this.txtOPrice.TabIndex = 1;
            // 
            // lbOPrice
            // 
            this.lbOPrice.AutoSize = true;
            this.lbOPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOPrice.Location = new System.Drawing.Point(6, 3);
            this.lbOPrice.Name = "lbOPrice";
            this.lbOPrice.Size = new System.Drawing.Size(75, 20);
            this.lbOPrice.TabIndex = 0;
            this.lbOPrice.Text = "Đơn Giá:";
            // 
            // pnO1
            // 
            this.pnO1.Controls.Add(this.txtOName);
            this.pnO1.Controls.Add(this.lbOName);
            this.pnO1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnO1.Location = new System.Drawing.Point(0, 37);
            this.pnO1.Name = "pnO1";
            this.pnO1.Size = new System.Drawing.Size(201, 56);
            this.pnO1.TabIndex = 1;
            // 
            // txtOName
            // 
            this.txtOName.Location = new System.Drawing.Point(43, 29);
            this.txtOName.Name = "txtOName";
            this.txtOName.ReadOnly = true;
            this.txtOName.Size = new System.Drawing.Size(154, 22);
            this.txtOName.TabIndex = 1;
            // 
            // lbOName
            // 
            this.lbOName.AutoSize = true;
            this.lbOName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOName.Location = new System.Drawing.Point(6, 3);
            this.lbOName.Name = "lbOName";
            this.lbOName.Size = new System.Drawing.Size(79, 20);
            this.lbOName.TabIndex = 0;
            this.lbOName.Text = "Tên Món:";
            // 
            // pOTop
            // 
            this.pOTop.Controls.Add(this.lbOrder);
            this.pOTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pOTop.Location = new System.Drawing.Point(0, 0);
            this.pOTop.Name = "pOTop";
            this.pOTop.Size = new System.Drawing.Size(201, 37);
            this.pOTop.TabIndex = 0;
            // 
            // lbOrder
            // 
            this.lbOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrder.ForeColor = System.Drawing.Color.Tomato;
            this.lbOrder.Location = new System.Drawing.Point(0, 0);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(201, 37);
            this.lbOrder.TabIndex = 3;
            this.lbOrder.Text = "Order";
            this.lbOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpMenu
            // 
            this.flpMenu.AutoScroll = true;
            this.flpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMenu.Location = new System.Drawing.Point(0, 38);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(627, 509);
            this.flpMenu.TabIndex = 5;
            this.flpMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.flpMenu_Paint);
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 547);
            this.Controls.Add(this.flpMenu);
            this.Controls.Add(this.pnOrder);
            this.Controls.Add(this.pnPay);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Pay";
            this.Text = "Pay";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnPay.ResumeLayout(false);
            this.pnP1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPList)).EndInit();
            this.pnP2.ResumeLayout(false);
            this.pnP2.PerformLayout();
            this.pnPTop.ResumeLayout(false);
            this.pnOrder.ResumeLayout(false);
            this.pnO4.ResumeLayout(false);
            this.pnO4.PerformLayout();
            this.pnO3.ResumeLayout(false);
            this.pnO3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOQuantity)).EndInit();
            this.pnO2.ResumeLayout(false);
            this.pnO2.PerformLayout();
            this.pnO1.ResumeLayout(false);
            this.pnO1.PerformLayout();
            this.pOTop.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnPay;
        private System.Windows.Forms.Panel pnOrder;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Panel pnPTop;
        private System.Windows.Forms.Label lbPay;
        private System.Windows.Forms.Panel pnO1;
        private System.Windows.Forms.Label lbOName;
        private System.Windows.Forms.Panel pOTop;
        private System.Windows.Forms.Label lbOrder;
        private System.Windows.Forms.TextBox txtOName;
        private System.Windows.Forms.Panel pnO3;
        private System.Windows.Forms.NumericUpDown nudOQuantity;
        private System.Windows.Forms.Label lbOQuantity;
        private System.Windows.Forms.Panel pnO2;
        private System.Windows.Forms.TextBox txtOPrice;
        private System.Windows.Forms.Label lbOPrice;
        private System.Windows.Forms.Panel pnO4;
        private System.Windows.Forms.Label lbONumber;
        private System.Windows.Forms.Button btOPut;
        private System.Windows.Forms.TextBox txtONumber;
        private System.Windows.Forms.Panel pnP1;
        private System.Windows.Forms.Panel pnP2;
        private System.Windows.Forms.TextBox txtPNumber;
        private System.Windows.Forms.Button btPPay;
        private System.Windows.Forms.TextBox txtPSum;
        private System.Windows.Forms.Label lbPSum;
        private System.Windows.Forms.Label lbPNumber;
        private System.Windows.Forms.DataGridView dgvPList;
        private System.Windows.Forms.Button btPSearch;
        private System.Windows.Forms.ToolStripMenuItem tsStatistical;
    }
}