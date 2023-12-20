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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHoaDon);
            this.panel1.Controls.Add(this.buttonPhong);
            this.panel1.Controls.Add(this.buttonKhachHang);
            this.panel1.Controls.Add(this.buttonDonDatPhong);
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 671);
            this.panel1.TabIndex = 0;
            // 
            // buttonHoaDon
            // 
            this.buttonHoaDon.Location = new System.Drawing.Point(3, 172);
            this.buttonHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonHoaDon.Name = "buttonHoaDon";
            this.buttonHoaDon.Size = new System.Drawing.Size(154, 48);
            this.buttonHoaDon.TabIndex = 3;
            this.buttonHoaDon.Text = "Hóa đơn";
            this.buttonHoaDon.UseVisualStyleBackColor = true;
            this.buttonHoaDon.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonPhong
            // 
            this.buttonPhong.Location = new System.Drawing.Point(3, 116);
            this.buttonPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPhong.Name = "buttonPhong";
            this.buttonPhong.Size = new System.Drawing.Size(154, 48);
            this.buttonPhong.TabIndex = 2;
            this.buttonPhong.Text = "Phòng";
            this.buttonPhong.UseVisualStyleBackColor = true;
            // 
            // buttonKhachHang
            // 
            this.buttonKhachHang.Location = new System.Drawing.Point(3, 60);
            this.buttonKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonKhachHang.Name = "buttonKhachHang";
            this.buttonKhachHang.Size = new System.Drawing.Size(154, 48);
            this.buttonKhachHang.TabIndex = 1;
            this.buttonKhachHang.Text = "Khách hàng";
            this.buttonKhachHang.UseVisualStyleBackColor = true;
            // 
            // buttonDonDatPhong
            // 
            this.buttonDonDatPhong.Location = new System.Drawing.Point(3, 4);
            this.buttonDonDatPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDonDatPhong.Name = "buttonDonDatPhong";
            this.buttonDonDatPhong.Size = new System.Drawing.Size(154, 48);
            this.buttonDonDatPhong.TabIndex = 0;
            this.buttonDonDatPhong.Text = "Đơn đặt phòng";
            this.buttonDonDatPhong.UseVisualStyleBackColor = true;
            this.buttonDonDatPhong.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControlDonDatPhong1
            // 
            this.userControlDonDatPhong1.Location = new System.Drawing.Point(181, 20);
            this.userControlDonDatPhong1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.userControlDonDatPhong1.Name = "userControlDonDatPhong1";
            this.userControlDonDatPhong1.Size = new System.Drawing.Size(916, 658);
            this.userControlDonDatPhong1.TabIndex = 0;
            this.userControlDonDatPhong1.Visible = false;
            // 
            // FormLeTan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 692);
            this.Controls.Add(this.userControlDonDatPhong1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    }
}