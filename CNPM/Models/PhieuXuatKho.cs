//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNPM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhieuXuatKho
    {
        public PhieuXuatKho()
        {
            this.ChiTietPhieuXuatKhoes = new HashSet<ChiTietPhieuXuatKho>();
            this.HoaDonBanHangs = new HashSet<HoaDonBanHang>();
        }
    
        public int IdPhieuXK { get; set; }
        public System.DateTime NgayXuatKho { get; set; }
        public string HoTenNguoiXuat { get; set; }
        public string TongSoTien { get; set; }
        public string SoChungTuGocKem { get; set; }
        public int IdDDHKH { get; set; }
    
        public virtual ICollection<ChiTietPhieuXuatKho> ChiTietPhieuXuatKhoes { get; set; }
        public virtual DonDatHang_KH DonDatHang_KH { get; set; }
        public virtual ICollection<HoaDonBanHang> HoaDonBanHangs { get; set; }
    }
}
