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
    public partial class UserControlQuanLy_BaoCaoThongKe : UserControl
    {
        public UserControlQuanLy_BaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UserControlQuanLy_BaoCaoThongKe_Load(object sender, EventArgs e)
        {
            // dùng để hiện thị các thông tin thống kê lên form

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // dùng để thực hiện thống kê một vài thông số
            string ngatBatDau = dateTimePickerNgayBatDau.Value.ToString("yyyy/MM/dd");
            string ngayKetThuc = dateTimePickerNgayKetThuc.Value.ToString("yyyy/MM/dd");
            textBoxTongDoanhThu.Text = ChucNangHeThong.GSQuanLy.tinhDoanhThu(ngatBatDau, ngayKetThuc);
            textBoxSoDonDatPhong.Text = ChucNangHeThong.GSQuanLy.tinhSoDonDatPhong(ngatBatDau, ngayKetThuc);
            textBoxSoDonBiHuy.Text = ChucNangHeThong.GSQuanLy.tinhSoDonBiHuy(ngatBatDau, ngayKetThuc);
            dataGridViewXepHangPhong.DataSource = ChucNangHeThong.GSQuanLy.hienThiThuTuPhongTheoDonDatPhong(ngatBatDau, ngayKetThuc).Tables[0];
            dataGridViewXepHangKhachHang.DataSource = ChucNangHeThong.GSQuanLy.xepHangKhachHangTheoSoLanDatPhong(ngatBatDau, ngayKetThuc).Tables[1];
        }
    }
}
