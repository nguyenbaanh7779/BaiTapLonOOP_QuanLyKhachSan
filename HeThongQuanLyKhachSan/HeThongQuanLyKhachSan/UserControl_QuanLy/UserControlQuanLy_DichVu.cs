using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyKhachSan.UserControl_QuanLy
{
    public partial class UserControlQuanLy_DichVu : UserControl
    {
        private List<int> ds_loai_dich_vu = new List<int>();
        public UserControlQuanLy_DichVu()
        {
            InitializeComponent();
        }
        private void UserControlQuanLy_DichVu_Load(object sender, EventArgs e)
        {
            this.ds_loai_dich_vu.Clear();
            dataGridViewDichVu.DataSource = ChucNangHeThong.GSQuanLy.timKiemDichVu("", this.ds_loai_dich_vu).Tables[0];
        }

        private void dataGridViewDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // click vào dataGridview thì hiện thông tin lên các textbox
            dataGridViewDichVu.CurrentRow.Selected = true;
            textBoxMaDichVu.Text = dataGridViewDichVu.Rows[e.RowIndex].Cells["CollumnMaDichDu"].FormattedValue.ToString();
            textBoxTenDichVu.Text = dataGridViewDichVu.Rows[e.RowIndex].Cells["CollumnTenDichVu"].FormattedValue.ToString();
            comboBoxLoaiDichVu.Text = dataGridViewDichVu.Rows[e.RowIndex].Cells["CollumnLoaiDichVu"].FormattedValue.ToString();
            textBoxDonGia.Text = dataGridViewDichVu.Rows[e.RowIndex].Cells["CollumnDonGia"].FormattedValue.ToString();
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            // dùng để thực hiện chức năng cập nhật dịch vụ
            if (textBoxMaDichVu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dịch vụ cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                ChucNangHeThong.GSQuanLy.capNhatDichVu(textBoxMaDichVu.Text, textBoxTenDichVu.Text, comboBoxLoaiDichVu.Text, textBoxDonGia.Text);
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            // dùng để hiện thị form thêm dịch vụ để thực hiện chức năng thêm dịch vụ
            userControlLeTan_ThemDichVu1.Visible = true;
        }
    }
}
