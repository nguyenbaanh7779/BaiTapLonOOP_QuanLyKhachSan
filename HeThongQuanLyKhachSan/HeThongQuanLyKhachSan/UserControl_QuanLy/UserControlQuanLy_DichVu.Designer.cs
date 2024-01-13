namespace HeThongQuanLyKhachSan.UserControl_QuanLy
{
    partial class UserControlQuanLy_DichVu
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
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxDonGia = new System.Windows.Forms.TextBox();
            this.comboBoxLoaiDichVu = new System.Windows.Forms.ComboBox();
            this.textBoxMaDichVu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.textBoxTenDichVu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonNhanVien_TimKiem = new System.Windows.Forms.Button();
            this.textBoxNhanVien_TimKiem = new System.Windows.Forms.TextBox();
            this.labelDonDatPhong = new System.Windows.Forms.Label();
            this.dataGridViewDichVu = new System.Windows.Forms.DataGridView();
            this.CollumnMaDichDu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollumnTenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollumnLoaiDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollumnDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonThem = new System.Windows.Forms.Button();
            this.userControlLeTan_ThemDichVu1 = new HeThongQuanLyKhachSan.UserControl_QuanLy.UserControlLeTan_ThemDichVu();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(3, 19);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(72, 19);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "Ăn uống";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox6);
            this.groupBox3.Location = new System.Drawing.Point(25, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 47);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại dịch vụ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(159, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Giải trí";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(81, 19);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(72, 19);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "Thư giãn";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxDonGia);
            this.panel2.Controls.Add(this.comboBoxLoaiDichVu);
            this.panel2.Controls.Add(this.textBoxMaDichVu);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonCapNhat);
            this.panel2.Controls.Add(this.textBoxTenDichVu);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(577, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 336);
            this.panel2.TabIndex = 31;
            // 
            // textBoxDonGia
            // 
            this.textBoxDonGia.Location = new System.Drawing.Point(8, 216);
            this.textBoxDonGia.Name = "textBoxDonGia";
            this.textBoxDonGia.Size = new System.Drawing.Size(176, 23);
            this.textBoxDonGia.TabIndex = 12;
            // 
            // comboBoxLoaiDichVu
            // 
            this.comboBoxLoaiDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoaiDichVu.FormattingEnabled = true;
            this.comboBoxLoaiDichVu.Items.AddRange(new object[] {
            "",
            "Ăn uống",
            "Thư giãn",
            "Giải trí",
            "Tiện ích",
            "Vận động"});
            this.comboBoxLoaiDichVu.Location = new System.Drawing.Point(8, 149);
            this.comboBoxLoaiDichVu.Name = "comboBoxLoaiDichVu";
            this.comboBoxLoaiDichVu.Size = new System.Drawing.Size(176, 23);
            this.comboBoxLoaiDichVu.TabIndex = 11;
            // 
            // textBoxMaDichVu
            // 
            this.textBoxMaDichVu.Enabled = false;
            this.textBoxMaDichVu.Location = new System.Drawing.Point(8, 28);
            this.textBoxMaDichVu.Name = "textBoxMaDichVu";
            this.textBoxMaDichVu.Size = new System.Drawing.Size(176, 23);
            this.textBoxMaDichVu.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã dịch vụ";
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.Location = new System.Drawing.Point(8, 255);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(87, 30);
            this.buttonCapNhat.TabIndex = 3;
            this.buttonCapNhat.Text = "Cập nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = true;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // textBoxTenDichVu
            // 
            this.textBoxTenDichVu.Location = new System.Drawing.Point(8, 83);
            this.textBoxTenDichVu.Name = "textBoxTenDichVu";
            this.textBoxTenDichVu.Size = new System.Drawing.Size(176, 23);
            this.textBoxTenDichVu.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên dịch vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonNhanVien_TimKiem);
            this.groupBox1.Controls.Add(this.textBoxNhanVien_TimKiem);
            this.groupBox1.Location = new System.Drawing.Point(298, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 54);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tên dịch vụ";
            // 
            // buttonNhanVien_TimKiem
            // 
            this.buttonNhanVien_TimKiem.Location = new System.Drawing.Point(173, 20);
            this.buttonNhanVien_TimKiem.Name = "buttonNhanVien_TimKiem";
            this.buttonNhanVien_TimKiem.Size = new System.Drawing.Size(94, 28);
            this.buttonNhanVien_TimKiem.TabIndex = 3;
            this.buttonNhanVien_TimKiem.Text = "Tìm kiếm";
            this.buttonNhanVien_TimKiem.UseVisualStyleBackColor = true;
            // 
            // textBoxNhanVien_TimKiem
            // 
            this.textBoxNhanVien_TimKiem.Location = new System.Drawing.Point(6, 22);
            this.textBoxNhanVien_TimKiem.Name = "textBoxNhanVien_TimKiem";
            this.textBoxNhanVien_TimKiem.Size = new System.Drawing.Size(161, 23);
            this.textBoxNhanVien_TimKiem.TabIndex = 20;
            // 
            // labelDonDatPhong
            // 
            this.labelDonDatPhong.AutoSize = true;
            this.labelDonDatPhong.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDonDatPhong.Location = new System.Drawing.Point(360, 12);
            this.labelDonDatPhong.Name = "labelDonDatPhong";
            this.labelDonDatPhong.Size = new System.Drawing.Size(105, 37);
            this.labelDonDatPhong.TabIndex = 29;
            this.labelDonDatPhong.Text = "Dịch vụ";
            // 
            // dataGridViewDichVu
            // 
            this.dataGridViewDichVu.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.dataGridViewDichVu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CollumnMaDichDu,
            this.CollumnTenDichVu,
            this.CollumnLoaiDichVu,
            this.CollumnDonGia});
            this.dataGridViewDichVu.Location = new System.Drawing.Point(25, 139);
            this.dataGridViewDichVu.Name = "dataGridViewDichVu";
            this.dataGridViewDichVu.RowHeadersWidth = 51;
            this.dataGridViewDichVu.RowTemplate.Height = 25;
            this.dataGridViewDichVu.Size = new System.Drawing.Size(540, 336);
            this.dataGridViewDichVu.TabIndex = 32;
            this.dataGridViewDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDichVu_CellClick);
            // 
            // CollumnMaDichDu
            // 
            this.CollumnMaDichDu.DataPropertyName = "ID_Dich_vu";
            this.CollumnMaDichDu.HeaderText = "Mã dịch vụ";
            this.CollumnMaDichDu.MinimumWidth = 6;
            this.CollumnMaDichDu.Name = "CollumnMaDichDu";
            this.CollumnMaDichDu.Width = 90;
            // 
            // CollumnTenDichVu
            // 
            this.CollumnTenDichVu.DataPropertyName = "Ten";
            this.CollumnTenDichVu.HeaderText = "Tên dịch vụ";
            this.CollumnTenDichVu.MinimumWidth = 6;
            this.CollumnTenDichVu.Name = "CollumnTenDichVu";
            this.CollumnTenDichVu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CollumnTenDichVu.Width = 150;
            // 
            // CollumnLoaiDichVu
            // 
            this.CollumnLoaiDichVu.DataPropertyName = "Loai_hinh";
            this.CollumnLoaiDichVu.HeaderText = "Loại dịch vụ";
            this.CollumnLoaiDichVu.MinimumWidth = 6;
            this.CollumnLoaiDichVu.Name = "CollumnLoaiDichVu";
            this.CollumnLoaiDichVu.Width = 120;
            // 
            // CollumnDonGia
            // 
            this.CollumnDonGia.DataPropertyName = "Don_gia";
            this.CollumnDonGia.HeaderText = "Đơn giá";
            this.CollumnDonGia.MinimumWidth = 6;
            this.CollumnDonGia.Name = "CollumnDonGia";
            this.CollumnDonGia.Width = 120;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(690, 98);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(87, 30);
            this.buttonThem.TabIndex = 12;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // userControlLeTan_ThemDichVu1
            // 
            this.userControlLeTan_ThemDichVu1.Location = new System.Drawing.Point(0, 0);
            this.userControlLeTan_ThemDichVu1.Name = "userControlLeTan_ThemDichVu1";
            this.userControlLeTan_ThemDichVu1.Size = new System.Drawing.Size(799, 494);
            this.userControlLeTan_ThemDichVu1.TabIndex = 33;
            this.userControlLeTan_ThemDichVu1.Visible = false;
            // 
            // UserControlQuanLy_DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControlLeTan_ThemDichVu1);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.dataGridViewDichVu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelDonDatPhong);
            this.Name = "UserControlQuanLy_DichVu";
            this.Size = new System.Drawing.Size(799, 494);
            this.Load += new System.EventHandler(this.UserControlQuanLy_DichVu_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal CheckBox checkBox6;
        private GroupBox groupBox3;
        private CheckBox checkBox4;
        private Panel panel2;
        private ComboBox comboBoxLoaiDichVu;
        private TextBox textBoxMaDichVu;
        private Label label1;
        private Button buttonCapNhat;
        private TextBox textBoxTenDichVu;
        private Label label5;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private Button buttonNhanVien_TimKiem;
        private TextBox textBoxNhanVien_TimKiem;
        private Label labelDonDatPhong;
        private DataGridView dataGridViewDichVu;
        private CheckBox checkBox1;
        private Button buttonThem;
        private UserControlLeTan_ThemDichVu userControlLeTan_ThemDichVu1;
        private TextBox textBoxDonGia;
        private DataGridViewTextBoxColumn CollumnMaDichDu;
        private DataGridViewTextBoxColumn CollumnTenDichVu;
        private DataGridViewTextBoxColumn CollumnLoaiDichVu;
        private DataGridViewTextBoxColumn CollumnDonGia;
    }
}
