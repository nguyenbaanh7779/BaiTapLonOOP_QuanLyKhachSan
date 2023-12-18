namespace HeThongQuanLyKhachSan
{
    partial class Form1
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
            this.buttonPhong = new System.Windows.Forms.Button();
            this.buttonHoaDon = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(200, 407);
            this.panel1.TabIndex = 0;
            // 
            // buttonKhachHang
            // 
            this.buttonKhachHang.Location = new System.Drawing.Point(28, 58);
            this.buttonKhachHang.Name = "buttonKhachHang";
            this.buttonKhachHang.Size = new System.Drawing.Size(135, 36);
            this.buttonKhachHang.TabIndex = 1;
            this.buttonKhachHang.Text = "Khách hàng";
            this.buttonKhachHang.UseVisualStyleBackColor = true;
            // 
            // buttonDonDatPhong
            // 
            this.buttonDonDatPhong.Location = new System.Drawing.Point(28, 16);
            this.buttonDonDatPhong.Name = "buttonDonDatPhong";
            this.buttonDonDatPhong.Size = new System.Drawing.Size(135, 36);
            this.buttonDonDatPhong.TabIndex = 0;
            this.buttonDonDatPhong.Text = "Đơn đặt phòng";
            this.buttonDonDatPhong.UseVisualStyleBackColor = true;
            this.buttonDonDatPhong.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPhong
            // 
            this.buttonPhong.Location = new System.Drawing.Point(28, 100);
            this.buttonPhong.Name = "buttonPhong";
            this.buttonPhong.Size = new System.Drawing.Size(135, 36);
            this.buttonPhong.TabIndex = 2;
            this.buttonPhong.Text = "Phòng";
            this.buttonPhong.UseVisualStyleBackColor = true;
            // 
            // buttonHoaDon
            // 
            this.buttonHoaDon.Location = new System.Drawing.Point(28, 142);
            this.buttonHoaDon.Name = "buttonHoaDon";
            this.buttonHoaDon.Size = new System.Drawing.Size(135, 36);
            this.buttonHoaDon.TabIndex = 3;
            this.buttonHoaDon.Text = "Hóa đơn";
            this.buttonHoaDon.UseVisualStyleBackColor = true;
            this.buttonHoaDon.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 454);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
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
    }
}