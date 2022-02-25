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
    
    public partial class Ihale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ihale()
        {
            this.IhaleArac = new HashSet<IhaleArac>();
            this.IhaleSurec = new HashSet<IhaleSurec>();
            this.KurumsalIhale = new HashSet<KurumsalIhale>();
        }
    
        public int IhaleID { get; set; }
        public string IhaleAdi { get; set; }
        public int CalisanID { get; set; }
        public int KullaniciTipID { get; set; }
        public System.DateTime IhaleBaslangic { get; set; }
        public System.DateTime IhaleBitis { get; set; }
        public System.TimeSpan BaslangicSaat { get; set; }
        public System.TimeSpan BitisSaat { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Calisan Calisan { get; set; }
        public virtual KullaniciTip KullaniciTip { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IhaleArac> IhaleArac { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IhaleSurec> IhaleSurec { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KurumsalIhale> KurumsalIhale { get; set; }
    }
}
