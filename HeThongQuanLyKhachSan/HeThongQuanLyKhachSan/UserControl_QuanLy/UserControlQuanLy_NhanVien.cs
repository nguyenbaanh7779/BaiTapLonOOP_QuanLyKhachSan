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
    public partial class UserControlQuanLy_NhanVien : UserControl
    {
        public UserControlQuanLy_NhanVien()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBoxNhanVien_MaNhanVien.Text == "" || textBoxNhanVien_HoTen.Text == "" || textBoxNhanVien_SoCanCuocCongDan.Text == "" || textBoxNhanVien_SoDienThoai.Text == "" || comboBoxNhanVien_GioiTinh.Text == "" || textBoxNhanVien_TienLuong.Text == "" || comboBoxNhanVien_BoPhan.Text == "" || textBoxNhanVien_TaiKhoan.Text == "" || textBoxNhanVien_MatKhau.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else
            {
                string ngay_sinh = dateTimePickerNhanVien_NgaySinh.Value.Year.ToString() + "-" + dateTimePickerNhanVien_NgaySinh.Value.Month.ToString() + "-" + dateTimePickerNhanVien_NgaySinh.Value.Day.ToString();
                ChucNangHeThong.GSQuanLy.capNhatNhanVien(textBoxNhanVien_MaNhanVien.Text,textBoxNhanVien_HoTen.Text, textBoxNhanVien_SoCanCuocCongDan.Text, textBoxNhanVien_SoDienThoai.Text, comboBoxNhanVien_GioiTinh.Text, ngay_sinh, textBoxNhanVien_TienLuong.Text, comboBoxNhanVien_BoPhan.Text, textBoxNhanVien_MatKhau.Text);
                dataGridViewNhanVien.DataSource = ChucNangHeThong.GSQuanLy.timKiemNhanVien(textBoxNhanVien_SoDienThoai.Text).Tables[0];
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNhanVien_TimKiem_Click(object sender, EventArgs e)
        {
            if (textBoxNhanVien_TimKiem.Text == "")
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm!");
            dataGridViewNhanVien.DataSource = ChucNangHeThong.GSQuanLy.timKiemNhanVien(textBoxNhanVien_TimKiem.Text).Tables[0];
        }

        private void UserControlQuanLy_NhanVien_Load(object sender, EventArgs e)
        {
            dataGridViewNhanVien.DataSource = ChucNangHeThong.GSQuanLy.timKiemNhanVien(textBoxNhanVien_TimKiem.Text).Tables[0];
        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewNhanVien.CurrentRow.Selected = true;
            textBoxNhanVien_MaNhanVien.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells["ColumnNhanVien_MaNhanVien"].Value.ToString();
            textBoxNhanVien_HoTen.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells["ColumnNhanVien_HoVaTen"].Value.ToString();
            textBoxNhanVien_SoCanCuocCongDan.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells["ColumnNhanVien_SoCanCuocCongDan"].Value.ToString();
            textBoxNhanVien_SoDienThoai.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells["ColumnNhanVien_SoDienThoai"].Value.ToString();
            comboBoxNhanVien_GioiTinh.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells["ColumnNhanVien_GioiTinh"].Value.ToString();
            dateTimePickerNhanVien_NgaySinh.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells["ColumnNhanVien_NgaySinh"].Value.ToString();
            textBoxNhanVien_TienLuong.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells["ColumnNhanVien_TienLuong"].Value.ToString();
            comboBoxNhanVien_BoPhan.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells["ColumnNhanVien_BoPhan"].Value.ToString();
            textBoxNhanVien_TaiKhoan.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells["ColumnNhanVien_TaiKhoan"].Value.ToString();
            textBoxNhanVien_MatKhau.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells["ColumnNhanVien_MatKhau"].Value.ToString();
        }

        private void checkBoxQuanLy_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
