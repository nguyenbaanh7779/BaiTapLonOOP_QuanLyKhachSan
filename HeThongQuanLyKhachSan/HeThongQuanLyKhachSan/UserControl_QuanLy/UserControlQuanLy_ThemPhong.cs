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
    public partial class UserControlQuanLy_ThemPhong : UserControl
    {
        public UserControlQuanLy_ThemPhong()
        {
            InitializeComponent();
        }

        private void buttonPhongTimKiem_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonPhongTimKiem_Click_1(object sender, EventArgs e)
        {
            if (textBoxThemPhong_SoPhong.Text == "" || comboBoxThemPhong_SoGiuong.Text == "" || comboBoxThemPhong_LoaiPhong.Text == "" || textBoxThemPhong_DonGia.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else
            {
                QuanLy quanLy = new QuanLy(ChucNangHeThong.ID_Nhan_vien);
                quanLy.themPhong(textBoxThemPhong_SoPhong.Text, comboBoxThemPhong_SoGiuong.Text, comboBoxThemPhong_LoaiPhong.Text, textBoxThemPhong_DonGia.Text);
            }
        }
    }
}
