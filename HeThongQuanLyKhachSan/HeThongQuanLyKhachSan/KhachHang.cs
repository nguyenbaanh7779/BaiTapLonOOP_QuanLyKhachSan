using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKhachSan
{
    internal class KhachHang
    {
        private int ID_khach_hang;
        private string ho_ten = "";
        private string so_can_cuoc_cong_dan = "";
        public int ID_Khach_hang
        {
            get { return ID_khach_hang; }
            set { ID_khach_hang = value; }
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
        public KhachHang(string ID_khach_hang)
        {
            this.ID_Khach_hang = Convert.ToInt32(ID_khach_hang);
            string query = "select * from khach_hang where ID_khach_hang = " + ID_khach_hang;
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = query;
            MySqlDataReader reader = thaoTacVoiSQL.layDuLieuChoClass();
            if (reader.Read())
            {
                this.Ho_Ten = reader.GetString("ho_ten");
                this.So_Can_Cuoc_Cong_Dan = reader.GetString("so_can_cuoc_cong_dan");
            }
        }
    }
}