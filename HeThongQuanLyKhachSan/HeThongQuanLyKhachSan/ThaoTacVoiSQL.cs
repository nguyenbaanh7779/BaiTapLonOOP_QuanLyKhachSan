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
        private static MySqlConnection tao_connetion()
        {
            string server = "localhost";
            string database = "db_quan_ly_khach_san";
            string uid = "root";
            string password = "187801612";
            string constring = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + password;
            MySqlConnection connection = new MySqlConnection(constring);
            return connection;
        }

        public static MySqlDataReader layDuLieu(string query)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            return dataReader;
        }

        public static void cap_nhat_du_lieu(string query)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        
    }
}
