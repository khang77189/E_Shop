//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_Shop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class taiKhoanTV
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public taiKhoanTV()
        {
            this.baiViet = new HashSet<baiViet>();
            this.donHang = new HashSet<donHang>();
            this.sanPham = new HashSet<sanPham>();
        }
    
        public string taiKhoan { get; set; }
        public string matKhau { get; set; }
        public string hoDem { get; set; }
        public string tenTV { get; set; }
        public Nullable<System.DateTime> ngaysinh { get; set; }
        public Nullable<bool> gioiTinh { get; set; }
        public string soDT { get; set; }
        public string email { get; set; }
        public string diaChi { get; set; }
        public Nullable<bool> trangThai { get; set; }
        public string ghiChu { get; set; }
        public Nullable<int> maNhom { get; set; }
        public Nullable<int> maQH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<baiViet> baiViet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<donHang> donHang { get; set; }
        public virtual quanHuyen quanHuyen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sanPham> sanPham { get; set; }
    }
}
