using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKhachSan
{
    internal class CauTruyVan
    {
        public static string truyVanThongTinPhong(string so_phong, string so_giuong, string loai_phong, string trang_thai) 
        {
            if (so_phong == "" && so_giuong == "" && loai_phong == "" && trang_thai == "")
                return "select so_phong, so_giuong, loai_phong, don_gia, trang_thai_phong from phong";
            else
            {
                string truyVan = "select so_phong, so_giuong, loai_phong, don_gia, trang_thai_phong from phong where ";
                if (so_phong != "")
                {
                    truyVan += "so_phong = '" + so_phong + "'";
                }
                if (so_giuong != "")
                {
                    truyVan += " and  so_giuong = '" + so_giuong + "'";
                }
                if (loai_phong != "")
                {
                    truyVan += " and loai_phong = '" + loai_phong + "'";
                }
                if (trang_thai != "")
                {
                    truyVan += "  and trang_thai_phong = '" + trang_thai + "'";
                }
                return truyVan;
            }
        }
        public static string truyVanThongTinDonDatPhong(string so_dien_thoai)
        {
            if (so_dien_thoai == "")
                return "select ID_don_dat_phong, so_phong, ho_ten, so_can_cuoc_cong_dan, so_dien_thoai, ngay_nhan_phong, ngay_tra_phong, trang_thai_don from don_dat_phong inner join khach_hang on don_dat_phong.ID_khach_hang = khach_hang.ID_khach_hang inner join phong on don_dat_phong.ID_phong = phong.ID_phong where trang_thai_don = 'Đã đặt phòng'";
            else
            {
                string truyVan = "select ID_don_dat_phong, so_phong, ho_ten, so_can_cuoc_cong_dan, so_dien_thoai, ngay_nhan_phong, ngay_tra_phong, trang_thai_don from don_dat_phong inner join khach_hang on don_dat_phong.ID_khach_hang = khach_hang.ID_khach_hang inner join phong on don_dat_phong.ID_phong = phong.ID_phong where trang_thai_don = 'Đã đặt phòng' and " + "so_dien_thoai = '" + so_dien_thoai + "'";
                return truyVan;
            }
        }
    }
}
