//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATN_QLKS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblKhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblKhachHang()
        {
            this.tblPhieuDatPhongs = new HashSet<tblPhieuDatPhong>();
            this.tblTinNhans = new HashSet<tblTinNhan>();
        }
    
        public string ma_kh { get; set; }
        public string mat_khau { get; set; }
        public string ho_ten { get; set; }
        public string cmt { get; set; }
        public string sdt { get; set; }
        public string mail { get; set; }
        public Nullable<int> diem { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPhieuDatPhong> tblPhieuDatPhongs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTinNhan> tblTinNhans { get; set; }
    }
}
