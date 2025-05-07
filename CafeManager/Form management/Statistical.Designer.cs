namespace CafeManager.Form_management
{
    partial class Statistical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistical));
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
            this.pn1 = new System.Windows.Forms.Panel();
            this.lbStatistical = new System.Windows.Forms.Label();
            this.pn2 = new System.Windows.Forms.Panel();
            this.pn1Right = new System.Windows.Forms.Panel();
            this.btSearch = new System.Windows.Forms.Button();
            this.dtpStatistical = new System.Windows.Forms.DateTimePicker();
            this.pn1Left = new System.Windows.Forms.Panel();
            this.cbStatistical = new System.Windows.Forms.ComboBox();
            this.pn3 = new System.Windows.Forms.Panel();
            this.dgvStatistical = new System.Windows.Forms.DataGridView();
            this.pn4 = new System.Windows.Forms.Panel();
            this.lbNumber = new System.Windows.Forms.Label();
            this.lbSum = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pn1.SuspendLayout();
            this.pn2.SuspendLayout();
            this.pn1Right.SuspendLayout();
            this.pn1Left.SuspendLayout();
            this.pn3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistical)).BeginInit();
            this.pn4.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1279, 38);
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
            this.tsStatistical.Size = new System.Drawing.Size(141, 34);
            this.tsStatistical.Text = "Doanh Thu";
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
            // pn1
            // 
            this.pn1.Controls.Add(this.lbStatistical);
            this.pn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn1.Location = new System.Drawing.Point(0, 38);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(1279, 35);
            this.pn1.TabIndex = 3;
            // 
            // lbStatistical
            // 
            this.lbStatistical.BackColor = System.Drawing.Color.PeachPuff;
            this.lbStatistical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStatistical.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatistical.ForeColor = System.Drawing.Color.Tomato;
            this.lbStatistical.Location = new System.Drawing.Point(0, 0);
            this.lbStatistical.Name = "lbStatistical";
            this.lbStatistical.Size = new System.Drawing.Size(1279, 35);
            this.lbStatistical.TabIndex = 2;
            this.lbStatistical.Text = "Thống Kê Doanh Thu";
            this.lbStatistical.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn2
            // 
            this.pn2.BackColor = System.Drawing.Color.PeachPuff;
            this.pn2.Controls.Add(this.pn1Right);
            this.pn2.Controls.Add(this.pn1Left);
            this.pn2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn2.Location = new System.Drawing.Point(0, 73);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(1279, 62);
            this.pn2.TabIndex = 4;
            // 
            // pn1Right
            // 
            this.pn1Right.BackColor = System.Drawing.Color.PeachPuff;
            this.pn1Right.Controls.Add(this.btSearch);
            this.pn1Right.Controls.Add(this.dtpStatistical);
            this.pn1Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn1Right.Location = new System.Drawing.Point(703, 0);
            this.pn1Right.Name = "pn1Right";
            this.pn1Right.Size = new System.Drawing.Size(576, 62);
            this.pn1Right.TabIndex = 1;
            // 
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.Location = new System.Drawing.Point(461, 19);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(81, 31);
            this.btSearch.TabIndex = 1;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // dtpStatistical
            // 
            this.dtpStatistical.Location = new System.Drawing.Point(136, 22);
            this.dtpStatistical.Name = "dtpStatistical";
            this.dtpStatistical.Size = new System.Drawing.Size(306, 22);
            this.dtpStatistical.TabIndex = 0;
            // 
            // pn1Left
            // 
            this.pn1Left.BackColor = System.Drawing.Color.PeachPuff;
            this.pn1Left.Controls.Add(this.cbStatistical);
            this.pn1Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn1Left.Location = new System.Drawing.Point(0, 0);
            this.pn1Left.Name = "pn1Left";
            this.pn1Left.Size = new System.Drawing.Size(563, 62);
            this.pn1Left.TabIndex = 0;
            // 
            // cbStatistical
            // 
            this.cbStatistical.FormattingEnabled = true;
            this.cbStatistical.Location = new System.Drawing.Point(102, 20);
            this.cbStatistical.Name = "cbStatistical";
            this.cbStatistical.Size = new System.Drawing.Size(306, 24);
            this.cbStatistical.TabIndex = 0;
            // 
            // pn3
            // 
            this.pn3.Controls.Add(this.dgvStatistical);
            this.pn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn3.Location = new System.Drawing.Point(0, 135);
            this.pn3.Name = "pn3";
            this.pn3.Size = new System.Drawing.Size(1279, 315);
            this.pn3.TabIndex = 5;
            // 
            // dgvStatistical
            // 
            this.dgvStatistical.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatistical.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStatistical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatistical.Location = new System.Drawing.Point(0, 0);
            this.dgvStatistical.Name = "dgvStatistical";
            this.dgvStatistical.RowHeadersWidth = 51;
            this.dgvStatistical.RowTemplate.Height = 24;
            this.dgvStatistical.Size = new System.Drawing.Size(1279, 315);
            this.dgvStatistical.TabIndex = 0;
            // 
            // pn4
            // 
            this.pn4.BackColor = System.Drawing.Color.PeachPuff;
            this.pn4.Controls.Add(this.lbNumber);
            this.pn4.Controls.Add(this.lbSum);
            this.pn4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn4.Location = new System.Drawing.Point(0, 369);
            this.pn4.Name = "pn4";
            this.pn4.Size = new System.Drawing.Size(1279, 81);
            this.pn4.TabIndex = 6;
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.ForeColor = System.Drawing.Color.Red;
            this.lbNumber.Location = new System.Drawing.Point(916, 32);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(113, 22);
            this.lbNumber.TabIndex = 1;
            this.lbNumber.Text = "Số Hoá Đơn:";
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSum.ForeColor = System.Drawing.Color.Red;
            this.lbSum.Location = new System.Drawing.Point(47, 32);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(152, 22);
            this.lbSum.TabIndex = 0;
            this.lbSum.Text = "Tổng Doanh Thu:";
            // 
            // Statistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 450);
            this.Controls.Add(this.pn4);
            this.Controls.Add(this.pn3);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Statistical";
            this.Text = "Statistical";
            this.Load += new System.EventHandler(this.Statistical_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pn1.ResumeLayout(false);
            this.pn2.ResumeLayout(false);
            this.pn1Right.ResumeLayout(false);
            this.pn1Left.ResumeLayout(false);
            this.pn3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistical)).EndInit();
            this.pn4.ResumeLayout(false);
            this.pn4.PerformLayout();
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
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Panel pn2;
        private System.Windows.Forms.Panel pn3;
        private System.Windows.Forms.Panel pn4;
        private System.Windows.Forms.Label lbStatistical;
        private System.Windows.Forms.Panel pn1Right;
        private System.Windows.Forms.Panel pn1Left;
        private System.Windows.Forms.DateTimePicker dtpStatistical;
        private System.Windows.Forms.ComboBox cbStatistical;
        private System.Windows.Forms.DataGridView dgvStatistical;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.ToolStripMenuItem tsStatistical;
    }
}