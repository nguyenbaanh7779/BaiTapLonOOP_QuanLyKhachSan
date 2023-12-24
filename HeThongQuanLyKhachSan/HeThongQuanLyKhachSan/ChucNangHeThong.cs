using MySql.Data.MySqlClient;
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
        private static string ID_nhan_vien = "";
        public static string ID_Nhan_vien
        {
            get { return ID_nhan_vien; }
            set { ID_nhan_vien = value; }
        }
        private static LeTan leTan = new LeTan();
        public static bool dangNhap(string tai_khoan, string mat_khau)
        {
            string truy_van = "select ID_nhan_vien, bo_phan from nhan_vien where tai_khoan = '" + tai_khoan + "' and mat_khau = '" + mat_khau + "'";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            MySqlDataReader reader = thaoTacVoiSQL.layDuLieuChoClass();
            if (reader.Read())
            {
                ID_Nhan_vien = reader.GetString("ID_nhan_vien");
                if (reader.GetString("bo_phan") == "Lễ tân")
                {
                    FormLeTan formLeTan = new FormLeTan();
                    formLeTan.Show();
                }
                else
                {
                    FormQuanLy formQuanLy = new FormQuanLy();
                    formQuanLy.Show();
                }
                return true;
            }
            else
            {
                return false;
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
        public static DataSet timKiemThongTinDonDatPhong(string so_dien_thoai = "")
        {
            string truy_van = "";
            if (so_dien_thoai == "")
                truy_van = "select ID_don_dat_phong, so_phong, ho_ten, so_can_cuoc_cong_dan, so_dien_thoai, ngay_nhan_phong, ngay_tra_phong, trang_thai_don from don_dat_phong inner join khach_hang on don_dat_phong.ID_khach_hang = khach_hang.ID_khach_hang inner join phong on don_dat_phong.ID_phong = phong.ID_phong where trang_thai_don = 'Đã đặt phòng'";
            else
            {
                truy_van = "select ID_don_dat_phong, so_phong, ho_ten, so_can_cuoc_cong_dan, so_dien_thoai, ngay_nhan_phong, ngay_tra_phong, trang_thai_don from don_dat_phong inner join khach_hang on don_dat_phong.ID_khach_hang = khach_hang.ID_khach_hang inner join phong on don_dat_phong.ID_phong = phong.ID_phong where trang_thai_don = 'Đã đặt phòng' and " + "so_dien_thoai = '" + so_dien_thoai + "'";
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
        public static void themPhong(string so_phong, string so_giuong, string loai_phong, long don_gia)
        {
            string truy_van = "insert into phong(so_phong, so_giuong, loai_phong, don_gia, trang_thai_phong) values('" + so_phong + "', '" + so_giuong + "', '" + loai_phong + "', " + don_gia + ", 'Trống')";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            thaoTacVoiSQL.capNhatDuLieu();
            MessageBox.Show("Thêm phòng thành công!");
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
}
