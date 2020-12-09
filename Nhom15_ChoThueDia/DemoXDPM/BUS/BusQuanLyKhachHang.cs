using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using Entity;

namespace BUS
{
    public class BusQuanLyKhachHang
    {
        dbChoThueDiaContextDataContext db = new dbChoThueDiaContextDataContext();

        public List<eKhachHang> layDSKhachHang()
        {
            IEnumerable<tbKhachHang> dsKH = (from n in db.tbKhachHangs
                                             select n).ToList();
            List<eKhachHang> dsCustomKH = new List<eKhachHang>();
            foreach (tbKhachHang t in dsKH)
            {
                eKhachHang customKH = new eKhachHang();
                customKH.MaKhachHang = t.MaKhachHang;
                customKH.TenKH = t.TenKH;
                customKH.DiaChi = t.DiaChi;
                customKH.SoDienThoai = t.SoDienThoai;
                customKH.PhiPhat = (decimal)t.PhiPhat;
                dsCustomKH.Add(customKH);
            }
            return dsCustomKH;
        }
        public Boolean themKhachHang(eKhachHang eKhach)
        {
            tbKhachHang tbKhach = new tbKhachHang();
            tbKhach.MaKhachHang = eKhach.MaKhachHang;
            tbKhach.TenKH = eKhach.TenKH;
            tbKhach.DiaChi = eKhach.DiaChi;
            tbKhach.SoDienThoai = eKhach.SoDienThoai;
            tbKhach.PhiPhat = eKhach.PhiPhat;
            db.tbKhachHangs.InsertOnSubmit(tbKhach);
            db.SubmitChanges();
            return true;
        }

        public Boolean xoaKhachHang(String ma)
        {
            tbKhachHang tbKhach = (from x in db.tbKhachHangs
                                   where x.MaKhachHang.Equals(ma)
                                   select x).FirstOrDefault();
            if (tbKhach != null)
            {
                db.tbKhachHangs.DeleteOnSubmit(tbKhach);
                db.SubmitChanges();
                return true;
            }
            return false;
        }


        public Boolean suaKhachHang(eKhachHang kh)
        {
            tbKhachHang khachHang = (from n in db.tbKhachHangs
                              where n.MaKhachHang.Equals(kh.MaKhachHang)
                              select n).FirstOrDefault();
            if (khachHang != null)
            {
                khachHang.TenKH = kh.TenKH;
                khachHang.DiaChi = kh.DiaChi;
                khachHang.SoDienThoai = kh.SoDienThoai;
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        //Nguyễn Lê Ngân Bình
        //Kiểm tra khách hàng có tồn tại trong lập phiếu thuê hay không?
        public Boolean kiemTraTonTaiKhachHang(string maKhachHang)
        {
            tbLapPhieuThue diaThue = (from n in db.tbLapPhieuThues
                                      where n.MaKhachHang.Equals(maKhachHang)
                                      select n).FirstOrDefault();
            if (diaThue != null)
            {
                return true;
            }
            return false;
        }
    }
}
