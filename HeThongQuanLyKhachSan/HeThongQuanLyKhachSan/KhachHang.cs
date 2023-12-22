using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKhachSan
{
    internal class KhachHang
    {
        private string ho_ten = "";
        private string so_can_cuoc_cong_dan = "";
        public string Ho_ten
        {
            get { return ho_ten; }
            set { ho_ten = value; }
        }
        public string So_can_cuoc_cong_dan
        {
            get { return so_can_cuoc_cong_dan; }
            set { so_can_cuoc_cong_dan = value; }
        }
        public KhachHang(string ho_ten, string so_can_cuoc_cong_dan)
        {
            Ho_ten = ho_ten;
            So_can_cuoc_cong_dan = so_can_cuoc_cong_dan;
        }
    }
}
