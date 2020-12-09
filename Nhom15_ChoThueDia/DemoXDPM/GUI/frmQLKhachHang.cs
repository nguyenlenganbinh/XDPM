using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BUS;

namespace GUI
{
    public partial class frmQLKhachHang : Form
    {
        public frmQLKhachHang()
        {
            InitializeComponent();
        }
        public List<eKhachHang> dsKH;
        public List<eDanhSachHangDoi> dsHangDoiCuaKH;
        public BusQuanLyKhachHang busQuanLyKhachHang;
        public BusDatDia busDatDia;

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            dsKH = new List<eKhachHang>();
            dsHangDoiCuaKH = new List<eDanhSachHangDoi>();
            busQuanLyKhachHang = new BusQuanLyKhachHang();
            busDatDia = new BusDatDia();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            dsKH = busQuanLyKhachHang.layDSKhachHang();
            txtMaKH.Text = "KH" + kiemTraMaTuDong(getMaDD_AuTo(busQuanLyKhachHang.layDSKhachHang()));
            griDanhSachKhachHang.DataSource = dsKH;
            formatDatagridsKhachHang();
        }

        private string kiemTraMaTuDong(int so)
        {
            if (so / 10 >= 0 && so / 10 < 1) //số thuộc hàng đơn vị
            {
                return "000" + so;
            }
            else if (so / 10 >= 1 && so / 10 < 10) //số thuộc hàng chục
            {
                return "00" + so;
            }
            else if (so / 10 >= 10 && so / 10 < 100) //số thuộc hàng trăm
            {
                return "0" + so;
            }
            else //số thuộc hàng nghìn
            {
                return "" + so;
            }
        }

        //Hàm tự động tăng mã Đặt đĩa
        private int getMaDD_AuTo(List<eKhachHang> dshd)
        {
            int max = 0;
            foreach (eKhachHang item in dshd)
            {
                //Substring này lấy 4 kí tự cuối của chuỗi
                if (long.Parse(item.MaKhachHang.Substring(item.MaKhachHang.Length - 4)) >= max)
                {
                    max = Int32.Parse(item.MaKhachHang.Substring(item.MaKhachHang.Length - 4));
                }
            }
            return max + 1;
        }

