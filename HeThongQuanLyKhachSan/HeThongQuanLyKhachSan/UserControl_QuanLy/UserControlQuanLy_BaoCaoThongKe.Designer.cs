namespace HeThongQuanLyKhachSan.UserControl_QuanLy
{
    partial class UserControlQuanLy_BaoCaoThongKe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSoDonDatPhong = new System.Windows.Forms.TextBox();
            this.textBoxTongDoanhThu = new System.Windows.Forms.TextBox();
            this.dataGridViewXepHangPhong = new System.Windows.Forms.DataGridView();
            this.dataGridViewXepHangKhachHang = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSoDonBiHuy = new System.Windows.Forms.TextBox();
            this.ColumnMaSoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoDonDatPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoCanCuocCongDan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoLanDatPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXepHangPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXepHangKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDonDatPhong
            // 
            this.labelDonDatPhong.AutoSize = true;
            this.labelDonDatPhong.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDonDatPhong.Location = new System.Drawing.Point(282, 0);
            this.labelDonDatPhong.Name = "labelDonDatPhong";
            this.labelDonDatPhong.Size = new System.Drawing.Size(223, 37);
            this.labelDonDatPhong.TabIndex = 5;
            this.labelDonDatPhong.Text = "Báo cáo thống kê";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đến ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tổng doanh thu:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số đơn đặt phòng:";
            // 
            // textBoxSoDonDatPhong
            // 
            this.textBoxSoDonDatPhong.Enabled = false;
            this.textBoxSoDonDatPhong.Location = new System.Drawing.Point(512, 77);
            this.textBoxSoDonDatPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSoDonDatPhong.Name = "textBoxSoDonDatPhong";
            this.textBoxSoDonDatPhong.Size = new System.Drawing.Size(207, 23);
            this.textBoxSoDonDatPhong.TabIndex = 10;
            // 
            // textBoxTongDoanhThu
            // 
            this.textBoxTongDoanhThu.Enabled = false;
            this.textBoxTongDoanhThu.Location = new System.Drawing.Point(512, 53);
            this.textBoxTongDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTongDoanhThu.Name = "textBoxTongDoanhThu";
            this.textBoxTongDoanhThu.Size = new System.Drawing.Size(207, 23);
            this.textBoxTongDoanhThu.TabIndex = 11;
            // 
            // dataGridViewXepHangPhong
            // 
            this.dataGridViewXepHangPhong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewXepHangPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXepHangPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaSoPhong,
            this.ColumnSoPhong,
            this.ColumnSoDonDatPhong});
            this.dataGridViewXepHangPhong.Location = new System.Drawing.Point(15, 174);
            this.dataGridViewXepHangPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewXepHangPhong.Name = "dataGridViewXepHangPhong";
            this.dataGridViewXepHangPhong.RowHeadersWidth = 51;
            this.dataGridViewXepHangPhong.RowTemplate.Height = 29;
            this.dataGridViewXepHangPhong.Size = new System.Drawing.Size(377, 302);
            this.dataGridViewXepHangPhong.TabIndex = 12;
            // 
            // dataGridViewXepHangKhachHang
            // 
            this.dataGridViewXepHangKhachHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewXepHangKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXepHangKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTenKhachHang,
            this.ColumnSoCanCuocCongDan,
            this.ColumnSoLanDatPhong});
            this.dataGridViewXepHangKhachHang.Location = new System.Drawing.Point(405, 174);
            this.dataGridViewXepHangKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewXepHangKhachHang.Name = "dataGridViewXepHangKhachHang";
            this.dataGridViewXepHangKhachHang.RowHeadersWidth = 51;
            this.dataGridViewXepHangKhachHang.RowTemplate.Height = 29;
            this.dataGridViewXepHangKhachHang.Size = new System.Drawing.Size(377, 302);
            this.dataGridViewXepHangKhachHang.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(15, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(349, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Xếp hạng phòng theo số đơn đặt phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(405, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(385, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Xếp hạng khách hàng theo số lần đặt phòng";
            // 
            // dateTimePickerNgayBatDau
            // 
            this.dateTimePickerNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayBatDau.Location = new System.Drawing.Point(77, 52);
            this.dateTimePickerNgayBatDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerNgayBatDau.Name = "dateTimePickerNgayBatDau";
            this.dateTimePickerNgayBatDau.Size = new System.Drawing.Size(112, 23);
            this.dateTimePickerNgayBatDau.TabIndex = 17;
            // 
            // dateTimePickerNgayKetThuc
            // 
            this.dateTimePickerNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayKetThuc.Location = new System.Drawing.Point(265, 53);
            this.dateTimePickerNgayKetThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerNgayKetThuc.Name = "dateTimePickerNgayKetThuc";
            this.dateTimePickerNgayKetThuc.Size = new System.Drawing.Size(118, 23);
            this.dateTimePickerNgayKetThuc.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 80);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Số đơn bị hủy:";
            // 
            // textBoxSoDonBiHuy
            // 
            this.textBoxSoDonBiHuy.Enabled = false;
            this.textBoxSoDonBiHuy.Location = new System.Drawing.Point(512, 100);
            this.textBoxSoDonBiHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSoDonBiHuy.Name = "textBoxSoDonBiHuy";
            this.textBoxSoDonBiHuy.Size = new System.Drawing.Size(207, 23);
            this.textBoxSoDonBiHuy.TabIndex = 21;
            // 
            // ColumnMaSoPhong
            // 
            this.ColumnMaSoPhong.DataPropertyName = "ID_Phong";
            this.ColumnMaSoPhong.HeaderText = "Mã số phòng";
            this.ColumnMaSoPhong.MinimumWidth = 6;
            this.ColumnMaSoPhong.Name = "ColumnMaSoPhong";
            // 
            // ColumnSoPhong
            // 
            this.ColumnSoPhong.DataPropertyName = "So_phong";
            this.ColumnSoPhong.HeaderText = "Số phòng";
            this.ColumnSoPhong.MinimumWidth = 6;
            this.ColumnSoPhong.Name = "ColumnSoPhong";
            this.ColumnSoPhong.Width = 120;
            // 
            // ColumnSoDonDatPhong
            // 
            this.ColumnSoDonDatPhong.DataPropertyName = "So_don_dat_phong";
            this.ColumnSoDonDatPhong.HeaderText = "Số đơn đặt phòng";
            this.ColumnSoDonDatPhong.MinimumWidth = 6;
            this.ColumnSoDonDatPhong.Name = "ColumnSoDonDatPhong";
            // 
            // ColumnTenKhachHang
            // 
            this.ColumnTenKhachHang.DataPropertyName = "Ho_ten";
            this.ColumnTenKhachHang.HeaderText = "Tên khách hàng";
            this.ColumnTenKhachHang.MinimumWidth = 6;
            this.ColumnTenKhachHang.Name = "ColumnTenKhachHang";
            // 
            // ColumnSoCanCuocCongDan
            // 
            this.ColumnSoCanCuocCongDan.DataPropertyName = "So_can_cuoc_cong_dan";
            this.ColumnSoCanCuocCongDan.HeaderText = "Số căn cước công dân";
            this.ColumnSoCanCuocCongDan.MinimumWidth = 6;
            this.ColumnSoCanCuocCongDan.Name = "ColumnSoCanCuocCongDan";
            this.ColumnSoCanCuocCongDan.Width = 120;
            // 
            // ColumnSoLanDatPhong
            // 
            this.ColumnSoLanDatPhong.DataPropertyName = "So_lan_dat_phong";
            this.ColumnSoLanDatPhong.HeaderText = "Số lần đặt phòng";
            this.ColumnSoLanDatPhong.MinimumWidth = 6;
            this.ColumnSoLanDatPhong.Name = "ColumnSoLanDatPhong";
            // 
            // UserControlQuanLy_BaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxSoDonBiHuy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerNgayKetThuc);
            this.Controls.Add(this.dateTimePickerNgayBatDau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewXepHangKhachHang);
            this.Controls.Add(this.dataGridViewXepHangPhong);
            this.Controls.Add(this.textBoxTongDoanhThu);
            this.Controls.Add(this.textBoxSoDonDatPhong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDonDatPhong);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlQuanLy_BaoCaoThongKe";
            this.Size = new System.Drawing.Size(799, 494);
            this.Load += new System.EventHandler(this.UserControlQuanLy_BaoCaoThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXepHangPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXepHangKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelDonDatPhong;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxSoDonDatPhong;
        private TextBox textBoxTongDoanhThu;
        private DataGridView dataGridViewXepHangPhong;
        private DataGridView dataGridViewXepHangKhachHang;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePickerNgayBatDau;
        private DateTimePicker dateTimePickerNgayKetThuc;
        private Button button1;
        private Label label7;
        private TextBox textBoxSoDonBiHuy;
        private DataGridViewTextBoxColumn ColumnMaSoPhong;
        private DataGridViewTextBoxColumn ColumnSoPhong;
        private DataGridViewTextBoxColumn ColumnSoDonDatPhong;
        private DataGridViewTextBoxColumn ColumnTenKhachHang;
        private DataGridViewTextBoxColumn ColumnSoCanCuocCongDan;
        private DataGridViewTextBoxColumn ColumnSoLanDatPhong;
    }
}
