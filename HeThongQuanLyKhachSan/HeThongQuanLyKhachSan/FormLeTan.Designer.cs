namespace HeThongQuanLyKhachSan
{
    partial class FormLeTan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTaiKhoan = new System.Windows.Forms.Label();
            this.buttonDangXuat = new System.Windows.Forms.Button();
            this.buttonThongTinCaNhan = new System.Windows.Forms.Button();
            this.buttonDatPhong = new System.Windows.Forms.Button();
            this.buttonDonDatPhong = new System.Windows.Forms.Button();
            this.useControlLeTan_DonDatPhong1 = new HeThongQuanLyKhachSan.All_user_control.useControlLeTan_DonDatPhong();
            this.useControlLeTan_DatPhong1 = new HeThongQuanLyKhachSan.All_user_control.useControlLeTan_DatPhong();
            this.userControlLeTan_ThongTinCaNhan1 = new HeThongQuanLyKhachSan.UseControl_LeTan.UserControlLeTan_ThongTinCaNhan();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTaiKhoan);
            this.panel1.Controls.Add(this.buttonDangXuat);
            this.panel1.Controls.Add(this.buttonThongTinCaNhan);
            this.panel1.Controls.Add(this.buttonDatPhong);
            this.panel1.Controls.Add(this.buttonDonDatPhong);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 494);
            this.panel1.TabIndex = 0;
            // 
            // labelTaiKhoan
            // 
            this.labelTaiKhoan.AutoSize = true;
            this.labelTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTaiKhoan.Location = new System.Drawing.Point(4, 15);
            this.labelTaiKhoan.Name = "labelTaiKhoan";
            this.labelTaiKhoan.Size = new System.Drawing.Size(75, 21);
            this.labelTaiKhoan.TabIndex = 16;
            this.labelTaiKhoan.Text = "Tài khoản";
            // 
            // buttonDangXuat
            // 
            this.buttonDangXuat.Location = new System.Drawing.Point(25, 454);
            this.buttonDangXuat.Name = "buttonDangXuat";
            this.buttonDangXuat.Size = new System.Drawing.Size(84, 25);
            this.buttonDangXuat.TabIndex = 15;
            this.buttonDangXuat.Text = "Đăng xuất";
            this.buttonDangXuat.UseVisualStyleBackColor = true;
            this.buttonDangXuat.Click += new System.EventHandler(this.buttonDangXuat_Click);
            // 
            // buttonThongTinCaNhan
            // 
            this.buttonThongTinCaNhan.Location = new System.Drawing.Point(3, 50);
            this.buttonThongTinCaNhan.Name = "buttonThongTinCaNhan";
            this.buttonThongTinCaNhan.Size = new System.Drawing.Size(135, 36);
            this.buttonThongTinCaNhan.TabIndex = 14;
            this.buttonThongTinCaNhan.Text = "Thông tin cá nhân";
            this.buttonThongTinCaNhan.UseVisualStyleBackColor = true;
            this.buttonThongTinCaNhan.Click += new System.EventHandler(this.buttonThongTinCaNhan_Click);
            // 
            // buttonDatPhong
            // 
            this.buttonDatPhong.Location = new System.Drawing.Point(4, 134);
            this.buttonDatPhong.Name = "buttonDatPhong";
            this.buttonDatPhong.Size = new System.Drawing.Size(135, 36);
            this.buttonDatPhong.TabIndex = 2;
            this.buttonDatPhong.Text = "Đặt phòng";
            this.buttonDatPhong.UseVisualStyleBackColor = true;
            this.buttonDatPhong.Click += new System.EventHandler(this.buttonDatPhong_Click);
            // 
            // buttonDonDatPhong
            // 
            this.buttonDonDatPhong.Location = new System.Drawing.Point(4, 92);
            this.buttonDonDatPhong.Name = "buttonDonDatPhong";
            this.buttonDonDatPhong.Size = new System.Drawing.Size(135, 36);
            this.buttonDonDatPhong.TabIndex = 0;
            this.buttonDonDatPhong.Text = "Đơn đặt phòng";
            this.buttonDonDatPhong.UseVisualStyleBackColor = true;
            this.buttonDonDatPhong.Click += new System.EventHandler(this.buttonDonDatPhong_Click);
            // 
            // useControlLeTan_DonDatPhong1
            // 
            this.useControlLeTan_DonDatPhong1.Location = new System.Drawing.Point(160, 12);
            this.useControlLeTan_DonDatPhong1.Name = "useControlLeTan_DonDatPhong1";
            this.useControlLeTan_DonDatPhong1.Size = new System.Drawing.Size(799, 494);
            this.useControlLeTan_DonDatPhong1.TabIndex = 1;
            this.useControlLeTan_DonDatPhong1.Visible = false;
            // 
            // useControlLeTan_DatPhong1
            // 
            this.useControlLeTan_DatPhong1.Location = new System.Drawing.Point(160, 12);
            this.useControlLeTan_DatPhong1.Name = "useControlLeTan_DatPhong1";
            this.useControlLeTan_DatPhong1.Size = new System.Drawing.Size(799, 494);
            this.useControlLeTan_DatPhong1.TabIndex = 12;
            this.useControlLeTan_DatPhong1.Visible = false;
            // 
            // userControlLeTan_ThongTinCaNhan1
            // 
            this.userControlLeTan_ThongTinCaNhan1.Location = new System.Drawing.Point(159, 12);
            this.userControlLeTan_ThongTinCaNhan1.Name = "userControlLeTan_ThongTinCaNhan1";
            this.userControlLeTan_ThongTinCaNhan1.Size = new System.Drawing.Size(799, 494);
            this.userControlLeTan_ThongTinCaNhan1.TabIndex = 13;
            this.userControlLeTan_ThongTinCaNhan1.Visible = false;
            // 
            // FormLeTan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 519);
            this.Controls.Add(this.userControlLeTan_ThongTinCaNhan1);
            this.Controls.Add(this.useControlLeTan_DatPhong1);
            this.Controls.Add(this.useControlLeTan_DonDatPhong1);
            this.Controls.Add(this.panel1);
            this.Name = "FormLeTan";
            this.Text = "Lễ Tân";
            this.Load += new System.EventHandler(this.FormLeTan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonDonDatPhong;
        private Button buttonDatPhong;
        private Button buttonThongTinCaNhan;
        private All_user_control.useControlLeTan_DonDatPhong useControlLeTan_DonDatPhong1;
        private All_user_control.useControlLeTan_DatPhong useControlLeTan_DatPhong1;
        private UseControl_LeTan.UserControlLeTan_ThongTinCaNhan userControlLeTan_ThongTinCaNhan1;
        private Button buttonDangXuat;
        private Label labelTaiKhoan;
    }
}