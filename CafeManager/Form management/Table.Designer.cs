namespace CafeManager.Form_management
{
    partial class Table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Table));
            this.pnTableBottom = new System.Windows.Forms.Panel();
            this.pnBTFill = new System.Windows.Forms.Panel();
            this.pnButton = new System.Windows.Forms.Panel();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tbNumner = new System.Windows.Forms.TextBox();
            this.lbNumberTable = new System.Windows.Forms.Label();
            this.pnTBFTop = new System.Windows.Forms.Panel();
            this.lbTable = new System.Windows.Forms.Label();
            this.pnTBRight = new System.Windows.Forms.Panel();
            this.lbUsed = new System.Windows.Forms.Label();
            this.lbClean = new System.Windows.Forms.Label();
            this.lbBook = new System.Windows.Forms.Label();
            this.pbUsed = new System.Windows.Forms.PictureBox();
            this.pbClean = new System.Windows.Forms.PictureBox();
            this.pbBook = new System.Windows.Forms.PictureBox();
            this.lbEmpty = new System.Windows.Forms.Label();
            this.pbEmpty = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.flbTable = new System.Windows.Forms.FlowLayoutPanel();
            this.pnTableBottom.SuspendLayout();
            this.pnBTFill.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.pnTBFTop.SuspendLayout();
            this.pnTBRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpty)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTableBottom
            // 
            this.pnTableBottom.BackColor = System.Drawing.Color.PeachPuff;
            this.pnTableBottom.Controls.Add(this.pnBTFill);
            this.pnTableBottom.Controls.Add(this.pnTBRight);
            this.pnTableBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnTableBottom.Location = new System.Drawing.Point(0, 333);
            this.pnTableBottom.Name = "pnTableBottom";
            this.pnTableBottom.Size = new System.Drawing.Size(1261, 198);
            this.pnTableBottom.TabIndex = 3;
            // 
            // pnBTFill
            // 
            this.pnBTFill.Controls.Add(this.pnButton);
            this.pnBTFill.Controls.Add(this.lbStatus);
            this.pnBTFill.Controls.Add(this.cbStatus);
            this.pnBTFill.Controls.Add(this.tbNumner);
            this.pnBTFill.Controls.Add(this.lbNumberTable);
            this.pnBTFill.Controls.Add(this.pnTBFTop);
            this.pnBTFill.Location = new System.Drawing.Point(0, 0);
            this.pnBTFill.Name = "pnBTFill";
            this.pnBTFill.Size = new System.Drawing.Size(969, 198);
            this.pnBTFill.TabIndex = 7;
            // 
            // pnButton
            // 
            this.pnButton.Controls.Add(this.btUpdate);
            this.pnButton.Controls.Add(this.btDelete);
            this.pnButton.Controls.Add(this.btAdd);
            this.pnButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnButton.Location = new System.Drawing.Point(257, 148);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(452, 50);
            this.pnButton.TabIndex = 10;
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(184, 3);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 40);
            this.btUpdate.TabIndex = 7;
            this.btUpdate.Text = "Cập nhật";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btDelete.Location = new System.Drawing.Point(377, 0);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 50);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "Xoá";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btAdd.Location = new System.Drawing.Point(0, 0);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 50);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(709, 49);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.lbStatus.Size = new System.Drawing.Size(129, 20);
            this.lbStatus.TabIndex = 9;
            this.lbStatus.Text = "Trạng thái:";
            // 
            // cbStatus
            // 
            this.cbStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Trống",
            "Đã sử dụng",
            "Đã đặt trước",
            "Dọn dẹp"});
            this.cbStatus.Location = new System.Drawing.Point(838, 49);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(131, 24);
            this.cbStatus.TabIndex = 4;
            // 
            // tbNumner
            // 
            this.tbNumner.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbNumner.Location = new System.Drawing.Point(126, 49);
            this.tbNumner.Name = "tbNumner";
            this.tbNumner.Size = new System.Drawing.Size(131, 22);
            this.tbNumner.TabIndex = 2;
            // 
            // lbNumberTable
            // 
            this.lbNumberTable.AutoSize = true;
            this.lbNumberTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbNumberTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberTable.Location = new System.Drawing.Point(0, 49);
            this.lbNumberTable.Name = "lbNumberTable";
            this.lbNumberTable.Padding = new System.Windows.Forms.Padding(20, 0, 40, 0);
            this.lbNumberTable.Size = new System.Drawing.Size(126, 20);
            this.lbNumberTable.TabIndex = 1;
            this.lbNumberTable.Text = "Số bàn:";
            // 
            // pnTBFTop
            // 
            this.pnTBFTop.Controls.Add(this.lbTable);
            this.pnTBFTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTBFTop.Location = new System.Drawing.Point(0, 0);
            this.pnTBFTop.Name = "pnTBFTop";
            this.pnTBFTop.Size = new System.Drawing.Size(969, 49);
            this.pnTBFTop.TabIndex = 0;
            // 
            // lbTable
            // 
            this.lbTable.BackColor = System.Drawing.Color.PeachPuff;
            this.lbTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTable.ForeColor = System.Drawing.Color.Tomato;
            this.lbTable.Location = new System.Drawing.Point(0, 0);
            this.lbTable.Name = "lbTable";
            this.lbTable.Size = new System.Drawing.Size(969, 49);
            this.lbTable.TabIndex = 2;
            this.lbTable.Text = "Quản lý Bàn";
            this.lbTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnTBRight
            // 
            this.pnTBRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTBRight.Controls.Add(this.lbUsed);
            this.pnTBRight.Controls.Add(this.lbClean);
            this.pnTBRight.Controls.Add(this.lbBook);
            this.pnTBRight.Controls.Add(this.pbUsed);
            this.pnTBRight.Controls.Add(this.pbClean);
            this.pnTBRight.Controls.Add(this.pbBook);
            this.pnTBRight.Controls.Add(this.lbEmpty);
            this.pnTBRight.Controls.Add(this.pbEmpty);
            this.pnTBRight.Controls.Add(this.label1);
            this.pnTBRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnTBRight.Location = new System.Drawing.Point(1114, 0);
            this.pnTBRight.Name = "pnTBRight";
            this.pnTBRight.Size = new System.Drawing.Size(147, 198);
            this.pnTBRight.TabIndex = 6;
            // 
            // lbUsed
            // 
            this.lbUsed.AutoSize = true;
            this.lbUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsed.Location = new System.Drawing.Point(43, 78);
            this.lbUsed.Name = "lbUsed";
            this.lbUsed.Size = new System.Drawing.Size(84, 16);
            this.lbUsed.TabIndex = 8;
            this.lbUsed.Text = "Đã sử dụng";
            // 
            // lbClean
            // 
            this.lbClean.AutoSize = true;
            this.lbClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClean.Location = new System.Drawing.Point(43, 161);
            this.lbClean.Name = "lbClean";
            this.lbClean.Size = new System.Drawing.Size(66, 16);
            this.lbClean.TabIndex = 7;
            this.lbClean.Text = "Dọn dẹp";
            // 
            // lbBook
            // 
            this.lbBook.AutoSize = true;
            this.lbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBook.Location = new System.Drawing.Point(43, 120);
            this.lbBook.Name = "lbBook";
            this.lbBook.Size = new System.Drawing.Size(68, 16);
            this.lbBook.TabIndex = 6;
            this.lbBook.Text = "Đặt trước";
            // 
            // pbUsed
            // 
            this.pbUsed.Image = ((System.Drawing.Image)(resources.GetObject("pbUsed.Image")));
            this.pbUsed.Location = new System.Drawing.Point(12, 77);
            this.pbUsed.Name = "pbUsed";
            this.pbUsed.Size = new System.Drawing.Size(16, 17);
            this.pbUsed.TabIndex = 5;
            this.pbUsed.TabStop = false;
            // 
            // pbClean
            // 
            this.pbClean.Image = ((System.Drawing.Image)(resources.GetObject("pbClean.Image")));
            this.pbClean.Location = new System.Drawing.Point(12, 161);
            this.pbClean.Name = "pbClean";
            this.pbClean.Size = new System.Drawing.Size(16, 17);
            this.pbClean.TabIndex = 4;
            this.pbClean.TabStop = false;
            // 
            // pbBook
            // 
            this.pbBook.Image = ((System.Drawing.Image)(resources.GetObject("pbBook.Image")));
            this.pbBook.Location = new System.Drawing.Point(12, 120);
            this.pbBook.Name = "pbBook";
            this.pbBook.Size = new System.Drawing.Size(16, 17);
            this.pbBook.TabIndex = 3;
            this.pbBook.TabStop = false;
            // 
            // lbEmpty
            // 
            this.lbEmpty.AutoSize = true;
            this.lbEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpty.Location = new System.Drawing.Point(43, 35);
            this.lbEmpty.Name = "lbEmpty";
            this.lbEmpty.Size = new System.Drawing.Size(73, 16);
            this.lbEmpty.TabIndex = 2;
            this.lbEmpty.Text = "Bàn trống";
            // 
            // pbEmpty
            // 
            this.pbEmpty.Image = ((System.Drawing.Image)(resources.GetObject("pbEmpty.Image")));
            this.pbEmpty.Location = new System.Drawing.Point(12, 34);
            this.pbEmpty.Name = "pbEmpty";
            this.pbEmpty.Size = new System.Drawing.Size(16, 17);
            this.pbEmpty.TabIndex = 1;
            this.pbEmpty.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lưu Ý:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 43);
            this.panel1.TabIndex = 5;
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
            this.menuStrip1.Size = new System.Drawing.Size(1261, 38);
            this.menuStrip1.TabIndex = 6;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.flbTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1261, 290);
            this.panel2.TabIndex = 6;
            // 
            // flbTable
            // 
            this.flbTable.AutoScroll = true;
            this.flbTable.BackColor = System.Drawing.Color.PeachPuff;
            this.flbTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flbTable.Location = new System.Drawing.Point(0, 0);
            this.flbTable.Name = "flbTable";
            this.flbTable.Size = new System.Drawing.Size(1261, 290);
            this.flbTable.TabIndex = 5;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 531);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTableBottom);
            this.Name = "Table";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.Table_Load);
            this.pnTableBottom.ResumeLayout(false);
            this.pnBTFill.ResumeLayout(false);
            this.pnBTFill.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.pnTBFTop.ResumeLayout(false);
            this.pnTBRight.ResumeLayout(false);
            this.pnTBRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpty)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTableBottom;
        private System.Windows.Forms.Panel pnBTFill;
        private System.Windows.Forms.Panel pnTBRight;
        private System.Windows.Forms.Label lbUsed;
        private System.Windows.Forms.Label lbClean;
        private System.Windows.Forms.Label lbBook;
        private System.Windows.Forms.PictureBox pbUsed;
        private System.Windows.Forms.PictureBox pbClean;
        private System.Windows.Forms.PictureBox pbBook;
        private System.Windows.Forms.Label lbEmpty;
        private System.Windows.Forms.PictureBox pbEmpty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnTBFTop;
        private System.Windows.Forms.Label lbTable;
        private System.Windows.Forms.TextBox tbNumner;
        private System.Windows.Forms.Label lbNumberTable;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flbTable;
        private System.Windows.Forms.ToolStripMenuItem tsStatistical;
    }
}