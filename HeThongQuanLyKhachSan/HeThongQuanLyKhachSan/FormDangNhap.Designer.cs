namespace HeThongQuanLyKhachSan
{
    partial class FormDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTaiKhoanHoacMatKhauKhongDung = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.textBoxTaiKhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(275, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelTaiKhoanHoacMatKhauKhongDung);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBoxMatKhau);
            this.panel2.Controls.Add(this.textBoxTaiKhoan);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(234, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 130);
            this.panel2.TabIndex = 3;
            // 
            // labelTaiKhoanHoacMatKhauKhongDung
            // 
            this.labelTaiKhoanHoacMatKhauKhongDung.AutoSize = true;
            this.labelTaiKhoanHoacMatKhauKhongDung.ForeColor = System.Drawing.Color.Red;
            this.labelTaiKhoanHoacMatKhauKhongDung.Location = new System.Drawing.Point(4, 97);
            this.labelTaiKhoanHoacMatKhauKhongDung.Name = "labelTaiKhoanHoacMatKhauKhongDung";
            this.labelTaiKhoanHoacMatKhauKhongDung.Size = new System.Drawing.Size(207, 15);
            this.labelTaiKhoanHoacMatKhauKhongDung.TabIndex = 6;
            this.labelTaiKhoanHoacMatKhauKhongDung.Text = "Tài khoản hoặc mật khẩu không đúng";
            this.labelTaiKhoanHoacMatKhauKhongDung.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 70);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "Đăng nhập";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.Location = new System.Drawing.Point(73, 45);
            this.textBoxMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(151, 23);
            this.textBoxMatKhau.TabIndex = 4;
            this.textBoxMatKhau.Text = "0123456789";
            this.textBoxMatKhau.UseSystemPasswordChar = true;
            this.textBoxMatKhau.TextChanged += new System.EventHandler(this.textBoxMatKhau_TextChanged);
            // 
            // textBoxTaiKhoan
            // 
            this.textBoxTaiKhoan.Location = new System.Drawing.Point(73, 13);
            this.textBoxTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTaiKhoan.Name = "textBoxTaiKhoan";
            this.textBoxTaiKhoan.Size = new System.Drawing.Size(151, 23);
            this.textBoxTaiKhoan.TabIndex = 3;
            this.textBoxTaiKhoan.Text = "0123456789";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tài khoản:";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mật khẩu:";
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 338);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Label labelTaiKhoanHoacMatKhauKhongDung;
        private Button button2;
        private TextBox textBoxMatKhau;
        private TextBox textBoxTaiKhoan;
        private Label label4;
        private Label label5;
    }
}