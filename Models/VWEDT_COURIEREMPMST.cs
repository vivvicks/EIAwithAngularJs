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
    
    public partial class VWEDT_COURIEREMPMST
    {
        public long CourierEmpID { get; set; }
        public string CourierEmpCode { get; set; }
        public string CourierEmpName { get; set; }
        public Nullable<long> CourierCoId { get; set; }
        public string TerminalCode { get; set; }
        public string Status { get; set; }
        public string MC_Status { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public Nullable<System.DateTime> LastUpDtOn { get; set; }
    }
}
