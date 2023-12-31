using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKhachSan
{
    internal class HoaDon
    {
        private int ID_hoa_don;
        private DonDatPhong don_dat_phong = new DonDatPhong("-1");
        private LeTan le_tan = new LeTan("-1");
        private DateTime ngay_thanh_toan = DateTime.Now;
        private string trang_thai_hoa_don = "";
        public int ID_Hoa_Don
        {
            get { return ID_hoa_don; }
            set { ID_hoa_don = value; }
        }
        public DonDatPhong Don_Dat_Phong
        {
            get { return don_dat_phong; }
            set { don_dat_phong = value; }
        }
        public LeTan Le_Tan
        {
            get { return le_tan; }
            set { le_tan = value; }
        }
        public DateTime Ngay_Thanh_Toan
        {
            get { return ngay_thanh_toan; }
            set { ngay_thanh_toan = value; }
        }
        public string Trang_Thai_Hoa_Don
        {
            get { return trang_thai_hoa_don; }
            set { trang_thai_hoa_don = value; }
        }
        public HoaDon(string ID_hoa_don)
        {
            this.ID_hoa_don = Convert.ToInt32(ID_hoa_don);
            string truy_van = "select ID_don_dat_phong, ID_le_tan, ngay_thanh_toan from hoa_don where ID_hoa_don = " + ID_hoa_don;
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            MySqlDataReader reader = thaoTacVoiSQL.layDuLieuChoClass();
            if (reader.Read())
            {
                this.don_dat_phong = new DonDatPhong(reader.GetString("ID_don_dat_phong"));
                this.le_tan = new LeTan(reader.GetString("ID_le_tan"));
                this.ngay_thanh_toan = reader.GetDateTime("ngay_thanh_toan");
            }
        }
        public DataSet hienThiThongTinPhong()
        {
            string truy_van = "select so_phong, ngay_nhan_phong - ngay_tra_phong as so_ngay_thue, so_ngay_thue * don_gia as thanh_tien from don_dat_phong join chi_tiet_don_dat_phong on don_dat_phong.ID_don_dat_phong = chi_tiet_don_dat_phong.ID_don_dat_phong join phong on chi_tiet_don_dat_phong.ID_phong = phong.ID_phong where don_dat_phong.ID_don_dat_phong = " + this.don_dat_phong.ID_Don_Dat_Phong;
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            return thaoTacVoiSQL.layDuLieuChoGridView();
        }
    }
}
