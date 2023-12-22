using Org.BouncyCastle.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKhachSan
{
    internal class Phong
    {
        //private int ID_phong;
        private string so_phong = "";
        private string so_giuong = "";
        private string loai_phong = "";
        private long don_gia;
        private string trang_thai_phong = "";

        //public int ID_Phong
        //{
        //    get { return ID_phong; }
        //    set { ID_phong = value; }
        //}

        public string So_phong
        {
            get { return so_phong; }
            set { so_phong = value; }
        }
        public string So_giuong
        {
            get { return so_giuong;}
            set { so_giuong = value;}
        }

        public string Loai_phong
        {
            get { return loai_phong; }
            set { loai_phong = value; }
        }

        public long Don_gia
        {
            get { return don_gia; }
            set { don_gia = value; }
        }
        public string Trang_thai_phong
        {
            get { return trang_thai_phong; }
            set { trang_thai_phong = value; }
        }

        public Phong(string so_phong, string so_giuong, string loai_phong, long don_gia, string trang_thai_phong)
        {
            //ID_Phong = ID_phong;
            So_phong = so_phong;
            So_giuong = so_giuong;
            Loai_phong = loai_phong;
            Don_gia = don_gia;
            Trang_thai_phong = trang_thai_phong;
        }

    }
}
