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
    
    public partial class ChiTietPhieuNhapKho
    {
        public int IdCT_PNK { get; set; }
        public int IdPhieuNK { get; set; }
        public int GiaNhap { get; set; }
        public int SoLuong { get; set; }
        public string TenVT { get; set; }
        public int IdDDHNCC { get; set; }
    
        public virtual PhieuNhapKho PhieuNhapKho { get; set; }
    }
}
