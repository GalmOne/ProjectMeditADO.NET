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
    
    public partial class ExamenPratique
    {
        public decimal idExaPrat { get; set; }
        public decimal idVisite { get; set; }
        public decimal codeExamen { get; set; }
        public decimal duree { get; set; }
        public string resultat { get; set; }
        public decimal prixTotal { get; set; }
    
        public virtual Examan Examan { get; set; }
        public virtual VisiteMedicale VisiteMedicale { get; set; }
    }
}
