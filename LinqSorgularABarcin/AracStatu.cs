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
    
    public partial class AracStatu
    {
        public int AracStatuID { get; set; }
        public int AracID { get; set; }
        public int StatuID { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Arac Arac { get; set; }
        public virtual Statu Statu { get; set; }
    }
}