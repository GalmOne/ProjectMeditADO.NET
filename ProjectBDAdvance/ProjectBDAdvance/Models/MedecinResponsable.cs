//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectBDAdvance.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MedecinResponsable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedecinResponsable()
        {
            this.VisiteMedicales = new HashSet<VisiteMedicale>();
        }
    
        public decimal idPersonne { get; set; }
        public bool interne { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisiteMedicale> VisiteMedicales { get; set; }
        public virtual Personne Personne { get; set; }
    }
}
