namespace HeThongQuanLyKhachSan.All_user_control
{
    partial class useControlDonDatPhong
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
            this.dataGridViewDonDatPhong = new System.Windows.Forms.DataGridView();
            this.ColumnDonDatPhong_IdDonDatPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDonDatPhong_SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDonDatPhong_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDonDatPhong_SoCanCuocCongDan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDonDatPhong_SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDonDatPhong_NgayNhanPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDonDatPhong_NgayTraPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDonDatPhong_TrangThaiDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDonDatPhong_TimKiemSoDienThoai = new System.Windows.Forms.TextBox();
            this.buttonDonDatPhong_NhanPhong = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonTraPhong = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelThongBao = new System.Windows.Forms.Label();
            this.textBoxDonDatPhong_MaDon = new System.Windows.Forms.TextBox();
            this.textBoxDonDatPhong_TrangThaiDon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDonDatPhong_SoPhong = new System.Windows.Forms.TextBox();
            this.textBoxDonDatPhong_HoTen = new System.Windows.Forms.TextBox();
            this.textBoxDonDatPhong_NgayTraPhong = new System.Windows.Forms.TextBox();
            this.textBoxDonDatPhong_NgayNhanPhong = new System.Windows.Forms.TextBox();
            this.textBoxDonDatPhong_SoDienThoai = new System.Windows.Forms.TextBox();
            this.textBoxDonDatPhong_SoCanCuocCongDan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phong1 = new HeThongQuanLyKhachSan.All_user_control.useControlPhong();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonDatPhong)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDonDatPhong
            // 
            this.labelDonDatPhong.AutoSize = true;
            this.labelDonDatPhong.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDonDatPhong.Location = new System.Drawing.Point(302, 18);
            this.labelDonDatPhong.Name = "labelDonDatPhong";
            this.labelDonDatPhong.Size = new System.Drawing.Size(198, 37);
            this.labelDonDatPhong.TabIndex = 1;
            this.labelDonDatPhong.Text = "Đơn đặt phòng";
            this.labelDonDatPhong.Click += new System.EventHandler(this.labelDonDatPhong_Click);
            // 
            // dataGridViewDonDatPhong
            // 
            this.dataGridViewDonDatPhong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDonDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDonDatPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDonDatPhong_IdDonDatPhong,
            this.ColumnDonDatPhong_SoPhong,
            this.ColumnDonDatPhong_HoTen,
            this.ColumnDonDatPhong_SoCanCuocCongDan,
            this.ColumnDonDatPhong_SoDienThoai,
            this.ColumnDonDatPhong_NgayNhanPhong,
            this.ColumnDonDatPhong_NgayTraPhong,
            this.ColumnDonDatPhong_TrangThaiDon});
            this.dataGridViewDonDatPhong.Location = new System.Drawing.Point(19, 113);
            this.dataGridViewDonDatPhong.Name = "dataGridViewDonDatPhong";
            this.dataGridViewDonDatPhong.RowHeadersWidth = 51;
            this.dataGridViewDonDatPhong.RowTemplate.Height = 25;
            this.dataGridViewDonDatPhong.Size = new System.Drawing.Size(392, 362);
            this.dataGridViewDonDatPhong.TabIndex = 2;
            this.dataGridViewDonDatPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDonDatPhong_CellClick);
            this.dataGridViewDonDatPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnDonDatPhong_IdDonDatPhong
            // 
            this.ColumnDonDatPhong_IdDonDatPhong.DataPropertyName = "ID_Don_dat_phong";
            this.ColumnDonDatPhong_IdDonDatPhong.HeaderText = "Mã đơn đặt phòng";
            this.ColumnDonDatPhong_IdDonDatPhong.Name = "ColumnDonDatPhong_IdDonDatPhong";
            this.ColumnDonDatPhong_IdDonDatPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnDonDatPhong_SoPhong
            // 
            this.ColumnDonDatPhong_SoPhong.DataPropertyName = "So_phong";
            this.ColumnDonDatPhong_SoPhong.HeaderText = "Số phòng";
            this.ColumnDonDatPhong_SoPhong.Name = "ColumnDonDatPhong_SoPhong";
            this.ColumnDonDatPhong_SoPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnDonDatPhong_HoTen
            // 
            this.ColumnDonDatPhong_HoTen.DataPropertyName = "Ho_ten";
            this.ColumnDonDatPhong_HoTen.HeaderText = "Họ tên khách hàng";
            this.ColumnDonDatPhong_HoTen.Name = "ColumnDonDatPhong_HoTen";
            this.ColumnDonDatPhong_HoTen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnDonDatPhong_SoCanCuocCongDan
            // 
            this.ColumnDonDatPhong_SoCanCuocCongDan.DataPropertyName = "So_can_cuoc_cong_dan";
            this.ColumnDonDatPhong_SoCanCuocCongDan.HeaderText = "Số căn cước công dân";
            this.ColumnDonDatPhong_SoCanCuocCongDan.Name = "ColumnDonDatPhong_SoCanCuocCongDan";
            this.ColumnDonDatPhong_SoCanCuocCongDan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnDonDatPhong_SoDienThoai
            // 
            this.ColumnDonDatPhong_SoDienThoai.DataPropertyName = "So_dien_thoai";
            this.ColumnDonDatPhong_SoDienThoai.HeaderText = "Số điện thoại";
            this.ColumnDonDatPhong_SoDienThoai.Name = "ColumnDonDatPhong_SoDienThoai";
            this.ColumnDonDatPhong_SoDienThoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnDonDatPhong_NgayNhanPhong
            // 
            this.ColumnDonDatPhong_NgayNhanPhong.DataPropertyName = "Ngay_nhan_phong";
            this.ColumnDonDatPhong_NgayNhanPhong.HeaderText = "Ngày nhận phòng";
            this.ColumnDonDatPhong_NgayNhanPhong.Name = "ColumnDonDatPhong_NgayNhanPhong";
            this.ColumnDonDatPhong_NgayNhanPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnDonDatPhong_NgayTraPhong
            // 
            this.ColumnDonDatPhong_NgayTraPhong.DataPropertyName = "Ngay_tra_phong";
            this.ColumnDonDatPhong_NgayTraPhong.HeaderText = "Ngày trả phòng";
            this.ColumnDonDatPhong_NgayTraPhong.Name = "ColumnDonDatPhong_NgayTraPhong";
            this.ColumnDonDatPhong_NgayTraPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnDonDatPhong_TrangThaiDon
            // 
            this.ColumnDonDatPhong_TrangThaiDon.DataPropertyName = "Trang_thai_don";
            this.ColumnDonDatPhong_TrangThaiDon.HeaderText = "Trạng thái đơn đặt phòng";
            this.ColumnDonDatPhong_TrangThaiDon.Name = "ColumnDonDatPhong_TrangThaiDon";
            this.ColumnDonDatPhong_TrangThaiDon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBoxDonDatPhong_TimKiemSoDienThoai);
            this.panel1.Location = new System.Drawing.Point(19, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 35);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDonDatPhong_TimKiemSoDienThoai
            // 
            this.textBoxDonDatPhong_TimKiemSoDienThoai.Location = new System.Drawing.Point(175, 4);
            this.textBoxDonDatPhong_TimKiemSoDienThoai.Name = "textBoxDonDatPhong_TimKiemSoDienThoai";
            this.textBoxDonDatPhong_TimKiemSoDienThoai.Size = new System.Drawing.Size(136, 23);
            this.textBoxDonDatPhong_TimKiemSoDienThoai.TabIndex = 1;
            // 
            // buttonDonDatPhong_NhanPhong
            // 
            this.buttonDonDatPhong_NhanPhong.Location = new System.Drawing.Point(3, 4);
            this.buttonDonDatPhong_NhanPhong.Name = "buttonDonDatPhong_NhanPhong";
            this.buttonDonDatPhong_NhanPhong.Size = new System.Drawing.Size(94, 28);
            this.buttonDonDatPhong_NhanPhong.TabIndex = 3;
            this.buttonDonDatPhong_NhanPhong.Text = "Nhận phòng";
            this.buttonDonDatPhong_NhanPhong.UseVisualStyleBackColor = true;
            this.buttonDonDatPhong_NhanPhong.Click += new System.EventHandler(this.buttonNhanPhong_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonTraPhong);
            this.panel2.Controls.Add(this.buttonDonDatPhong_NhanPhong);
            this.panel2.Location = new System.Drawing.Point(417, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 36);
            this.panel2.TabIndex = 4;
            // 
            // buttonTraPhong
            // 
            this.buttonTraPhong.Location = new System.Drawing.Point(103, 5);
            this.buttonTraPhong.Name = "buttonTraPhong";
            this.buttonTraPhong.Size = new System.Drawing.Size(94, 28);
            this.buttonTraPhong.TabIndex = 4;
            this.buttonTraPhong.Text = "Trả phòng";
            this.buttonTraPhong.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelThongBao);
            this.panel3.Controls.Add(this.textBoxDonDatPhong_MaDon);
            this.panel3.Controls.Add(this.textBoxDonDatPhong_TrangThaiDon);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textBoxDonDatPhong_SoPhong);
            this.panel3.Controls.Add(this.textBoxDonDatPhong_HoTen);
            this.panel3.Controls.Add(this.textBoxDonDatPhong_NgayTraPhong);
            this.panel3.Controls.Add(this.textBoxDonDatPhong_NgayNhanPhong);
            this.panel3.Controls.Add(this.textBoxDonDatPhong_SoDienThoai);
            this.panel3.Controls.Add(this.textBoxDonDatPhong_SoCanCuocCongDan);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.phong1);
            this.panel3.Location = new System.Drawing.Point(417, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 275);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // labelThongBao
            // 
            this.labelThongBao.AutoSize = true;
            this.labelThongBao.BackColor = System.Drawing.SystemColors.Control;
            this.labelThongBao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelThongBao.Location = new System.Drawing.Point(3, 249);
            this.labelThongBao.Name = "labelThongBao";
            this.labelThongBao.Size = new System.Drawing.Size(64, 15);
            this.labelThongBao.TabIndex = 17;
            this.labelThongBao.Text = "Thông báo";
            this.labelThongBao.Click += new System.EventHandler(this.labelThongBao_Click);
            // 
            // textBoxDonDatPhong_MaDon
            // 
            this.textBoxDonDatPhong_MaDon.Location = new System.Drawing.Point(153, 15);
            this.textBoxDonDatPhong_MaDon.Name = "textBoxDonDatPhong_MaDon";
            this.textBoxDonDatPhong_MaDon.Size = new System.Drawing.Size(187, 23);
            this.textBoxDonDatPhong_MaDon.TabIndex = 16;
            // 
            // textBoxDonDatPhong_TrangThaiDon
            // 
            this.textBoxDonDatPhong_TrangThaiDon.Location = new System.Drawing.Point(153, 218);
            this.textBoxDonDatPhong_TrangThaiDon.Name = "textBoxDonDatPhong_TrangThaiDon";
            this.textBoxDonDatPhong_TrangThaiDon.Size = new System.Drawing.Size(187, 23);
            this.textBoxDonDatPhong_TrangThaiDon.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Trạng thái đơn đặt phòng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mã đơn đặt phòng:";
            // 
            // textBoxDonDatPhong_SoPhong
            // 
            this.textBoxDonDatPhong_SoPhong.Location = new System.Drawing.Point(153, 44);
            this.textBoxDonDatPhong_SoPhong.Name = "textBoxDonDatPhong_SoPhong";
            this.textBoxDonDatPhong_SoPhong.Size = new System.Drawing.Size(187, 23);
            this.textBoxDonDatPhong_SoPhong.TabIndex = 12;
            // 
            // textBoxDonDatPhong_HoTen
            // 
            this.textBoxDonDatPhong_HoTen.Location = new System.Drawing.Point(153, 73);
            this.textBoxDonDatPhong_HoTen.Name = "textBoxDonDatPhong_HoTen";
            this.textBoxDonDatPhong_HoTen.Size = new System.Drawing.Size(187, 23);
            this.textBoxDonDatPhong_HoTen.TabIndex = 11;
            // 
            // textBoxDonDatPhong_NgayTraPhong
            // 
            this.textBoxDonDatPhong_NgayTraPhong.Location = new System.Drawing.Point(153, 189);
            this.textBoxDonDatPhong_NgayTraPhong.Name = "textBoxDonDatPhong_NgayTraPhong";
            this.textBoxDonDatPhong_NgayTraPhong.Size = new System.Drawing.Size(187, 23);
            this.textBoxDonDatPhong_NgayTraPhong.TabIndex = 10;
            // 
            // textBoxDonDatPhong_NgayNhanPhong
            // 
            this.textBoxDonDatPhong_NgayNhanPhong.Location = new System.Drawing.Point(153, 160);
            this.textBoxDonDatPhong_NgayNhanPhong.Name = "textBoxDonDatPhong_NgayNhanPhong";
            this.textBoxDonDatPhong_NgayNhanPhong.Size = new System.Drawing.Size(187, 23);
            this.textBoxDonDatPhong_NgayNhanPhong.TabIndex = 9;
            // 
            // textBoxDonDatPhong_SoDienThoai
            // 
            this.textBoxDonDatPhong_SoDienThoai.Location = new System.Drawing.Point(153, 131);
            this.textBoxDonDatPhong_SoDienThoai.Name = "textBoxDonDatPhong_SoDienThoai";
            this.textBoxDonDatPhong_SoDienThoai.Size = new System.Drawing.Size(187, 23);
            this.textBoxDonDatPhong_SoDienThoai.TabIndex = 8;
            // 
            // textBoxDonDatPhong_SoCanCuocCongDan
            // 
            this.textBoxDonDatPhong_SoCanCuocCongDan.Location = new System.Drawing.Point(153, 102);
            this.textBoxDonDatPhong_SoCanCuocCongDan.Name = "textBoxDonDatPhong_SoCanCuocCongDan";
            this.textBoxDonDatPhong_SoCanCuocCongDan.Size = new System.Drawing.Size(187, 23);
            this.textBoxDonDatPhong_SoCanCuocCongDan.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Họ tên khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày trả phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày nhận phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số căn cước công dân:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số phòng:";
            // 
            // phong1
            // 
            this.phong1.Location = new System.Drawing.Point(263, 110);
            this.phong1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phong1.Name = "phong1";
            this.phong1.Size = new System.Drawing.Size(8, 8);
            this.phong1.TabIndex = 0;
            // 
            // useControlDonDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDonDatPhong);
            this.Controls.Add(this.labelDonDatPhong);
            this.Name = "useControlDonDatPhong";
            this.Size = new System.Drawing.Size(799, 494);
            this.Load += new System.EventHandler(this.useControlDonDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonDatPhong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelDonDatPhong;
        private DataGridView dataGridViewDonDatPhong;
        private Panel panel1;
        private Button button1;
        private TextBox textBoxDonDatPhong_TimKiemSoDienThoai;
        private Button buttonDonDatPhong_NhanPhong;
        private Panel panel2;
        private Button buttonTraPhong;
        private Panel panel3;
        private useControlPhong phong1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxDonDatPhong_SoPhong;
        private TextBox textBoxDonDatPhong_HoTen;
        private TextBox textBoxDonDatPhong_NgayTraPhong;
        private TextBox textBoxDonDatPhong_NgayNhanPhong;
        private TextBox textBoxDonDatPhong_SoDienThoai;
        private TextBox textBoxDonDatPhong_SoCanCuocCongDan;
        private Label label6;
        private Label label5;
        private TextBox textBoxDonDatPhong_MaDon;
        private TextBox textBoxDonDatPhong_TrangThaiDon;
        private Label label8;
        private Label label7;
        private DataGridViewTextBoxColumn ColumnDonDatPhong_IdDonDatPhong;
        private DataGridViewTextBoxColumn ColumnDonDatPhong_SoPhong;
        private DataGridViewTextBoxColumn ColumnDonDatPhong_HoTen;
        private DataGridViewTextBoxColumn ColumnDonDatPhong_SoCanCuocCongDan;
        private DataGridViewTextBoxColumn ColumnDonDatPhong_SoDienThoai;
        private DataGridViewTextBoxColumn ColumnDonDatPhong_NgayNhanPhong;
        private DataGridViewTextBoxColumn ColumnDonDatPhong_NgayTraPhong;
        private DataGridViewTextBoxColumn ColumnDonDatPhong_TrangThaiDon;
        private Label labelThongBao;
    }
}
