using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.Field;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKhachSan
{
    internal class ChucNangHeThong
    {
        private static DonDatPhong donDatPhong = new DonDatPhong("-1");
        public static DonDatPhong GSDonDatPhong // get set DonDatPhong
        {
            get { return donDatPhong; }
            set { donDatPhong = value; }
        }
        private static HoaDon hoaDon = new HoaDon("-1");
        public static HoaDon GSHoaDon // get set HoaDon
        {
            get { return hoaDon; }
            set { hoaDon = value; }
        }
        private static LeTan leTan = new LeTan("-1");
        public static LeTan GSLeTan // get set LeTan
        {
            get { return leTan; }
            set { leTan = value; }
        }
        private static QuanLy quanLy = new QuanLy("-1");
        public static QuanLy GSQuanLy // get set QuanLy
        {
            get { return quanLy; }
            set { quanLy = value; }
        }
        public static void capNhatDuLieuDB()
        {
            // cập nhật trạng thái của phòng: nếu như đến ngày nhận phòng mà chưa nhận thì trạng thái của đơn đặt phòng sẽ chuyển sang đã hủy
            DateTime ngay_hien_tai = DateTime.Now;
            string truy_van = "select * from don_dat_phong where trang_thai_don = 'Đã đặt phòng'";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            MySqlDataReader reader = thaoTacVoiSQL.layDuLieuChoClass();
            while (reader.Read())
            {
                DateTime ngay_nhan_phong = reader.GetDateTime("ngay_nhan_phong");
                if (ngay_hien_tai > ngay_nhan_phong)
                {
                    string ID_don_dat_phong = reader.GetString("ID_don_dat_phong");
                    string truy_van_cap_nhat = "update don_dat_phong set trang_thai_don = 'Đã hủy' where ID_don_dat_phong = " + ID_don_dat_phong;
                    ThaoTacVoiSQL thaoTacVoiSQL_cap_nhat = new ThaoTacVoiSQL();
                    thaoTacVoiSQL_cap_nhat.Truy_van = truy_van_cap_nhat;
                    thaoTacVoiSQL_cap_nhat.capNhatDuLieu();
                    truy_van_cap_nhat = "select ID_phong, trang_thai_phong from don_dat_phong join chi_tiet_don_dat_phong using(ID_don_dat_phong) join phong using(ID_phong) where ID_don_dat_phong = " + ID_don_dat_phong;
                    thaoTacVoiSQL_cap_nhat.Truy_van = truy_van_cap_nhat;
                    MySqlDataReader reader_cap_nhat = thaoTacVoiSQL_cap_nhat.layDuLieuChoClass();
                    while (reader_cap_nhat.Read())
                    {
                        string ID_phong = reader_cap_nhat.GetString("ID_phong");
                        string trang_thai_phong = reader_cap_nhat.GetString("trang_thai_phong");
                        if (trang_thai_phong == "Đã đặt")
                        {
                            truy_van_cap_nhat = "update phong set trang_thai_phong = 'Trống' where ID_phong = " + ID_phong;
                            thaoTacVoiSQL_cap_nhat.Truy_van = truy_van_cap_nhat;
                            thaoTacVoiSQL_cap_nhat.capNhatDuLieu();
                        }
                    }
                }
            }
        }
        public static string dangNhap(string tai_khoan, string mat_khau)
        {
            // dùng để thực hiện chức năng đăng nhập, trả về chuỗi là bộ phận của nhân viên
            string truy_van = "select ID_nhan_vien, bo_phan from nhan_vien where tai_khoan = '" + tai_khoan + "' and mat_khau = '" + mat_khau + "'";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            MySqlDataReader reader = thaoTacVoiSQL.layDuLieuChoClass();
            if (reader.Read())
            {
                string ID_nhan_vien = reader.GetString("ID_nhan_vien");
                string bo_phan = reader.GetString("bo_phan");
                if (bo_phan == "Lễ tân")
                {
                    GSLeTan = new LeTan(ID_nhan_vien);
                }
                else
                {
                    GSQuanLy = new QuanLy(ID_nhan_vien);
                }
                capNhatDuLieuDB();
                return bo_phan;
            }
            else
            {
                return "";
            }
        }
        public static DataSet timKiemThongTinPhong(string so_phong = "", string so_giuong = "", string loai_phong = "", string trang_thai = "")
        {
            string truy_van = "";
            if (so_phong == "" && so_giuong == "" && loai_phong == "" && trang_thai == "")
                truy_van = "select so_phong, so_giuong, loai_phong, don_gia, trang_thai_phong from phong";
            else
            {
                truy_van = "select so_phong, so_giuong, loai_phong, don_gia, trang_thai_phong from phong where ";
                if (so_phong != "")
                {
                    truy_van += "so_phong = '" + so_phong + "'";
                }
                if (so_giuong != "")
                {
                    truy_van += " and  so_giuong = '" + so_giuong + "'";
                }
                if (loai_phong != "")
                {
                    truy_van += " and loai_phong = '" + loai_phong + "'";
                }
                if (trang_thai != "")
                {
                    truy_van += "  and trang_thai_phong = '" + trang_thai + "'";
                }
            }
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            return thaoTacVoiSQL.layDuLieuChoGridView();
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
                ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
                thaoTacVoiSQL.Truy_van = query;
                thaoTacVoiSQL.capNhatDuLieu();
                MessageBox.Show("Nhận phòng thành công!");
            }
        }
        public static void themNhanVien(string ho_ten, string so_can_cuoc_cong_dan, string so_dien_thoai, string gioi_tinh, DateTime ngay_sinh, long tien_luong, string bo_phan, string tai_khoan, string mat_khau)
        {
            string truy_van = "insert into le_tan(ho_ten, so_can_cuoc_cong_dan, so_dien_thoai, gioi_tinh, ngay_sinh, tien_luong, bo_phan, tai_khoan, mat_khau) values('" + ho_ten + "', '" + so_can_cuoc_cong_dan + "', '" + so_dien_thoai + "', '" + gioi_tinh + "', '" + ngay_sinh.ToString("yyyy-MM-dd") + "', " + tien_luong + ", '" + bo_phan + ", '" + tai_khoan + "', '" + mat_khau + "')";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            thaoTacVoiSQL.capNhatDuLieu();
            MessageBox.Show("Thêm nhân viên thành công!");
        }
    }

    internal class MySqlAttributeReader
    {
    }

}
