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

        }
        private void buttonDonDatPhong_Click(object sender, EventArgs e)
        {
            // dùng để hiện thị giao hiện đơn đặt phòng

            // form đặt phòng
            useControlLeTan_DatPhong1.Visible = false;

            // form đơn đặt phòng
            buttonDonDatPhong_NhanPhong.Visible = true;
            buttonDonDatPhong_TraPhong.Visible = true;
            useControlLeTan_DonDatPhong1.Visible = true;
            /////////////////////
        }
        private void buttonDonDatPhong_NhanPhong_Click(object sender, EventArgs e)
        {
            // dùng để mở form chi tiết đơn hàng để thực hiện chức năng nhận phòng từ form đơn đặt phòng

            if (ChucNangHeThong.ID_Don_dat_phong == -1)
            {
                MessageBox.Show("Vui lòng chọn đơn đặt phòng!");
            }
            else
            {
                // khởi tạo đối tượng đơn đặt phòng
                ChucNangHeThong.GSDonDatPhong = new DonDatPhong(Convert.ToString(ChucNangHeThong.ID_Don_dat_phong));

                // form đơn đặt phòng
                buttonDonDatPhong_NhanPhong.Visible = false;
                buttonDonDatPhong_TraPhong.Visible = false;
                useControlLeTan_DonDatPhong1.Visible = false;
                /////////////////////

                // form chi tiết đơn đặt phòng
                buttonChiTietDonDatPhong_QuayLai.Visible = true;
                userControlLeTan_ChiTietDonDatPhong1.Visible = true;
                //////////////////////////////
            }
        }

        private void buttonDonDatPhong_TraPhong_Click(object sender, EventArgs e)
        {
            // dùng để thực hiện chức năng trả phòng

            if (ChucNangHeThong.ID_Don_dat_phong == -1)
            {
                MessageBox.Show("Vui lòng chọn đơn đặt phòng!");
            }
            else
            {
                // Tạo hóa đơn
                ChucNangHeThong.GSLeTan.taoHoaDon(Convert.ToString(ChucNangHeThong.ID_Don_dat_phong));

                // form đơn đặt phòng
                buttonDonDatPhong_NhanPhong.Visible = false;
                buttonDonDatPhong_TraPhong.Visible = false;
                useControlLeTan_DonDatPhong1.Visible = false;
                /////////////////////

                // form hóa đơn
                buttonHoaDon_QuayLai.Visible = true;
                userControlLeTan_HoaDon1.Visible = true;
                ///////////////
            }


        }

        private void buttonChiTietDonDatPhong_NhanPhong_Click(object sender, EventArgs e)
        {
            // dùng để thực hiện chức năng nhận phòng từ form chi tiết đơn đặt phòng
        }

        private void buttonChiTietDonDatPhong_HuyPhong_Click(object sender, EventArgs e)
        {
            // dùng để thực hiện chức năng hủy đơn đặt phòng từ form chi tiết đơn đặt phòng
        }

        private void buttonChiTietDonDatPhong_QuayLai_Click(object sender, EventArgs e)
        {
            // dùng để quay về form đơn đặt phòng

            // from chi tiết đơn đặt phòng
            buttonChiTietDonDatPhong_QuayLai.Visible = false;
            userControlLeTan_ChiTietDonDatPhong1.Visible = false;
            //////////////////////////////

            // form đơn đặt phòng
            buttonDonDatPhong_NhanPhong.Visible = true;
            buttonDonDatPhong_TraPhong.Visible = true;
            useControlLeTan_DonDatPhong1.Visible = true;
            /////////////////////
        }

        private void buttonHoaDon_QuayLai_Click(object sender, EventArgs e)
        {
            // dùng để quay về form đơn đặt phòng

            // form hóa đơn
            buttonHoaDon_QuayLai.Visible = false;
            userControlLeTan_HoaDon1.Visible = false;
            ///////////////


            // form đơn đặt phòng
            buttonDonDatPhong_NhanPhong.Visible = true;
            buttonDonDatPhong_TraPhong.Visible = true;
            useControlLeTan_DonDatPhong1.Visible = true;
            /////////////////////
        }

        private void buttonDatPhong_Click(object sender, EventArgs e)
        {
            // form đơn đặt phòng
            buttonDonDatPhong_NhanPhong.Visible = false;
            buttonDonDatPhong_TraPhong.Visible = false;
            useControlLeTan_DonDatPhong1.Visible = false;
            /////////////////////

            // from chi tiết đơn đặt phòng
            buttonChiTietDonDatPhong_QuayLai.Visible = false;
            userControlLeTan_ChiTietDonDatPhong1.Visible = false;
            //////////////////////////////

            // form hóa đơn
            buttonHoaDon_QuayLai.Visible = false;
            userControlLeTan_HoaDon1.Visible = false;
            ///////////////

            // form đặt phòng
            useControlLeTan_DatPhong1.Visible = true;
        }
    }
}
