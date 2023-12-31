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
        public useControlLeTan_DonDatPhong()
        {
            InitializeComponent();
        }

        private void labelDonDatPhong_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void useControlDonDatPhong_Load(object sender, EventArgs e)
        {
            dataGridViewDonDatPhong.DataSource = ChucNangHeThong.GSLeTan.timKiemThongTinDonDatPhong(textBoxDonDatPhong_TimKiemSoDienThoai.Text).Tables[0]; 
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
            ChucNangHeThong.ID_Don_dat_phong = Convert.ToInt32(textBoxDonDatPhong_MaDon.Text);
        }

        private void buttonNhanPhong_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelThongBao_Click(object sender, EventArgs e)
        {

        }
    }
}
