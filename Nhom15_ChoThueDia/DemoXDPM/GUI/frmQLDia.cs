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
    public partial class frmQLDia : Form
    {
        public frmQLDia()
        {
            InitializeComponent();
        }
        public List<eTieuDe> dsTieuDe;
        public BusQuanLyDia busQuanLyDia;
        public List<eDiaCD> dsDia;
        public BusDatDia busDatDia;
        public BusLapPhieuTra busLapPhieuTra;

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Nguyễn Lê Ngân Bình
            //Thêm đĩa với số lượng
            if(cboTieuDe.SelectedIndex >= 0)
            {
                if (txtSoLuong.Text != "" && kiemTraSo(txtSoLuong.Text))
                {
                    //MessageBox.Show("True", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    for (int i = 0; i < Int32.Parse(txtSoLuong.Text); i++)
                    {
                        eDiaCD eDia = new eDiaCD();
                        eDia.MaDiaCD = txtMaDia.Text;
                        eDia.TinhTrang = "Trống";
                        eDia.MaTieuDe = busQuanLyDia.layMaTieuDe(cboTieuDe.Text);
                        busQuanLyDia.themDia(eDia);
                        busLapPhieuTra.tuDongGanDia(eDia.MaDiaCD, eDia.MaTieuDe); //Tự động gán đĩa khi có đĩa mới
                        txtMaDia.Text = "CD" + kiemTraMaTuDong(getMaDD_AuTo(busQuanLyDia.layDSDia())); 
                    }
                    dsDia = busQuanLyDia.layDSDia();
                    griDanhSachDia.DataSource = null;
                    griDanhSachDia.Rows.Clear();
                    griDanhSachDia.DataSource = dsDia;
                    formatDatagridsDia();
                    MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuong.Text = "1";
                }
                else
                {
                    MessageBox.Show("Số lượng phải là số nguyên dương và không rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Tiêu đề không hợp lệ!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void frmQLDia_Load(object sender, EventArgs e)
        {
            dsTieuDe = new List<eTieuDe>();
            busQuanLyDia = new BusQuanLyDia();
            busDatDia = new BusDatDia();
            busLapPhieuTra = new BusLapPhieuTra();
            dsDia = new List<eDiaCD>();
            dsTieuDe = busQuanLyDia.LayDSTieuDe();
            
            txtSoLuong.Text = "1";
            cboTieuDe.DataSource = dsTieuDe;
            cboTieuDe.DisplayMember = "TenTieuDe";
            cboTieuDe.ValueMember = "MaTieuDe";
            // Mã đĩa tăng tự động
            griDanhSachDia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dsDia = busQuanLyDia.layDSDia();

            txtMaDia.Text = "CD" + kiemTraMaTuDong(getMaDD_AuTo(busQuanLyDia.layDSDia()));
            griDanhSachDia.DataSource = dsDia;
            formatDatagridsDia();
        }

        private void formatDatagridsDia()
        {
            griDanhSachDia.Columns["maDiaCD"].HeaderText = "Mã Đĩa CD";
            griDanhSachDia.Columns["maDiaCD"].Width = 150;
            griDanhSachDia.Columns["maDiaCD"].ReadOnly = true;
            griDanhSachDia.Columns["tinhTrang"].HeaderText = "Tình Trạng ";
            griDanhSachDia.Columns["tinhTrang"].Width = 150;
            griDanhSachDia.Columns["tinhTrang"].ReadOnly = true;

            griDanhSachDia.Columns["maTieuDe"].HeaderText = "Mã tiêu đề";
            griDanhSachDia.Columns["maTieuDe"].Width = 150;
            griDanhSachDia.Columns["maTieuDe"].ReadOnly = true;

        }



        //Xét hàng đơn vị,chục,trăm,nghìn
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
        private int getMaDD_AuTo(List<eDiaCD> dshd)
        {
            int max = 0;
            foreach (eDiaCD item in dshd)
            {
                //Substring này lấy 4 kí tự cuối của chuỗi
                if (long.Parse(item.MaDiaCD.Substring(item.MaDiaCD.Length - 4)) >= max)
                {
                    max = Int32.Parse(item.MaDiaCD.Substring(item.MaDiaCD.Length - 4));
                }
            }
            return max + 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (griDanhSachDia.SelectedRows.Count > 0)
            {
                String maDia = griDanhSachDia.SelectedRows[0].Cells[0].Value.ToString();
                if (busQuanLyDia.kiemTraTonTaiDia(maDia))
                {
                    MessageBox.Show("Đĩa này đã tồn tại trong danh sách phiếu thuê nên không thể xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult d;
                    d = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        busDatDia.CapNhatHangDoiKhiXoaDia(maDia);
                        busQuanLyDia.xoaDia(maDia);
                        MessageBox.Show("Xóa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dsDia = busQuanLyDia.layDSDia();
                        txtMaDia.Text = "CD" + kiemTraMaTuDong(getMaDD_AuTo(busQuanLyDia.layDSDia()));
                        griDanhSachDia.DataSource = dsDia;
                        formatDatagridsDia();
                    }
                }
            }
        }
    }
}
