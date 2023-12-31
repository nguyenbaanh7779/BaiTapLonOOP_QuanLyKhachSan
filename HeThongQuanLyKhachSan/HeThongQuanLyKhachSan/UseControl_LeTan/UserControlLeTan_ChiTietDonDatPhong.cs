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
    public partial class UserControlLeTan_ChiTietDonDatPhong : UserControl
    {
        public UserControlLeTan_ChiTietDonDatPhong()
        {
            InitializeComponent();
        }

        private void UserControlLeTan_ChiTietDonDatPhong_Load(object sender, EventArgs e)
        {
            textBoxChiTietDonDatPhong_MaDon.Text = Convert.ToString(ChucNangHeThong.GSDonDatPhong.ID_Don_Dat_Phong);
            textBoxChiTietDonDatPhong_HoTen.Text = ChucNangHeThong.GSDonDatPhong.Khach_Hang.Ho_Ten;
            textBoxChiTietDonDatPhong_SoCanCuocCongDan .Text = ChucNangHeThong.GSDonDatPhong.Khach_Hang.So_Can_Cuoc_Cong_Dan;
            textBoxChiTietDonDatPhong_SoDienThoai.Text = ChucNangHeThong.GSDonDatPhong.So_Dien_Thoai;
            dateTimePickerChiTietDonDatPhong_NgayNhanPhong.Value = ChucNangHeThong.GSDonDatPhong.Ngay_Nhan_Phong;
            dateTimePickerChiTietDonDatPhong_NgayTraPhong.Value = ChucNangHeThong.GSDonDatPhong.Ngay_Tra_Phong;
            dataGridViewChiTietDonDatPhong_PhongDaDat.DataSource = ChucNangHeThong.GSDonDatPhong.hienThiPhongDaDat().Tables[0];
        }

        private void dataGridViewChiTietDonDatPhong_PhongDaDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonDatPhong_DatPhong_Click(object sender, EventArgs e)
        {
            // dùng để xác nhận nhận phòng
            ChucNangHeThong.GSLeTan.nhanPhong(Convert.ToString(ChucNangHeThong.GSDonDatPhong.ID_Don_Dat_Phong));
        }
    }
}
