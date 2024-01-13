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
                this.tai_khoan = reader.GetString("tai_khoan");
                this.mat_khau = reader.GetString("mat_khau");
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
        public List<int> layDanhSachIDPhong(string so_phong = "", string so_giuong = "", string loai_phong = "", string trang_thai = "")
        {
            // lấy danh sách ID phòng từ ID đơn đặt phòng
            List<int> DS_ID_phong = new List<int>();
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
            MySqlDataReader reader = thaoTacVoiSQL.layDuLieuChoClass();
            while (reader.Read())
            {
                DS_ID_phong.Add(reader.GetInt32("ID_phong"));
            }
            return DS_ID_phong;
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
            string truy_van = "select ID_khach_hang, ho_ten from khach_hang where so_can_cuoc_cong_dan = '" + so_can_cuoc_cong_dan + "'";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            MySqlDataReader reader = thaoTacVoiSQL.layDuLieuChoClass();
            if (reader.Read())
            {
                if (ho_ten != reader.GetString("ho_ten"))
                {
                    MessageBox.Show("Số căn cước công dân không hợp lệ!");
                }
                else
                {
                    string ID_khach_hang = reader.GetString("ID_khach_hang");
                    truy_van = "insert into don_dat_phong(ID_khach_hang, ngay_nhan_phong, ngay_tra_phong, so_dien_thoai, trang_thai_don) values("+ ID_khach_hang + ", '" + ngay_nhan_phong + "', '" + ngay_tra_phong + "', '" + so_dien_thoai + "', 'Đã đặt')";
                    thaoTacVoiSQL.Truy_van = truy_van;
                    thaoTacVoiSQL.capNhatDuLieu();
                }
            }
            else
            {
                themKhachHang(ho_ten, so_can_cuoc_cong_dan);
                taoDonDatPhong(ho_ten, so_can_cuoc_cong_dan, so_dien_thoai, ngay_nhan_phong, ngay_tra_phong);
            }
        }
        public void datPhong (string ho_ten, string so_can_cuoc_cong_dan, string so_dien_thoai, DateTime ngay_nhan_phong, DateTime ngay_tra_phong, List<int> ID_phong) {
            // dùng để thực hiện chức năng đặt phòng
            if (ngay_nhan_phong >= DateTime.Now && ngay_tra_phong >= ngay_nhan_phong) // kiểm tra ngày nhận phòng và ngày trả phòng có hợp lệ hay không
            {
                string ngay_nhan_phong_string = ngay_nhan_phong.ToString("yyyy-MM-dd");
                string ngay_tra_phong_string = ngay_tra_phong.ToString("yyyy-MM-dd");
                taoDonDatPhong(ho_ten, so_can_cuoc_cong_dan, so_dien_thoai, ngay_nhan_phong_string, ngay_tra_phong_string);
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
                else
                {
                    return;
                }
                truy_van = "select ID_don_dat_phong from don_dat_phong where ID_khach_hang = " + ID_khach_hang + " and ngay_nhan_phong = '" + ngay_nhan_phong_string + "' and ngay_tra_phong = '" + ngay_tra_phong_string + "' and so_dien_thoai = '" + so_dien_thoai + "' and trang_thai_don = 'Đã đặt'";
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
                    thaoTacVoiSQL.Truy_van = truy_van;
                    thaoTacVoiSQL.capNhatDuLieu();
                    // thay đổi trạng thái phòng
                    truy_van = "update phong set trang_thai_phong = 'Đã đặt' where ID_phong = " + Convert.ToString(ID);
                    thaoTacVoiSQL.Truy_van = truy_van;
                    thaoTacVoiSQL.capNhatDuLieu();
                }
                MessageBox.Show("Đặt phòng thành công!");
            }
            else if (ngay_nhan_phong < DateTime.Now)
            {
                MessageBox.Show("Ngày nhận phòng phải sau hơn ngày hiện tại!");
            }
            else if (ngay_tra_phong < ngay_nhan_phong)
            {
                MessageBox.Show("Ngày trả phòng phải sau hơn ngày nhận phòng!");
            }
        }
        public DataSet timKiemThongTinDonDatPhong(string text_tim_kiem, string loai_tim_kiem, List<string> DS_trang_thai_don)
        {
            string truy_van = "";
            if (DS_trang_thai_don.Count != 0)
            {
                if (text_tim_kiem == "")
                {
                    truy_van = "select chi_tiet_don_dat_phong.ID_don_dat_phong, ho_ten, so_can_cuoc_cong_dan, so_dien_thoai, ngay_nhan_phong, ngay_tra_phong, COUNT(chi_tiet_don_dat_phong.ID_phong) as so_luong_phong, trang_thai_don from khach_hang join don_dat_phong on khach_hang.ID_khach_hang = don_dat_phong.ID_khach_hang join chi_tiet_don_dat_phong on don_dat_phong.ID_don_dat_phong = chi_tiet_don_dat_phong.ID_don_dat_phong join phong on chi_tiet_don_dat_phong.ID_phong = phong.ID_phong where don_dat_phong.trang_thai_don IN (";
                    foreach (string trang_thai_don in DS_trang_thai_don)
                    {
                        truy_van += "'" + trang_thai_don + "', ";
                    }
                    truy_van = truy_van.Remove(truy_van.Length - 2); // xóa dấu , và dấu cách cuối cùng
                    truy_van += ") group by chi_tiet_don_dat_phong.ID_don_dat_phong";
                }
                else
                {
                    if (loai_tim_kiem == "Mã số đơn")
                    {
                        truy_van = "select chi_tiet_don_dat_phong.ID_don_dat_phong, ho_ten, so_can_cuoc_cong_dan, so_dien_thoai, ngay_nhan_phong, ngay_tra_phong, COUNT(chi_tiet_don_dat_phong.ID_phong) as so_luong_phong, trang_thai_don from khach_hang join don_dat_phong on khach_hang.ID_khach_hang = don_dat_phong.ID_khach_hang join chi_tiet_don_dat_phong on don_dat_phong.ID_don_dat_phong = chi_tiet_don_dat_phong.ID_don_dat_phong join phong on chi_tiet_don_dat_phong.ID_phong = phong.ID_phong where don_dat_phong.ID_don_dat_phong = " + text_tim_kiem + " and don_dat_phong.trang_thai_don IN (";
                        foreach (string trang_thai_don in DS_trang_thai_don)
                        {
                            truy_van += "'" + trang_thai_don + "', ";
                        }
                        truy_van = truy_van.Remove(truy_van.Length - 2); // xóa dấu , và dấu cách cuối cùng
                        truy_van += ") group by chi_tiet_don_dat_phong.ID_don_dat_phong";
                    }
                    else if (loai_tim_kiem == "Số điện thoại")
                    {
                        truy_van = "select chi_tiet_don_dat_phong.ID_don_dat_phong, ho_ten, so_can_cuoc_cong_dan, so_dien_thoai, ngay_nhan_phong, ngay_tra_phong, COUNT(chi_tiet_don_dat_phong.ID_phong) as so_luong_phong, trang_thai_don from khach_hang join don_dat_phong on khach_hang.ID_khach_hang = don_dat_phong.ID_khach_hang join chi_tiet_don_dat_phong on don_dat_phong.ID_don_dat_phong = chi_tiet_don_dat_phong.ID_don_dat_phong join phong on chi_tiet_don_dat_phong.ID_phong = phong.ID_phong where so_dien_thoai = '" + text_tim_kiem + "' and don_dat_phong.trang_thai_don IN (";
                        foreach (string trang_thai_don in DS_trang_thai_don)
                        {
                            truy_van += "'" + trang_thai_don + "', ";
                        }
                        truy_van = truy_van.Remove(truy_van.Length - 2); // xóa dấu , và dấu cách cuối cùng
                        truy_van += ") group by chi_tiet_don_dat_phong.ID_don_dat_phong";
                    }
                }
            }
            else
            {
                truy_van = "select chi_tiet_don_dat_phong.ID_don_dat_phong, ho_ten, so_can_cuoc_cong_dan, so_dien_thoai, ngay_nhan_phong, ngay_tra_phong, trang_thai_don from khach_hang join don_dat_phong on khach_hang.ID_khach_hang = don_dat_phong.ID_khach_hang join chi_tiet_don_dat_phong on don_dat_phong.ID_don_dat_phong = chi_tiet_don_dat_phong.ID_don_dat_phong join phong on chi_tiet_don_dat_phong.ID_phong = phong.ID_phong where don_dat_phong.ID_don_dat_phong = -1";
            }
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            return thaoTacVoiSQL.layDuLieuChoGridView();
        }
        public void capNhatTrangThaiPhong(int ID_phong, string trang_thai_phong)
        {
            // thực hiện chức năng cập nhật trạng thái phòng
            string truy_van = "update phong set trang_thai_phong = '" + trang_thai_phong + "' where ID_phong = " + Convert.ToString(ID_phong);
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            thaoTacVoiSQL.capNhatDuLieu();
        }
        public void capNhatDonDatPhong(int ID_don_dat_phong, string ho_ten, string so_can_cuoc_cong_dan, string so_dien_thoai, DateTime ngay_nhan_phong, DateTime ngay_tra_phong, List<int> DS_ID_phong_moi, List<int> DS_ID_phong_cu)
        {
            // thực hiện chức năng cập nhật phòng
            if (ngay_nhan_phong >= DateTime.Now && ngay_tra_phong >= ngay_nhan_phong)
            {
                string truy_van = "update don_dat_phong set ngay_nhan_phong = '" + ngay_nhan_phong.ToString("yyyy-MM-dd") + "', ngay_tra_phong = '" + ngay_tra_phong.ToString("yyyy-MM-dd") + "', so_dien_thoai = '" + so_dien_thoai + "' where ID_don_dat_phong = " + Convert.ToString(ID_don_dat_phong);
                ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
                thaoTacVoiSQL.Truy_van = truy_van;
                thaoTacVoiSQL.capNhatDuLieu();
                truy_van = "update khach_hang set ho_ten = '" + ho_ten + "', so_can_cuoc_cong_dan = '" + so_can_cuoc_cong_dan + "' where ID_khach_hang IN (select ID_khach_hang from don_dat_phong where ID_don_dat_phong = " + Convert.ToString(ID_don_dat_phong) + ")";
                thaoTacVoiSQL.Truy_van = truy_van;
                thaoTacVoiSQL.capNhatDuLieu();
                foreach (int ID in DS_ID_phong_moi)
                {
                    if (!DS_ID_phong_cu.Contains(ID))
                    {
                        truy_van = "insert into chi_tiet_don_dat_phong(ID_phong, ID_don_dat_phong) values(" + Convert.ToString(ID) + ", " + Convert.ToString(ID_don_dat_phong) + ")";
                        thaoTacVoiSQL.Truy_van = truy_van;
                        thaoTacVoiSQL.capNhatDuLieu();
                        truy_van = "update phong set trang_thai_phong = 'Đã đặt' where ID_phong = " + Convert.ToString(ID);
                        thaoTacVoiSQL.Truy_van = truy_van;
                        thaoTacVoiSQL.capNhatDuLieu();
                    }
                }
                foreach (int ID in DS_ID_phong_cu)
                {
                    if (!DS_ID_phong_moi.Contains(ID))
                    {
                        truy_van = "delete from chi_tiet_don_dat_phong where ID_phong = " + Convert.ToString(ID) + " and ID_don_dat_phong = " + Convert.ToString(ID_don_dat_phong);
                        thaoTacVoiSQL.Truy_van = truy_van;
                        thaoTacVoiSQL.capNhatDuLieu();
                        truy_van = "update phong set trang_thai_phong = 'Trống' where ID_phong = " + Convert.ToString(ID);
                        thaoTacVoiSQL.Truy_van = truy_van;
                        thaoTacVoiSQL.capNhatDuLieu();
                    }
                }
                MessageBox.Show("Cập nhật đơn đặt phòng thành công!");
            }
            else if (ngay_nhan_phong < DateTime.Now)
            {
                MessageBox.Show("Ngày nhận phòng phải sau hơn ngày hiện tại!");
            }
            else if (ngay_tra_phong < ngay_nhan_phong)
            {
                MessageBox.Show("Ngày trả phòng phải sau hơn ngày nhận phòng!");
            }
        }
        public void nhanPhong(string ID_don_dat_phong)
        {
            // thực hiện chức năng nhận phòng
            string truy_van = "update don_dat_phong set trang_thai_don = 'Đã nhận' where ID_don_dat_phong = " + ID_don_dat_phong;
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            thaoTacVoiSQL.capNhatDuLieu();
            truy_van = "update phong set trang_thai_phong = 'Đang ở' where ID_phong IN (select ID_phong from chi_tiet_don_dat_phong where ID_don_dat_phong = " + ID_don_dat_phong + ")";
            thaoTacVoiSQL.Truy_van = truy_van;
            thaoTacVoiSQL.capNhatDuLieu();
            MessageBox.Show("Nhận phòng thành công!");
        }
        public string taoHoaDon(string ID_don_dat_phong)
        {
            // tạo hóa đơn
            string truy_van = "insert into hoa_don(ID_don_dat_phong, ID_nhan_vien, ngay_thanh_toan) values(" + ID_don_dat_phong + ", " + Convert.ToString(this.ID_Nhan_vien) + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            thaoTacVoiSQL.capNhatDuLieu();
            truy_van = "select ID_hoa_don from hoa_don where ID_don_dat_phong = " + ID_don_dat_phong;
            thaoTacVoiSQL.Truy_van = truy_van;
            MySqlDataReader reader = thaoTacVoiSQL.layDuLieuChoClass();
            string ID_hoa_don = "";
            if (reader.Read())
            {
                ID_hoa_don = reader.GetString("ID_hoa_don");
            }
            return ID_hoa_don;
        }
        public void thanhToanHoaDon(string ID_hoa_don)
        {
            // thực hiện chức năng thanh toán hóa đơn
            string truy_van = "select ID_don_dat_phong from hoa_don where ID_hoa_don = " + ID_hoa_don;
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            MySqlDataReader reader = thaoTacVoiSQL.layDuLieuChoClass();
            string ID_don_dat_phong = "";
            if (reader.Read())
            {
                ID_don_dat_phong = reader.GetString("ID_don_dat_phong");
            }
            truy_van = "update don_dat_phong set trang_thai_don = 'Đã trả' where ID_don_dat_phong = " + ID_don_dat_phong;
            thaoTacVoiSQL.Truy_van = truy_van;
            thaoTacVoiSQL.capNhatDuLieu();
            truy_van = "update phong set trang_thai_phong = 'Trống' where ID_phong IN (select ID_phong from chi_tiet_don_dat_phong where ID_don_dat_phong = " + ID_don_dat_phong + ")";
            thaoTacVoiSQL.Truy_van = truy_van;
            thaoTacVoiSQL.capNhatDuLieu();
            MessageBox.Show("Thanh toán hóa đơn thành công!");
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
        public void huyDonDatPhong (int ID_don_dat_phong)
        {
            string St_Id_don_dat_phong = Convert.ToString(ID_don_dat_phong);
            string truy_van = "update don_dat_phong set trang_thai_don = 'Đã hủy' where ID_don_dat_phong = " + St_Id_don_dat_phong;
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            thaoTacVoiSQL.capNhatDuLieu();
            truy_van = "update phong set trang_thai_phong = 'Trống' where ID_phong IN (select ID_phong from chi_tiet_don_dat_phong where ID_don_dat_phong = " + St_Id_don_dat_phong + ")";
            thaoTacVoiSQL.Truy_van = truy_van;
            thaoTacVoiSQL.capNhatDuLieu();
            MessageBox.Show("Hủy đơn đặt phòng thành công!");
        }
        public void taoHoaDonDichVu(string ho_ten, string so_can_cuoc_cong_dan, string so_dien_thoai, int ID_le_tan)
        {
            string truy_van = "select ID_khach_hang, ho_ten from khach_hang where so_can_cuoc_cong_dan = '" + so_can_cuoc_cong_dan + "'";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van; 
            MySqlDataReader reader = thaoTacVoiSQL.layDuLieuChoClass();
            if (reader.Read())
            {
                string ID_khach_hang = reader.GetString("ID_khach_hang");
                truy_van = "insert into hoa_don_dich_vu(ID_khach_hang, ID_nhan_vien, ngay_thanh_toan, so_dien_thoai) values(" + ID_khach_hang + ", " + Convert.ToString(ID_le_tan) + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + so_dien_thoai + "')";
                thaoTacVoiSQL.Truy_van = truy_van;
                thaoTacVoiSQL.capNhatDuLieu();
            }
            else
            {
                themKhachHang(ho_ten, so_can_cuoc_cong_dan);
                taoHoaDonDichVu(ho_ten, so_can_cuoc_cong_dan, so_dien_thoai, ID_le_tan);
            }
        }
        public void datDichVu (string ho_ten, string so_can_cuoc_cong_dan, string so_dien_thoai, int ID_le_tan, List<int> DS_ID_dich_vu, List<int> DS_so_luong)
        {
            taoHoaDonDichVu(ho_ten, so_can_cuoc_cong_dan, so_dien_thoai, ID_le_tan);
            string truy_van = "select ID_khach_hang from khach_hang where so_can_cuoc_cong_dan = '" + so_can_cuoc_cong_dan + "' and ho_ten = '" + ho_ten + "'";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            MySqlDataReader reader = thaoTacVoiSQL.layDuLieuChoClass();
            string ID_khach_hang = "";
            if (reader.Read())
            {
                ID_khach_hang = reader.GetString("ID_khach_hang");
            }
            else
            {
                return;
            }
            truy_van = "select ID_hoa_don_dich_vu from hoa_don_dich_vu where ID_khach_hang = " + ID_khach_hang + " and ngay_thanh_toan = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and ID_nhan_vien = " + Convert.ToString(ID_le_tan) + " and so_dien_thoai = '" + so_dien_thoai + "'";
            thaoTacVoiSQL.Truy_van = truy_van;
            reader = thaoTacVoiSQL.layDuLieuChoClass();
            string ID_hoa_don_dich_vu = "";
            if (reader.Read())
            {
                ID_hoa_don_dich_vu = reader.GetString("ID_hoa_don_dich_vu");
            }
            else
            {
                return;
            }
            for (int i = 0; i < DS_ID_dich_vu.Count; i++)
            {
                truy_van = "insert into hoa_don_dich_vu_chi_tiet(ID_hoa_don_dich_vu, ID_dich_vu, so_luong) values(" + ID_hoa_don_dich_vu + ", " + Convert.ToString(DS_ID_dich_vu[i]) + ", " + Convert.ToString(DS_so_luong[i]) + ")";
                thaoTacVoiSQL.Truy_van = truy_van;
                thaoTacVoiSQL.capNhatDuLieu();
            }
            MessageBox.Show("Đặt dịch vụ thành công!");
        }
        public DataSet timKiemDichVu(string ten_dich_vu, List<string> ds_loai_dich_vu)
        {
            string truy_van = "select * from dich_vu";
            if (ten_dich_vu != "")
            {
                truy_van = " where ";
                truy_van += "ten_dich_vu like '%" + ten_dich_vu + "%'";
            }
            if (ds_loai_dich_vu.Count != 0)
            {
                truy_van += " and (";
                for (int i = 0; i < ds_loai_dich_vu.Count; i++)
                {
                    if (i == 0)
                    {
                        truy_van += "loai_dich_vu = '" + ds_loai_dich_vu[i] + "'";
                    }
                    else
                    {
                        truy_van += " or loai_dich_vu = '" + ds_loai_dich_vu[i] + "'";
                    }
                }
                truy_van += ")";
            }
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            return thaoTacVoiSQL.layDuLieuChoGridView();
        }
        public DataSet hienThiDichVuDaChon(List<int> DS_ma_dich_vu, List<int> DS_so_luong_dich_vu)
        {
            string truy_van = "select ID_dich_vu, ten, don_gia from dich_vu where ID_dich_vu in (";
            for (int i = 0; i < DS_ma_dich_vu.Count; i++)
            {
                truy_van += Convert.ToString(DS_ma_dich_vu[i]);
                if (i != DS_ma_dich_vu.Count - 1)
                {
                    truy_van += ",";
                }
            }
            truy_van += ")";
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            DataSet dataSet = thaoTacVoiSQL.layDuLieuChoGridView();
            dataSet.Tables[0].Columns.Add("so_luong");
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                dataSet.Tables[0].Rows[i]["so_luong"] = DS_so_luong_dich_vu[i];
            }
            return dataSet;
        }
    }
}
