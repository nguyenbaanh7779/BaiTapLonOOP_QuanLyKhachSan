﻿namespace HeThongQuanLyKhachSan
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
            this.buttonHoaDon = new System.Windows.Forms.Button();
            this.buttonPhong = new System.Windows.Forms.Button();
            this.buttonKhachHang = new System.Windows.Forms.Button();
            this.buttonDonDatPhong = new System.Windows.Forms.Button();
            this.useControlLeTan_DonDatPhong1 = new HeThongQuanLyKhachSan.All_user_control.useControlLeTan_DonDatPhong();
            this.buttonDonDatPhong_NhanPhong = new System.Windows.Forms.Button();
            this.buttonDonDatPhong_TraPhong = new System.Windows.Forms.Button();
            this.userControlLeTan_ChiTietDonDatPhong1 = new HeThongQuanLyKhachSan.UseControl_LeTan.UserControlLeTan_ChiTietDonDatPhong();
            this.buttonChiTietDonDatPhong_QuayLai = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHoaDon);
            this.panel1.Controls.Add(this.buttonPhong);
            this.panel1.Controls.Add(this.buttonKhachHang);
            this.panel1.Controls.Add(this.buttonDonDatPhong);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 494);
            this.panel1.TabIndex = 0;
            // 
            // buttonHoaDon
            // 
            this.buttonHoaDon.Location = new System.Drawing.Point(3, 189);
            this.buttonHoaDon.Name = "buttonHoaDon";
            this.buttonHoaDon.Size = new System.Drawing.Size(135, 36);
            this.buttonHoaDon.TabIndex = 3;
            this.buttonHoaDon.Text = "Hóa đơn";
            this.buttonHoaDon.UseVisualStyleBackColor = true;
            // 
            // buttonPhong
            // 
            this.buttonPhong.Location = new System.Drawing.Point(3, 147);
            this.buttonPhong.Name = "buttonPhong";
            this.buttonPhong.Size = new System.Drawing.Size(135, 36);
            this.buttonPhong.TabIndex = 2;
            this.buttonPhong.Text = "Đặt phòng";
            this.buttonPhong.UseVisualStyleBackColor = true;
            // 
            // buttonKhachHang
            // 
            this.buttonKhachHang.Location = new System.Drawing.Point(3, 105);
            this.buttonKhachHang.Name = "buttonKhachHang";
            this.buttonKhachHang.Size = new System.Drawing.Size(135, 36);
            this.buttonKhachHang.TabIndex = 1;
            this.buttonKhachHang.Text = "Khách hàng";
            this.buttonKhachHang.UseVisualStyleBackColor = true;
            // 
            // buttonDonDatPhong
            // 
            this.buttonDonDatPhong.Location = new System.Drawing.Point(3, 63);
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
            // buttonDonDatPhong_NhanPhong
            // 
            this.buttonDonDatPhong_NhanPhong.Location = new System.Drawing.Point(452, 456);
            this.buttonDonDatPhong_NhanPhong.Name = "buttonDonDatPhong_NhanPhong";
            this.buttonDonDatPhong_NhanPhong.Size = new System.Drawing.Size(94, 29);
            this.buttonDonDatPhong_NhanPhong.TabIndex = 4;
            this.buttonDonDatPhong_NhanPhong.Text = "Nhận phòng";
            this.buttonDonDatPhong_NhanPhong.UseVisualStyleBackColor = true;
            this.buttonDonDatPhong_NhanPhong.Visible = false;
            this.buttonDonDatPhong_NhanPhong.Click += new System.EventHandler(this.buttonDonDatPhong_NhanPhong_Click);
            // 
            // buttonDonDatPhong_TraPhong
            // 
            this.buttonDonDatPhong_TraPhong.Location = new System.Drawing.Point(552, 456);
            this.buttonDonDatPhong_TraPhong.Name = "buttonDonDatPhong_TraPhong";
            this.buttonDonDatPhong_TraPhong.Size = new System.Drawing.Size(94, 29);
            this.buttonDonDatPhong_TraPhong.TabIndex = 5;
            this.buttonDonDatPhong_TraPhong.Text = "Trả phòng";
            this.buttonDonDatPhong_TraPhong.UseVisualStyleBackColor = true;
            this.buttonDonDatPhong_TraPhong.Visible = false;
            this.buttonDonDatPhong_TraPhong.Click += new System.EventHandler(this.buttonDonDatPhong_TraPhong_Click);
            // 
            // userControlLeTan_ChiTietDonDatPhong1
            // 
            this.userControlLeTan_ChiTietDonDatPhong1.Location = new System.Drawing.Point(160, 12);
            this.userControlLeTan_ChiTietDonDatPhong1.Name = "userControlLeTan_ChiTietDonDatPhong1";
            this.userControlLeTan_ChiTietDonDatPhong1.Size = new System.Drawing.Size(799, 494);
            this.userControlLeTan_ChiTietDonDatPhong1.TabIndex = 6;
            this.userControlLeTan_ChiTietDonDatPhong1.Visible = false;
            // 
            // buttonChiTietDonDatPhong_QuayLai
            // 
            this.buttonChiTietDonDatPhong_QuayLai.Location = new System.Drawing.Point(862, 12);
            this.buttonChiTietDonDatPhong_QuayLai.Name = "buttonChiTietDonDatPhong_QuayLai";
            this.buttonChiTietDonDatPhong_QuayLai.Size = new System.Drawing.Size(96, 29);
            this.buttonChiTietDonDatPhong_QuayLai.TabIndex = 9;
            this.buttonChiTietDonDatPhong_QuayLai.Text = "Quay lại";
            this.buttonChiTietDonDatPhong_QuayLai.UseVisualStyleBackColor = true;
            this.buttonChiTietDonDatPhong_QuayLai.Visible = false;
            this.buttonChiTietDonDatPhong_QuayLai.Click += new System.EventHandler(this.buttonChiTietDonDatPhong_QuayLai_Click);
            // 
            // FormLeTan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 519);
            this.Controls.Add(this.buttonChiTietDonDatPhong_QuayLai);
            this.Controls.Add(this.userControlLeTan_ChiTietDonDatPhong1);
            this.Controls.Add(this.buttonDonDatPhong_TraPhong);
            this.Controls.Add(this.buttonDonDatPhong_NhanPhong);
            this.Controls.Add(this.useControlLeTan_DonDatPhong1);
            this.Controls.Add(this.panel1);
            this.Name = "FormLeTan";
            this.Text = "Lễ Tân";
            this.Load += new System.EventHandler(this.FormLeTan_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonDonDatPhong;
        private Button buttonKhachHang;
        private Button buttonHoaDon;
        private Button buttonPhong;
        private All_user_control.useControlLeTan_DonDatPhong useControlLeTan_DonDatPhong1;
        private Button buttonDonDatPhong_NhanPhong;
        private Button buttonDonDatPhong_TraPhong;
        private UseControl_LeTan.UserControlLeTan_ChiTietDonDatPhong userControlLeTan_ChiTietDonDatPhong1;
        private Button buttonChiTietDonDatPhong_QuayLai;
    }
}