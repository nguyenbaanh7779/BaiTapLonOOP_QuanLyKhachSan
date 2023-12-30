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
            this.buttonHoaDon = new System.Windows.Forms.Button();
            this.buttonPhong = new System.Windows.Forms.Button();
            this.buttonKhachHang = new System.Windows.Forms.Button();
            this.buttonDonDatPhong = new System.Windows.Forms.Button();
            this.useControlLeTan_DonDatPhong1 = new HeThongQuanLyKhachSan.All_user_control.useControlLeTan_DonDatPhong();
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
            // 
            // useControlLeTan_DonDatPhong1
            // 
            this.useControlLeTan_DonDatPhong1.Location = new System.Drawing.Point(160, 12);
            this.useControlLeTan_DonDatPhong1.Name = "useControlLeTan_DonDatPhong1";
            this.useControlLeTan_DonDatPhong1.Size = new System.Drawing.Size(799, 494);
            this.useControlLeTan_DonDatPhong1.TabIndex = 1;
            // 
            // FormLeTan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 519);
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
    }
}