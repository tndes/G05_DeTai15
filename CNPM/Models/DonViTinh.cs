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
    
    public partial class DonViTinh
    {
        public DonViTinh()
        {
            this.VatTus = new HashSet<VatTu>();
        }
    
        public int IdDVT { get; set; }
        public string DonVi { get; set; }
    
        public virtual ICollection<VatTu> VatTus { get; set; }
    }
}