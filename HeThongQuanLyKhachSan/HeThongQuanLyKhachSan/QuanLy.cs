using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKhachSan
{
    internal class QuanLy
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
        public QuanLy()
        {

        }
        public QuanLy(string ID_nhan_vien)
        {
            this.ID_Nhan_vien = Convert.ToInt32(ID_nhan_vien);
            string query = "select * from nhan_vien where ID_nhan_vien = " + ID_nhan_vien;
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
        public void themNhanVien(string ho_ten, string so_can_cuoc_cong_dan, string so_dien_thoai, string gioi_tinh, string ngay_sinh, string tien_luong, string bo_phan)
        {
            string tai_khoan = so_dien_thoai;
            string mat_khau = so_can_cuoc_cong_dan;
            string truy_van = "insert into nhan_vien(ho_ten, so_can_cuoc_cong_dan, so_dien_thoai, gioi_tinh, ngay_sinh, tien_luong, bo_phan, tai_khoan, mat_khau) values('" + ho_ten + "', '" + so_can_cuoc_cong_dan + "', '" + so_dien_thoai + "', '" + gioi_tinh + "', '" + ngay_sinh + "', " + tien_luong + ", '" + bo_phan + "', '" + tai_khoan + "', '" + mat_khau + "')";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            thaoTacVoiSQL.capNhatDuLieu();
            MessageBox.Show("Thêm nhân viên thành công!");
        }
    }
}
