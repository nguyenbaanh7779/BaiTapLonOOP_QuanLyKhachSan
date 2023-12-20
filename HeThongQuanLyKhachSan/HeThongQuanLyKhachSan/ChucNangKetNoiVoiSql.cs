using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HeThongQuanLyKhachSan
{
    internal class ChucNangKetNoiVoiSql
    {
        private void ketNoiVoiSQL(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "testdb";
            string uid = "root";
            string password = "187801612";
            string constring = "Server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;

        }

    }
}
