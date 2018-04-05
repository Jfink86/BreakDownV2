//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BreakDownV2
{
    using System;
    using System.Collections.Generic;
    
    public partial class TuneUp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TuneUp()
        {
            this.Services = new HashSet<Service>();
        }
    
        public int TuneUpID { get; set; }
        public int VehicleID { get; set; }
        public bool PlugsChanged { get; set; }
        public int BeltCondition { get; set; }
        public int TireCondition { get; set; }
        public int ODOServiced { get; set; }
        public Nullable<int> NextODO { get; set; }
        public string Notes { get; set; }
        public string Photo { get; set; }
        public System.DateTime DateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Service> Services { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}