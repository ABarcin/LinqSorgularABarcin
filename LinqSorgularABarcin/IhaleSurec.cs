//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqSorgularABarcin
{
    using System;
    using System.Collections.Generic;
    
    public partial class IhaleSurec
    {
        public int StatuIhaleID { get; set; }
        public int IhaleID { get; set; }
        public int IhaleStatuID { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Ihale Ihale { get; set; }
        public virtual IhaleStatu IhaleStatu { get; set; }
    }
}
