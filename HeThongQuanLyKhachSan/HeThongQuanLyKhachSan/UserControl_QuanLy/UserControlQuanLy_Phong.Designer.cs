namespace HeThongQuanLyKhachSan.UserControl_QuanLy
{
    partial class UserControlQuanLy_Phong
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
            this.textBoxNhanVien_TimKiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNhanVien_TimKiem = new System.Windows.Forms.Button();
            this.comboBoxPhong_So_Giuong = new System.Windows.Forms.ComboBox();
            this.textBoxPhong_DonGia = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxPhong_MaSoPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPhongTimKiem = new System.Windows.Forms.Button();
            this.comboBoxPhong_LoaiPhong = new System.Windows.Forms.ComboBox();
            this.textBoxPhong_SoPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewQuanLy_Phong = new System.Windows.Forms.DataGridView();
            this.ColumnPhong_MaSoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhong_SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhong_SoGiuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhong_LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhong_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDonDatPhong = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLy_Phong)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNhanVien_TimKiem
            // 
            this.textBoxNhanVien_TimKiem.Location = new System.Drawing.Point(10, 5);
            this.textBoxNhanVien_TimKiem.Name = "textBoxNhanVien_TimKiem";
            this.textBoxNhanVien_TimKiem.Size = new System.Drawing.Size(194, 23);
            this.textBoxNhanVien_TimKiem.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonNhanVien_TimKiem);
            this.panel1.Controls.Add(this.textBoxNhanVien_TimKiem);
            this.panel1.Location = new System.Drawing.Point(259, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 35);
            this.panel1.TabIndex = 26;
            // 
            // buttonNhanVien_TimKiem
            // 
            this.buttonNhanVien_TimKiem.Location = new System.Drawing.Point(210, 1);
            this.buttonNhanVien_TimKiem.Name = "buttonNhanVien_TimKiem";
            this.buttonNhanVien_TimKiem.Size = new System.Drawing.Size(94, 28);
            this.buttonNhanVien_TimKiem.TabIndex = 3;
            this.buttonNhanVien_TimKiem.Text = "Tìm kiếm";
            this.buttonNhanVien_TimKiem.UseVisualStyleBackColor = true;
            this.buttonNhanVien_TimKiem.Click += new System.EventHandler(this.buttonNhanVien_TimKiem_Click);
            // 
            // comboBoxPhong_So_Giuong
            // 
            this.comboBoxPhong_So_Giuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPhong_So_Giuong.FormattingEnabled = true;
            this.comboBoxPhong_So_Giuong.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxPhong_So_Giuong.Location = new System.Drawing.Point(8, 149);
            this.comboBoxPhong_So_Giuong.Name = "comboBoxPhong_So_Giuong";
            this.comboBoxPhong_So_Giuong.Size = new System.Drawing.Size(176, 23);
            this.comboBoxPhong_So_Giuong.TabIndex = 11;
            // 
            // textBoxPhong_DonGia
            // 
            this.textBoxPhong_DonGia.Location = new System.Drawing.Point(8, 280);
            this.textBoxPhong_DonGia.Name = "textBoxPhong_DonGia";
            this.textBoxPhong_DonGia.Size = new System.Drawing.Size(176, 23);
            this.textBoxPhong_DonGia.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBoxPhong_So_Giuong);
            this.panel2.Controls.Add(this.textBoxPhong_DonGia);
            this.panel2.Controls.Add(this.textBoxPhong_MaSoPhong);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonPhongTimKiem);
            this.panel2.Controls.Add(this.comboBoxPhong_LoaiPhong);
            this.panel2.Controls.Add(this.textBoxPhong_SoPhong);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(585, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 364);
            this.panel2.TabIndex = 25;
            // 
            // textBoxPhong_MaSoPhong
            // 
            this.textBoxPhong_MaSoPhong.Enabled = false;
            this.textBoxPhong_MaSoPhong.Location = new System.Drawing.Point(8, 28);
            this.textBoxPhong_MaSoPhong.Name = "textBoxPhong_MaSoPhong";
            this.textBoxPhong_MaSoPhong.Size = new System.Drawing.Size(176, 23);
            this.textBoxPhong_MaSoPhong.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã số phòng";
            // 
            // buttonPhongTimKiem
            // 
            this.buttonPhongTimKiem.Location = new System.Drawing.Point(8, 331);
            this.buttonPhongTimKiem.Name = "buttonPhongTimKiem";
            this.buttonPhongTimKiem.Size = new System.Drawing.Size(87, 30);
            this.buttonPhongTimKiem.TabIndex = 3;
            this.buttonPhongTimKiem.Text = "Cập nhật";
            this.buttonPhongTimKiem.UseVisualStyleBackColor = true;
            this.buttonPhongTimKiem.Click += new System.EventHandler(this.buttonPhongTimKiem_Click);
            // 
            // comboBoxPhong_LoaiPhong
            // 
            this.comboBoxPhong_LoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPhong_LoaiPhong.FormattingEnabled = true;
            this.comboBoxPhong_LoaiPhong.Items.AddRange(new object[] {
            "Thường",
            "Cao cấp"});
            this.comboBoxPhong_LoaiPhong.Location = new System.Drawing.Point(8, 216);
            this.comboBoxPhong_LoaiPhong.Name = "comboBoxPhong_LoaiPhong";
            this.comboBoxPhong_LoaiPhong.Size = new System.Drawing.Size(176, 23);
            this.comboBoxPhong_LoaiPhong.TabIndex = 6;
            // 
            // textBoxPhong_SoPhong
            // 
            this.textBoxPhong_SoPhong.Location = new System.Drawing.Point(8, 83);
            this.textBoxPhong_SoPhong.Name = "textBoxPhong_SoPhong";
            this.textBoxPhong_SoPhong.Size = new System.Drawing.Size(176, 23);
            this.textBoxPhong_SoPhong.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số giường";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số phòng";
            // 
            // dataGridViewQuanLy_Phong
            // 
            this.dataGridViewQuanLy_Phong.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.dataGridViewQuanLy_Phong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewQuanLy_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLy_Phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPhong_MaSoPhong,
            this.ColumnPhong_SoPhong,
            this.ColumnPhong_SoGiuong,
            this.ColumnPhong_LoaiPhong,
            this.ColumnPhong_DonGia});
            this.dataGridViewQuanLy_Phong.Location = new System.Drawing.Point(17, 91);
            this.dataGridViewQuanLy_Phong.Name = "dataGridViewQuanLy_Phong";
            this.dataGridViewQuanLy_Phong.RowHeadersWidth = 51;
            this.dataGridViewQuanLy_Phong.RowTemplate.Height = 25;
            this.dataGridViewQuanLy_Phong.Size = new System.Drawing.Size(549, 364);
            this.dataGridViewQuanLy_Phong.TabIndex = 24;
            this.dataGridViewQuanLy_Phong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuanLy_Phong_CellClick);
            // 
            // ColumnPhong_MaSoPhong
            // 
            this.ColumnPhong_MaSoPhong.DataPropertyName = "ID_Phong";
            this.ColumnPhong_MaSoPhong.HeaderText = "Mã số phòng";
            this.ColumnPhong_MaSoPhong.Name = "ColumnPhong_MaSoPhong";
            // 
            // ColumnPhong_SoPhong
            // 
            this.ColumnPhong_SoPhong.DataPropertyName = "So_phong";
            this.ColumnPhong_SoPhong.HeaderText = "Số phòng";
            this.ColumnPhong_SoPhong.Name = "ColumnPhong_SoPhong";
            this.ColumnPhong_SoPhong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ColumnPhong_SoGiuong
            // 
            this.ColumnPhong_SoGiuong.DataPropertyName = "So_giuong";
            this.ColumnPhong_SoGiuong.HeaderText = "Số giường";
            this.ColumnPhong_SoGiuong.Name = "ColumnPhong_SoGiuong";
            // 
            // ColumnPhong_LoaiPhong
            // 
            this.ColumnPhong_LoaiPhong.DataPropertyName = "Loai_phong";
            this.ColumnPhong_LoaiPhong.HeaderText = "Loại phòng";
            this.ColumnPhong_LoaiPhong.Name = "ColumnPhong_LoaiPhong";
            // 
            // ColumnPhong_DonGia
            // 
            this.ColumnPhong_DonGia.DataPropertyName = "Don_gia";
            this.ColumnPhong_DonGia.HeaderText = "Đơn giá";
            this.ColumnPhong_DonGia.Name = "ColumnPhong_DonGia";
            // 
            // labelDonDatPhong
            // 
            this.labelDonDatPhong.AutoSize = true;
            this.labelDonDatPhong.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDonDatPhong.Location = new System.Drawing.Point(353, 0);
            this.labelDonDatPhong.Name = "labelDonDatPhong";
            this.labelDonDatPhong.Size = new System.Drawing.Size(94, 37);
            this.labelDonDatPhong.TabIndex = 23;
            this.labelDonDatPhong.Text = "Phòng";
            // 
            // UserControlQuanLy_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewQuanLy_Phong);
            this.Controls.Add(this.labelDonDatPhong);
            this.Name = "UserControlQuanLy_Phong";
            this.Size = new System.Drawing.Size(799, 494);
            this.Load += new System.EventHandler(this.UserControlQuanLy_Phong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLy_Phong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNhanVien_TimKiem;
        private Panel panel1;
        private Button buttonNhanVien_TimKiem;
        private ComboBox comboBoxPhong_So_Giuong;
        private TextBox textBoxPhong_DonGia;
        private Panel panel2;
        private TextBox textBoxPhong_MaSoPhong;
        private Label label1;
        private Button buttonPhongTimKiem;
        private ComboBox comboBoxPhong_LoaiPhong;
        private TextBox textBoxPhong_SoPhong;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridViewQuanLy_Phong;
        private Label labelDonDatPhong;
        private DataGridViewTextBoxColumn ColumnPhong_MaSoPhong;
        private DataGridViewTextBoxColumn ColumnPhong_SoPhong;
        private DataGridViewTextBoxColumn ColumnPhong_SoGiuong;
        private DataGridViewTextBoxColumn ColumnPhong_LoaiPhong;
        private DataGridViewTextBoxColumn ColumnPhong_DonGia;
    }
}
