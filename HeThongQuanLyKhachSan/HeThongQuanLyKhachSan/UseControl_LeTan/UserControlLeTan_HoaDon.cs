using System;
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
    public partial class UserControlLeTan_HoaDon : UserControl
    {
        public UserControlLeTan_HoaDon()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UserControlLeTan_HoaDon_Load(object sender, EventArgs e)
        {
            // dùng để hiện thị thông tin của hóa đơn
            textBoxHoaDon_KhachHang.Text = ChucNangHeThong.GSHoaDon.Don_Dat_Phong.Khach_Hang.Ho_Ten;
            textBoxHoaDon_SoDienThoai.Text = ChucNangHeThong.GSHoaDon.Don_Dat_Phong.So_Dien_Thoai;
            dateTimePickerHoaDon_NgayNhanPhong.Value = ChucNangHeThong.GSHoaDon.Don_Dat_Phong.Ngay_Nhan_Phong;
            dateTimePickerHoaDon_NgayTraPhong.Value = ChucNangHeThong.GSHoaDon.Don_Dat_Phong.Ngay_Tra_Phong;
            textBoxHoaDon_MaHoaDon.Text = ChucNangHeThong.GSHoaDon.ID_Hoa_Don.ToString();
            textBoxHoaDon_LeTan.Text = ChucNangHeThong.GSHoaDon.Le_Tan.Ho_Ten;
            textBoxHoaDon_TienPhong.Text = ChucNangHeThong.GSHoaDon.Don_Dat_Phong.Tong_tien_phong.ToString();
            dateTimePickerHoaDon_NgayThanhToan.Value = ChucNangHeThong.GSHoaDon.Ngay_Thanh_Toan;
            dataGridViewHoaDon_ThongTinPhong.DataSource = ChucNangHeThong.GSHoaDon.hienThiThongTinPhong().Tables[0];
        }

        private void buttonHoaDon_ThanhToan_Click(object sender, EventArgs e)
        {
            // dùng để thanh toán hóa đơn
            ChucNangHeThong.GSLeTan.thanhToanHoaDon(Convert.ToString(ChucNangHeThong.GSHoaDon.ID_Hoa_Don));
            ChucNangHeThong.GSHoaDon = new HoaDon("-1");
        }
    }
}
