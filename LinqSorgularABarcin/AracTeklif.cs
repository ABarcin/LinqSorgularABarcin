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
    
    public partial class AracTeklif
    {
        public int AracTeklifID { get; set; }
        public int IhaleAracID { get; set; }
        public int KullaniciID { get; set; }
        public decimal TeklifFiyat { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<bool> TeklifOnay { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual IhaleArac IhaleArac { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
