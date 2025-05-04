namespace CafeManager.Form_management
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbNameShop = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnFill = new System.Windows.Forms.Panel();
            this.btSignUp = new System.Windows.Forms.Button();
            this.rbPosition2 = new System.Windows.Forms.RadioButton();
            this.lbPassword = new System.Windows.Forms.Label();
            this.rbPosition1 = new System.Windows.Forms.RadioButton();
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.Pink;
            this.pnTop.Controls.Add(this.lbNameShop);
            this.pnTop.Controls.Add(this.pictureBox1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(800, 184);
            this.pnTop.TabIndex = 0;
            this.pnTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTop_Paint);
            // 
            // lbNameShop
            // 
            this.lbNameShop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbNameShop.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameShop.ForeColor = System.Drawing.Color.Red;
            this.lbNameShop.Location = new System.Drawing.Point(0, 147);
            this.lbNameShop.Name = "lbNameShop";
            this.lbNameShop.Size = new System.Drawing.Size(800, 37);
            this.lbNameShop.TabIndex = 5;
            this.lbNameShop.Text = "CAFE Ngũ Hổ Tướng";
            this.lbNameShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbNameShop.Click += new System.EventHandler(this.lbNameShop_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(340, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnFill
            // 
            this.pnFill.BackColor = System.Drawing.Color.Pink;
            this.pnFill.Controls.Add(this.btSignUp);
            this.pnFill.Controls.Add(this.rbPosition2);
            this.pnFill.Controls.Add(this.lbPassword);
            this.pnFill.Controls.Add(this.rbPosition1);
            this.pnFill.Controls.Add(this.lbName);
            this.pnFill.Controls.Add(this.txtName);
            this.pnFill.Controls.Add(this.txtPassword);
            this.pnFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFill.Location = new System.Drawing.Point(0, 184);
            this.pnFill.Name = "pnFill";
            this.pnFill.Size = new System.Drawing.Size(800, 266);
            this.pnFill.TabIndex = 1;
            // 
            // btSignUp
            // 
            this.btSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignUp.Location = new System.Drawing.Point(344, 210);
            this.btSignUp.Name = "btSignUp";
            this.btSignUp.Size = new System.Drawing.Size(129, 44);
            this.btSignUp.TabIndex = 16;
            this.btSignUp.Text = "Đăng Nhập";
            this.btSignUp.UseVisualStyleBackColor = true;
            this.btSignUp.Click += new System.EventHandler(this.btSignUp_Click);
            // 
            // rbPosition2
            // 
            this.rbPosition2.AutoSize = true;
            this.rbPosition2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPosition2.ForeColor = System.Drawing.Color.Red;
            this.rbPosition2.Location = new System.Drawing.Point(473, 158);
            this.rbPosition2.Name = "rbPosition2";
            this.rbPosition2.Size = new System.Drawing.Size(125, 29);
            this.rbPosition2.TabIndex = 15;
            this.rbPosition2.TabStop = true;
            this.rbPosition2.Text = "Nhân Viên";
            this.rbPosition2.UseVisualStyleBackColor = true;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.Red;
            this.lbPassword.Location = new System.Drawing.Point(199, 93);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(103, 25);
            this.lbPassword.TabIndex = 10;
            this.lbPassword.Text = "Mật Khẩu:";
            // 
            // rbPosition1
            // 
            this.rbPosition1.AutoSize = true;
            this.rbPosition1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPosition1.ForeColor = System.Drawing.Color.Red;
            this.rbPosition1.Location = new System.Drawing.Point(288, 158);
            this.rbPosition1.Name = "rbPosition1";
            this.rbPosition1.Size = new System.Drawing.Size(89, 29);
            this.rbPosition1.TabIndex = 14;
            this.rbPosition1.TabStop = true;
            this.rbPosition1.Text = "Admin";
            this.rbPosition1.UseVisualStyleBackColor = true;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Red;
            this.lbName.Location = new System.Drawing.Point(145, 40);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(157, 25);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "Tên Đăng Nhập:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(343, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(292, 22);
            this.txtName.TabIndex = 13;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(343, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(292, 22);
            this.txtPassword.TabIndex = 12;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnFill);
            this.Controls.Add(this.pnTop);
            this.Name = "Login";
            this.Text = "Login";
            this.pnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnFill.ResumeLayout(false);
            this.pnFill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnFill;
        private System.Windows.Forms.Label lbNameShop;
        private System.Windows.Forms.Button btSignUp;
        private System.Windows.Forms.RadioButton rbPosition2;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.RadioButton rbPosition1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
    }
}