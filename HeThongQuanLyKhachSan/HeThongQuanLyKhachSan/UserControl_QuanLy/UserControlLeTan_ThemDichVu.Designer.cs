namespace HeThongQuanLyKhachSan.UserControl_QuanLy
{
    partial class UserControlLeTan_ThemDichVu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxDonGia = new System.Windows.Forms.TextBox();
            this.comboBoxLoaiDichVu = new System.Windows.Forms.ComboBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.textBoxTenDichVu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDonDatPhong = new System.Windows.Forms.Label();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxDonGia);
            this.panel2.Controls.Add(this.comboBoxLoaiDichVu);
            this.panel2.Controls.Add(this.buttonThem);
            this.panel2.Controls.Add(this.textBoxTenDichVu);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(299, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 232);
            this.panel2.TabIndex = 30;
            // 
            // textBoxDonGia
            // 
            this.textBoxDonGia.Location = new System.Drawing.Point(8, 161);
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
            this.comboBoxLoaiDichVu.Location = new System.Drawing.Point(8, 94);
            this.comboBoxLoaiDichVu.Name = "comboBoxLoaiDichVu";
            this.comboBoxLoaiDichVu.Size = new System.Drawing.Size(176, 23);
            this.comboBoxLoaiDichVu.TabIndex = 11;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(54, 190);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(87, 30);
            this.buttonThem.TabIndex = 3;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // textBoxTenDichVu
            // 
            this.textBoxTenDichVu.Location = new System.Drawing.Point(8, 28);
            this.textBoxTenDichVu.Name = "textBoxTenDichVu";
            this.textBoxTenDichVu.Size = new System.Drawing.Size(176, 23);
            this.textBoxTenDichVu.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên dịch vụ";
            // 
            // labelDonDatPhong
            // 
            this.labelDonDatPhong.AutoSize = true;
            this.labelDonDatPhong.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDonDatPhong.Location = new System.Drawing.Point(308, 42);
            this.labelDonDatPhong.Name = "labelDonDatPhong";
            this.labelDonDatPhong.Size = new System.Drawing.Size(175, 37);
            this.labelDonDatPhong.TabIndex = 29;
            this.labelDonDatPhong.Text = "Thêm dịch vụ";
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.Location = new System.Drawing.Point(709, 3);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(87, 30);
            this.buttonQuayLai.TabIndex = 12;
            this.buttonQuayLai.Text = "Quay lại";
            this.buttonQuayLai.UseVisualStyleBackColor = true;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // UserControlLeTan_ThemDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonQuayLai);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelDonDatPhong);
            this.Name = "UserControlLeTan_ThemDichVu";
            this.Size = new System.Drawing.Size(799, 494);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private ComboBox comboBoxLoaiDichVu;
        private Button buttonThem;
        private TextBox textBoxTenDichVu;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label labelDonDatPhong;
        private Button buttonQuayLai;
        private TextBox textBoxDonGia;
    }
}
