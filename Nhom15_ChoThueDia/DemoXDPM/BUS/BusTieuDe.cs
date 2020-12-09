using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using Entity;

namespace BUS
{
    public class BusTieuDe
    {
        dbChoThueDiaContextDataContext db = new dbChoThueDiaContextDataContext();

        public List<eLoaiDia> LayDSLoaiDia()
        {
            IEnumerable<tbLoaiDia> dsLoai = (from n in db.tbLoaiDias
                                             select n).ToList();
            List<eLoaiDia> dsCustomLoaiDia = new List<eLoaiDia>();
            foreach (tbLoaiDia t in dsLoai)
            {
                eLoaiDia customLoaiDia = new eLoaiDia();
                customLoaiDia.MaLoai = t.MaLoai;
                customLoaiDia.TenLoai = t.TenLoai;
                customLoaiDia.ThoiGianThue = (int)t.ThoiGianThue;
                customLoaiDia.Gia = (decimal)t.Gia;

                dsCustomLoaiDia.Add(customLoaiDia);
            }
            return dsCustomLoaiDia;
        }

        public List<eTieuDe> layDSTieuDe()
        {
            IEnumerable<tbTieuDe> dsTieuDe = (from n in db.tbTieuDes
                                              select n).ToList();
            List<eTieuDe> dsCustomDiaTieuDe = new List<eTieuDe>();
            foreach (tbTieuDe t in dsTieuDe)
            {
                eTieuDe customTieuDe = new eTieuDe();
                customTieuDe.MaTieuDe = t.MaTieuDe;
                customTieuDe.TenTieuDe = t.TenTieuDe;
                customTieuDe.MoTa = t.MoTa;
                customTieuDe.MaLoai = t.MaLoai;
                dsCustomDiaTieuDe.Add(customTieuDe);
            }
            return dsCustomDiaTieuDe;
        }

        public String layMaLoai(String tenLoai)
        {
            tbLoaiDia loaiDia = (from x in db.tbLoaiDias
                                 where x.TenLoai.Equals(tenLoai)
                                 select x).FirstOrDefault();
            if (loaiDia != null)
            {
                return loaiDia.MaLoai;
            }
            return null;
        }

        public Boolean themTieuDe(eTieuDe eTieuDe)
        {
            tbTieuDe tbTieu = new tbTieuDe();
            tbTieu.MaTieuDe = eTieuDe.MaTieuDe;
            tbTieu.TenTieuDe = eTieuDe.TenTieuDe;
            tbTieu.MoTa = eTieuDe.MoTa;
            tbTieu.MaLoai = eTieuDe.MaLoai;
            db.tbTieuDes.InsertOnSubmit(tbTieu);
            db.SubmitChanges();
            return true;

        }

        public Boolean xoaTieuDe(String ma)
        {
            tbTieuDe tbTieu = (from x in db.tbTieuDes
                               where x.MaTieuDe.Equals(ma)
                               select x).FirstOrDefault();
            if (tbTieu != null)
            {
                db.tbTieuDes.DeleteOnSubmit(tbTieu);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        //Lấy danh sách đĩa bằng mã tiêu đề
        public List<eDiaCD> layDSDiaBangMaTieuDe(string maTieuDe)
        {
            IEnumerable<tbDiaCD> dsDia = (from n in db.tbDiaCDs
                                          where n.MaTieuDe.Equals(maTieuDe)
                                          select n).ToList();
            if (dsDia != null)
            {
                List<eDiaCD> dsDiaCustom = new List<eDiaCD>();
                foreach(tbDiaCD dia in dsDia)
                {
                    eDiaCD diaCD = new eDiaCD();
                    diaCD.MaDiaCD = dia.MaDiaCD;
                    diaCD.TinhTrang = dia.TinhTrangDia;
                    diaCD.MaTieuDe = dia.MaTieuDe;
                    dsDiaCustom.Add(diaCD);
                }
                return dsDiaCustom;
            }
            return null;
        }
    }
}
