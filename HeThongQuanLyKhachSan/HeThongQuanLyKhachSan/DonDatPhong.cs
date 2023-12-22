using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKhachSan
{
    internal class DonDatPhong
    {
        private int ID_don_dat_phong;
        private string so_phong = "";
        private string ho_ten_khach_hang = "";
        private string so_can_cuoc_cong_dan = "";
        private string so_dien_thoai = "";
        private DateTime ngay_nhan_phong;
        private DateTime ngay_tra_phong;
        private string trang_thai_don_dat_phong = "";
        public int Id_Don_dat_phong
        {
            get { return ID_don_dat_phong; }
            set { ID_don_dat_phong = value; }
        }
        public string So_phong
        {
            get { return so_phong; }
            set { so_phong = value; }
        }
        public string Ho_ten_khach_hang
        {
            get { return ho_ten_khach_hang; }
            set { ho_ten_khach_hang = value; }
        }
        public string So_can_cuoc_cong_dan
        {
            get { return so_can_cuoc_cong_dan; }
            set { so_can_cuoc_cong_dan = value; }
        }
        public string So_dien_thoai
        {
            get { return so_dien_thoai; }
            set { so_dien_thoai = value; }
        }
        public DateTime Ngay_nhan_phong
        {
            get { return ngay_nhan_phong; }
            set { ngay_nhan_phong = value; }
        }
        public DateTime Ngay_tra_phong
        {
            get { return ngay_tra_phong; }
            set { ngay_tra_phong = value; }
        }
        public string Trang_thai_don_dat_phong
        {
            get { return trang_thai_don_dat_phong; }
            set { trang_thai_don_dat_phong = value; }
        }
        public DonDatPhong(int ID_don_dat_phong, string so_phong, string ho_ten_khach_hang, string so_can_cuoc_cong_dan, string so_dien_thoai, DateTime ngay_nhan_phong, DateTime ngay_tra_phong, string trang_thai_don_dat_phong)
        {
            Id_Don_dat_phong = ID_don_dat_phong;
            So_phong = so_phong;
            Ho_ten_khach_hang = ho_ten_khach_hang;
            So_can_cuoc_cong_dan = so_can_cuoc_cong_dan;
            So_dien_thoai = so_dien_thoai;
            Ngay_nhan_phong = ngay_nhan_phong;
            Ngay_tra_phong = ngay_tra_phong;
            Trang_thai_don_dat_phong = trang_thai_don_dat_phong;
        }
    }
}
