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
    public partial class UserControlQuanLy_ThongTinCaNhan : UserControl
    {
        public UserControlQuanLy_ThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void UserControlQuanLy_ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            textBoxThongTinCaNhan_MaNhanVien.Text = ChucNangHeThong.GSQuanLy.ID_Nhan_vien.ToString();
            textBoxThongTinCaNhan_HoTen.Text = ChucNangHeThong.GSQuanLy.Ho_Ten;
            textBoxThongTinCaNhan_GioiTinh.Text = ChucNangHeThong.GSQuanLy.Gioi_Tinh;
            textBoxThongTinCaNhan_SoDienThoai.Text = ChucNangHeThong.GSQuanLy.So_Dien_Thoai;
            dateTimePickerThongTinCaNhan_NgaySinh.Value = ChucNangHeThong.GSQuanLy.Ngay_Sinh;
            textBoxThongTinCaNhan_BoPhan.Text = "Quản lý";
            textBoxThongTinCaNhan_TienLuong.Text = ChucNangHeThong.GSQuanLy.Tien_Luong.ToString();
        }

        private void buttonDoiMatKhau_Click(object sender, EventArgs e)
        {
            panelDoiMatKhau.Visible = true;
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            ChucNangHeThong.GSLeTan.doiMatKhau(textBoxThongTinCaNhan_MatKhauCu.Text, textBoxThongTinCaNhan_MatKhauMoi.Text, textBoxThongTinCaNhan_NhapLaiMatKhau.Text);
        }
    }
}
