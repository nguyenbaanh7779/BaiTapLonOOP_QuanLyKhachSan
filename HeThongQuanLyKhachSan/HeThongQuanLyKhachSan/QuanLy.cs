using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
        private string tai_khoan = "";
        private string mat_khau = "";
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
        public string Tai_Khoan
        {
            get { return tai_khoan; }
            set { tai_khoan = value; }
        }
        public string Mat_Khau
        {
            get { return mat_khau; }
            set { mat_khau = value; }
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
        public DataSet timKiemNhanVien(string so_dien_thoai)
        {
            string truy_van = "";
            if (so_dien_thoai == "")
            {
                truy_van = "select * from nhan_vien";
                ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
                thaoTacVoiSQL.Truy_van = truy_van;
                return thaoTacVoiSQL.layDuLieuChoGridView();
            }
            else
            {
                truy_van = "select * from nhan_vien where ";
                truy_van += "so_dien_thoai = '" + so_dien_thoai + "'";
                ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
                thaoTacVoiSQL.Truy_van = truy_van;
                return thaoTacVoiSQL.layDuLieuChoGridView();
            }
        }
        public void capNhatNhanVien(string ID_nhan_vien, string ho_ten, string so_can_cuoc_cong_dan, string so_dien_thoai, string gioi_tinh, string ngay_sinh, string tien_luong, string bo_phan, string mat_khau)
        {
            string tai_khoan = so_dien_thoai;
            string truy_van = "update nhan_vien set ho_ten = '" + ho_ten + "', so_can_cuoc_cong_dan = '" + so_can_cuoc_cong_dan + "', so_dien_thoai = '" + so_dien_thoai + "', gioi_tinh = '" + gioi_tinh + "', ngay_sinh = '" + ngay_sinh + "', tien_luong = " + tien_luong + ", bo_phan = '" + bo_phan + "', tai_khoan = '" + tai_khoan + "', mat_khau = '" + mat_khau + "' where ID_nhan_vien = " + ID_nhan_vien;
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            thaoTacVoiSQL.capNhatDuLieu();
            MessageBox.Show("Cập nhật nhân viên thành công!");
        }
        public void themPhong(string so_phong, string so_giuong, string loai_phong, string don_gia)
        {
            string trang_thai_phong = "Trống";
            string truy_van = "insert into phong(so_phong, so_giuong, loai_phong, don_gia, trang_thai_phong) values('" + so_phong + "', '" + so_giuong + "', '" + loai_phong + "', " + don_gia + ", '" + trang_thai_phong + "')";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            thaoTacVoiSQL.capNhatDuLieu();
            MessageBox.Show("Thêm phòng thành công!");
        }
        public DataSet timKiemPhong(string so_phong)
        {
            string truy_van = "";
            if (so_phong == "")
            {
                truy_van = "select ID_phong, so_phong, so_giuong, loai_phong, don_gia from phong";
                ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
                thaoTacVoiSQL.Truy_van = truy_van;
                return thaoTacVoiSQL.layDuLieuChoGridView();
            }
            else
            {
                truy_van = "select ID_phong, so_phong, so_giuong, loai_phong, don_gia from phong where ";
                truy_van += "so_phong = '" + so_phong + "'";
                ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
                thaoTacVoiSQL.Truy_van = truy_van;
                return thaoTacVoiSQL.layDuLieuChoGridView();
            }
        }
        public void capNhatPhong(string ID_phong, string so_phong, string so_giuong, string loai_phong, string don_gia)
        {
            string truy_van = "update phong set so_phong = '" + so_phong + "', so_giuong = '" + so_giuong + "', loai_phong = '" + loai_phong + "', don_gia = " + don_gia + " where ID_phong = " + ID_phong;
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            thaoTacVoiSQL.capNhatDuLieu();
            MessageBox.Show("Cập nhật phòng thành công!");
        }
        public void doiMatKhau(string matKhauCu, string MatKhauMoi, string NhapLaiMatKhau)
        {
            // thực hiện chức năng đổi mật khẩu
            if (matKhauCu == this.mat_khau)
            {
                if (MatKhauMoi == NhapLaiMatKhau)
                {
                    string truy_van = "update nhan_vien set mat_khau = '" + MatKhauMoi + "' where ID_nhan_vien = " + Convert.ToString(this.ID_nhan_vien);
                    ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
                    thaoTacVoiSQL.Truy_van = truy_van;
                    thaoTacVoiSQL.capNhatDuLieu();
                    MessageBox.Show("Đổi mật khẩu thành công!");
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không khớp!");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng!");
            }
        }
        public string tinhDoanhThu(string ngayBatDau, string ngayKetThuc)
        {
            long tong_tien = 0;
            string truy_van = "select ID_don_dat_phong from don_dat_phong join hoa_don on don_dat_phong.ID_don_dat_phong = hoa_don.ID_don_dat_phong where ngay_thanh_toan >= '" + ngayBatDau + "' and ngay_thanh_toan <= '" + ngayKetThuc + "'";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            MySqlDataReader reader = thaoTacVoiSQL.layDuLieuChoClass();
            if (reader.Read())
            {
                do
                {
                    DonDatPhong donDatPhong = new DonDatPhong(Convert.ToString(reader.GetInt32("ID_don_dat_phong")));
                    tong_tien += donDatPhong.Tong_tien_phong;
                } 
                while (reader.Read());
                return Convert.ToString(tong_tien);
            }
            else
            {
            return "0";
            }
        }
        public string tinhSoDonDatPhong(string ngayBatDau, string ngayKetThuc)
        {
            string truy_van = "select count(ID_hoa_don) as so_don_dat_phong from hoa_don where ngay_thanh_toan >= '" + ngayBatDau + "' and ngay_thanh_toan <= '" + ngayKetThuc + "'";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            MySqlDataReader reader = thaoTacVoiSQL.layDuLieuChoClass();
            if (reader.Read())
            {
                return Convert.ToString(reader.GetInt32("so_don_dat_phong"));
            }
            else
            {
                return "0";
            }
        }
        public string tinhSoDonBiHuy(string ngayBatDau, string ngayKetThuc)
        {
            string truy_van = "select count(ID_don_dat_phong) as so_don_dat_phong from don_dat_phong where ngay_nhan_phong >= '" + ngayBatDau + "' and ngay_nhan_phong <= '" + ngayKetThuc + "' and trang_thai_don = 'Đã hủy'";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            MySqlDataReader reader = thaoTacVoiSQL.layDuLieuChoClass();
            if (reader.Read())
            {
                return Convert.ToString(reader.GetInt32("so_don_dat_phong"));
            }
            else
            {
                return "0";
            }
        }
        public DataSet hienThiThuTuPhongTheoDonDatPhong(string ngayBatDau, string ngayKetThuc)
        {
            string truy_van = "select ID_phong, so_phong, count(ID_Don_dat_phong) as so_don_dat_phong from phong join chi_tiet_don_dat_phong on phong.ID_phong = chi_tiet_don_dat_phong.ID_phong join don_dat_phong on chi_tiet_don_dat_phong.ID_don_dat_phong = don_dat_phong.ID_don_dat_phong where ngay_nhan_phong >= '" + ngayBatDau + "' and ngay_nhan_phong <= '" + ngayKetThuc + "' and trang_thai_don = 'Đã thanh toán' group by ID_phong order by so_don_dat_phong desc";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            return thaoTacVoiSQL.layDuLieuChoGridView();
        }
        public DataSet xepHangKhachHangTheoSoLanDatPhong(string ngayBatDau, string ngayKetThuc)
        {
            string truy_van = "select ho_ten, so_dien_thoai, count(ID_don_dat_phong) as so_lan_dat_phong from khach_hang join don_dat_phong on khach_hang.ID_khach_hang = don_dat_phong.ID_khach_hang where ngay_nhan_phong >= '" + ngayBatDau + "' and ngay_nhan_phong <= '" + ngayKetThuc + "' and trang_thai_don = 'Đã thanh toán' group by ID_khach_hang order by so_lan_dat_phong desc";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            return thaoTacVoiSQL.layDuLieuChoGridView();
        }
    }
}
