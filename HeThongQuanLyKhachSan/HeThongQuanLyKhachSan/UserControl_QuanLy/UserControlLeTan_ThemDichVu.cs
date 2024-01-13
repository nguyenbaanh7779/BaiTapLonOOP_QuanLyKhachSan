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
    public partial class UserControlLeTan_ThemDichVu : UserControl
    {
        public UserControlLeTan_ThemDichVu()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            // dùng để thực hiện chức năng thêm dịch vụ
            if (comboBoxLoaiDichVu.Text == "" || textBoxTenDichVu.Text == "" || textBoxDonGia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                ChucNangHeThong.GSQuanLy.themDichVu(textBoxTenDichVu.Text, comboBoxLoaiDichVu.Text, textBoxDonGia.Text);
                textBoxTenDichVu.Text = "";
                textBoxDonGia.Text = "";
                comboBoxLoaiDichVu.Text = "";
            }
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            // dùng đẻ quay trở lại form dịch vụ
            this.Visible = false;
        }
    }
}
