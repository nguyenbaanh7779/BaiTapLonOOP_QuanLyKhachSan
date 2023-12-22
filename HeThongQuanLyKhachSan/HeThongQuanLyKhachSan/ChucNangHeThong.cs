using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKhachSan
{
    internal class ChucNangHeThong
    {
        public static List<Phong> timKiemThongTinPhong(string so_phong, string so_giuong, string loai_phong, string trang_thai_phong)
        {
            string query = CauTruyVan.truyVanThongTinPhong(so_phong, so_giuong, loai_phong, trang_thai_phong);
            DanhSachPhong danhSachPhong = new DanhSachPhong();
            danhSachPhong.Query = query;
            danhSachPhong.LayDanhSachPhong();
            return danhSachPhong.DanhSachPhongs;
        }
        public static List<DonDatPhong> timKiemThongTinDonDatPhong(string so_dien_thoai)
        {
            string query = CauTruyVan.truyVanThongTinDonDatPhong(so_dien_thoai);
            DanhSachDonDatPhong danhSachDonDatPhong = new DanhSachDonDatPhong();
            danhSachDonDatPhong.Query = query;
            danhSachDonDatPhong.LayDanhSachDonDatPhong();
            return danhSachDonDatPhong.DanhSachDonDatPhongs;
        }
        public static void nhanPhong (string ID_don_dat_phong)
        {
            if (ID_don_dat_phong == "")
            {
                MessageBox.Show("Vui lòng chọn đơn đặt phòng!");
                return;
            }
            else 
            {
                string query = "update don_dat_phong set trang_thai_don = 'Đã nhận phòng' where id_don_dat_phong = " + Convert.ToString(ID_don_dat_phong);
                ThaoTacVoiSQL.cap_nhat_du_lieu(query);
                MessageBox.Show("Nhận phòng thành công!");
            }
        }
    }
}
