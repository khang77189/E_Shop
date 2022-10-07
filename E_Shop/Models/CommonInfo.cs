using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Shop.Models
{
    public class CommonInfo
    {
        private BanHangOnlineEntities db;
        public CommonInfo()
        {
            this.db = new BanHangOnlineEntities();
        }
        public IEnumerable<loaiSP> NhomHang
        {
            get
            {
                return this.db.loaiSP;
            }
        }
        public List<string> NhaSanXuat
        {
            get
            {
                List<string> kq = new List<string>();
                foreach (sanPham i in this.db.sanPham)
                    if (!kq.Contains(i.nhaSanXuat.Trim()))
                        kq.Add(i.nhaSanXuat.Trim());
                    return kq;
            }
        }
        public IEnumerable<sanPham>SanPhamMoi(int n)
        {
            return db.sanPham.OrderByDescending(x => x.ngayDang).Take(n);
        }
        public IEnumerable<E_Shop.Models.loaiSP> loaiSPDungChung()
        {
            return db.loaiSP;
        }
        public IEnumerable<E_Shop.Models.sanPham> sanPhamDungChung()
        {
            return db.sanPham;
        }
    }
}