using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKhachSan
{
    internal class DanhSachPhong
    {
        private string query = "select * from phong";
        public string Query
        {
            get { return query; }
            set { query = value; }
        }
        private List<Phong> danhSachPhongs = new List<Phong>();
        public List<Phong> DanhSachPhongs
        {
            get { return danhSachPhongs; }
            set { danhSachPhongs = value; }
        }
        public void LayDanhSachPhong()
        {
            MySqlDataReader dataReader = ThaoTacVoiSQL.layDuLieu(this.query);
            while (dataReader.Read())
            {
                string so_phong = dataReader.GetString("so_phong");
                string so_giuong = dataReader.GetString("so_giuong");
                string loai_phong = dataReader.GetString("loai_phong");
                long don_gia = dataReader.GetInt64("don_gia");
                string trang_thai_phong = dataReader.GetString("trang_thai_phong");
                this.danhSachPhongs.Add(new Phong(so_phong, so_giuong, loai_phong, don_gia, trang_thai_phong));
            }
        }
    }
}
