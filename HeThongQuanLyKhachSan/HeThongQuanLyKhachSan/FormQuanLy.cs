using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyKhachSan
{
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
        }

        private void buttonDonDatPhong_Click(object sender, EventArgs e)
        {
            buttonNhanVien_Them.Visible = true;
            userControlQuanLy_NhanVien.Visible = true;
        }

        private void buttonDonDatPhong_NhanPhong_Click(object sender, EventArgs e)
        {
            userControlQuanLy_NhanVien.Visible = false;
            buttonNhanVien_Them.Visible = false;
            userControlQuanLy_themNhanVien.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
