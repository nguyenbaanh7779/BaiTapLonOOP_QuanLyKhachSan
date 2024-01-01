using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyKhachSan.UseControl_LeTan
{
    public partial class UserControlLeTan_ThongTinCaNhan : UserControl
    {
        public UserControlLeTan_ThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void UserControlLeTan_ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            textBoxThongTinCaNhan_MaNhanVien.Text = ChucNangHeThong.GSLeTan.ID_Nhan_vien.ToString();
            textBoxThongTinCaNhan_HoTen.Text = ChucNangHeThong.GSLeTan.Ho_Ten;
            textBoxThongTinCaNhan_GioiTinh.Text = ChucNangHeThong.GSLeTan.Gioi_Tinh;
            textBoxThongTinCaNhan_SoDienThoai.Text = ChucNangHeThong.GSLeTan.So_Dien_Thoai;
            dateTimePickerThongTinCaNhan_NgaySinh.Value = ChucNangHeThong.GSLeTan.Ngay_Sinh;
            textBoxThongTinCaNhan_BoPhan.Text = "Lễ tân";
            textBoxThongTinCaNhan_TienLuong.Text = ChucNangHeThong.GSLeTan.Tien_Luong.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelThongTinCaNhan_DoiMatKhau.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChucNangHeThong.GSLeTan.doiMatKhau(textBoxThongTinCaNhan_MatKhauCu.Text, textBoxThongTinCaNhan_MatKhauMoi.Text, textBoxThongTinCaNhan_NhapLaiMatKhau.Text);
        }
    }
}
