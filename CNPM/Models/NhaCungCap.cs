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
    
    public partial class NhaCungCap
    {
        public NhaCungCap()
        {
            this.DonDatHang_NCC = new HashSet<DonDatHang_NCC>();
            this.VatTus = new HashSet<VatTu>();
        }
    
        public int IdNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }
        public string GhiChu { get; set; }
    
        public virtual ICollection<DonDatHang_NCC> DonDatHang_NCC { get; set; }
        public virtual ICollection<VatTu> VatTus { get; set; }
    }
}
