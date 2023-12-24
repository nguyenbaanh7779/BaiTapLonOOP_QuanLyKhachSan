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

        private void buttonDonDatPhong_NhanPhong_Click(object sender, EventArgs e)
        {
            QuanLy quanLy = new QuanLy(ChucNangHeThong.ID_Nhan_vien);
            quanLy.themNhanVien(textBoxThemNhanVien_HoTen.Text, textBoxThemNhanVien_SoCanCuocCongDan.Text, textBoxThemNhanVien_SoDienThoai.Text, textBoxThemNhanVien_GioiTinh.Text, textBoxThemNhanVien_NgaySinh.Text, textBoxThemNhanVien_TienLuong.Text, textBoxThemNhanVien_BoPhan.Text);
        }
    }
}
