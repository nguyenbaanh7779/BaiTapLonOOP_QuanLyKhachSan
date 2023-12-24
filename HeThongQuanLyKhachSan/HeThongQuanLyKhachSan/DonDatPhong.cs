// using MySql.Data.MySqlClient;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace HeThongQuanLyKhachSan
// {
//     internal class DonDatPhong
//     {
//         private int ID_don_dat_phong;
//         private Phong phong = new Phong();
//         private KhachHang khach_hang = new KhachHang();
//         private DateTime ngay_nhan_phong = new DateTime();
//         private DateTime ngay_tra_phong = new DateTime();
//         private string so_dien_thoai = "";
//         private string trang_thai_don = "";
//         public int ID_Don_Dat_Phong
//         {
//             get { return ID_don_dat_phong; }
//             set { ID_don_dat_phong = value; }
//         }
//         public Phong Phong
//         {
//             get { return phong; }
//             set { phong = value; }
//         }
//         public KhachHang Khach_Hang
//         {
//             get { return khach_hang; }
//             set { khach_hang = value; }
//         }
//         public DateTime Ngay_Nhan_Phong
//         {
//             get { return ngay_nhan_phong; }
//             set { ngay_nhan_phong = value; }
//         }
//         public DateTime Ngay_Tra_Phong
//         {
//             get { return ngay_tra_phong; }
//             set { ngay_tra_phong = value; }
//         }
//         public string So_Dien_Thoai
//         {
//             get { return so_dien_thoai; }
//             set { so_dien_thoai = value; }
//         }
//         public string Trang_Thai_Don
//         {
//             get { return trang_thai_don; }
//             set { trang_thai_don = value; }
//         }
//         public DonDatPhong()
//         {

//         }
//         public DonDatPhong(int ID_don_dat_phong)
//         {
//             this.ID_don_dat_phong = ID_don_dat_phong;
//             string truy_van = "select * from don_dat_phong where ID_don_dat_phong = " + ID_don_dat_phong;
//             ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
//             thaoTacVoiSQL.Truy_van = truy_van;
//             MySqlDataReader result = thaoTacVoiSQL.layDuLieuChoClass();
//             if (result.Read())
//             {
//                 this.phong = new Phong(result.GetInt32("ID_phong"));
//                 this.khach_hang = new KhachHang(result.GetInt32("ID_khach_hang"));
//                 this.ngay_nhan_phong = result.GetDateTime("ngay_nhan_phong");
//                 this.ngay_tra_phong = result.GetDateTime("ngay_tra_phong");
//                 this.so_dien_thoai = result.GetString("so_dien_thoai");
//                 this.trang_thai_don = result.GetString("trang_thai_don");
//             }
//         }

//     }
// }
