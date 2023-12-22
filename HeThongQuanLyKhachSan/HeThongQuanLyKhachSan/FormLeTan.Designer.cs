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
            this.userControlDonDatPhong1 = new HeThongQuanLyKhachSan.All_user_control.useControlDonDatPhong();
            this.useControlPhong = new HeThongQuanLyKhachSan.All_user_control.useControlPhong();
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
            this.panel1.Size = new System.Drawing.Size(141, 497);
            this.panel1.TabIndex = 0;
            // 
            // buttonHoaDon
            // 
            this.buttonHoaDon.Location = new System.Drawing.Point(3, 129);
            this.buttonHoaDon.Name = "buttonHoaDon";
            this.buttonHoaDon.Size = new System.Drawing.Size(135, 36);
            this.buttonHoaDon.TabIndex = 3;
            this.buttonHoaDon.Text = "Hóa đơn";
            this.buttonHoaDon.UseVisualStyleBackColor = true;
            this.buttonHoaDon.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonPhong
            // 
            this.buttonPhong.Location = new System.Drawing.Point(3, 87);
            this.buttonPhong.Name = "buttonPhong";
            this.buttonPhong.Size = new System.Drawing.Size(135, 36);
            this.buttonPhong.TabIndex = 2;
            this.buttonPhong.Text = "Phòng";
            this.buttonPhong.UseVisualStyleBackColor = true;
            this.buttonPhong.Click += new System.EventHandler(this.buttonPhong_Click);
            // 
            // buttonKhachHang
            // 
            this.buttonKhachHang.Location = new System.Drawing.Point(3, 45);
            this.buttonKhachHang.Name = "buttonKhachHang";
            this.buttonKhachHang.Size = new System.Drawing.Size(135, 36);
            this.buttonKhachHang.TabIndex = 1;
            this.buttonKhachHang.Text = "Khách hàng";
            this.buttonKhachHang.UseVisualStyleBackColor = true;
            // 
            // buttonDonDatPhong
            // 
            this.buttonDonDatPhong.Location = new System.Drawing.Point(3, 3);
            this.buttonDonDatPhong.Name = "buttonDonDatPhong";
            this.buttonDonDatPhong.Size = new System.Drawing.Size(135, 36);
            this.buttonDonDatPhong.TabIndex = 0;
            this.buttonDonDatPhong.Text = "Đơn đặt phòng";
            this.buttonDonDatPhong.UseVisualStyleBackColor = true;
            this.buttonDonDatPhong.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControlDonDatPhong1
            // 
            this.userControlDonDatPhong1.Location = new System.Drawing.Point(159, 15);
            this.userControlDonDatPhong1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControlDonDatPhong1.Name = "userControlDonDatPhong1";
            this.userControlDonDatPhong1.Size = new System.Drawing.Size(802, 494);
            this.userControlDonDatPhong1.TabIndex = 0;
            this.userControlDonDatPhong1.Visible = false;
            // 
            // useControlPhong
            // 
            this.useControlPhong.Location = new System.Drawing.Point(159, 15);
            this.useControlPhong.Name = "useControlPhong";
            this.useControlPhong.Size = new System.Drawing.Size(799, 494);
            this.useControlPhong.TabIndex = 1;
            this.useControlPhong.Visible = false;
            this.useControlPhong.Load += new System.EventHandler(this.useControlPhong_Load);
            // 
            // FormLeTan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 519);
            this.Controls.Add(this.useControlPhong);
            this.Controls.Add(this.userControlDonDatPhong1);
            this.Controls.Add(this.panel1);
            this.Name = "FormLeTan";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonDonDatPhong;
        private Button buttonKhachHang;
        private Button buttonHoaDon;
        private Button buttonPhong;
        private All_user_control.useControlDonDatPhong userControlDonDatPhong1;
        //private All_user_control.useControlPhong useControlPhong1;
        private All_user_control.useControlPhong useControlPhong;
    }
}