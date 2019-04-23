//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IA_PM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public project()
        {
            this.hirings = new HashSet<hiring>();
            this.projrequests = new HashSet<projrequest>();
            this.teams = new HashSet<team>();
        }
    
        public int Id { get; set; }
        public string name { get; set; }
        public string descreption { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public bool status { get; set; }
        public Nullable<double> price { get; set; }
        public int progressid { get; set; }
        public int customerid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hiring> hirings { get; set; }
        public virtual progress progress { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<projrequest> projrequests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<team> teams { get; set; }
    }
}
