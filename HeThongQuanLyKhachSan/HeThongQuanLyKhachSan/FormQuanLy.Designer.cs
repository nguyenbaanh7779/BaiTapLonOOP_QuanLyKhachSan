namespace HeThongQuanLyKhachSan
{
    partial class FormQuanLy
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
            this.buttonKhachHang = new System.Windows.Forms.Button();
            this.buttonDonDatPhong = new System.Windows.Forms.Button();
            this.userControlQuanLy_NhanVien = new HeThongQuanLyKhachSan.UserControl_QuanLy.UserControlQuanLy_NhanVien();
            this.userControlQuanLy_themNhanVien = new HeThongQuanLyKhachSan.UserControl_QuanLy.UserControlQuanLy_themNhanVien();
            this.buttonNhanVien_Them = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonKhachHang);
            this.panel1.Controls.Add(this.buttonDonDatPhong);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 497);
            this.panel1.TabIndex = 1;
            // 
            // buttonKhachHang
            // 
            this.buttonKhachHang.Location = new System.Drawing.Point(3, 114);
            this.buttonKhachHang.Name = "buttonKhachHang";
            this.buttonKhachHang.Size = new System.Drawing.Size(135, 36);
            this.buttonKhachHang.TabIndex = 1;
            this.buttonKhachHang.Text = "Phòng";
            this.buttonKhachHang.UseVisualStyleBackColor = true;
            // 
            // buttonDonDatPhong
            // 
            this.buttonDonDatPhong.Location = new System.Drawing.Point(3, 72);
            this.buttonDonDatPhong.Name = "buttonDonDatPhong";
            this.buttonDonDatPhong.Size = new System.Drawing.Size(135, 36);
            this.buttonDonDatPhong.TabIndex = 0;
            this.buttonDonDatPhong.Text = "Nhân viên";
            this.buttonDonDatPhong.UseVisualStyleBackColor = true;
            this.buttonDonDatPhong.Click += new System.EventHandler(this.buttonDonDatPhong_Click);
            // 
            // userControlQuanLy_NhanVien
            // 
            this.userControlQuanLy_NhanVien.Location = new System.Drawing.Point(159, 12);
            this.userControlQuanLy_NhanVien.Name = "userControlQuanLy_NhanVien";
            this.userControlQuanLy_NhanVien.Size = new System.Drawing.Size(799, 497);
            this.userControlQuanLy_NhanVien.TabIndex = 2;
            this.userControlQuanLy_NhanVien.Visible = false;
            // 
            // userControlQuanLy_themNhanVien
            // 
            this.userControlQuanLy_themNhanVien.Location = new System.Drawing.Point(159, 15);
            this.userControlQuanLy_themNhanVien.Name = "userControlQuanLy_themNhanVien";
            this.userControlQuanLy_themNhanVien.Size = new System.Drawing.Size(799, 497);
            this.userControlQuanLy_themNhanVien.TabIndex = 3;
            this.userControlQuanLy_themNhanVien.Visible = false;
            // 
            // buttonNhanVien_Them
            // 
            this.buttonNhanVien_Them.Location = new System.Drawing.Point(830, 65);
            this.buttonNhanVien_Them.Name = "buttonNhanVien_Them";
            this.buttonNhanVien_Them.Size = new System.Drawing.Size(94, 28);
            this.buttonNhanVien_Them.TabIndex = 4;
            this.buttonNhanVien_Them.Text = "Thêm";
            this.buttonNhanVien_Them.UseVisualStyleBackColor = true;
            this.buttonNhanVien_Them.Visible = false;
            this.buttonNhanVien_Them.Click += new System.EventHandler(this.buttonDonDatPhong_NhanPhong_Click);
            // 
            // FormQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 519);
            this.Controls.Add(this.buttonNhanVien_Them);
            this.Controls.Add(this.userControlQuanLy_themNhanVien);
            this.Controls.Add(this.userControlQuanLy_NhanVien);
            this.Controls.Add(this.panel1);
            this.Name = "FormQuanLy";
            this.Text = "FormQuanLy";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonKhachHang;
        private Button buttonDonDatPhong;
        private UserControl_QuanLy.UserControlQuanLy_NhanVien userControlQuanLy_NhanVien;
        private UserControl_QuanLy.UserControlQuanLy_themNhanVien userControlQuanLy_themNhanVien;
        private UserControl_QuanLy.UserControlQuanLy_NhanVien userControlQuanLy_NhanVien1;
        private Button buttonNhanVien_Them;
    }
}