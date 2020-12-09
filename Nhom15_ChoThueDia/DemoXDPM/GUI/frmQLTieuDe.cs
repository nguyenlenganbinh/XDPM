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
    public partial class frmQLTieuDe : Form
    {
        public frmQLTieuDe()
        {
            InitializeComponent();
        }
        public List<eTieuDe> dsTieuDe;
        public List<eDiaCD> dsDiaCD;
        public BusTieuDe busQuanTieuDe;
        public BusQuanLyDia busQuanLyDia;
        public BusDatDia busDatDia;
        public List<eLoaiDia> dsLoaiDia;

        private void frmQLTieuDe_Load(object sender, EventArgs e)
        {
            dsTieuDe = new List<eTieuDe>();
            busQuanTieuDe = new BusTieuDe();
            busQuanLyDia = new BusQuanLyDia();
            busDatDia = new BusDatDia();
            dsLoaiDia = new List<eLoaiDia>();
            dsDiaCD = new List<eDiaCD>();
            dsLoaiDia = busQuanTieuDe.LayDSLoaiDia();

            cboMaLoai.DataSource = dsLoaiDia;
            cboMaLoai.DisplayMember = "TenLoai";
            cboMaLoai.ValueMember = "MaLoai";
            // mã đĩa tăng tự động
            griViewTieuDe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dsTieuDe = busQuanTieuDe.layDSTieuDe();

            txtMaTieuDe.Text = "TD" + kiemTraMaTuDong(getMaDD_AuTo(busQuanTieuDe.layDSTieuDe()));
            griViewTieuDe.DataSource = dsTieuDe;
            formatDatagridsTieuDe();
        }
        private void formatDatagridsTieuDe()
        {
            griViewTieuDe.Columns["maTieuDe"].HeaderText = "Mã tiêu đề";
            griViewTieuDe.Columns["maTieuDe"].Width = 300;
            griViewTieuDe.Columns["maTieuDe"].ReadOnly = true;

            griViewTieuDe.Columns["tenTieuDe"].HeaderText = "Tên tiêu đề";
            griViewTieuDe.Columns["tenTieuDe"].Width = 300;
            griViewTieuDe.Columns["tenTieuDe"].ReadOnly = true;

            griViewTieuDe.Columns["moTa"].HeaderText = "Mô tả";
            griViewTieuDe.Columns["moTa"].Width = 300;
            griViewTieuDe.Columns["moTa"].ReadOnly = true;

            griViewTieuDe.Columns["maLoai"].HeaderText = "Mã loại";
            griViewTieuDe.Columns["maLoai"].Width = 300;
            griViewTieuDe.Columns["maLoai"].ReadOnly = true;

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
        private int getMaDD_AuTo(List<eTieuDe> dshd)
        {
            int max = 0;
            foreach (eTieuDe item in dshd)
            {
                //Substring này lấy 4 kí tự cuối của chuỗi
                if (long.Parse(item.MaTieuDe.Substring(item.MaTieuDe.Length - 4)) >= max)
                {
                    max = Int32.Parse(item.MaTieuDe.Substring(item.MaTieuDe.Length - 4));
                }
            }
            return max + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboMaLoai.SelectedIndex >= 0)
            {
                if (txtTenTieuDe.Text != "")
                {
                    eTieuDe eDe = new eTieuDe();
                    eDe.MaTieuDe = txtMaTieuDe.Text;
                    eDe.TenTieuDe = txtTenTieuDe.Text;
                    eDe.MoTa = txtMoTa.Text;
                    eDe.MaLoai = busQuanTieuDe.layMaLoai(cboMaLoai.Text);
                    if (busQuanTieuDe.themTieuDe(eDe))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dsTieuDe = busQuanTieuDe.layDSTieuDe();
                        txtMaTieuDe.Text = "TD" + kiemTraMaTuDong(getMaDD_AuTo(busQuanTieuDe.layDSTieuDe()));
                        griViewTieuDe.DataSource = dsTieuDe;
                        formatDatagridsTieuDe();
                        txtTenTieuDe.Text = "";
                        txtMoTa.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Tên tiêu đề không được rỗng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Loại đĩa không hợp lệ!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (griViewTieuDe.SelectedRows.Count > 0)
            {
                String maTieuDe = griViewTieuDe.SelectedRows[0].Cells[0].Value.ToString();
                dsDiaCD = busQuanTieuDe.layDSDiaBangMaTieuDe(maTieuDe); //Lấy danh sách đĩa bằng mã để xét tồn tại đĩa trong lập phiếu thuê
                if (dsDiaCD != null)
                {
                    Boolean checkTonTai = false; //Lưu trạng thái đĩa có tồn tại trong lập phiếu thuê hay không?
                    foreach(eDiaCD item in dsDiaCD) //Duyệt đĩa trong ds để kiểm tra tồn tại
                    {
                        if (busQuanLyDia.kiemTraTonTaiDia(item.MaDiaCD))  //Đĩa tồn tại trong lập phiếu thuê
                        {
                            checkTonTai = true;
                            break;
                        }
                    }
                    if (checkTonTai) 
                    {
                        MessageBox.Show("Tiêu đề này có đĩa đã tồn tại trong danh sách phiếu thuê nên không thể xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DialogResult d;
                        d = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (d == DialogResult.Yes)
                        {
                            foreach (eDiaCD item in dsDiaCD) //Duyệt đĩa để xóa
                            {
                                busDatDia.CapNhatHangDoiKhiXoaDia(item.MaDiaCD);
                                busQuanLyDia.xoaDia(item.MaDiaCD);
                            }
                            busQuanTieuDe.xoaTieuDe(maTieuDe);
                            MessageBox.Show("Xóa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dsTieuDe = busQuanTieuDe.layDSTieuDe();
                            txtMaTieuDe.Text = "TD" + kiemTraMaTuDong(getMaDD_AuTo(busQuanTieuDe.layDSTieuDe()));
                            griViewTieuDe.DataSource = dsTieuDe;
                            formatDatagridsTieuDe();
                        }
                    }
                }
                else
                {
                    DialogResult d;
                    d = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        busQuanTieuDe.xoaTieuDe(maTieuDe);
                        MessageBox.Show("Xóa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dsTieuDe = busQuanTieuDe.layDSTieuDe();
                        txtMaTieuDe.Text = "TD" + kiemTraMaTuDong(getMaDD_AuTo(busQuanTieuDe.layDSTieuDe()));
                        griViewTieuDe.DataSource = dsTieuDe;
                        formatDatagridsTieuDe();
                    }
                }
            }
        }
    }
}
