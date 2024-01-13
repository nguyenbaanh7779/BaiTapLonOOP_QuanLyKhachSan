using HeThongQuanLyKhachSan.All_user_control;
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
    public partial class FormLeTan : Form
    {
        public FormLeTan()
        {
            InitializeComponent();
        }

        private void FormLeTan_Load(object sender, EventArgs e)
        {
            labelTaiKhoan.Text = ChucNangHeThong.GSLeTan.Ho_Ten;
        }
        private void buttonDonDatPhong_Click(object sender, EventArgs e)
        {
            // dùng để hiện thị giao hiện đơn đặt phòng

            // form thông tin cá nhân
            userControlLeTan_ThongTinCaNhan1.Visible = false;
            /////////////////////////

            // form đặt phòng
            useControlLeTan_DatPhong1.Visible = false;
            /////////////////

            // form đặt phòng
            useControlLeTan_DatPhong1.Visible = false;
            /////////////////

            // form đơn đặt phòng
            useControlLeTan_DonDatPhong1.Visible = true;
            /////////////////////
        }

        private void buttonDatPhong_Click(object sender, EventArgs e)
        {
            // form đơn đặt phòng
            useControlLeTan_DonDatPhong1.Visible = false;
            /////////////////////

            // from chi tiết đơn đặt phòng
            //////////////////////////////

            // form hóa đơn
            ///////////////

            // form thông tin cá nhân
            userControlLeTan_ThongTinCaNhan1.Visible = false;
            /////////////////////////

            // form đặt phòng
            useControlLeTan_DatPhong1.Visible = false;
            /////////////////

            // form đặt phòng
            useControlLeTan_DatPhong1.Visible = true;
        }

        private void buttonThongTinCaNhan_Click(object sender, EventArgs e)
        {
            // dùng để hiện thị thông tin cá nhân của lễ tân

            // form đơn đặt phòng
            useControlLeTan_DonDatPhong1.Visible = false;
            /////////////////////

            // form đặt phòng
            useControlLeTan_DatPhong1.Visible = false;
            /////////////////

            // form dịch vụ
            userControlLeTan_DichVu1.Visible = false;
            ///////////////

            // form thông tin cá nhân
            userControlLeTan_ThongTinCaNhan1.Visible = true;
            /////////////////////////
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDichVu_Click(object sender, EventArgs e)
        {
            // dùng để hiện thị form dịch vụ

            // form đơn đặt phòng
            useControlLeTan_DonDatPhong1.Visible = false;
            /////////////////////

            // form đặt phòng
            useControlLeTan_DatPhong1.Visible = false;
            /////////////////

            // form thông tin cá nhân
            userControlLeTan_ThongTinCaNhan1.Visible = false;
            /////////////////////////

            // form dịch vụ
            userControlLeTan_DichVu1.Visible = true;
            ///////////////
        }
    }
}
