using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Misc;

namespace HeThongQuanLyKhachSan.All_user_control
{
    public partial class useControlLeTan_DatPhong : UserControl
    {
        private int ID_Phong;
        private List<int> listID_Phong = new List<int>();
        public useControlLeTan_DatPhong()
        {
            InitializeComponent();
        }

        private void useControlLeTan_DatPhong_Load(object sender, EventArgs e)
        {
            comboBoxDatPhong_TrangThai.Text = "Trống";
            dataGridViewDatPhong_ChonPhong.DataSource = ChucNangHeThong.GSLeTan.timKiemThongTinPhong(textBoxDatPhong_SoPhong.Text, comboBoxDatPhong_SoGiuong.Text, comboBoxDatPhong_LoaiPhong.Text, comboBoxDatPhong_TrangThai.Text).Tables[0];
        }

        private void buttonPhongTimKiem_Click(object sender, EventArgs e)
        {
            // dùng để tìm kiếm thông tin phòng theo bộ lọc
            dataGridViewDatPhong_ChonPhong.DataSource = ChucNangHeThong.GSLeTan.timKiemThongTinPhong(textBoxDatPhong_SoPhong.Text, comboBoxDatPhong_SoGiuong.Text, comboBoxDatPhong_LoaiPhong.Text, comboBoxDatPhong_TrangThai.Text).Tables[0];
        }

        private void dataGridViewDatPhong_ChonPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // dùng để click vào phòng và thêm vào danh sách phòng đã chọn
            dataGridViewDatPhong_ChonPhong.CurrentRow.Selected = true;
            this.ID_Phong = Convert.ToInt32(dataGridViewDatPhong_ChonPhong.Rows[e.RowIndex].Cells["CollumnChonPhong_MaSoPhong"].FormattedValue.ToString());
            if (this.listID_Phong.Contains(this.ID_Phong))
            {
                MessageBox.Show("Phòng này đã được chọn");
            }
            else
            {
                this.listID_Phong.Add(this.ID_Phong);
            }
            dataGridViewDatPhong_PhongDaChon.DataSource = ChucNangHeThong.GSLeTan.hienThiPhongDaThem(this.listID_Phong).Tables[0];
        }

        private void dataGridViewDatPhong_ChonPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDatPhong_PhongDaChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // dùng để click vào phòng đã chọn và xóa khỏi danh sách phòng đã chọn
            dataGridViewDatPhong_PhongDaChon.CurrentRow.Selected = true;
            this.ID_Phong = Convert.ToInt32(dataGridViewDatPhong_PhongDaChon.Rows[e.RowIndex].Cells["CollumnPhongDaChon_MaSoPhong"].FormattedValue.ToString());
            this.listID_Phong.Remove(this.ID_Phong);
            dataGridViewDatPhong_PhongDaChon.DataSource = ChucNangHeThong.GSLeTan.hienThiPhongDaThem(this.listID_Phong).Tables[0];
        }

        private void buttonDatPhong_DatPhong_Click(object sender, EventArgs e)
        {
            // dùng để thực hiện chức năng đặt phòng
            if (this.listID_Phong.Count == 0) // nếu chưa chọn phòng
            {
                MessageBox.Show("Bạn chưa chọn phòng");
            }
            else
            {
                if (textBoxDatPhong_HoTen.Text == "" || textBoxDatPhong_SoCanCuocCongDan.Text == "" || textBoxDatPhong_SoDienThoai.Text == "") // nếu chưa nhập đầy đủ thông tin
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    ChucNangHeThong.GSLeTan.datPhong(textBoxDatPhong_HoTen.Text, textBoxDatPhong_SoCanCuocCongDan.Text, textBoxDatPhong_SoDienThoai.Text, dateTimePickerDatPhong_NgayNhanPhong.Value, dateTimePickerDatPhong_NgayTraPhong.Value, this.listID_Phong);
                }
            }
        }
    }
}
