using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HeThongQuanLyKhachSan
{
    internal class DichVu
    {
        private int ID_dich_vu;
        private string ten_dich_vu = "";
        private string loai_hinh_dich_vu = "";
        private long don_gia = 0;
        public int ID_Dich_Vu
        {
            get { return ID_dich_vu; }
            set { ID_dich_vu = value; }
        }
        public string Ten_Dich_Vu
        {
            get { return ten_dich_vu; }
            set { ten_dich_vu = value; }
        }
        public string Loai_Hinh_Dich_Vu
        {
            get { return loai_hinh_dich_vu; }
            set { loai_hinh_dich_vu = value; }
        }
        public long Don_gia
        {
            get { return don_gia; }
            set { don_gia = value; }
        }
        public DichVu(int ID_dich_vu)
        {
            this.ID_dich_vu = ID_dich_vu;
            string truy_van = "select ten, loai_hinh, don_gia from dich_vu where ID_dich_vu = " + ID_dich_vu;
            ThaoTacVoiSQL thaoTacVoiSQL = new ThaoTacVoiSQL();
            thaoTacVoiSQL.Truy_van = truy_van;
            MySqlDataReader reader = thaoTacVoiSQL.layDuLieuChoClass();
            if (reader.Read())
            {
                ten_dich_vu = reader.GetString("ten_dich_vu");
                loai_hinh_dich_vu = reader.GetString("loai_hinh_dich_vu");
                don_gia = reader.GetInt64("don_gia");
            }
        }
    }
}
