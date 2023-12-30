using MySql.Data.MySqlClient;
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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kiem_tra = ChucNangHeThong.dangNhap(textBoxTaiKhoan.Text, textBoxMatKhau.Text);
            if (kiem_tra == "")
            {
                labelTaiKhoanHoacMatKhauKhongDung.Visible = true;
            }
            else
            {
                if (kiem_tra == "Quản lý")
                {
                   FormQuanLy formQuanLy = new FormQuanLy();
                    formQuanLy.Show();
                }
                if (kiem_tra == "Lễ tân")
                {
                    FormLeTan formLeTan = new FormLeTan();
                    formLeTan.Show();
                }
                labelTaiKhoanHoacMatKhauKhongDung.Visible = false;
                textBoxTaiKhoan.Text = "";
                textBoxMatKhau.Text = "";
            }
        }

        private void textBoxMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