        private void formatDatagridsKhachHang()
        {
            griDanhSachKhachHang.Columns["maKhachHang"].HeaderText = "Mã khách hàng";
            griDanhSachKhachHang.Columns["maKhachHang"].Width = 150;
            griDanhSachKhachHang.Columns["maKhachHang"].ReadOnly = true;

            griDanhSachKhachHang.Columns["tenKH"].HeaderText = "Tên khách hàng";
            griDanhSachKhachHang.Columns["tenKH"].Width = 250;
            griDanhSachKhachHang.Columns["tenKH"].ReadOnly = true;

            griDanhSachKhachHang.Columns["diaChi"].HeaderText = "Địa chỉ";
            griDanhSachKhachHang.Columns["diaChi"].Width = 300;
            griDanhSachKhachHang.Columns["diaChi"].ReadOnly = true;

            griDanhSachKhachHang.Columns["soDienThoai"].HeaderText = "Số điện thoại";
            griDanhSachKhachHang.Columns["soDienThoai"].Width = 150;
            griDanhSachKhachHang.Columns["soDienThoai"].ReadOnly = true;

            griDanhSachKhachHang.Columns["phiPhat"].HeaderText = "Phí phạt";
            griDanhSachKhachHang.Columns["phiPhat"].Width = 150;
            griDanhSachKhachHang.Columns["phiPhat"].ReadOnly = true;

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (griDanhSachKhachHang.SelectedRows.Count > 0)
            {
                String maKH = griDanhSachKhachHang.SelectedRows[0].Cells[0].Value.ToString();
                if (busQuanLyKhachHang.kiemTraTonTaiKhachHang(maKH))
                {
                    MessageBox.Show("Khách hàng này đã tồn tại trong danh sách phiếu thuê nên không thể xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult d;
                    d = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        dsHangDoiCuaKH = busDatDia.LayDSHangDoiBangMaKhachHang(maKH);
                        if (dsHangDoiCuaKH != null) //Khách hàng này có đặt trước
                        {
                            foreach (eDanhSachHangDoi item in dsHangDoiCuaKH)
                            {
                                busDatDia.XoaHangDoiBangMaDatDia(item.MaDatDia);
                            }
                        }
                        busQuanLyKhachHang.xoaKhachHang(maKH);
                        MessageBox.Show("Xóa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dsKH = busQuanLyKhachHang.layDSKhachHang();
                        txtMaKH.Text = "KH" + kiemTraMaTuDong(getMaDD_AuTo(busQuanLyKhachHang.layDSKhachHang()));
                        griDanhSachKhachHang.DataSource = dsKH;
                        formatDatagridsKhachHang();
                        btnXoa.Enabled = false;
                        btnSua.Enabled = false;
                        txtSDT.Text = "";
                        txtTenKH.Text = "";
                        txtDiaChi.Text = "";
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text != "" && txtTenKH.Text != "" && txtDiaChi.Text != "" && kiemTraSo(txtSDT.Text))
            {
                eKhachHang eKhach = new eKhachHang();
                eKhach.MaKhachHang = txtMaKH.Text;
                eKhach.TenKH = txtTenKH.Text;
                eKhach.DiaChi = txtDiaChi.Text;
                eKhach.SoDienThoai = txtSDT.Text;
                eKhach.PhiPhat = Decimal.Parse(txtPhiPhat.Text);

                if (busQuanLyKhachHang.themKhachHang(eKhach))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dsKH = busQuanLyKhachHang.layDSKhachHang();
                    txtMaKH.Text = "KH" + kiemTraMaTuDong(getMaDD_AuTo(busQuanLyKhachHang.layDSKhachHang()));
                    griDanhSachKhachHang.DataSource = dsKH;
                    formatDatagridsKhachHang();
                    txtSDT.Text = "";
                    txtTenKH.Text = "";
                    txtDiaChi.Text = "";
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    btnThem.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Tên khách hàng, số điện thoại, địa chỉ không được rỗng và số điện thoại khác chuỗi!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Kiểm tra số
        private Boolean kiemTraSo(string check)
        {
            try
            {
                int so = Int32.Parse(check);
                if (so > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void griDanhSachKhachHang_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (griDanhSachKhachHang.SelectedRows.Count > 0)
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnThem.Enabled = false;
                txtMaKH.Text = griDanhSachKhachHang.SelectedRows[0].Cells[0].Value.ToString();
                txtTenKH.Text = griDanhSachKhachHang.SelectedRows[0].Cells[1].Value.ToString();
                txtDiaChi.Text = griDanhSachKhachHang.SelectedRows[0].Cells[2].Value.ToString();
                txtSDT.Text = griDanhSachKhachHang.SelectedRows[0].Cells[3].Value.ToString();
                txtPhiPhat.Text = griDanhSachKhachHang.SelectedRows[0].Cells[4].Value.ToString();
            }
            else
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnThem.Enabled = true;
                txtMaKH.Text = "KH" + kiemTraMaTuDong(getMaDD_AuTo(busQuanLyKhachHang.layDSKhachHang()));
                txtSDT.Text = "";
                txtTenKH.Text = "";
                txtDiaChi.Text = "";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text != "" && txtTenKH.Text != "" && txtDiaChi.Text != "" && kiemTraSo(txtSDT.Text))
            {
                eKhachHang kh = new eKhachHang();
                kh.MaKhachHang = txtMaKH.Text;
                kh.TenKH = txtTenKH.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.SoDienThoai = txtSDT.Text;
                kh.PhiPhat =Decimal.Parse(txtPhiPhat.Text);
                if (busQuanLyKhachHang.suaKhachHang(kh))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dsKH = busQuanLyKhachHang.layDSKhachHang();
                    txtMaKH.Text = "KH" + kiemTraMaTuDong(getMaDD_AuTo(busQuanLyKhachHang.layDSKhachHang()));
                    griDanhSachKhachHang.DataSource = dsKH;
                    formatDatagridsKhachHang();
                    txtSDT.Text = "";
                    txtTenKH.Text = "";
                    txtDiaChi.Text = "";
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    btnThem.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Tên khách hàng, số điện thoại, địa chỉ không được rỗng và số điện thoại khác chuỗi!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
