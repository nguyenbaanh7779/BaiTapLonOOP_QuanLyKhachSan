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
    public partial class UserControlLeTan_DichVu : UserControl
    {
        private List<int> ds_loai_dich_vu = new List<int>();
        private List<int> ds_dich_vu_da_chon = new List<int>();
        private List<int> so_luong_dich_vu_da_chon = new List<int>();
        public UserControlLeTan_DichVu()
        {
            InitializeComponent();
        }
        private void UserControlLeTan_DichVu_Load(object sender, EventArgs e)
        {
            this.ds_loai_dich_vu.Clear();
            this.so_luong_dich_vu_da_chon.Clear();
            this.ds_dich_vu_da_chon.Clear();
            dataGridViewChonDichVu.DataSource = ChucNangHeThong.GSQuanLy.timKiemDichVu("", this.ds_loai_dich_vu).Tables[0];
        }

        private void dataGridViewChonDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // dùng để ấn vào hàng và chọn dịch vụ muốn sử dụng
            dataGridViewChonDichVu.CurrentRow.Selected = true;
            string maDichVu = dataGridViewChonDichVu.Rows[e.RowIndex].Cells["CollumnChonDichVu_MaDichVu"].FormattedValue.ToString() + "";
            if (this.ds_dich_vu_da_chon.Contains(Convert.ToInt32(maDichVu)))
            {
                int so_luong = Convert.ToInt32(dataGridViewDichVuDaChon.Rows[e.RowIndex].Cells["ColumnDichVuDaChon_SoLuong"].FormattedValue.ToString() + "");
                // tìm vị trí của mã dịch vụ trong danh sách dịch vụ đã chọn
                int vi_tri = this.ds_dich_vu_da_chon.IndexOf(Convert.ToInt32(maDichVu));
                // cập nhật lại số lượng dịch vụ đã chọn
                this.so_luong_dich_vu_da_chon[vi_tri] = so_luong + 1;
            }
            else
            {
                this.ds_dich_vu_da_chon.Add(Convert.ToInt32(maDichVu));
                this.so_luong_dich_vu_da_chon.Add(1);
            }
            dataGridViewDichVuDaChon.DataSource = ChucNangHeThong.GSLeTan.hienThiDichVuDaChon(this.ds_dich_vu_da_chon, this.so_luong_dich_vu_da_chon).Tables[0];
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            // thực hiện chức năng thanh toán
            if (this.ds_dich_vu_da_chon.Count > 0)
            {
                // thực hiện chức năng thanh toán
                ChucNangHeThong.GSLeTan.datDichVu(textBoxHoTen.Text, textBoxSoCanCuocCongDan.Text, textBoxSoDienThoai.Text, ChucNangHeThong.GSLeTan.ID_Nhan_vien, ds_dich_vu_da_chon, so_luong_dich_vu_da_chon);
                // cập nhật lại danh sách dịch vụ đã chọn
                this.ds_dich_vu_da_chon.Clear();
                this.so_luong_dich_vu_da_chon.Clear();
                userControlLeTan_HoaDonDichVu1.Visible = true;
            }
            else
            {
                MessageBox.Show("Chưa chọn dịch vụ nào để thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
