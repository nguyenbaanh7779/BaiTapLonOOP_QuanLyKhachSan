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
    public partial class UserControlQuanLy_themNhanVien : UserControl
    {
        public UserControlQuanLy_themNhanVien()
        {
            InitializeComponent();
        }

        private void buttonNhanVien_CapNhat_Click(object sender, EventArgs e)
        {
            if (textBoxThemNhanVien_HoTen.Text == "" || textBoxThemNhanVien_SoCanCuocCongDan.Text == "" || textBoxThemNhanVien_SoDienThoai.Text == "" || comboBoxThemNhanVien_GioiTinh.Text == "" || textBoxThemNhanVien_TienLuong.Text == "" || comboBoxThemNhanVien_BoPhan.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else
            {
                QuanLy quanLy = new QuanLy(ChucNangHeThong.ID_Nhan_vien);
                string ngay_sinh = dateTimePickerThemNhanVien_NgaySinh.Value.Year.ToString() + "-" + dateTimePickerThemNhanVien_NgaySinh.Value.Month.ToString() + "-" + dateTimePickerThemNhanVien_NgaySinh.Value.Day.ToString();
                quanLy.themNhanVien(textBoxThemNhanVien_HoTen.Text, textBoxThemNhanVien_SoCanCuocCongDan.Text, textBoxThemNhanVien_SoDienThoai.Text, comboBoxThemNhanVien_GioiTinh.Text, ngay_sinh, textBoxThemNhanVien_TienLuong.Text, comboBoxThemNhanVien_BoPhan.Text);
            }
        }
    }
}
