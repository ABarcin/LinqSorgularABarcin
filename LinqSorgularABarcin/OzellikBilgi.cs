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
    
    public partial class OzellikBilgi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OzellikBilgi()
        {
            this.AracOzellik = new HashSet<AracOzellik>();
            this.FavoriOzellik = new HashSet<FavoriOzellik>();
        }
    
        public int OzellikBilgiID { get; set; }
        public string OzellikDetay { get; set; }
        public int OzellikID { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AracOzellik> AracOzellik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FavoriOzellik> FavoriOzellik { get; set; }
        public virtual Ozellik Ozellik { get; set; }
    }
}
