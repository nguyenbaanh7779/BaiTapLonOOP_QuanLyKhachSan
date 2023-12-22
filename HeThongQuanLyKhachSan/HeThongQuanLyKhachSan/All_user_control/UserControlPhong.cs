﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyKhachSan.All_user_control
{
    public partial class useControlPhong : UserControl
    {

        public useControlPhong()
        {
            InitializeComponent();
        }

        private void labelDonDatPhong_Click(object sender, EventArgs e)
        {

        }

        private void useControlPhong_Load(object sender, EventArgs e)
        {
            DanhSachPhong danhSachPhong = new DanhSachPhong();
            danhSachPhong.LayDanhSachPhong();
            dataGridViewPhong.DataSource = danhSachPhong.DanhSachPhongs;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewPhong_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewPhong.DataSource = ChucNangHeThong.timKiemThongTinPhong(textBoxPhong_TimKiemSoPhong.Text, textBoxPhong_TimKiemSoGiuong.Text, comboBoxPhong_TimKiemLoaiPhong.Text, comboBoxPhong_TimKiemTrangThaiPhong.Text);
        }
    }
}
