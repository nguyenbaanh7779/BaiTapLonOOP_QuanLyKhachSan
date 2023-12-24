using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKhachSan
{
    internal class LeTan
    {
        private int ID_nhan_vien;
        private string ho_ten = "";
        private string so_can_cuoc_cong_dan = "";
        private string so_dien_thoai = "";
        private string gioi_tinh = "";
        private DateTime ngay_sinh = new DateTime();
        private long tien_luong;
        public int ID_Nhan_vien
        {
            get { return ID_nhan_vien; }
            set { ID_nhan_vien = value; }
        }
        public string Ho_Ten
        {
            get { return ho_ten; }
            set { ho_ten = value; }
        }
        public string So_Can_Cuoc_Cong_Dan
        {
            get { return so_can_cuoc_cong_dan; }
            set { so_can_cuoc_cong_dan = value; }
        }
        public string So_Dien_Thoai
        {
            get { return so_dien_thoai; }
            set { so_dien_thoai = value; }
        }
        public string Gioi_Tinh
        {
            get { return gioi_tinh; }
            set { gioi_tinh = value; }
        }
        public DateTime Ngay_Sinh
        {
            get { return ngay_sinh; }
            set { ngay_sinh = value; }
        }
        public long Tien_Luong
        {
            get { return tien_luong; }
            set { tien_luong = value; }
        }
        public LeTan()
        {

        }
        public LeTan(string ID_nhan_vien)
        {
            this.ID_Nhan_vien = Convert.ToInt32(ID_nhan_vien);
            string query = "select * from le_tan where ID_nhan_vien = " + ID_nhan_vien;
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = query;
            MySqlDataReader reader = thaoTacVoiSQL.layDuLieuChoClass();
            if (reader.Read())
            {
                this.ho_ten = reader.GetString("ho_ten");
                this.so_can_cuoc_cong_dan = reader.GetString("so_can_cuoc_cong_dan");
                this.so_dien_thoai = reader.GetString("so_dien_thoai");
                this.gioi_tinh = reader.GetString("gioi_tinh");
                this.ngay_sinh = reader.GetDateTime("ngay_sinh");
                this.tien_luong = reader.GetInt64("tien_luong");
            }
        }
        public void themKhachHang(string ho_ten, string so_can_cuoc_cong_dan)
        {
            string truy_van = "insert into khach_hang(ho_ten, so_can_cuoc_cong_dan) values('" + ho_ten + "', '" + so_can_cuoc_cong_dan + "')";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            thaoTacVoiSQL.capNhatDuLieu();
        }
        public void taoDonDatPhong(string ID_phong, string ho_ten, string so_can_cuoc_cong_dan, string ngay_nhan_phong, string ngay_tra_phong, string so_dien_thoai)
        {
            string truy_van = "select ID_khach_hang from khach_hang where so_can_cuoc_cong_dan = '" + so_can_cuoc_cong_dan + "' and ho_ten = '" + ho_ten + "'";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            MySqlDataReader reader = thaoTacVoiSQL.layDuLieuChoClass();
            if (reader.Read())
            {
                string ID_khach_hang = reader.GetString("ID_khach_hang");
                truy_van = "insert into don_dat_phong(ID_phong, ID_khach_hang, ngay_nhan_phong, ngay_tra_phong, so_dien_thoai, trang_thai_don) values(" + ID_phong + ", " + ID_khach_hang + ", '" + ngay_nhan_phong + "', '" + ngay_tra_phong + "', '" + so_dien_thoai + "', 'Đã đặt phòng')";
                thaoTacVoiSQL.Truy_van = truy_van;
                thaoTacVoiSQL.capNhatDuLieu();
                MessageBox.Show("Đặt phòng thành công!");
            }
            else
            {
                themKhachHang(ho_ten, so_can_cuoc_cong_dan);
                taoDonDatPhong(ID_phong, ho_ten, so_can_cuoc_cong_dan, ngay_nhan_phong, ngay_tra_phong, so_dien_thoai);
            }
        }
    }
}
