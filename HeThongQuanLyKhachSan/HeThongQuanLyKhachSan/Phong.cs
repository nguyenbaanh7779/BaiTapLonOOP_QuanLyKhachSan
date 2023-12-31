using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKhachSan
{
    internal class Phong
    {
        private int ID_phong;
        private string so_phong = "";
        private string so_giuong = "";
        private string loai_phong = "";
        private long don_gia;
        private string trang_thai_phong = "";
        public int ID_Phong
        {
            get { return ID_phong; }
            set { ID_phong = value; }
        }
        public string So_Phong
        {
            get { return so_phong; }
            set { so_phong = value; }
        }
        public string So_Giuong
        {
            get { return so_giuong; }
            set { so_giuong = value; }
        }
        public string Loai_Phong
        {
            get { return loai_phong; }
            set { loai_phong = value; }
        }
        public long Don_Gia
        {
            get { return don_gia; }
            set { don_gia = value; }
        }
        public string Trang_Thai_Phong
        {
            get { return trang_thai_phong; }
            set { trang_thai_phong = value; }
        }
        public Phong(int ID_phong)
        {
            this.ID_phong = ID_phong;
            string truy_van = "select * from phong where ID_phong = " + ID_phong;
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            MySqlDataReader result = thaoTacVoiSQL.layDuLieuChoClass();
            if (result.Read())
            {
                so_phong = result.GetString("so_phong");
                so_giuong = result.GetString("so_giuong");
                loai_phong = result.GetString("loai_phong");
                don_gia = result.GetInt64("don_gia");
                trang_thai_phong = result.GetString("trang_thai_phong");
            }
        }
    }
}
