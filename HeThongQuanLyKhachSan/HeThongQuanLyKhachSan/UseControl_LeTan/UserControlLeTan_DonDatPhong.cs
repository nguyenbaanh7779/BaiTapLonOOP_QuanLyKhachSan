using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyKhachSan.All_user_control
{
    public partial class useControlLeTan_DonDatPhong : UserControl
    {
        private List<string> DS_trangThaiDon = new List<string>();
        string trang_thai_don = "";
        public useControlLeTan_DonDatPhong()
        {
            InitializeComponent();
        }

        private void labelDonDatPhong_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // dùng để thực hiện tìm kiếm đơn đặt phòng theo số điện thoại hoặc mã số đơn
            foreach (RadioButton item in groupBox_TieuChiTimKiem.Controls)
            {
                if (item.Checked == true)
                {
                    dataGridViewDonDatPhong.DataSource = ChucNangHeThong.GSLeTan.timKiemThongTinDonDatPhong(textBoxDonDatPhong_TimKiem.Text, item.Text, DS_trangThaiDon).Tables[0];
                    break;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void useControlDonDatPhong_Load(object sender, EventArgs e)
        {
            // hiện thị thông tin tất cả các đơn đặt phòng lên datagridview
            radioButton_SoDienThoai.Checked = true;
            checkBox_DaDat.Checked = true;
            dataGridViewDonDatPhong.DataSource = ChucNangHeThong.GSLeTan.timKiemThongTinDonDatPhong(textBoxDonDatPhong_TimKiem.Text, radioButton_SoDienThoai.Text, DS_trangThaiDon).Tables[0];
        }

        private void dataGridViewDonDatPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // dùng để click vào một hàng và hiện thị thông tin hàng đó ở phía dưới
            dataGridViewDonDatPhong.CurrentRow.Selected = true;
            textBoxDonDatPhong_MaDon.Text = dataGridViewDonDatPhong.Rows[e.RowIndex].Cells["ColumnDonDatPhong_IdDonDatPhong"].Value.ToString();
            textBoxDonDatPhong_HoTen.Text = dataGridViewDonDatPhong.Rows[e.RowIndex].Cells["ColumnDonDatPhong_HoTen"].Value.ToString();
            textBoxDonDatPhong_SoCanCuocCongDan.Text = dataGridViewDonDatPhong.Rows[e.RowIndex].Cells["ColumnDonDatPhong_SoCanCuocCongDan"].Value.ToString();
            textBoxDonDatPhong_SoDienThoai.Text = dataGridViewDonDatPhong.Rows[e.RowIndex].Cells["ColumnDonDatPhong_SoDienThoai"].Value.ToString();
            dateTimePickerDonDatPhong_NgayNhanPhong.Text = dataGridViewDonDatPhong.Rows[e.RowIndex].Cells["ColumnDonDatPhong_NgayNhanPhong"].Value.ToString();
            dateTimePickerDonDatPhong_NgayTraPhong.Text = dataGridViewDonDatPhong.Rows[e.RowIndex].Cells["ColumnDonDatPhong_NgayTraPhong"].Value.ToString();
            textBoxDonDatPhong_SoLuongPhong.Text = dataGridViewDonDatPhong.Rows[e.RowIndex].Cells["ColumnDonDatPhong_SoLuongPhong"].Value.ToString();
            trang_thai_don = dataGridViewDonDatPhong.Rows[e.RowIndex].Cells["ColumnDonDatPhong_TrangThaiDon"].Value.ToString() + "";
        }

        private void buttonNhanPhong_Click(object sender, EventArgs e)
        {
            // dùng để mở form nhận phòng để thực hiện chức năng nhận phòng
            if (textBoxDonDatPhong_MaDon.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đơn đặt phòng!");
            }
            else
            {
                ChucNangHeThong.GSDonDatPhong = new DonDatPhong(textBoxDonDatPhong_MaDon.Text);
                if (trang_thai_don == "Đã đặt")
                {
                    userControlLeTan_ChiTietDonDatPhong1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Không thể thực hiện nhận phòng! Vui lòng xem lại trạng thái đơn");
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelThongBao_Click(object sender, EventArgs e)
        {

        }

        private void buttonDonDatPhong_CapNhat_Click(object sender, EventArgs e)
        {
            // dùng để mở form cập nhật phòng để thực hiện chức năng cập nhật phòng
            if (textBoxDonDatPhong_MaDon.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đơn đặt phòng!");
            }
            else
            {
                ChucNangHeThong.GSDonDatPhong = new DonDatPhong(textBoxDonDatPhong_MaDon.Text);
                if (trang_thai_don == "Đã đặt")
                {
                    userControlLeTan_CapNhatDonDatPhong1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Không thể thực hiện cập nhật phòng! Vui lòng xem lại trạng thái đơn");
                }
            }
        }

        private void buttonTraPhong_Click(object sender, EventArgs e)
        {
            // dùng để mở form thanh toán để thực hiện chức năng trả phòng
            if (textBoxDonDatPhong_MaDon.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đơn đặt phòng!");
            }
            else
            {
                if (trang_thai_don == "Đã nhận")
                {
                    string ID_hoa_don = ChucNangHeThong.GSLeTan.taoHoaDon(textBoxDonDatPhong_MaDon.Text);
                    ChucNangHeThong.GSHoaDon = new HoaDon(ID_hoa_don);
                    userControlLeTan_HoaDon1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Không thể thực hiện trả phòng! Vui lòng xem lại trạng thái đơn");
                }
            }
        }

        private void buttonDonDatPhong_HuyDon_Click(object sender, EventArgs e)
        {
            // dùng để thực hiện chức năng hủy đơn đặt phòng
            if (textBoxDonDatPhong_MaDon.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đơn đặt phòng!");
            }
            else
            {
                if (trang_thai_don == "Đã đặt")
                {
                    ChucNangHeThong.GSLeTan.huyDonDatPhong(ChucNangHeThong.GSDonDatPhong.ID_Don_Dat_Phong);
                    dataGridViewDonDatPhong.DataSource = ChucNangHeThong.GSLeTan.timKiemThongTinDonDatPhong(textBoxDonDatPhong_TimKiem.Text, radioButton_SoDienThoai.Text, DS_trangThaiDon).Tables[0];
                }
                else
                {
                    MessageBox.Show("Không thể thực hiện hủy đơn đặt phòng! Vui lòng xem lại trạng thái đơn");
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxTatCa_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox_DaDat_CheckedChanged(object sender, EventArgs e)
        {
            // thao tác với check box đã đặt
            DS_trangThaiDon.Clear();
            foreach (CheckBox item in groupBox_trangThaiDon.Controls)
            {
                if (item.Checked == true)
                {
                    DS_trangThaiDon.Add(item.Text);
                }
            }
            // hiện thị thông tin tất cả các đơn đặt phòng lên datagridview
            foreach (RadioButton item in groupBox_TieuChiTimKiem.Controls)
            {
                if (item.Checked == true)
                {
                    dataGridViewDonDatPhong.DataSource = ChucNangHeThong.GSLeTan.timKiemThongTinDonDatPhong(textBoxDonDatPhong_TimKiem.Text, item.Text, DS_trangThaiDon).Tables[0];
                    break;
                }
            }
        }

        private void checkBox_DaNhan_CheckedChanged(object sender, EventArgs e)
        {
            // thao tác với check box đã nhận
            DS_trangThaiDon.Clear();
            foreach (CheckBox item in groupBox_trangThaiDon.Controls)
            {
                if (item.Checked == true)
                {
                    DS_trangThaiDon.Add(item.Text);
                }
            }
            // hiện thị thông tin tất cả các đơn đặt phòng lên datagridview
            foreach (RadioButton item in groupBox_TieuChiTimKiem.Controls)
            {
                if (item.Checked == true)
                {
                    dataGridViewDonDatPhong.DataSource = ChucNangHeThong.GSLeTan.timKiemThongTinDonDatPhong(textBoxDonDatPhong_TimKiem.Text, item.Text, DS_trangThaiDon).Tables[0];
                    break;
                }
            }
        }

        private void checkBox_DaTra_CheckedChanged(object sender, EventArgs e)
        {
            // thao tác với check box đã trả
            DS_trangThaiDon.Clear();
            foreach (CheckBox item in groupBox_trangThaiDon.Controls)
            {
                if (item.Checked == true)
                {
                    DS_trangThaiDon.Add(item.Text);
                }
            }
            // hiện thị thông tin tất cả các đơn đặt phòng lên datagridview
            foreach (RadioButton item in groupBox_TieuChiTimKiem.Controls)
            {
                if (item.Checked == true)
                {
                    dataGridViewDonDatPhong.DataSource = ChucNangHeThong.GSLeTan.timKiemThongTinDonDatPhong(textBoxDonDatPhong_TimKiem.Text, item.Text, DS_trangThaiDon).Tables[0];
                    break;
                } 
            }
        }

        private void checkBox_DaHuy_CheckedChanged(object sender, EventArgs e)
        {
            // thao tác với check box đã hủy
            DS_trangThaiDon.Clear();
            foreach (CheckBox item in groupBox_trangThaiDon.Controls)
            {
                if (item.Checked == true)
                {
                    DS_trangThaiDon.Add(item.Text);
                }
            }
            // hiện thị thông tin tất cả các đơn đặt phòng lên datagridview
            foreach (RadioButton item in groupBox_TieuChiTimKiem.Controls)
            {
                if (item.Checked == true)
                {
                    dataGridViewDonDatPhong.DataSource = ChucNangHeThong.GSLeTan.timKiemThongTinDonDatPhong(textBoxDonDatPhong_TimKiem.Text, item.Text, DS_trangThaiDon).Tables[0];
                    break;
                }
            }
        }

        private void userControlLeTan_HoaDon1_Load(object sender, EventArgs e)
        {

        }

        private void userControlLeTan_CapNhatDonDatPhong1_Load(object sender, EventArgs e)
        {

        }
    }
}