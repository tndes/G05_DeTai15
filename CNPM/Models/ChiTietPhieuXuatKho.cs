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
    
    public partial class ChiTietPhieuXuatKho
    {
        public int IdCT_PXK { get; set; }
        public int IdPhieuXK { get; set; }
        public int SoLuong { get; set; }
        public int GiaBan { get; set; }
        public int GiaMua { get; set; }
    
        public virtual PhieuXuatKho PhieuXuatKho { get; set; }
    }
}
