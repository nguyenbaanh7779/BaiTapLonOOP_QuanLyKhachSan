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
