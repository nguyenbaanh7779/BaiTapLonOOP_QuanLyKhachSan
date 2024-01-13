using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HeThongQuanLyKhachSan
{
    internal class HoaDonDichVu
    {
        private int ID_hoa_don_dich_vu;
        private List<DichVu> danh_sach_dich_vu = new List<DichVu>();
        private List<int> danh_sach_so_luong = new List<int>();
        private LeTan leTan = new LeTan("-1");
        private KhachHang khachHang = new KhachHang("-1");
        private string so_dien_thoai = "";
        private DateTime ngay_lap = DateTime.Now;
        private long tong_tien = 0;
        public int ID_Hoa_Don_Dich_Vu
        {
            get { return ID_hoa_don_dich_vu; }
            set { ID_hoa_don_dich_vu = value; }
        }
        public List<DichVu> Danh_Sach_Dich_Vu
        {
            get { return danh_sach_dich_vu; }
            set { danh_sach_dich_vu = value; }
        }
        public LeTan Le_Tan
        {
            get { return leTan; }
            set { leTan = value; }
        }
        public KhachHang Khach_Hang
        {
            get { return khachHang; }
            set { khachHang = value; }
        }
        public string So_Dien_Thoai
        {
            get { return so_dien_thoai; }
            set { so_dien_thoai = value; }
        }
        public long Tong_Tien
        {
            get { return tong_tien; }
            set { tong_tien = value; }
        }
        public DateTime Ngay_Lap
        {
            get { return ngay_lap; }
            set { ngay_lap = value; }
        }
        public List<int> Danh_Sach_So_Luong
        {
            get { return danh_sach_so_luong; }
            set { danh_sach_so_luong = value; }
        }
        public HoaDonDichVu (int ID_hoa_don_dich_vu)
        {
            this.ID_hoa_don_dich_vu = ID_hoa_don_dich_vu;
            string truy_van = "select ID_nhan_vien, ID_khach_hang, hoa_don_dich_vu_chi_tiet.ID_dich_vu, so_luong, so_dien_thoai from hoa_don_dich_vu join hoa_don_dich_vu_chi_tiet on hoa_don_dich_vu.ID_hoa_don = hoa_don_dich_vu_chi_tiet.ID_hoa_don where hoa_don_dich_vu.ID_hoa_don_dich_vu = " + ID_hoa_don_dich_vu + "group by hoa_don_dich_vu_chi_tiet.ID_hoa_don";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            MySqlDataReader reader = thaoTacVoiSQL.layDuLieuChoClass();
            if (reader.Read())
            {
                so_dien_thoai = reader.GetString("so_dien_thoai");
                leTan = new LeTan(reader.GetString("ID_nhan_vien"));
                khachHang = new KhachHang(reader.GetString("ID_khach_hang"));
                do
                {
                    danh_sach_dich_vu.Add(new DichVu(reader.GetInt32("ID_dich_vu")));
                    danh_sach_so_luong.Add(reader.GetInt32("so_luong"));
                } while (reader.Read());
            }
        }
    }
}
