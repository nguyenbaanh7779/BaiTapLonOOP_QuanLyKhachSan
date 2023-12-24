using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKhachSan
{
    internal class ThaoTacVoiSQL
    {
        private string truy_van = "";
        public string Truy_van
        {
            get { return truy_van; }
            set { truy_van = value; }
        }
        private MySqlConnection tao_connetion()
        {
            string server = "localhost";
            string database = "quan_ly_khach_san";
            string uid = "root";
            string password = "187801612";
            string constring = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + password;
            MySqlConnection connection = new MySqlConnection(constring);
            return connection;
        }

        public DataSet layDuLieuChoGridView()
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(this.truy_van, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            connection.Close();
            return ds;
        }
        public MySqlDataReader layDuLieuChoClass()
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(this.truy_van, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public void capNhatDuLieu()
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(this.truy_van, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
