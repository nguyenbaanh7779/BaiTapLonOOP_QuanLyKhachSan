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
            // dùng để hiện thị thông tin của nhân viên

            //form thong tin ca nhan
            userControlQuanLy_ThongTinCaNhan1.Visible = false;
            ////////////////////////
            
            //form them nhan vien
            buttonThemNhanVien_QuayLai.Visible = false;
            userControlQuanLy_themNhanVien.Visible = false;
            ////////////////

            //form phong
            buttonPhong_Them.Visible = false;
            userControlQuanLy_Phong.Visible = false;
            ////////////
            
            //form thêm phòng
            buttonThemPhong_QuayLai.Visible = false;
            userControlQuanLy_ThemPhong1.Visible = false;
            /////////////////

            //form bao cao thong ke
            userControlQuanLy_BaoCaoThongKe1.Visible = false;
            ///////////////////////

            //form nhan vien
            buttonNhanVien_Them.Visible = true;
            userControlQuanLy_NhanVien.Visible = true;
            ////////////////
        }

        private void buttonDonDatPhong_NhanPhong_Click(object sender, EventArgs e)
        {
            // dùng để hiện thị form thêm nhân viên để thực hiện chức năng thêm nhân viên

            //form nhân viên
            buttonNhanVien_Them.Visible = false;
            userControlQuanLy_NhanVien.Visible = false;
            ////////////////

            //form thêm nhân viên
            buttonThemNhanVien_QuayLai.Visible = true;
            userControlQuanLy_themNhanVien.Visible = true;
            /////////////////////
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // dùng để quay trở lại form nhân viên

            //form thêm nhân viên
            userControlQuanLy_themNhanVien.Visible = false;
            buttonThemNhanVien_QuayLai.Visible = false;
            /////////////////////
            
            //form nhân viên
            buttonNhanVien_Them.Visible = true;
            userControlQuanLy_NhanVien.Visible = true;
            ////////////////
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
            // dùng để hiện thị form phòng 

            //form thong tin ca nhan
            userControlQuanLy_ThongTinCaNhan1.Visible = false;
            ////////////////////////
            
            //form nhan vien
            buttonNhanVien_Them.Visible = false;
            userControlQuanLy_NhanVien.Visible = false;
            ////////////////

            //form them nhan vien
            buttonThemNhanVien_QuayLai.Visible = false;
            userControlQuanLy_themNhanVien.Visible = false;
            ////////////////

            //form thêm phòng
            buttonThemPhong_QuayLai.Visible = false;
            userControlQuanLy_ThemPhong1.Visible = false;
            /////////////////

            //form bao cao thong ke
            userControlQuanLy_BaoCaoThongKe1.Visible = false;
            ///////////////////////

            //form phòng
            buttonPhong_Them.Visible = true;
            userControlQuanLy_Phong.Visible = true;
            ////////////
        }

        private void buttonPhong_Them_Click(object sender, EventArgs e)
        {
            // dùng để hiện thị form thêm phòng để thực hiện chức năng thêm phòng

            //form phòng
            userControlQuanLy_Phong.Visible = false;
            buttonPhong_Them.Visible = false;
            ////////////
            
            //form thêm phòng
            buttonThemPhong_QuayLai.Visible = true;
            userControlQuanLy_ThemPhong1.Visible = true;
            /////////////////
        }

        private void buttonThemPhong_QuayLai_Click(object sender, EventArgs e)
        {
            // dùng để quay lại form phòng

            //form thêm phòng
            buttonThemPhong_QuayLai.Visible = false;
            userControlQuanLy_ThemPhong1.Visible = false;
            /////////////////
            
            //form phòng
            buttonPhong_Them.Visible = true;
            userControlQuanLy_Phong.Visible = true;
            ///////////
        }

        private void userControlQuanLy_ThemPhong1_Load(object sender, EventArgs e)
        {

        }

        private void buttonThongTinCaNhan_Click(object sender, EventArgs e)
        {
            // dùng để hiện thị thông tin cá nhân

            //form nhan vien
            buttonNhanVien_Them.Visible = false;
            userControlQuanLy_NhanVien.Visible = false;
            ////////////////
            
            //form them nhan vien
            buttonThemNhanVien_QuayLai.Visible = false;
            userControlQuanLy_themNhanVien.Visible = false;
            ////////////////

            //form phòng
            buttonPhong_Them.Visible = false;
            userControlQuanLy_Phong.Visible = false;
            ////////////

            //form thêm phòng
            buttonThemPhong_QuayLai.Visible = false;
            userControlQuanLy_ThemPhong1.Visible = false;
            /////////////////

            //form báo cáo thống kê
            userControlQuanLy_BaoCaoThongKe1.Visible = false;
            ///////////////////////
            
            //form thông tin cá nhân
            userControlQuanLy_ThongTinCaNhan1.Visible = true;
            ////////////////////////
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // dùng để hiện thị form báo cáo thống kê

            //form thông tin cá nhân
            userControlQuanLy_ThongTinCaNhan1.Visible = false;
            ////////////////////////
            
            //form nhan vien
            buttonNhanVien_Them.Visible = false;
            userControlQuanLy_NhanVien.Visible = false;
            ////////////////

            //form them nhan vien
            buttonThemNhanVien_QuayLai.Visible = false;
            userControlQuanLy_themNhanVien.Visible = false;
            ////////////////

            //form phòng
            buttonPhong_Them.Visible = false;
            userControlQuanLy_Phong.Visible = false;
            ////////////

            //form thêm phòng
            buttonThemPhong_QuayLai.Visible = false;
            userControlQuanLy_ThemPhong1.Visible = false;
            /////////////////

            //form báo cáo thống kê
            userControlQuanLy_BaoCaoThongKe1.Visible = true;
            ///////////////////////
        }
    }
}
