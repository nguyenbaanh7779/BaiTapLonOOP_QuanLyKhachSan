using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyKhachSan.UserControl_QuanLy
{
    public partial class UserControlQuanLy_Phong : UserControl
    {
        public UserControlQuanLy_Phong()
        {
            InitializeComponent();
        }

        private void buttonNhanVien_TimKiem_Click(object sender, EventArgs e)
        {
            if (textBoxNhanVien_TimKiem.Text == "")
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!");
            else
            {
                dataGridViewQuanLy_Phong.DataSource = ChucNangHeThong.GSQuanLy.timKiemPhong(textBoxNhanVien_TimKiem.Text).Tables[0];
            }
        }

        private void UserControlQuanLy_Phong_Load(object sender, EventArgs e)
        {
            dataGridViewQuanLy_Phong.DataSource = ChucNangHeThong.GSQuanLy.timKiemPhong(textBoxNhanVien_TimKiem.Text).Tables[0];
        }

        private void dataGridViewQuanLy_Phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewQuanLy_Phong.CurrentRow.Selected = true;
            textBoxPhong_MaSoPhong.Text = dataGridViewQuanLy_Phong.Rows[e.RowIndex].Cells["ColumnPhong_MaSoPhong"].FormattedValue.ToString();
            textBoxPhong_SoPhong.Text = dataGridViewQuanLy_Phong.Rows[e.RowIndex].Cells["ColumnPhong_SoPhong"].FormattedValue.ToString();
            comboBoxPhong_So_Giuong.Text = dataGridViewQuanLy_Phong.Rows[e.RowIndex].Cells["ColumnPhong_SoGiuong"].FormattedValue.ToString();
            comboBoxPhong_LoaiPhong.Text = dataGridViewQuanLy_Phong.Rows[e.RowIndex].Cells["ColumnPhong_LoaiPhong"].FormattedValue.ToString();
            textBoxPhong_DonGia.Text = dataGridViewQuanLy_Phong.Rows[e.RowIndex].Cells["ColumnPhong_DonGia"].FormattedValue.ToString();
        }

        private void buttonPhongTimKiem_Click(object sender, EventArgs e)
        {
            if (textBoxPhong_SoPhong.Text == "" || comboBoxPhong_So_Giuong.Text == "" || comboBoxPhong_LoaiPhong.Text == "" || textBoxPhong_DonGia.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else
            {
                ChucNangHeThong.GSQuanLy.capNhatPhong(textBoxPhong_MaSoPhong.Text, textBoxPhong_SoPhong.Text, comboBoxPhong_So_Giuong.Text, comboBoxPhong_LoaiPhong.Text, textBoxPhong_DonGia.Text);
                dataGridViewQuanLy_Phong.DataSource = ChucNangHeThong.GSQuanLy.timKiemPhong(textBoxNhanVien_TimKiem.Text).Tables[0];
            }
        }
    }
}
