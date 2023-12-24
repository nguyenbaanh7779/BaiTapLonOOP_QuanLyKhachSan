namespace HeThongQuanLyKhachSan.All_user_control
{
    partial class useControlPhong
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
            this.dataGridViewPhong = new System.Windows.Forms.DataGridView();
            this.ColumnSoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoGiuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhong_LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhong_TrangThaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhong_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxPhong_TimKiemSoGiuong = new System.Windows.Forms.TextBox();
            this.buttonPhongTimKiem = new System.Windows.Forms.Button();
            this.comboBoxPhong_TimKiemTrangThaiPhong = new System.Windows.Forms.ComboBox();
            this.comboBoxPhong_TimKiemLoaiPhong = new System.Windows.Forms.ComboBox();
            this.textBoxPhong_TimKiemSoPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDonDatPhong
            // 
            this.labelDonDatPhong.AutoSize = true;
            this.labelDonDatPhong.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDonDatPhong.Location = new System.Drawing.Point(354, 26);
            this.labelDonDatPhong.Name = "labelDonDatPhong";
            this.labelDonDatPhong.Size = new System.Drawing.Size(94, 37);
            this.labelDonDatPhong.TabIndex = 5;
            this.labelDonDatPhong.Text = "Phòng";
            this.labelDonDatPhong.Click += new System.EventHandler(this.labelDonDatPhong_Click);
            // 
            // dataGridViewPhong
            // 
            this.dataGridViewPhong.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.dataGridViewPhong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSoPhong,
            this.ColumnSoGiuong,
            this.ColumnPhong_LoaiPhong,
            this.ColumnPhong_TrangThaiPhong,
            this.ColumnPhong_DonGia});
            this.dataGridViewPhong.Location = new System.Drawing.Point(21, 107);
            this.dataGridViewPhong.Name = "dataGridViewPhong";
            this.dataGridViewPhong.RowHeadersWidth = 51;
            this.dataGridViewPhong.RowTemplate.Height = 25;
            this.dataGridViewPhong.Size = new System.Drawing.Size(553, 362);
            this.dataGridViewPhong.TabIndex = 6;
            this.dataGridViewPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhong_CellContentClick_1);
            // 
            // ColumnSoPhong
            // 
            this.ColumnSoPhong.DataPropertyName = "So_phong";
            this.ColumnSoPhong.HeaderText = "Số phòng";
            this.ColumnSoPhong.Name = "ColumnSoPhong";
            this.ColumnSoPhong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ColumnSoGiuong
            // 
            this.ColumnSoGiuong.DataPropertyName = "So_giuong";
            this.ColumnSoGiuong.HeaderText = "Số giường";
            this.ColumnSoGiuong.Name = "ColumnSoGiuong";
            // 
            // ColumnPhong_LoaiPhong
            // 
            this.ColumnPhong_LoaiPhong.DataPropertyName = "Loai_phong";
            this.ColumnPhong_LoaiPhong.HeaderText = "Loại phòng";
            this.ColumnPhong_LoaiPhong.Name = "ColumnPhong_LoaiPhong";
            // 
            // ColumnPhong_TrangThaiPhong
            // 
            this.ColumnPhong_TrangThaiPhong.DataPropertyName = "Trang_thai_phong";
            this.ColumnPhong_TrangThaiPhong.HeaderText = "Trạng thái";
            this.ColumnPhong_TrangThaiPhong.Name = "ColumnPhong_TrangThaiPhong";
            // 
            // ColumnPhong_DonGia
            // 
            this.ColumnPhong_DonGia.DataPropertyName = "Don_gia";
            this.ColumnPhong_DonGia.HeaderText = "Đơn giá";
            this.ColumnPhong_DonGia.Name = "ColumnPhong_DonGia";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxPhong_TimKiemSoGiuong);
            this.panel2.Controls.Add(this.buttonPhongTimKiem);
            this.panel2.Controls.Add(this.comboBoxPhong_TimKiemTrangThaiPhong);
            this.panel2.Controls.Add(this.comboBoxPhong_TimKiemLoaiPhong);
            this.panel2.Controls.Add(this.textBoxPhong_TimKiemSoPhong);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(580, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 362);
            this.panel2.TabIndex = 7;
            // 
            // textBoxPhong_TimKiemSoGiuong
            // 
            this.textBoxPhong_TimKiemSoGiuong.Location = new System.Drawing.Point(8, 116);
            this.textBoxPhong_TimKiemSoGiuong.Name = "textBoxPhong_TimKiemSoGiuong";
            this.textBoxPhong_TimKiemSoGiuong.Size = new System.Drawing.Size(176, 23);
            this.textBoxPhong_TimKiemSoGiuong.TabIndex = 8;
            // 
            // buttonPhongTimKiem
            // 
            this.buttonPhongTimKiem.Location = new System.Drawing.Point(65, 306);
            this.buttonPhongTimKiem.Name = "buttonPhongTimKiem";
            this.buttonPhongTimKiem.Size = new System.Drawing.Size(72, 23);
            this.buttonPhongTimKiem.TabIndex = 3;
            this.buttonPhongTimKiem.Text = "Tìm kiếm";
            this.buttonPhongTimKiem.UseVisualStyleBackColor = true;
            this.buttonPhongTimKiem.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxPhong_TimKiemTrangThaiPhong
            // 
            this.comboBoxPhong_TimKiemTrangThaiPhong.FormattingEnabled = true;
            this.comboBoxPhong_TimKiemTrangThaiPhong.Location = new System.Drawing.Point(8, 247);
            this.comboBoxPhong_TimKiemTrangThaiPhong.Name = "comboBoxPhong_TimKiemTrangThaiPhong";
            this.comboBoxPhong_TimKiemTrangThaiPhong.Size = new System.Drawing.Size(176, 23);
            this.comboBoxPhong_TimKiemTrangThaiPhong.TabIndex = 7;
            // 
            // comboBoxPhong_TimKiemLoaiPhong
            // 
            this.comboBoxPhong_TimKiemLoaiPhong.FormattingEnabled = true;
            this.comboBoxPhong_TimKiemLoaiPhong.Location = new System.Drawing.Point(8, 183);
            this.comboBoxPhong_TimKiemLoaiPhong.Name = "comboBoxPhong_TimKiemLoaiPhong";
            this.comboBoxPhong_TimKiemLoaiPhong.Size = new System.Drawing.Size(176, 23);
            this.comboBoxPhong_TimKiemLoaiPhong.TabIndex = 6;
            // 
            // textBoxPhong_TimKiemSoPhong
            // 
            this.textBoxPhong_TimKiemSoPhong.Location = new System.Drawing.Point(8, 50);
            this.textBoxPhong_TimKiemSoPhong.Name = "textBoxPhong_TimKiemSoPhong";
            this.textBoxPhong_TimKiemSoPhong.Size = new System.Drawing.Size(176, 23);
            this.textBoxPhong_TimKiemSoPhong.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số giường";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bộ lọc";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // useControlPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewPhong);
            this.Controls.Add(this.labelDonDatPhong);
            this.Name = "useControlPhong";
            this.Size = new System.Drawing.Size(799, 494);
            this.Load += new System.EventHandler(this.useControlPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelDonDatPhong;
        private DataGridView dataGridViewPhong;
        private Panel panel2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxPhong_TimKiemTrangThaiPhong;
        private ComboBox comboBoxPhong_TimKiemLoaiPhong;
        private TextBox textBoxPhong_TimKiemSoPhong;
        private Button buttonPhongTimKiem;
        private TextBox textBoxPhong_TimKiemSoGiuong;
        private DataGridViewTextBoxColumn ColumnSoPhong;
        private DataGridViewTextBoxColumn ColumnSoGiuong;
        private DataGridViewTextBoxColumn ColumnPhong_LoaiPhong;
        private DataGridViewTextBoxColumn ColumnPhong_TrangThaiPhong;
        private DataGridViewTextBoxColumn ColumnPhong_DonGia;
    }
}
