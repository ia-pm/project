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
    
    public partial class hiring
    {
        public int Id { get; set; }
        public int userid { get; set; }
        public int requestid { get; set; }
        public int projectid { get; set; }
    
        public virtual project project { get; set; }
        public virtual request request1 { get; set; }
        public virtual user user1 { get; set; }
    }
}
