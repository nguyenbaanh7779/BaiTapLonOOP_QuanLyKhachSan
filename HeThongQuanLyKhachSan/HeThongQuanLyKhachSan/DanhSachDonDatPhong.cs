using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HeThongQuanLyKhachSan
{
    internal class DanhSachDonDatPhong
    {
        private string query = "select ID_don_dat_phong, so_phong, ho_ten, so_can_cuoc_cong_dan, so_dien_thoai, ngay_nhan_phong, ngay_tra_phong, trang_thai_don from don_dat_phong inner join khach_hang on don_dat_phong.ID_khach_hang = khach_hang.ID_khach_hang inner join phong on don_dat_phong.ID_phong = phong.ID_phong";
        public string Query
        {
            get { return query; }
            set { query = value; }
        }
        private List<DonDatPhong> danhSachDonDatPhongs = new List<DonDatPhong>();
        public List<DonDatPhong> DanhSachDonDatPhongs
        {
            get { return danhSachDonDatPhongs; }
            set { danhSachDonDatPhongs = value; }
        }
        public void LayDanhSachDonDatPhong()
        {
            MySqlDataReader dataReader = ThaoTacVoiSQL.layDuLieu(this.query);
            while (dataReader.Read())
            {
                int id_don_dat_phong = dataReader.GetInt32("ID_don_dat_phong");
                string so_phong = dataReader.GetString("so_phong");
                string ho_ten_khach_hang = dataReader.GetString("ho_ten");
                string so_can_cuoc_cong_dan = dataReader.GetString("so_can_cuoc_cong_dan");
                string so_dien_thoai = dataReader.GetString("so_dien_thoai");
                DateTime ngay_nhan_phong = dataReader.GetDateTime("ngay_nhan_phong");
                DateTime ngay_tra_phong = dataReader.GetDateTime("ngay_tra_phong");
                string trang_thai_don_dat_phong = dataReader.GetString("trang_thai_don");
                this.danhSachDonDatPhongs.Add(new DonDatPhong(id_don_dat_phong, so_phong, ho_ten_khach_hang, so_can_cuoc_cong_dan, so_dien_thoai, ngay_nhan_phong, ngay_tra_phong, trang_thai_don_dat_phong));
            }
        }
        
    }
}
