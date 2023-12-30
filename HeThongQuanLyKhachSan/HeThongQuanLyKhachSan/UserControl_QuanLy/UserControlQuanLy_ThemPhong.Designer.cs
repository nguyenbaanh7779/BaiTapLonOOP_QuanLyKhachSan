namespace HeThongQuanLyKhachSan.UserControl_QuanLy
{
    partial class UserControlQuanLy_ThemPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDonDatPhong = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxThemPhong_SoGiuong = new System.Windows.Forms.ComboBox();
            this.textBoxThemPhong_DonGia = new System.Windows.Forms.TextBox();
            this.buttonPhongTimKiem = new System.Windows.Forms.Button();
            this.comboBoxThemPhong_LoaiPhong = new System.Windows.Forms.ComboBox();
            this.textBoxThemPhong_SoPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDonDatPhong
            // 
            this.labelDonDatPhong.AutoSize = true;
            this.labelDonDatPhong.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDonDatPhong.Location = new System.Drawing.Point(313, 0);
            this.labelDonDatPhong.Name = "labelDonDatPhong";
            this.labelDonDatPhong.Size = new System.Drawing.Size(168, 37);
            this.labelDonDatPhong.TabIndex = 27;
            this.labelDonDatPhong.Text = "Thêm phòng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBoxThemPhong_SoGiuong);
            this.panel2.Controls.Add(this.textBoxThemPhong_DonGia);
            this.panel2.Controls.Add(this.buttonPhongTimKiem);
            this.panel2.Controls.Add(this.comboBoxThemPhong_LoaiPhong);
            this.panel2.Controls.Add(this.textBoxThemPhong_SoPhong);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(296, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 322);
            this.panel2.TabIndex = 28;
            // 
            // comboBoxThemPhong_SoGiuong
            // 
            this.comboBoxThemPhong_SoGiuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThemPhong_SoGiuong.FormattingEnabled = true;
            this.comboBoxThemPhong_SoGiuong.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxThemPhong_SoGiuong.Location = new System.Drawing.Point(8, 94);
            this.comboBoxThemPhong_SoGiuong.Name = "comboBoxThemPhong_SoGiuong";
            this.comboBoxThemPhong_SoGiuong.Size = new System.Drawing.Size(176, 23);
            this.comboBoxThemPhong_SoGiuong.TabIndex = 11;
            // 
            // textBoxThemPhong_DonGia
            // 
            this.textBoxThemPhong_DonGia.Location = new System.Drawing.Point(8, 225);
            this.textBoxThemPhong_DonGia.Name = "textBoxThemPhong_DonGia";
            this.textBoxThemPhong_DonGia.Size = new System.Drawing.Size(176, 23);
            this.textBoxThemPhong_DonGia.TabIndex = 10;
            // 
            // buttonPhongTimKiem
            // 
            this.buttonPhongTimKiem.Location = new System.Drawing.Point(8, 280);
            this.buttonPhongTimKiem.Name = "buttonPhongTimKiem";
            this.buttonPhongTimKiem.Size = new System.Drawing.Size(87, 30);
            this.buttonPhongTimKiem.TabIndex = 3;
            this.buttonPhongTimKiem.Text = "Thêm";
            this.buttonPhongTimKiem.UseVisualStyleBackColor = true;
            this.buttonPhongTimKiem.Click += new System.EventHandler(this.buttonPhongTimKiem_Click_1);
            // 
            // comboBoxThemPhong_LoaiPhong
            // 
            this.comboBoxThemPhong_LoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThemPhong_LoaiPhong.FormattingEnabled = true;
            this.comboBoxThemPhong_LoaiPhong.Items.AddRange(new object[] {
            "Thường",
            "Cao cấp"});
            this.comboBoxThemPhong_LoaiPhong.Location = new System.Drawing.Point(8, 161);
            this.comboBoxThemPhong_LoaiPhong.Name = "comboBoxThemPhong_LoaiPhong";
            this.comboBoxThemPhong_LoaiPhong.Size = new System.Drawing.Size(176, 23);
            this.comboBoxThemPhong_LoaiPhong.TabIndex = 6;
            // 
            // textBoxThemPhong_SoPhong
            // 
            this.textBoxThemPhong_SoPhong.Location = new System.Drawing.Point(8, 28);
            this.textBoxThemPhong_SoPhong.Name = "textBoxThemPhong_SoPhong";
            this.textBoxThemPhong_SoPhong.Size = new System.Drawing.Size(176, 23);
            this.textBoxThemPhong_SoPhong.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số giường";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số phòng";
            // 
            // UserControlQuanLy_ThemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelDonDatPhong);
            this.Name = "UserControlQuanLy_ThemPhong";
            this.Size = new System.Drawing.Size(799, 494);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelDonDatPhong;
        private Panel panel2;
        private ComboBox comboBoxThemPhong_SoGiuong;
        private TextBox textBoxThemPhong_DonGia;
        private Button buttonPhongTimKiem;
        private ComboBox comboBoxThemPhong_LoaiPhong;
        private TextBox textBoxThemPhong_SoPhong;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
