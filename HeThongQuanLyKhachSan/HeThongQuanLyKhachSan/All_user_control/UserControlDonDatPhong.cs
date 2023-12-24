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
    public partial class useControlDonDatPhong : UserControl
    {
        public useControlDonDatPhong()
        {
            InitializeComponent();
        }

        private void labelDonDatPhong_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewDonDatPhong.DataSource = ChucNangHeThong.timKiemThongTinDonDatPhong(textBoxDonDatPhong_TimKiemSoDienThoai.Text).Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void useControlDonDatPhong_Load(object sender, EventArgs e)
        {
            dataGridViewDonDatPhong.DataSource = ChucNangHeThong.timKiemThongTinDonDatPhong().Tables[0];
        }

        private void dataGridViewDonDatPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewDonDatPhong.CurrentRow.Selected = true;
            textBoxDonDatPhong_MaDon.Text = dataGridViewDonDatPhong.Rows[e.RowIndex].Cells["ColumnDonDatPhong_IdDonDatPhong"].Value.ToString();
            textBoxDonDatPhong_SoPhong.Text = dataGridViewDonDatPhong.Rows[e.RowIndex].Cells["ColumnDonDatPhong_SoPhong"].Value.ToString();
            textBoxDonDatPhong_HoTen.Text = dataGridViewDonDatPhong.Rows[e.RowIndex].Cells["ColumnDonDatPhong_HoTen"].Value.ToString();
            textBoxDonDatPhong_SoCanCuocCongDan.Text = dataGridViewDonDatPhong.Rows[e.RowIndex].Cells["ColumnDonDatPhong_SoCanCuocCongDan"].Value.ToString();
            textBoxDonDatPhong_SoDienThoai.Text = dataGridViewDonDatPhong.Rows[e.RowIndex].Cells["ColumnDonDatPhong_SoDienThoai"].Value.ToString();
            textBoxDonDatPhong_NgayNhanPhong.Text = dataGridViewDonDatPhong.Rows[e.RowIndex].Cells["ColumnDonDatPhong_NgayNhanPhong"].Value.ToString();
            textBoxDonDatPhong_NgayTraPhong.Text = dataGridViewDonDatPhong.Rows[e.RowIndex].Cells["ColumnDonDatPhong_NgayTraPhong"].Value.ToString();
            textBoxDonDatPhong_TrangThaiDon.Text = dataGridViewDonDatPhong.Rows[e.RowIndex].Cells["ColumnDonDatPhong_TrangThaiDon"].Value.ToString();
        }

        private void buttonNhanPhong_Click(object sender, EventArgs e)
        {
            ChucNangHeThong.nhanPhong(textBoxDonDatPhong_MaDon.Text);
            if (textBoxDonDatPhong_MaDon.Text == "")
            {
                labelThongBao.Text = "Vui lòng chọn đơn đặt phòng!";
                labelThongBao.ForeColor = Color.Red;
            }
            else
            {
                labelThongBao.Text = "Nhận phòng không thành công!";
                labelThongBao.ForeColor = Color.Green;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelThongBao_Click(object sender, EventArgs e)
        {

        }
    }
}
