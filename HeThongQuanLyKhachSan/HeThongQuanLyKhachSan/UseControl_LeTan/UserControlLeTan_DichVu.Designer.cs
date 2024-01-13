namespace HeThongQuanLyKhachSan.UseControl_LeTan
{
    partial class UserControlLeTan_DichVu
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
            this.labelDatPhong_ClickVaoPhongMuonDat = new System.Windows.Forms.Label();
            this.panelDatPhong_ThongTinKhachHang = new System.Windows.Forms.Panel();
            this.buttonThanhToan = new System.Windows.Forms.Button();
            this.textBoxSoDienThoai = new System.Windows.Forms.TextBox();
            this.labelDatPhong_SDT = new System.Windows.Forms.Label();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.textBoxSoCanCuocCongDan = new System.Windows.Forms.TextBox();
            this.labelDatPhong_HoTen = new System.Windows.Forms.Label();
            this.labelDatPhong_SoCCCD = new System.Windows.Forms.Label();
            this.labelDatPhong_ClickVaoPhongMuonXoa = new System.Windows.Forms.Label();
            this.dataGridViewDichVuDaChon = new System.Windows.Forms.DataGridView();
            this.CollumnDichVuDaChon_maDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDichVuDaChon_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDatPhong_PhongDaChon = new System.Windows.Forms.Label();
            this.panelPhong_BoLoc = new System.Windows.Forms.Panel();
            this.comboBoxDatPhong_TrangThai = new System.Windows.Forms.ComboBox();
            this.buttonDatPhong_TimKiem = new System.Windows.Forms.Button();
            this.textBoxDatPhong_SoPhong = new System.Windows.Forms.TextBox();
            this.labelSoPhong_LoaiPhong = new System.Windows.Forms.Label();
            this.labelDatPhong_SoPhong = new System.Windows.Forms.Label();
            this.labelDatPhong_BoLoc = new System.Windows.Forms.Label();
            this.labelDatPhong_ChonPhong = new System.Windows.Forms.Label();
            this.dataGridViewChonDichVu = new System.Windows.Forms.DataGridView();
            this.CollumnChonDichVu_MaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollumnDichVu_TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollumnDichVu_LoaiHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollumnQuanLy__DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDonDatPhong = new System.Windows.Forms.Label();
            this.userControlLeTan_HoaDonDichVu1 = new HeThongQuanLyKhachSan.UseControl_LeTan.UserControlLeTan_HoaDonDichVu();
            this.panelDatPhong_ThongTinKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDichVuDaChon)).BeginInit();
            this.panelPhong_BoLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChonDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDatPhong_ClickVaoPhongMuonDat
            // 
            this.labelDatPhong_ClickVaoPhongMuonDat.AutoSize = true;
            this.labelDatPhong_ClickVaoPhongMuonDat.Location = new System.Drawing.Point(14, 339);
            this.labelDatPhong_ClickVaoPhongMuonDat.Name = "labelDatPhong_ClickVaoPhongMuonDat";
            this.labelDatPhong_ClickVaoPhongMuonDat.Size = new System.Drawing.Size(208, 15);
            this.labelDatPhong_ClickVaoPhongMuonDat.TabIndex = 22;
            this.labelDatPhong_ClickVaoPhongMuonDat.Text = "Click vào dịch vụ muốn chọn để chọn";
            // 
            // panelDatPhong_ThongTinKhachHang
            // 
            this.panelDatPhong_ThongTinKhachHang.Controls.Add(this.buttonThanhToan);
            this.panelDatPhong_ThongTinKhachHang.Controls.Add(this.textBoxSoDienThoai);
            this.panelDatPhong_ThongTinKhachHang.Controls.Add(this.labelDatPhong_SDT);
            this.panelDatPhong_ThongTinKhachHang.Controls.Add(this.textBoxHoTen);
            this.panelDatPhong_ThongTinKhachHang.Controls.Add(this.textBoxSoCanCuocCongDan);
            this.panelDatPhong_ThongTinKhachHang.Controls.Add(this.labelDatPhong_HoTen);
            this.panelDatPhong_ThongTinKhachHang.Controls.Add(this.labelDatPhong_SoCCCD);
            this.panelDatPhong_ThongTinKhachHang.Location = new System.Drawing.Point(414, 357);
            this.panelDatPhong_ThongTinKhachHang.Name = "panelDatPhong_ThongTinKhachHang";
            this.panelDatPhong_ThongTinKhachHang.Size = new System.Drawing.Size(374, 127);
            this.panelDatPhong_ThongTinKhachHang.TabIndex = 27;
            // 
            // buttonThanhToan
            // 
            this.buttonThanhToan.Location = new System.Drawing.Point(174, 94);
            this.buttonThanhToan.Name = "buttonThanhToan";
            this.buttonThanhToan.Size = new System.Drawing.Size(88, 27);
            this.buttonThanhToan.TabIndex = 11;
            this.buttonThanhToan.Text = "Thanh toán";
            this.buttonThanhToan.UseVisualStyleBackColor = true;
            this.buttonThanhToan.Click += new System.EventHandler(this.buttonThanhToan_Click);
            // 
            // textBoxSoDienThoai
            // 
            this.textBoxSoDienThoai.Location = new System.Drawing.Point(174, 60);
            this.textBoxSoDienThoai.Name = "textBoxSoDienThoai";
            this.textBoxSoDienThoai.Size = new System.Drawing.Size(187, 23);
            this.textBoxSoDienThoai.TabIndex = 23;
            // 
            // labelDatPhong_SDT
            // 
            this.labelDatPhong_SDT.AutoSize = true;
            this.labelDatPhong_SDT.Location = new System.Drawing.Point(23, 63);
            this.labelDatPhong_SDT.Name = "labelDatPhong_SDT";
            this.labelDatPhong_SDT.Size = new System.Drawing.Size(79, 15);
            this.labelDatPhong_SDT.TabIndex = 22;
            this.labelDatPhong_SDT.Text = "Số điện thoại:";
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Location = new System.Drawing.Point(174, 7);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(187, 23);
            this.textBoxHoTen.TabIndex = 15;
            // 
            // textBoxSoCanCuocCongDan
            // 
            this.textBoxSoCanCuocCongDan.Location = new System.Drawing.Point(174, 33);
            this.textBoxSoCanCuocCongDan.Name = "textBoxSoCanCuocCongDan";
            this.textBoxSoCanCuocCongDan.Size = new System.Drawing.Size(187, 23);
            this.textBoxSoCanCuocCongDan.TabIndex = 14;
            // 
            // labelDatPhong_HoTen
            // 
            this.labelDatPhong_HoTen.AutoSize = true;
            this.labelDatPhong_HoTen.Location = new System.Drawing.Point(23, 10);
            this.labelDatPhong_HoTen.Name = "labelDatPhong_HoTen";
            this.labelDatPhong_HoTen.Size = new System.Drawing.Size(111, 15);
            this.labelDatPhong_HoTen.TabIndex = 13;
            this.labelDatPhong_HoTen.Text = "Họ tên khách hàng:";
            // 
            // labelDatPhong_SoCCCD
            // 
            this.labelDatPhong_SoCCCD.AutoSize = true;
            this.labelDatPhong_SoCCCD.Location = new System.Drawing.Point(23, 36);
            this.labelDatPhong_SoCCCD.Name = "labelDatPhong_SoCCCD";
            this.labelDatPhong_SoCCCD.Size = new System.Drawing.Size(127, 15);
            this.labelDatPhong_SoCCCD.TabIndex = 12;
            this.labelDatPhong_SoCCCD.Text = "Số căn cước công dân:";
            // 
            // labelDatPhong_ClickVaoPhongMuonXoa
            // 
            this.labelDatPhong_ClickVaoPhongMuonXoa.AutoSize = true;
            this.labelDatPhong_ClickVaoPhongMuonXoa.Location = new System.Drawing.Point(414, 339);
            this.labelDatPhong_ClickVaoPhongMuonXoa.Name = "labelDatPhong_ClickVaoPhongMuonXoa";
            this.labelDatPhong_ClickVaoPhongMuonXoa.Size = new System.Drawing.Size(192, 15);
            this.labelDatPhong_ClickVaoPhongMuonXoa.TabIndex = 28;
            this.labelDatPhong_ClickVaoPhongMuonXoa.Text = "Click vào dịch vụ muốn xóa để xóa";
            // 
            // dataGridViewDichVuDaChon
            // 
            this.dataGridViewDichVuDaChon.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.dataGridViewDichVuDaChon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDichVuDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDichVuDaChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CollumnDichVuDaChon_maDichVu,
            this.dataGridViewTextBoxColumn2,
            this.ColumnDichVuDaChon_SoLuong,
            this.dataGridViewTextBoxColumn5});
            this.dataGridViewDichVuDaChon.Location = new System.Drawing.Point(414, 86);
            this.dataGridViewDichVuDaChon.Name = "dataGridViewDichVuDaChon";
            this.dataGridViewDichVuDaChon.RowHeadersWidth = 51;
            this.dataGridViewDichVuDaChon.RowTemplate.Height = 25;
            this.dataGridViewDichVuDaChon.Size = new System.Drawing.Size(374, 250);
            this.dataGridViewDichVuDaChon.TabIndex = 26;
            // 
            // CollumnDichVuDaChon_maDichVu
            // 
            this.CollumnDichVuDaChon_maDichVu.DataPropertyName = "ID_Dich_vu";
            this.CollumnDichVuDaChon_maDichVu.HeaderText = "Mã dịch vụ";
            this.CollumnDichVuDaChon_maDichVu.MinimumWidth = 6;
            this.CollumnDichVuDaChon_maDichVu.Name = "CollumnDichVuDaChon_maDichVu";
            this.CollumnDichVuDaChon_maDichVu.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ten";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên dịch vụ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // ColumnDichVuDaChon_SoLuong
            // 
            this.ColumnDichVuDaChon_SoLuong.DataPropertyName = "So_luong";
            this.ColumnDichVuDaChon_SoLuong.HeaderText = "Số lượng";
            this.ColumnDichVuDaChon_SoLuong.MinimumWidth = 6;
            this.ColumnDichVuDaChon_SoLuong.Name = "ColumnDichVuDaChon_SoLuong";
            this.ColumnDichVuDaChon_SoLuong.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Don_gia";
            this.dataGridViewTextBoxColumn5.HeaderText = "Đơn giá";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // labelDatPhong_PhongDaChon
            // 
            this.labelDatPhong_PhongDaChon.AutoSize = true;
            this.labelDatPhong_PhongDaChon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDatPhong_PhongDaChon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelDatPhong_PhongDaChon.Location = new System.Drawing.Point(536, 53);
            this.labelDatPhong_PhongDaChon.Name = "labelDatPhong_PhongDaChon";
            this.labelDatPhong_PhongDaChon.Size = new System.Drawing.Size(121, 21);
            this.labelDatPhong_PhongDaChon.TabIndex = 25;
            this.labelDatPhong_PhongDaChon.Text = "Dịch vụ đã chọn";
            // 
            // panelPhong_BoLoc
            // 
            this.panelPhong_BoLoc.Controls.Add(this.comboBoxDatPhong_TrangThai);
            this.panelPhong_BoLoc.Controls.Add(this.buttonDatPhong_TimKiem);
            this.panelPhong_BoLoc.Controls.Add(this.textBoxDatPhong_SoPhong);
            this.panelPhong_BoLoc.Controls.Add(this.labelSoPhong_LoaiPhong);
            this.panelPhong_BoLoc.Controls.Add(this.labelDatPhong_SoPhong);
            this.panelPhong_BoLoc.Controls.Add(this.labelDatPhong_BoLoc);
            this.panelPhong_BoLoc.Location = new System.Drawing.Point(14, 357);
            this.panelPhong_BoLoc.Name = "panelPhong_BoLoc";
            this.panelPhong_BoLoc.Size = new System.Drawing.Size(374, 127);
            this.panelPhong_BoLoc.TabIndex = 24;
            // 
            // comboBoxDatPhong_TrangThai
            // 
            this.comboBoxDatPhong_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDatPhong_TrangThai.FormattingEnabled = true;
            this.comboBoxDatPhong_TrangThai.Items.AddRange(new object[] {
            "Trống",
            "Đã đặt",
            "Đang ở"});
            this.comboBoxDatPhong_TrangThai.Location = new System.Drawing.Point(218, 59);
            this.comboBoxDatPhong_TrangThai.Name = "comboBoxDatPhong_TrangThai";
            this.comboBoxDatPhong_TrangThai.Size = new System.Drawing.Size(143, 23);
            this.comboBoxDatPhong_TrangThai.TabIndex = 12;
            // 
            // buttonDatPhong_TimKiem
            // 
            this.buttonDatPhong_TimKiem.Location = new System.Drawing.Point(141, 94);
            this.buttonDatPhong_TimKiem.Name = "buttonDatPhong_TimKiem";
            this.buttonDatPhong_TimKiem.Size = new System.Drawing.Size(88, 27);
            this.buttonDatPhong_TimKiem.TabIndex = 3;
            this.buttonDatPhong_TimKiem.Text = "Tìm kiếm";
            this.buttonDatPhong_TimKiem.UseVisualStyleBackColor = true;
            // 
            // textBoxDatPhong_SoPhong
            // 
            this.textBoxDatPhong_SoPhong.Location = new System.Drawing.Point(8, 59);
            this.textBoxDatPhong_SoPhong.Name = "textBoxDatPhong_SoPhong";
            this.textBoxDatPhong_SoPhong.Size = new System.Drawing.Size(143, 23);
            this.textBoxDatPhong_SoPhong.TabIndex = 5;
            // 
            // labelSoPhong_LoaiPhong
            // 
            this.labelSoPhong_LoaiPhong.AutoSize = true;
            this.labelSoPhong_LoaiPhong.Location = new System.Drawing.Point(218, 41);
            this.labelSoPhong_LoaiPhong.Name = "labelSoPhong_LoaiPhong";
            this.labelSoPhong_LoaiPhong.Size = new System.Drawing.Size(98, 15);
            this.labelSoPhong_LoaiPhong.TabIndex = 2;
            this.labelSoPhong_LoaiPhong.Text = "Loại hình dịch vụ";
            // 
            // labelDatPhong_SoPhong
            // 
            this.labelDatPhong_SoPhong.AutoSize = true;
            this.labelDatPhong_SoPhong.Location = new System.Drawing.Point(8, 41);
            this.labelDatPhong_SoPhong.Name = "labelDatPhong_SoPhong";
            this.labelDatPhong_SoPhong.Size = new System.Drawing.Size(67, 15);
            this.labelDatPhong_SoPhong.TabIndex = 1;
            this.labelDatPhong_SoPhong.Text = "Tên dịch vụ";
            // 
            // labelDatPhong_BoLoc
            // 
            this.labelDatPhong_BoLoc.AutoSize = true;
            this.labelDatPhong_BoLoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDatPhong_BoLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelDatPhong_BoLoc.Location = new System.Drawing.Point(158, 5);
            this.labelDatPhong_BoLoc.Name = "labelDatPhong_BoLoc";
            this.labelDatPhong_BoLoc.Size = new System.Drawing.Size(52, 21);
            this.labelDatPhong_BoLoc.TabIndex = 0;
            this.labelDatPhong_BoLoc.Text = "Bộ lọc";
            // 
            // labelDatPhong_ChonPhong
            // 
            this.labelDatPhong_ChonPhong.AutoSize = true;
            this.labelDatPhong_ChonPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDatPhong_ChonPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelDatPhong_ChonPhong.Location = new System.Drawing.Point(147, 53);
            this.labelDatPhong_ChonPhong.Name = "labelDatPhong_ChonPhong";
            this.labelDatPhong_ChonPhong.Size = new System.Drawing.Size(101, 21);
            this.labelDatPhong_ChonPhong.TabIndex = 20;
            this.labelDatPhong_ChonPhong.Text = "Chọn dịch vụ";
            // 
            // dataGridViewChonDichVu
            // 
            this.dataGridViewChonDichVu.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.dataGridViewChonDichVu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewChonDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChonDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CollumnChonDichVu_MaDichVu,
            this.CollumnDichVu_TenDichVu,
            this.CollumnDichVu_LoaiHinh,
            this.CollumnQuanLy__DonGia});
            this.dataGridViewChonDichVu.Location = new System.Drawing.Point(14, 86);
            this.dataGridViewChonDichVu.Name = "dataGridViewChonDichVu";
            this.dataGridViewChonDichVu.RowHeadersWidth = 51;
            this.dataGridViewChonDichVu.RowTemplate.Height = 25;
            this.dataGridViewChonDichVu.Size = new System.Drawing.Size(374, 250);
            this.dataGridViewChonDichVu.TabIndex = 23;
            this.dataGridViewChonDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChonDichVu_CellClick);
            // 
            // CollumnChonDichVu_MaDichVu
            // 
            this.CollumnChonDichVu_MaDichVu.DataPropertyName = "ID_Dich_vu";
            this.CollumnChonDichVu_MaDichVu.HeaderText = "Mã dịch vụ";
            this.CollumnChonDichVu_MaDichVu.MinimumWidth = 6;
            this.CollumnChonDichVu_MaDichVu.Name = "CollumnChonDichVu_MaDichVu";
            this.CollumnChonDichVu_MaDichVu.Width = 50;
            // 
            // CollumnDichVu_TenDichVu
            // 
            this.CollumnDichVu_TenDichVu.DataPropertyName = "Ten";
            this.CollumnDichVu_TenDichVu.HeaderText = "Tên dịch vụ";
            this.CollumnDichVu_TenDichVu.MinimumWidth = 6;
            this.CollumnDichVu_TenDichVu.Name = "CollumnDichVu_TenDichVu";
            this.CollumnDichVu_TenDichVu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CollumnDichVu_TenDichVu.Width = 110;
            // 
            // CollumnDichVu_LoaiHinh
            // 
            this.CollumnDichVu_LoaiHinh.DataPropertyName = "Loai_hinh";
            this.CollumnDichVu_LoaiHinh.HeaderText = "Loại dịch vụ";
            this.CollumnDichVu_LoaiHinh.MinimumWidth = 6;
            this.CollumnDichVu_LoaiHinh.Name = "CollumnDichVu_LoaiHinh";
            this.CollumnDichVu_LoaiHinh.Width = 80;
            // 
            // CollumnQuanLy__DonGia
            // 
            this.CollumnQuanLy__DonGia.DataPropertyName = "Don_gia";
            this.CollumnQuanLy__DonGia.HeaderText = "Đơn giá";
            this.CollumnQuanLy__DonGia.MinimumWidth = 6;
            this.CollumnQuanLy__DonGia.Name = "CollumnQuanLy__DonGia";
            this.CollumnQuanLy__DonGia.Width = 80;
            // 
            // labelDonDatPhong
            // 
            this.labelDonDatPhong.AutoSize = true;
            this.labelDonDatPhong.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDonDatPhong.Location = new System.Drawing.Point(348, 15);
            this.labelDonDatPhong.Name = "labelDonDatPhong";
            this.labelDonDatPhong.Size = new System.Drawing.Size(105, 37);
            this.labelDonDatPhong.TabIndex = 21;
            this.labelDonDatPhong.Text = "Dịch vụ";
            // 
            // userControlLeTan_HoaDonDichVu1
            // 
            this.userControlLeTan_HoaDonDichVu1.Location = new System.Drawing.Point(0, 0);
            this.userControlLeTan_HoaDonDichVu1.Name = "userControlLeTan_HoaDonDichVu1";
            this.userControlLeTan_HoaDonDichVu1.Size = new System.Drawing.Size(799, 494);
            this.userControlLeTan_HoaDonDichVu1.TabIndex = 29;
            this.userControlLeTan_HoaDonDichVu1.Visible = false;
            // 
            // UserControlLeTan_DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControlLeTan_HoaDonDichVu1);
            this.Controls.Add(this.labelDatPhong_ClickVaoPhongMuonDat);
            this.Controls.Add(this.panelDatPhong_ThongTinKhachHang);
            this.Controls.Add(this.labelDatPhong_ClickVaoPhongMuonXoa);
            this.Controls.Add(this.dataGridViewDichVuDaChon);
            this.Controls.Add(this.labelDatPhong_PhongDaChon);
            this.Controls.Add(this.panelPhong_BoLoc);
            this.Controls.Add(this.labelDatPhong_ChonPhong);
            this.Controls.Add(this.dataGridViewChonDichVu);
            this.Controls.Add(this.labelDonDatPhong);
            this.Name = "UserControlLeTan_DichVu";
            this.Size = new System.Drawing.Size(799, 494);
            this.Load += new System.EventHandler(this.UserControlLeTan_DichVu_Load);
            this.panelDatPhong_ThongTinKhachHang.ResumeLayout(false);
            this.panelDatPhong_ThongTinKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDichVuDaChon)).EndInit();
            this.panelPhong_BoLoc.ResumeLayout(false);
            this.panelPhong_BoLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChonDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelDatPhong_ClickVaoPhongMuonDat;
        private Panel panelDatPhong_ThongTinKhachHang;
        private Button buttonThanhToan;
        private TextBox textBoxSoDienThoai;
        private Label labelDatPhong_SDT;
        private TextBox textBoxHoTen;
        private TextBox textBoxSoCanCuocCongDan;
        private Label labelDatPhong_HoTen;
        private Label labelDatPhong_SoCCCD;
        private Label labelDatPhong_ClickVaoPhongMuonXoa;
        private DataGridView dataGridViewDichVuDaChon;
        private Label labelDatPhong_PhongDaChon;
        private Panel panelPhong_BoLoc;
        private ComboBox comboBoxDatPhong_TrangThai;
        private Button buttonDatPhong_TimKiem;
        private TextBox textBoxDatPhong_SoPhong;
        private Label labelSoPhong_LoaiPhong;
        private Label labelDatPhong_SoPhong;
        private Label labelDatPhong_BoLoc;
        private Label labelDatPhong_ChonPhong;
        private DataGridView dataGridViewChonDichVu;
        private Label labelDonDatPhong;
        private UserControlLeTan_HoaDonDichVu userControlLeTan_HoaDonDichVu1;
        private DataGridViewTextBoxColumn CollumnChonDichVu_MaDichVu;
        private DataGridViewTextBoxColumn CollumnDichVu_TenDichVu;
        private DataGridViewTextBoxColumn CollumnDichVu_LoaiHinh;
        private DataGridViewTextBoxColumn CollumnQuanLy__DonGia;
        private DataGridViewTextBoxColumn CollumnDichVuDaChon_maDichVu;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn ColumnDichVuDaChon_SoLuong;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
