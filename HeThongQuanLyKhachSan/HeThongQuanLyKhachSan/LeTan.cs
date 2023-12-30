using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
        public DataSet timKiemThongTinPhong(string so_phong = "", string so_giuong = "", string loai_phong = "", string trang_thai = "")
        {
            // tìm kiếm thông tin phòng theo các tiêu chí số phòng, số giường, loại phòng, trạng thái phòng
            string truy_van = "";
            if (so_phong == "" && so_giuong == "" && loai_phong == "" && trang_thai == "")
                truy_van = "select ID_phong, so_phong, so_giuong, loai_phong, don_gia from phong";
            else
            {
                truy_van = "select ID_phong, so_phong, so_giuong, loai_phong, don_gia from phong where ";
                if (so_phong != "")
                {
                    truy_van += "so_phong = '" + so_phong + "' and ";
                }
                if (so_giuong != "")
                {
                    truy_van += "so_giuong = '" + so_giuong + "' and ";
                }
                if (loai_phong != "")
                {
                    truy_van += "loai_phong = '" + loai_phong + "' and ";
                }
                if (trang_thai != "")
                {
                    truy_van += "trang_thai_phong = '" + trang_thai + "' and ";
                }
                truy_van = truy_van.Remove(truy_van.Length - 4); // xóa dấu and và dấu cách cuối cùng
            }
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            return thaoTacVoiSQL.layDuLieuChoGridView();
        }
        public DataSet hienThiPhongDaThem(List<int> ID_phong)
        {
            string truy_van = "";
            // lấy thông tin phòng từ ID_phong để hiển thị lên datagridview của phòng đã chọn trong form đặt phòng
            if (ID_phong.Count == 0)
            {
                truy_van = "select ID_phong, so_phong, so_giuong, loai_phong, don_gia from phong where ID_phong = -1";
            }
            else
            {
                truy_van = "select ID_phong, so_phong, so_giuong, loai_phong, don_gia from phong where ID_phong IN (";
            foreach (int ID in ID_phong)
            {
                truy_van += Convert.ToString(ID) + ", ";
            }
            truy_van = truy_van.Remove(truy_van.Length - 2); // xóa dấu , và dấu cách cuối cùng
            truy_van += ")";
            }
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            return thaoTacVoiSQL.layDuLieuChoGridView();
        }
        public void themKhachHang(string ho_ten, string so_can_cuoc_cong_dan)
        {
            // thêm khách hàng vào csdl
            string truy_van = "insert into khach_hang(ho_ten, so_can_cuoc_cong_dan) values('" + ho_ten + "', '" + so_can_cuoc_cong_dan + "')";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            thaoTacVoiSQL.capNhatDuLieu();
        }
        public void taoDonDatPhong(string ho_ten, string so_can_cuoc_cong_dan, string so_dien_thoai, string ngay_nhan_phong, string ngay_tra_phong)
        {
            // tạo đơn đặt phòng
            string truy_van = "select ID_khach_hang from khach_hang where so_can_cuoc_cong_dan = '" + so_can_cuoc_cong_dan + "' and ho_ten = '" + ho_ten + "'";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            MySqlDataReader reader = thaoTacVoiSQL.layDuLieuChoClass();
            if (reader.Read())
            {
                string ID_khach_hang = reader.GetString("ID_khach_hang");
                truy_van = "insert into don_dat_phong(ID_khach_hang, ngay_nhan_phong, ngay_tra_phong, so_dien_thoai, trang_thai_don) values("+ ID_khach_hang + ", '" + ngay_nhan_phong + "', '" + ngay_tra_phong + "', '" + so_dien_thoai + "', 'Đã đặt')";
                thaoTacVoiSQL.Truy_van = truy_van;
                thaoTacVoiSQL.capNhatDuLieu();
            }
            else
            {
                themKhachHang(ho_ten, so_can_cuoc_cong_dan);
                taoDonDatPhong(ho_ten, so_can_cuoc_cong_dan, so_dien_thoai, ngay_nhan_phong, ngay_tra_phong);
            }
        }
        public void datPhong (string ho_ten, string so_can_cuoc_cong_dan, string so_dien_thoai, string ngay_nhan_phong, string ngay_tra_phong, List<int> ID_phong) {
            // đặt phòng
            taoDonDatPhong(ho_ten, so_can_cuoc_cong_dan, so_dien_thoai, ngay_nhan_phong, ngay_tra_phong);
            string ID_khach_hang = "";
            string ID_don_dat_phong = "";
            string truy_van = "select ID_khach_hang from khach_hang where so_can_cuoc_cong_dan = '" + so_can_cuoc_cong_dan + "' and ho_ten = '" + ho_ten + "'";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            MySqlDataReader reader = thaoTacVoiSQL.layDuLieuChoClass();
            if (reader.Read())
            {
                ID_khach_hang = reader.GetString("ID_khach_hang");
            }
            truy_van = "select ID_don_dat_phong from don_dat_phong where ID_khach_hang = " + ID_khach_hang + " and ngay_nhan_phong = '" + ngay_nhan_phong + "' and ngay_tra_phong = '" + ngay_tra_phong + "' and so_dien_thoai = '" + so_dien_thoai + "' and trang_thai_don = 'Đã đặt'";
            thaoTacVoiSQL.Truy_van = truy_van;
            reader = thaoTacVoiSQL.layDuLieuChoClass();
            if (reader.Read())
            {
                ID_don_dat_phong = reader.GetString("ID_don_dat_phong");
            }
            foreach (int ID in ID_phong)
            {
                // thêm đơn dữ liệu cho chi tiết đơn đặt phòng
                truy_van = "insert into chi_tiet_don_dat_phong(ID_phong, ID_don_dat_phong) values(" + Convert.ToString(ID) + ", " + ID_don_dat_phong + ")";
                MessageBox.Show(truy_van);
                thaoTacVoiSQL.Truy_van = truy_van;
                thaoTacVoiSQL.capNhatDuLieu();
                // thay đổi trạng thái phòng
                truy_van = "update phong set trang_thai_phong = 'Đã đặt' where ID_phong = " + Convert.ToString(ID);
                thaoTacVoiSQL.Truy_van = truy_van;
                thaoTacVoiSQL.capNhatDuLieu();
            }
            MessageBox.Show("Đặt phòng thành công!");
        }
        public static DataSet timKiemThongTinDonDatPhong(string so_dien_thoai = "")
        {
            string truy_van = "";
            if (so_dien_thoai == "")
            {
                truy_van = "select ID_don_dat_phong, ho_ten, so_can_cuoc_cong_dan, so_dien_thoai, ngay_nhan_phong, ngay_tra_phong, COUNT(ID_phong) as so_luong_phong from khach_hang join don_dat_phong on khach_hang.ID_khach_hang = don_dat_phong.ID_khach_hang join chi_tiet_don_dat_phong on don_dat_phong.ID_don_dat_phong = chi_tiet_don_dat_phong.ID_don_dat_phong join phong on chi_tiet_don_dat_phong.ID_phong = phong.ID_phong group by ID_don_dat_phong";
            }
            else
            {
                truy_van = "select ID_don_dat_phong, ho_ten, so_can_cuoc_cong_dan, so_dien_thoai, ngay_nhan_phong, ngay_tra_phong, COUNT(ID_phong) as so_luong_phong from khach_hang join don_dat_phong on khach_hang.ID_khach_hang = don_dat_phong.ID_khach_hang join chi_tiet_don_dat_phong on don_dat_phong.ID_don_dat_phong = chi_tiet_don_dat_phong.ID_don_dat_phong join phong on chi_tiet_don_dat_phong.ID_phong = phong.ID_phong where so_dien_thoai = '" + so_dien_thoai + "' group by ID_don_dat_phong";
            }
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            return thaoTacVoiSQL.layDuLieuChoGridView();
        }
    }
}
