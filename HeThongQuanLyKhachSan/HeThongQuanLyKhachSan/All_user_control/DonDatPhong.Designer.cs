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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonNhanPhong = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonTraPhong = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.phong1 = new HeThongQuanLyKhachSan.All_user_control.useControlPhong();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDonDatPhong
            // 
            this.labelDonDatPhong.AutoSize = true;
            this.labelDonDatPhong.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDonDatPhong.Location = new System.Drawing.Point(345, 24);
            this.labelDonDatPhong.Name = "labelDonDatPhong";
            this.labelDonDatPhong.Size = new System.Drawing.Size(248, 46);
            this.labelDonDatPhong.TabIndex = 1;
            this.labelDonDatPhong.Text = "Đơn đặt phòng";
            this.labelDonDatPhong.Click += new System.EventHandler(this.labelDonDatPhong_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 151);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(448, 483);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(22, 96);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 47);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 27);
            this.textBox1.TabIndex = 1;
            // 
            // buttonNhanPhong
            // 
            this.buttonNhanPhong.Location = new System.Drawing.Point(3, 5);
            this.buttonNhanPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNhanPhong.Name = "buttonNhanPhong";
            this.buttonNhanPhong.Size = new System.Drawing.Size(119, 37);
            this.buttonNhanPhong.TabIndex = 3;
            this.buttonNhanPhong.Text = "Nhận phòng";
            this.buttonNhanPhong.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonTraPhong);
            this.panel2.Controls.Add(this.buttonNhanPhong);
            this.panel2.Location = new System.Drawing.Point(477, 585);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 48);
            this.panel2.TabIndex = 4;
            // 
            // buttonTraPhong
            // 
            this.buttonTraPhong.Location = new System.Drawing.Point(129, 5);
            this.buttonTraPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTraPhong.Name = "buttonTraPhong";
            this.buttonTraPhong.Size = new System.Drawing.Size(107, 37);
            this.buttonTraPhong.TabIndex = 4;
            this.buttonTraPhong.Text = "Trả phòng";
            this.buttonTraPhong.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.phong1);
            this.panel3.Location = new System.Drawing.Point(477, 151);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 432);
            this.panel3.TabIndex = 5;
            // 
            // phong1
            // 
            this.phong1.Location = new System.Drawing.Point(301, 147);
            this.phong1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.phong1.Name = "phong1";
            this.phong1.Size = new System.Drawing.Size(9, 11);
            this.phong1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(777, 96);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Đặt phòng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // useControlDonDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelDonDatPhong);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "useControlDonDatPhong";
            this.Size = new System.Drawing.Size(897, 641);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelDonDatPhong;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button1;
        private TextBox textBox1;
        private Button buttonNhanPhong;
        private Panel panel2;
        private Button buttonTraPhong;
        private Panel panel3;
        private Button button2;
        private useControlPhong phong1;
    }
}
