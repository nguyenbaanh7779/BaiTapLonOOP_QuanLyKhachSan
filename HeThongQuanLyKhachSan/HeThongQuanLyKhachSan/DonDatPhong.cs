using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKhachSan
{
    internal class DonDatPhong
    {
        private int ID_don_dat_phong;
        private List<Phong> danh_sach_phong = new List<Phong>();
        private KhachHang khach_hang = new KhachHang("-1");
        private DateTime ngay_nhan_phong = DateTime.Now;
        private DateTime ngay_tra_phong = DateTime.Now;
        private string so_dien_thoai = "";
        private int so_ngay_thue = 0;
        private long tong_tien_phong = 0;
        private string trang_thai_don = "";
        public int ID_Don_Dat_Phong
        {
            get { return ID_don_dat_phong; }
            set { ID_don_dat_phong = value; }
        }
        public List<Phong> Danh_Sach_Phong
        {
            get { return danh_sach_phong; }
            set { danh_sach_phong = value; }
        }
        public KhachHang Khach_Hang
        {
            get { return khach_hang; }
            set { khach_hang = value; }
        }
        public DateTime Ngay_Nhan_Phong
        {
            get { return ngay_nhan_phong; }
            set { ngay_nhan_phong = value; }
        }
        public DateTime Ngay_Tra_Phong
        {
            get { return ngay_tra_phong; }
            set { ngay_tra_phong = value; }
        }
        public string So_Dien_Thoai
        {
            get { return so_dien_thoai; }
            set { so_dien_thoai = value; }
        }
        public string Trang_Thai_Don
        {
            get { return trang_thai_don; }
            set { trang_thai_don = value; }
        }
        public int So_Ngay_Thue
        {
            get { return so_ngay_thue; }
            set { so_ngay_thue = value; }
        }
        public long Tong_tien_phong
        {
            get { return tong_tien_phong; }
            set { tong_tien_phong = value; }
        }
        public DonDatPhong(string ID_don_dat_phong)
        {
            this.ID_don_dat_phong = Convert.ToInt32(ID_don_dat_phong);
            string truy_van = "select don_dat_phong.ID_khach_hang, chi_tiet_don_dat_phong.ID_phong, ngay_nhan_phong, ngay_tra_phong, so_dien_thoai, trang_thai_don from don_dat_phong join chi_tiet_don_dat_phong on don_dat_phong.ID_don_dat_phong = chi_tiet_don_dat_phong.ID_don_dat_phong where don_dat_phong.ID_don_dat_phong = " + ID_don_dat_phong;
            MessageBox.Show(truy_van);
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            MySqlDataReader result = thaoTacVoiSQL.layDuLieuChoClass();
            if (result.Read())
            {
                this.khach_hang = new KhachHang(result.GetString("ID_khach_hang"));
                this.ngay_nhan_phong = result.GetDateTime("ngay_nhan_phong");
                this.ngay_tra_phong = result.GetDateTime("ngay_tra_phong");
                this.so_dien_thoai = result.GetString("so_dien_thoai");
                this.trang_thai_don = result.GetString("trang_thai_don");
                do
                {
                    this.danh_sach_phong.Add(new Phong(result.GetInt32("ID_phong")));
                } 
                while (result.Read());
            }
            this.so_ngay_thue = (int)(this.ngay_tra_phong - this.ngay_nhan_phong).TotalDays;
            foreach (Phong phong in this.danh_sach_phong)
            {
                this.tong_tien_phong += phong.Don_Gia * this.so_ngay_thue;
            }
        }
        public DataSet hienThiPhongDaDat()
        {
            string truy_van = "select ID_phong, so_phong, so_giuong, loai_phong, don_gia from phong where ID_phong in (";
            foreach (Phong phong in this.danh_sach_phong)
            {
                truy_van += Convert.ToString(phong.ID_Phong) + ", ";
            }
            truy_van = truy_van.Substring(0, truy_van.Length - 2);
            truy_van += ")";
            MessageBox.Show(truy_van);
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            return thaoTacVoiSQL.layDuLieuChoGridView();
        }
    }
}
