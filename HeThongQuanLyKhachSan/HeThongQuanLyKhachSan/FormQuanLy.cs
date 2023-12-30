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
            userControlQuanLy_Phong.Visible = false;
            userControlQuanLy_themNhanVien.Visible = false;
            buttonPhong_Them.Visible = false;
            buttonThemNhanVien_QuayLai.Visible = false;
            buttonNhanVien_Them.Visible = true;
            userControlQuanLy_NhanVien.Visible = true;
        }

        private void buttonDonDatPhong_NhanPhong_Click(object sender, EventArgs e)
        {
            buttonNhanVien_Them.Visible = false;
            userControlQuanLy_NhanVien.Visible = false;
            buttonThemNhanVien_QuayLai.Visible = true;
            userControlQuanLy_themNhanVien.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            userControlQuanLy_themNhanVien.Visible = false;
            buttonThemNhanVien_QuayLai.Visible = false;
            buttonNhanVien_Them.Visible = true;
            userControlQuanLy_NhanVien.Visible = true;
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            labelQuanLy_TaiKhoan.Text = ChucNangHeThong.GSQuanLy.Ho_Ten;
        }

        private void buttonQuanLy_DangXuat_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            this.Close();
        }

        private void buttonKhachHang_Click(object sender, EventArgs e)
        {
            userControlQuanLy_NhanVien.Visible = false;
            buttonNhanVien_Them.Visible = false;
            userControlQuanLy_themNhanVien.Visible = false;
            buttonThemNhanVien_QuayLai.Visible = false;
            buttonPhong_Them.Visible = true;
            userControlQuanLy_Phong.Visible = true;
        }

        private void buttonPhong_Them_Click(object sender, EventArgs e)
        {
            userControlQuanLy_Phong.Visible = false;
            buttonPhong_Them.Visible = false;
            buttonThemPhong_QuayLai.Visible = true;
            userControlQuanLy_ThemPhong1.Visible = true;
        }

        private void buttonThemPhong_QuayLai_Click(object sender, EventArgs e)
        {
            buttonThemPhong_QuayLai.Visible = false;
            userControlQuanLy_ThemPhong1.Visible = false;
            buttonPhong_Them.Visible = true;
            userControlQuanLy_Phong.Visible = true;
        }

        private void userControlQuanLy_ThemPhong1_Load(object sender, EventArgs e)
        {

        }
    }
}
