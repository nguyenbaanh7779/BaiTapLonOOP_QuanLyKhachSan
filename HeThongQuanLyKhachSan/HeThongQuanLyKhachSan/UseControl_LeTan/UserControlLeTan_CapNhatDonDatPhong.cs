using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyKhachSan.UseControl_LeTan
{
    public partial class UserControlLeTan_CapNhatDonDatPhong : UserControl
    {
        private List<int> DS_ID_phong_moi = new List<int>();
        private List<int> DS_ID_phong_cu = new List<int>();
        private List<int> DS_ID_phong_hien_co = new List<int>();

        public UserControlLeTan_CapNhatDonDatPhong()
        {
            InitializeComponent();
        }

        private void buttonCapNhatDonDatPhong_TimKiem_Click(object sender, EventArgs e)
        {
            // dùng để tìm kiếm thông tin của phòng đang trống theo bộ lọc
            this.DS_ID_phong_hien_co.Clear();
            this.DS_ID_phong_hien_co = ChucNangHeThong.GSLeTan.layDanhSachIDPhong("", comboBoxCapNhatDonDatPhong_SoGiuong.Text, comboBoxCapNhatDonDatPhong_LoaiPhong.Text, "Trống");
            if (this.DS_ID_phong_hien_co.Count != 0)
            {
                foreach (int ID in this.DS_ID_phong_hien_co)
                {
                    if (this.DS_ID_phong_moi.Contains(ID))
                    {
                        this.DS_ID_phong_hien_co.Remove(ID);
                    }
                }
            }
            foreach (int ID in this.DS_ID_phong_cu)
            {
                if (!this.DS_ID_phong_moi.Contains(ID))
                {
                    this.DS_ID_phong_hien_co.Add(ID);
                }
            }
            dataGridViewCapNhatDonDatPhong_PhongDaDat.DataSource = ChucNangHeThong.GSLeTan.hienThiPhongDaThem(this.DS_ID_phong_moi).Tables[0];
            dataGridViewCapNhatDonDatPhong_PhongDangCo.DataSource = ChucNangHeThong.GSLeTan.hienThiPhongDaThem(this.DS_ID_phong_hien_co).Tables[0];
        }

        private void buttonCapNhatDonDatPhong_QuayLai_Click(object sender, EventArgs e)
        {
            // dùng để quay trở lại form đơn đặt phòng
            this.Visible = false;
        }

        private void buttonCapNhatDonDatPhong_CapNhat_Click(object sender, EventArgs e)
        {
            // dùng để thực hiện chức năng cập nhật phòng
            ChucNangHeThong.GSLeTan.capNhatDonDatPhong(ChucNangHeThong.GSDonDatPhong.ID_Don_Dat_Phong, textBoxCapNhatDonDatPhong_HoTen.Text, textBoxCapNhatDonDatPhong_SoCanCuocCongDan.Text, textBoxCapNhatDonDatPhong_SoDienThoai.Text, dateTimePickerCapNhatDonDatPhong_NgayNhanPhong.Value, dateTimePickerCapNhatDonDatPhong_NgayTraPhong.Value, this.DS_ID_phong_moi, this.DS_ID_phong_cu);
        }

        private void dataGridViewCapNhatDonDatPhong_PhongDaDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // dùng để click vào và hủy phòng đã đặt
            int ID_Phong = Convert.ToInt32(dataGridViewCapNhatDonDatPhong_PhongDaDat.Rows[e.RowIndex].Cells["CollumnPhongDaDat_MaSoPhong"].FormattedValue.ToString());
            dataGridViewCapNhatDonDatPhong_PhongDaDat.CurrentRow.Selected = true;
            this.DS_ID_phong_moi.Remove(ID_Phong);
            this.DS_ID_phong_hien_co.Add(ID_Phong);
            dataGridViewCapNhatDonDatPhong_PhongDaDat.DataSource = ChucNangHeThong.GSLeTan.hienThiPhongDaThem(this.DS_ID_phong_moi).Tables[0];
            dataGridViewCapNhatDonDatPhong_PhongDangCo.DataSource = ChucNangHeThong.GSLeTan.hienThiPhongDaThem(this.DS_ID_phong_hien_co).Tables[0];
        }

        private void UserControlLeTan_CapNhatDonDatPhong_Load(object sender, EventArgs e)
        {
            // dùng để hiện thị thông tin lên form cập nhật đơn đặt phòng
            textBoxCapNhatDonDatPhong_MaDon.Text = ChucNangHeThong.GSDonDatPhong.ID_Don_Dat_Phong.ToString();
            textBoxCapNhatDonDatPhong_HoTen.Text = ChucNangHeThong.GSDonDatPhong.Khach_Hang.Ho_Ten;
            textBoxCapNhatDonDatPhong_SoCanCuocCongDan.Text = ChucNangHeThong.GSDonDatPhong.Khach_Hang.So_Can_Cuoc_Cong_Dan;
            textBoxCapNhatDonDatPhong_SoDienThoai.Text = ChucNangHeThong.GSDonDatPhong.So_Dien_Thoai;
            dateTimePickerCapNhatDonDatPhong_NgayNhanPhong.Value = ChucNangHeThong.GSDonDatPhong.Ngay_Nhan_Phong;
            dateTimePickerCapNhatDonDatPhong_NgayTraPhong.Value = ChucNangHeThong.GSDonDatPhong.Ngay_Tra_Phong;
            dataGridViewCapNhatDonDatPhong_PhongDangCo.DataSource = ChucNangHeThong.GSLeTan.timKiemThongTinPhong("", "", "", "Trống").Tables[0];
            dataGridViewCapNhatDonDatPhong_PhongDaDat.DataSource = ChucNangHeThong.GSDonDatPhong.hienThiPhongDaDat().Tables[0];
            foreach (Phong phong in ChucNangHeThong.GSDonDatPhong.Danh_Sach_Phong)
            {
                this.DS_ID_phong_cu.Add(phong.ID_Phong);
                this.DS_ID_phong_moi.Add(phong.ID_Phong);
            }
            this.DS_ID_phong_hien_co = ChucNangHeThong.GSLeTan.layDanhSachIDPhong("", "", "", "Trống");
            
        }

        private void dataGridViewCapNhatDonDatPhong_PhongDangCo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewCapNhatDonDatPhong_PhongDangCo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // dùng để click vào phòng và thêm vào danh sách phòng đã chọn
            dataGridViewCapNhatDonDatPhong_PhongDangCo.CurrentRow.Selected = true;
            int ID_Phong = Convert.ToInt32(dataGridViewCapNhatDonDatPhong_PhongDangCo.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumnPhongDangCo_MaSoPhong"].FormattedValue.ToString());
            this.DS_ID_phong_moi.Add(ID_Phong);
            this.DS_ID_phong_hien_co.Remove(ID_Phong);
            dataGridViewCapNhatDonDatPhong_PhongDaDat.DataSource = ChucNangHeThong.GSLeTan.hienThiPhongDaThem(this.DS_ID_phong_moi).Tables[0];
            dataGridViewCapNhatDonDatPhong_PhongDangCo.DataSource = ChucNangHeThong.GSLeTan.hienThiPhongDaThem(this.DS_ID_phong_hien_co).Tables[0];
        }
    }
}
