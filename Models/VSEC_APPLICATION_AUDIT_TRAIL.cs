//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EIAwithAngular.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VSEC_APPLICATION_AUDIT_TRAIL
    {
        public long ID { get; set; }
        public Nullable<long> ACCESSED_MENU_ID { get; set; }
        public string ACCESSED_MENU { get; set; }
        public string IS_SUCCESSFUL { get; set; }
        public string ACCESSED_BY { get; set; }
        public System.DateTime ACCESSED_ON { get; set; }
        public string IP_ADDRESS { get; set; }
        public string SESSION_ID { get; set; }
    }
}
